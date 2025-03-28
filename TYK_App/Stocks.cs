using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class Stocks : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public Stocks(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowStocks();
            LoadStockAreas();
            dgvStocksInfo.SelectionChanged += new EventHandler(dgvStocksInfo_SelectionChanged);
            dgvStocksInfo.MouseClick += new MouseEventHandler(dgvStocksInfo_MouseClick);
            dgvStocksInfo.CellEnter += new DataGridViewCellEventHandler(dgvStocksInfo_CellEnter);
        }

        // Malzemelerin Bulunduğu Alanların Combobox a Yüklenmesi
        private void LoadStockAreas()
        {
            try
            {
                string query = "SELECT stockAreaId, stockArea FROM TblStockArea";
                DataTable dt = Con.GetData(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboStockArea.DataSource = dt;
                    cboStockArea.DisplayMember = "stockArea";
                    cboStockArea.ValueMember = "stockAreaId";
                    cboStockArea.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Stok alanları yüklenirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Verileri çekme ve tabloda gösterme
        private void ShowStocks()
        {
            string query = "SELECT s.stockId, s.stockName AS 'Malzeme Adı', s.stockNumber AS Adet, sa.stockArea AS 'Bulunduğu Yer' " +
                           "FROM TblStock s " +
                           "JOIN TblStockArea sa ON s.stockAreaId = sa.stockAreaId";
            DataTable dt = Con.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvStocksInfo.DataSource = dt;
                dgvStocksInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStocksInfo.ClearSelection();

                lblStock.Text = $"Toplam Malzeme Sayısı: {dt.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Veri bulunamadı.");
                lblStock.Text = $"Toplam Malzeme Sayısı: 0";
            }
        }

        private void dgvStocksInfo_CellEnter(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvStocksInfo.Rows[e.RowIndex];

                txtStockName.Text = selectedRow.Cells["Malzeme Adı"].Value?.ToString() ?? string.Empty;
                cboStockArea.Text = selectedRow.Cells["Bulunduğu Yer"].Value?.ToString() ?? string.Empty;
                int stockNumber;
                if (int.TryParse(selectedRow.Cells["Adet"].Value?.ToString(), out stockNumber))
                {
                    txtStockNumber.Text = stockNumber.ToString();
                }
                else
                {
                    txtStockNumber.Text = "0";
                }
            }
        }

        private void dgvStocksInfo_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvStocksInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStocksInfo.SelectedRows[0];
                txtStockName.Text = selectedRow.Cells["Malzeme Adı"].Value.ToString();
                cboStockArea.Text = selectedRow.Cells["Bulunduğu Yer"].Value.ToString();
                int stockNumber;
                if (int.TryParse(selectedRow.Cells["Adet"].Value?.ToString(), out stockNumber))
                {
                    txtStockNumber.Text = stockNumber.ToString();
                }
                else
                {
                    txtStockNumber.Text = "0";
                }
            }
            else
            {
                ClearInputFields();
            }
        }

        private void dgvStocksInfo_MouseClick(object? sender, MouseEventArgs e)
        {
            if (dgvStocksInfo.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
            {
                ClearInputFields();
            }
        }

        // Input Alaanlarının Temizlenmesi
        private void ClearInputFields()
        {
            txtStockName.Clear();
            txtStockNumber.Clear();
            cboStockArea.SelectedIndex = -1;
        }

        // Ekleme Metodu
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStockName.Text) && !string.IsNullOrEmpty(txtStockNumber.Text))
            {
                int number = int.Parse(txtStockNumber.Text);
                if (number < 0)
                {
                    MessageBox.Show("Malzeme adedi 0' dan az olamaz.");
                    return;
                }

                string name = txtStockName.Text;
                int areaId = Convert.ToInt32(cboStockArea.SelectedValue);

                try
                {
                    InsertStock(name, number, areaId);
                    ShowStocks();
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
        }

        // Güncelleme Metodu
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStocksInfo.SelectedRows.Count > 0)
            {
                int number = int.Parse(txtStockNumber.Text);
                if (number < 0)
                {
                    MessageBox.Show("Malzeme adedi 0' dan az olamaz.");
                    return;
                }

                DataGridViewRow selectedRow = dgvStocksInfo.SelectedRows[0];
                string name = txtStockName.Text;
                int areaId = Convert.ToInt32(cboStockArea.SelectedValue);
                int stockId = (int)selectedRow.Cells["stockId"].Value;

                string query = "UPDATE TblStock SET stockName = @stockName, stockNumber = @stockNumber, stockAreaId = @stockAreaId " +
                               "WHERE stockId = @stockId";

                SqlParameter[] parameters = {
            new SqlParameter("@stockName", name),
            new SqlParameter("@stockNumber", number),
            new SqlParameter("@stockAreaId", areaId),
            new SqlParameter("@stockId", stockId)
        };

                int resultCount = Con.SetData(query, parameters);
                if (resultCount > 0)
                {
                    MessageBox.Show("Malzeme başarıyla güncellendi.");
                    ShowStocks();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz malzemeyi seçin.");
            }
        }

        // Silme Metodu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStocksInfo.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Malzemeyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = dgvStocksInfo.SelectedRows[0];
                        int stockId = (int)selectedRow.Cells["stockId"].Value;

                        string query = "DELETE FROM TblStock WHERE stockId = @stockId";

                        SqlParameter[] parameters = {
                            new SqlParameter("@stockId", stockId)
                        };

                        int resultCount = Con.SetData(query, parameters);
                        if (resultCount > 0)
                        {
                            MessageBox.Show("Malzeme Silindi !!!");
                            ShowStocks();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi sırasında bir hata oluştu.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz malzemeyi seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Ekleme Metodunda kullanılan Malzeme Ekleme İşlemi Yapan Fonksiyon
        private void InsertStock(string name, int stockNumber, int areaId)
        {
            try
            {
                string checkQuery = "SELECT stockId, stockNumber FROM TblStock WHERE stockName = @stockName AND stockAreaId = @stockAreaId";
                SqlParameter[] checkParameters = {
                    new SqlParameter("@stockName", name),
                    new SqlParameter("@stockAreaId", areaId)
                };

                DataTable dt = Con.GetData(checkQuery, checkParameters);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    int existingStockId = Convert.ToInt32(row["stockId"]);
                    int existingStockNumber = Convert.ToInt32(row["stockNumber"]);

                    int newStockNumber = existingStockNumber + stockNumber;

                    string updateQuery = "UPDATE TblStock SET stockNumber = @stockNumber WHERE stockId = @stockId";
                    SqlParameter[] updateParameters = {
                        new SqlParameter("@stockNumber", newStockNumber),
                        new SqlParameter("@stockId", existingStockId)
                    };

                    int result = Con.SetData(updateQuery, updateParameters);
                    if (result > 0)
                    {
                        MessageBox.Show("Mevcut malzeme adeti başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Malzeme adeti güncellenirken bir hata oluştu.");
                    }
                }
                else
                {
                    string insertQuery = "INSERT INTO TblStock (stockName, stockNumber, stockAreaId) " +
                                         "VALUES (@stockName, @stockNumber, @stockAreaId)";

                    SqlParameter[] insertParameters = {
                        new SqlParameter("@stockName", (object)name ?? DBNull.Value),
                        new SqlParameter("@stockNumber", (object)stockNumber ?? DBNull.Value),
                        new SqlParameter("@stockAreaId", (object)areaId ?? DBNull.Value)
};

                    int result = Con.SetData(insertQuery, insertParameters);
                    if (result > 0)
                    {
                        MessageBox.Show("Yeni malzeme başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Malzeme eklenirken bir hata oluştu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Filtreleme Metodu
        private void ApplyFilter(string nameFilter, int stockNumberFilter, string stockAreaFilter)
        {
            string query = "SELECT s.stockId, s.stockName AS 'Malzeme Adı', s.stockNumber AS 'Adet', s.stockArea AS 'Bulunduğu Yer' FROM TblStock s WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(nameFilter))
            {
                query += " AND LOWER(s.stockName) LIKE @nameFilter";
                parameters.Add(new SqlParameter("@nameFilter", "%" + nameFilter.ToLower() + "%"));
            }

            if (stockNumberFilter > 0)
            {
                query += " AND s.stockNumber = @stockNumberFilter";
                parameters.Add(new SqlParameter("@stockNumberFilter", stockNumberFilter));
            }

            if (!string.IsNullOrEmpty(stockAreaFilter))
            {
                query += " AND LOWER(s.stockArea) LIKE @stockAreaFilter";
                parameters.Add(new SqlParameter("@stockAreaFilter", "%" + stockAreaFilter.ToLower() + "%"));
            }

            DataTable dt = Con.GetData(query, parameters.ToArray());
            dgvStocksInfo.DataSource = dt;
            lblStock.Text = $"Toplam Malzeme Sayısı: {dt.Rows.Count}";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterStock filterForm = new FilterStock(userPermissions);
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                string nameFilter = filterForm.SelectedName;
                int number = filterForm.SelectedStockNumber;
                string stockAreaFilter = filterForm.SelectedStockArea;

                ApplyFilter(nameFilter, number, stockAreaFilter);
            }
        }

        // Butonlar ile Sayfa Yönlendirmeleri
        private void pictureStudent_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Student"))
            {
                Students student = new Students(userPermissions);
                student.Show();
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
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
        }

        private void pictureStock_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                StockMenu stockMenu = new StockMenu(userPermissions);
                stockMenu.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockMenuInfo stockMenu = new StockMenuInfo(userPermissions);
                stockMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
        }

        private void pictureReport_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Report"))
            {
                ReportMenu reportMenu = new ReportMenu(userPermissions);
                reportMenu.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("ReportInfo"))
            {
                ReportMenuInfo reportMenu = new ReportMenuInfo(userPermissions);
                reportMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Raporlar sayfasına erişim izniniz yok.");
            }
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                StockMenu stockMenu = new StockMenu(userPermissions);
                stockMenu.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockMenuInfo stockMenu = new StockMenuInfo(userPermissions);
                stockMenu.Show();
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
                StockMenu stockMenu = new StockMenu(userPermissions);
                stockMenu.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockMenuInfo stockMenu = new StockMenuInfo(userPermissions);
                stockMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowStocks();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
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
                    Con.ExportDataGridViewToPdf(dgvStocksInfo, saveFileDialog.FileName);
                }
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
    }
}
