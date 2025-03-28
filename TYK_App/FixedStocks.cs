using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Formats.Asn1;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TYK_App
{
    public partial class FixedStocks : Form
    {
        Functions Con;

        private List<string> userPermissions;
        public FixedStocks(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowFixedStocks();
            LoadStockAreas();
            dgvFixedStocksInfo.SelectionChanged += new EventHandler(dgvStocksInfo_SelectionChanged);
            dgvFixedStocksInfo.MouseClick += new MouseEventHandler(dgvStocksInfo_MouseClick);
            dgvFixedStocksInfo.CellEnter += new DataGridViewCellEventHandler(dgvStocksInfo_CellEnter);
        }

        // Malzemelerin bulunduğu alanların yüklenmesi
        private void LoadStockAreas()
        {
			try
			{
				string query = "SELECT stockArea FROM TblStockArea";
				DataTable dt = Con.GetData(query);

				cboStockArea.DisplayMember = "stockArea";
				cboStockArea.ValueMember = "stockAreaId";
				cboStockArea.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
        }

        // Verileri çekme ve tabloda gösterme
        private void ShowFixedStocks()
        {
            string query = "SELECT s.stockName AS 'Malzeme Adı', s.stockSerialNo AS 'Seri Numarası', s.stockNo AS 'Malzeme Kodu', s.stockFeature AS 'Özellikler', s.stockArea AS 'Bulunduğu Yer', s.stockNumber AS Adet FROM TblFixedStock s";
            DataTable dt = Con.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvFixedStocksInfo.DataSource = dt;
                dgvFixedStocksInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvFixedStocksInfo.ClearSelection();

                lblFixedStock.Text = $"Toplam Malzeme Sayısı: {dt.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Veri bulunamadı.");
                lblFixedStock.Text = $"Toplam Malzeme Sayısı: 0";
            }
        }

        private void dgvStocksInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFixedStocksInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFixedStocksInfo.SelectedRows[0];
                txtStockName.Text = selectedRow.Cells["Malzeme Adı"].Value.ToString();
                txtSerialNo.Text = selectedRow.Cells["Seri Numarası"].Value.ToString();
                txtStockNo.Text = selectedRow.Cells["Malzeme Kodu"].Value.ToString();
                txtStockFeature.Text = selectedRow.Cells["Özellikler"].Value.ToString();
                cboStockArea.Text = selectedRow.Cells["Bulunduğu Yer"].Value.ToString();
                txtStockNumber.Text = selectedRow.Cells["Adet"].Value.ToString();
            }
            else
            {
                ClearInputFields();
            }
        }

        // Input alanlarının temizlenmesi
        private void ClearInputFields()
        {
            txtStockName.Clear();
            txtStockNo.Clear();
            txtSerialNo.Clear();
            txtStockFeature.Clear();
            cboStockArea.SelectedIndex = -1;
            txtStockNumber.Clear();
        }

        private void dgvStocksInfo_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvFixedStocksInfo.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
            {
                ClearInputFields();
            }
        }

        private void dgvStocksInfo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvFixedStocksInfo.Rows[e.RowIndex];
                txtStockName.Text = selectedRow.Cells["Malzeme Adı"].Value?.ToString() ?? string.Empty;
                txtSerialNo.Text = selectedRow.Cells["Seri Numarası"].Value?.ToString() ?? string.Empty;
                txtStockNo.Text = selectedRow.Cells["Malzeme Kodu"].Value?.ToString() ?? string.Empty;
                txtStockFeature.Text = selectedRow.Cells["Özellikler"].Value?.ToString() ?? string.Empty;
                cboStockArea.Text = selectedRow.Cells["Bulunduğu Yer"].Value?.ToString() ?? string.Empty;
                txtStockNumber.Text = selectedRow.Cells["Adet"].Value?.ToString() ?? string.Empty;
            }
        }

        // Butonlar ile Sayfa Yönlendirmeleri
        private void pictureStudent_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Student"))
            {
                Students teamsForm = new Students(userPermissions);
                teamsForm.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StudentInfo"))
            {
                StudentInfo student = new StudentInfo(userPermissions);
                student.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Öğrenciler sayfasına erişim izniniz yok.");
            }
        }

        private void pictureTeam_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Team"))
            {
                Teams teamsForm = new Teams(userPermissions);
                teamsForm.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("TeamInfo"))
            {
                TeamInfo student = new TeamInfo(userPermissions);
                student.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Takımlar sayfasına erişim izniniz yok.");
            }
        }

        private void pictureStock_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                StockMenu stock = new StockMenu(userPermissions);
                stock.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockMenuInfo stock = new StockMenuInfo(userPermissions);
                stock.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
        }

        private void InsertStock(string name, string serialNo, string stockNo, string feature, string area, int number)
        {
            try
            {
                string checkQuery = "SELECT stockNumber FROM TblFixedStock WHERE stockNo = @stockNo";
                SqlParameter[] checkParams = { new SqlParameter("@stockNo", stockNo) };
                DataTable checkDt = Con.GetData(checkQuery, checkParams);

                if (checkDt != null && checkDt.Rows.Count > 0)
                {
                    // Aynı malzeme koduna sahip bir kayıt varsa, adet sayısını artır.
                    int currentNumber = Convert.ToInt32(checkDt.Rows[0]["stockNumber"]);
                    string updateQuery = "UPDATE TblFixedStock SET stockNumber = @stockNumber, stockName = @stockName, stockSerialNo = @stockSerialNo, stockFeature = @stockFeature, stockArea = @stockArea WHERE stockNo = @stockNo";
                    SqlParameter[] updateParams = {
                new SqlParameter("@stockNumber", currentNumber + number),
                new SqlParameter("@stockNo", stockNo),
                new SqlParameter("@stockName", name ?? (object)DBNull.Value),
                new SqlParameter("@stockSerialNo", serialNo ?? (object)DBNull.Value),
                new SqlParameter("@stockFeature", feature ?? (object)DBNull.Value),
                new SqlParameter("@stockArea", area ?? (object)DBNull.Value)
            };
                    Con.SetData(updateQuery, updateParams);
                }
                else
                {
                    // Yeni malzeme ekle
                    string query = "INSERT INTO TblFixedStock (stockName, stockSerialNo, stockNo, stockFeature, stockArea, stockNumber) " +
								   "VALUES (@stockName, stockSerialNo, @stockNo, @stockFeature, @stockArea, @stockNumber)";

                    SqlParameter[] parameters = {
                new SqlParameter("@stockName", name ?? (object)DBNull.Value),
                new SqlParameter("@stockSerialNo", name ?? (object)DBNull.Value),
                new SqlParameter("@stockNo", stockNo ?? (object)DBNull.Value),
                new SqlParameter("@stockFeature", feature ?? (object)DBNull.Value),
                new SqlParameter("@stockArea", area ?? (object)DBNull.Value),
                new SqlParameter("@stockNumber", number)
            };
                    int result = Con.SetData(query, parameters);
                    if (result > 0)
                    {
                        MessageBox.Show("Malzeme başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Malzeme eklenirken bir hata oluştu.");
                    }
                }
                ShowFixedStocks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStockName.Text) && !string.IsNullOrEmpty(txtStockNo.Text))
            {
                string name = txtStockName.Text;
                string serialNo = txtSerialNo.Text;
                string stockNo = txtStockNo.Text;
                string feature = txtStockFeature.Text;
                string area = cboStockArea.Text;
                int number = int.Parse(txtStockNumber.Text);

                try
                {
                    // Malzeme ekle
                    InsertStock(name, serialNo, stockNo, feature, area, number);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli tüm bilgileri girin.");
            }
            ShowFixedStocks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Malzemeyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string stockNo = txtStockNo.Text;
                    string checkQuery = "SELECT stockNumber FROM TblFixedStock WHERE stockNo = @stockNo";
                    SqlParameter[] checkParams = { new SqlParameter("@stockNo", stockNo) };
                    DataTable checkDt = Con.GetData(checkQuery, checkParams);

                    if (checkDt != null && checkDt.Rows.Count > 0)
                    {
                        int currentNumber = Convert.ToInt32(checkDt.Rows[0]["stockNumber"]);
                        if (currentNumber > 1)
                        {
                            // Adet sayısını azalt
                            string updateQuery = "UPDATE TblFixedStock SET stockNumber = @stockNumber WHERE stockNo = @stockNo";
                            SqlParameter[] updateParams = {
                        new SqlParameter("@stockNumber", currentNumber - 1),
                        new SqlParameter("@stockNo", stockNo)
                    };
                            Con.SetData(updateQuery, updateParams);
                        }
                        else
                        {
                            // Tek kayıt varsa, kaydı sil
                            string deleteQuery = "DELETE FROM TblFixedStock WHERE stockNo = @stockNo";
                            SqlParameter[] deleteParams = { new SqlParameter("@stockNo", stockNo) };
                            Con.SetData(deleteQuery, deleteParams);
                        }
                        MessageBox.Show("Malzeme Silindi!");
                        ShowFixedStocks();
                        ClearInputFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvFixedStocksInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFixedStocksInfo.SelectedRows[0];
                string oldStockNo = selectedRow.Cells["Malzeme Kodu"].Value.ToString();
                string name = txtStockName.Text;
                string serialNo = txtSerialNo.Text;
                string stockNo = txtStockNo.Text;
                string feature = txtStockFeature.Text;
                string area = cboStockArea.Text;
                int number = int.Parse(txtStockNumber.Text);

                if (!oldStockNo.Equals(stockNo))
                {
                    // Eğer malzeme kodu değişiyorsa, yeni malzeme kodu ile ilgili kontrolleri yap
                    string checkQuery = "SELECT stockNumber FROM TblFixedStock WHERE stockNo = @stockNo";
                    SqlParameter[] checkParams = { new SqlParameter("@stockNo", stockNo) };
                    DataTable checkDt = Con.GetData(checkQuery, checkParams);

                    if (checkDt != null && checkDt.Rows.Count > 0)
                    {
                        // Yeni malzeme koduna sahip kayıt varsa, adet sayısını artır
                        int currentNumber = Convert.ToInt32(checkDt.Rows[0]["stockNumber"]);
                        string updateQuery = "UPDATE TblFixedStock SET stockNumber = @stockNumber WHERE stockNo = @stockNo";
                        SqlParameter[] updateParams = {
                    new SqlParameter("@stockNumber", currentNumber + number),
                    new SqlParameter("@stockNo", stockNo)
                };
                        Con.SetData(updateQuery, updateParams);
                    }
                    else
                    {
                        // Yeni malzeme koduna sahip kayıt yoksa, eski kaydı sil ve yeni kayıt ekle
                        string deleteQuery = "DELETE FROM TblFixedStock WHERE stockNo = @oldStockNo";
                        SqlParameter[] deleteParams = { new SqlParameter("@oldStockNo", oldStockNo) };
                        Con.SetData(deleteQuery, deleteParams);

                        string insertQuery = "INSERT INTO TblFixedStock (stockName, stockSerialNo, stockNo, stockFeature, stockArea, stockNumber) " +
											 "VALUES (@stockName, @stockSerialNo, @stockNo, @stockFeature, @stockArea, @stockNumber)";
                        SqlParameter[] insertParams = {
                    new SqlParameter("@stockName", name ?? (object)DBNull.Value),
                    new SqlParameter("@stockSerialNo", serialNo ?? (object)DBNull.Value),
                    new SqlParameter("@stockNo", stockNo ?? (object)DBNull.Value),
                    new SqlParameter("@stockFeature", feature ?? (object)DBNull.Value),
                    new SqlParameter("@stockArea", area ?? (object)DBNull.Value),
                    new SqlParameter("@stockNumber", number)
                };
                        Con.SetData(insertQuery, insertParams);
                    }
                }
                else
                {
                    // Malzeme kodu değişmiyorsa, mevcut kaydı güncelle
                    string updateQuery = "UPDATE TblFixedStock SET stockName = @stockName, stockSerialNo = @stockSerialNo, stockNo = @stockNo, stockFeature = @stockFeature, stockArea = @stockArea, stockNumber = @stockNumber WHERE stockNo = @oldStockNo";
                    SqlParameter[] updateParams = {
                new SqlParameter("@stockName", name),
                new SqlParameter("@stockSerialNo", serialNo),
                new SqlParameter("@stockNo", stockNo),
                new SqlParameter("@stockFeature", feature),
                new SqlParameter("@stockArea", area),
                new SqlParameter("@stockNumber", number),
                new SqlParameter("@oldStockNo", oldStockNo)
            };

                    Con.SetData(updateQuery, updateParams);
                }

                MessageBox.Show("Malzeme güncellendi.");
                ShowFixedStocks();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Güncellemek için bir malzeme seçin.");
            }
        }


        private void ApplyFilter(string nameFilter, string serialNoFilter, string stockNoFilter, string stockFeatureFilter, string stockAreaFilter, int? stockNumber)
        {
            string query = "SELECT s.stockName AS 'Malzeme Adı', s.stockSerialNo AS 'Seri Numarası', s.stockNo AS 'Malzeme Kodu', s.stockFeature AS 'Özellikler', s.stockArea AS 'Bulunduğu Yer', s.stockNumber AS Adet FROM TblFixedStock s WHERE 1=1";

            if (!string.IsNullOrEmpty(nameFilter)) query += $" AND s.stockName LIKE '%{nameFilter.ToLower()}%'";
            if (!string.IsNullOrEmpty(serialNoFilter)) query += $" AND s.stockSerialNo LIKE '%{serialNoFilter.ToLower()}%'";
            if (!string.IsNullOrEmpty(stockNoFilter)) query += $" AND s.stockNo LIKE '%{stockNoFilter.ToLower()}%'";
            if (!string.IsNullOrEmpty(stockFeatureFilter)) query += $" AND s.stockFeature LIKE '%{stockFeatureFilter.ToLower()}%'";
            if (!string.IsNullOrEmpty(stockAreaFilter)) query += $" AND s.stockArea LIKE '%{stockAreaFilter.ToLower()}%'";
            if (stockNumber.HasValue) query += $" AND s.stockNumber = {stockNumber.Value}";

            DataTable dt = Con.GetData(query);
            dgvFixedStocksInfo.DataSource = dt;
            lblFixedStock.Text = $"Toplam Malzeme Sayısı: {dt.Rows.Count}";
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterFixedStock filterForm = new FilterFixedStock(userPermissions);
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                string nameFilter = filterForm.SelectedName;
                string serialNoFilter = filterForm.SelectedName;
                string stockNoFilter = filterForm.SelectedSerialNo;
                string stockFeatureFilter = filterForm.SelectedStockFeature;
                string stockAreaFilter = filterForm.SelectedStockArea;
                int? stockNumber = filterForm.SelectedStockNumber;

				ApplyFilter(nameFilter, serialNoFilter, stockNoFilter, stockFeatureFilter, stockAreaFilter, stockNumber);
            }
        }

		private void pictureBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                StockMenu stock = new StockMenu(userPermissions);
                stock.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockMenuInfo stock = new StockMenuInfo(userPermissions);
                stock.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                StockMenu stock = new StockMenu(userPermissions);
                stock.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockMenuInfo stock = new StockMenuInfo(userPermissions);
                stock.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowFixedStocks();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF dosyası|*.pdf";
                saveFileDialog.Title = "PDF olarak kaydet";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    Con.ExportDataGridViewToPdf(dgvFixedStocksInfo, saveFileDialog.FileName);
                }
            }
        }

        private void pictureReport_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Report"))
            {
                ReportMenu report = new ReportMenu(userPermissions);
                report.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("ReportInfo"))
            {
                ReportMenuInfo report = new ReportMenuInfo(userPermissions);
                report.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Raporlar sayfasına erişim izniniz yok.");
            }
        }

        private void pictureCategory_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Category"))
            {
                Categories category = new Categories(userPermissions);
                category.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("CategoryInfo"))
            {
                CategoryInfo category = new CategoryInfo(userPermissions);
                category.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kategoriler sayfasına erişim izniniz yok.");
            }
        }

        private void pictureUser_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("User"))
            {
                Users user = new Users(userPermissions);
                user.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("UserInfo"))
            {
                UserInfo user = new UserInfo(userPermissions);
                user.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcılar sayfasına erişim izniniz yok.");
            }
        }
    }
}
