using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class StockTracing : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public StockTracing(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowTracingStocks();
            LoadStockAreas();
            dtpIssuedDate.Format = DateTimePickerFormat.Custom;
            dtpIssuedDate.CustomFormat = " ";
            dtpReturnedDate.Format = DateTimePickerFormat.Custom;
            dtpReturnedDate.CustomFormat = " ";

            dtpIssuedDate.ValueChanged += new EventHandler(dtpIssuedDate_ValueChanged);
            dtpReturnedDate.ValueChanged += new EventHandler(dtpReturnedDate_ValueChanged);
            dgvStockTracing.SelectionChanged += new EventHandler(dgvStockTracing_SelectionChanged);
            dgvStockTracing.MouseClick += new MouseEventHandler(dgvStockTracingInfo_MouseClick);
            dgvStockTracing.CellEnter += new DataGridViewCellEventHandler(dgvStockTracingInfo_CellEnter);
        }

        private void dtpIssuedDate_ValueChanged(object sender, EventArgs e)
        {
            dtpIssuedDate.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpReturnedDate_ValueChanged(object sender, EventArgs e)
        {
            dtpReturnedDate.CustomFormat = "dd/MM/yyyy";
        }

        private void dgvStockTracing_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStockTracing.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStockTracing.SelectedRows[0];
                txtStockName.Text = selectedRow.Cells["Malzeme Adı"].Value.ToString();
                dtpIssuedDate.Value = Convert.ToDateTime(selectedRow.Cells["Veriliş Tarihi"].Value);
                dtpIssuedDate.CustomFormat = "dd/MM/yyyy";

                if (selectedRow.Cells["Teslim Alınan Tarih"].Value != DBNull.Value)
                {
                    dtpReturnedDate.Value = Convert.ToDateTime(selectedRow.Cells["Teslim Alınan Tarih"].Value);
                    dtpReturnedDate.CustomFormat = "dd/MM/yyyy";
                }
                else
                {
                    dtpReturnedDate.CustomFormat = " ";
                }

                txtStudentName.Text = selectedRow.Cells["Teslim Alan Öğrenci"].Value.ToString();
                txtStudentNumber.Text = selectedRow.Cells["Öğrenci Numarası"].Value.ToString();
            }
        }

        // Malzemelerin Bulunduğu Alanların Combobox lara Yüklenmesi
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
        private void ShowTracingStocks()
        {
            string query = "SELECT k.stockTracingId AS 'ID', t.stockName AS 'Malzeme Adı', k.issuedDate AS 'Veriliş Tarihi', k.returnedDate AS 'Teslim Alınan Tarih', sa.stockArea AS 'Bulunduğu Yer', " +
               "s.studentName AS 'Teslim Alan Öğrenci', s.studentNumber AS 'Öğrenci Numarası', s.studentTC AS 'Öğrenci TC', s.studentPhone AS 'Öğrenci Telefon No', " +
               "m.teamName AS 'Öğrenci Takımı' " +
               "FROM TblStockTracing k " +
               "JOIN TblStudent s ON k.studentId = s.studentId " +
               "LEFT JOIN TblStock t ON k.stockId = t.stockId " +
               "LEFT JOIN TblStockArea sa ON t.stockAreaId = sa.stockAreaId " +
               "LEFT JOIN TblTeam m ON s.studentTeamId = m.teamId";
            DataTable dt = Con.GetData(query);

            ClearInputFields();

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvStockTracing.DataSource = dt;
                dgvStockTracing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStockTracing.ClearSelection();

                lblStockTracing.Text = $"Toplam Rapor Sayısı: {dt.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Veri bulunamadı.");
                lblStockTracing.Text = $"Toplam Rapor Sayısı: 0";
            }
        }

        private void dgvStockTracingInfo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvStockTracing.Rows[e.RowIndex];

                txtStockName.Text = selectedRow.Cells["Malzeme Adı"].Value?.ToString() ?? string.Empty;

                if (selectedRow.Cells["Veriliş Tarihi"].Value != DBNull.Value)
                {
                    DateTime issuedDate;
                    if (DateTime.TryParse(selectedRow.Cells["Veriliş Tarihi"].Value.ToString(), out issuedDate))
                    {
                        dtpIssuedDate.Value = issuedDate;
                    }
                    else
                    {
                        dtpIssuedDate.Value = DateTime.Now;
                    }
                }
                else
                {
                    dtpIssuedDate.Value = DateTime.Now;
                }

                cboStockArea.Text = selectedRow.Cells["Bulunduğu Yer"].Value?.ToString() ?? string.Empty;

                txtStudentName.Text = selectedRow.Cells["Teslim Alan Öğrenci"].Value?.ToString() ?? string.Empty;

                txtStudentNumber.Text = selectedRow.Cells["Öğrenci Numarası"].Value?.ToString() ?? string.Empty;

                if (selectedRow.Cells["Teslim Alınan Tarih"].Value != DBNull.Value)
                {
                    DateTime returnedDate;
                    if (DateTime.TryParse(selectedRow.Cells["Teslim Alınan Tarih"].Value.ToString(), out returnedDate))
                    {
                        dtpReturnedDate.CustomFormat = "dd/MM/yyyy";
                        dtpReturnedDate.Value = returnedDate;
                    }
                    else
                    {
                        dtpReturnedDate.CustomFormat = " ";
                    }
                }
                else
                {
                    dtpReturnedDate.CustomFormat = " ";
                }
            }
        }


        private void dgvStockTracingInfo_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvStockTracing.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
            {
                ClearInputFields();
            }
        }

        // Input Alanlarının Temizlenmesi
        private void ClearInputFields()
        {
            txtStockName.Clear();
            dtpIssuedDate.Value = DateTime.Now;
            dtpReturnedDate.CustomFormat = " ";
            cboStockArea.SelectedIndex = -1;
            txtStudentName.Clear();
            txtStudentNumber.Clear();
        }

        // Malzeme Adına Göre Malzeme Bilgilerinin Çekilmesi
        private bool TryGetStockIdAndArea(string stockName, out int stockId, out string stockArea)
        {
            stockId = 0;
            stockArea = null;

            try
            {
                string stockQuery = @"SELECT stockId, stockAreaId FROM TblStock WHERE stockName = @stockName";
                SqlParameter[] stockParameters = {
            new SqlParameter("@stockName", stockName)
        };

                DataTable stockTable = Con.GetData(stockQuery, stockParameters);

                if (stockTable != null && stockTable.Rows.Count > 0)
                {
                    stockId = Convert.ToInt32(stockTable.Rows[0]["stockId"]);
                    int stockAreaId = Convert.ToInt32(stockTable.Rows[0]["stockAreaId"]);

                    string areaQuery = @"SELECT stockArea FROM TblStockArea WHERE stockAreaId = @stockAreaId";
                    SqlParameter[] areaParameters = {
                new SqlParameter("@stockAreaId", stockAreaId)
            };

                    DataTable areaTable = Con.GetData(areaQuery, areaParameters);

                    if (areaTable != null && areaTable.Rows.Count > 0)
                    {
                        stockArea = areaTable.Rows[0]["stockArea"].ToString();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            return false;
        }

        // Ekleme Metodu
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStockName.Text) && dtpIssuedDate.CustomFormat != " ")
            {
                string stockName = txtStockName.Text;
                DateTime issuedDate = dtpIssuedDate.Value;
                DateTime? returnedDate = dtpReturnedDate.CustomFormat == " " ? (DateTime?)null : dtpReturnedDate.Value;
                string studentName = txtStudentName.Text;
                string studentNumber = txtStudentNumber.Text;

                try
                {
                    string stockArea;
                    int stockId;
                    if (TryGetStockIdAndArea(stockName, out stockId, out stockArea))
                    {
                        int studentId;
                        if (TryGetStudentId(studentName, studentNumber, out studentId))
                        {
                            // Stok kontrolü yapın ve stok yeterli değilse uyarı verin
                            if (UpdateStockQuantity(stockId, -1)) // Stok miktarını azalt
                            {
                                InsertTracingStocks(stockName, issuedDate, returnedDate, stockId, studentId);
                                MessageBox.Show("Malzeme başarıyla eklendi.");
                                ShowTracingStocks();
                            }
                            else
                            {
                                MessageBox.Show("Stok güncellenemedi. Stok miktarı yetersiz.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci bilgileri bulunamadı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girilen malzeme adı mevcut değil.");
                    }
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

        // Malzeme Miktarının Güncellenmesi
        private bool UpdateStockQuantity(int stockId, int quantityChange)
        {
            try
            {
                string checkQuery = "SELECT stockNumber FROM TblStock WHERE stockId = @stockId";
                SqlParameter[] checkParameters = {
            new SqlParameter("@stockId", stockId)
        };
                DataTable dt = Con.GetData(checkQuery, checkParameters);

                if (dt != null && dt.Rows.Count > 0)
                {
                    int currentStockNumber = Convert.ToInt32(dt.Rows[0]["stockNumber"]);
                    int newStockNumber = currentStockNumber + quantityChange;

                    if (newStockNumber < 0)
                    {
                        MessageBox.Show("Stok tükendi. Daha fazla malzeme verilemez.");
                        return false;
                    }

                    string query = "UPDATE TblStock SET stockNumber = @newStockNumber WHERE stockId = @stockId";
                    SqlParameter[] parameters = {
                new SqlParameter("@newStockNumber", newStockNumber),
                new SqlParameter("@stockId", stockId)
            };

                    int rowsAffected = Con.SetData(query, parameters);

                    return rowsAffected > 0;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return false;
            }
        }

        // Öğrenci adı ve numarasına göre id bilgisini çeken metod
        private bool TryGetStudentId(string studentName, string studentNumber, out int studentId)
        {
            studentId = 0;
            try
            {
                string query = "SELECT studentId FROM TblStudent WHERE studentName = @studentName AND studentNumber = @studentNumber";
                SqlParameter[] parameters = {
            new SqlParameter("@studentName", studentName),
            new SqlParameter("@studentNumber", studentNumber)
        };
                DataTable dt = Con.GetData(query, parameters);

                if (dt != null && dt.Rows.Count > 0)
                {
                    studentId = Convert.ToInt32(dt.Rows[0]["studentId"]);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            return false;
        }

        // Silme Metodunda Kullanılan Fonksiyon
        private void DeleteTracingStock(int tracingId)
        {
            try
            {
                string query = "DELETE FROM TblStockTracing WHERE stockTracingId = @stockTracingId";
                SqlParameter[] parameters = {
            new SqlParameter("@stockTracingId", tracingId)
        };
                int rowsAffected = Con.SetData(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Malzeme başarıyla silindi.");
                    ShowTracingStocks();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Güncelleme Metodunda Kullanılan Fonksiyon
        private void UpdateTracingStock(int tracingId, string stockName, DateTime issuedDate, DateTime? returnedDate, int stockId, int studentId)
        {
            try
            {
                string query = "UPDATE TblStockTracing SET stockName = @stockName, issuedDate = @issuedDate, returnedDate = @returnedDate, stockId = @stockId, studentId = @studentId " +
                               "WHERE stockTracingId = @stockTracingId";
                SqlParameter[] parameters = {
            new SqlParameter("@stockName", stockName),
            new SqlParameter("@issuedDate", issuedDate),
            new SqlParameter("@returnedDate", (object)returnedDate ?? DBNull.Value),
            new SqlParameter("@stockId", stockId),
            new SqlParameter("@studentId", studentId),
            new SqlParameter("@stockTracingId", tracingId)
        };

                int rowsAffected = Con.SetData(query, parameters);

                if (rowsAffected > 0)
                {
                    if (returnedDate.HasValue)
                    {
                        bool isStockUpdated = UpdateStockQuantity(stockId, 1); // Stok miktarını artır

                        if (isStockUpdated)
                        {
                            MessageBox.Show("Malzeme başarıyla güncellendi. Stok miktarı güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Malzeme güncellenirken stok güncellenemedi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Malzeme başarıyla güncellendi.");
                    }
                    ShowTracingStocks();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Ekleme Metodunda Kullanılan Fonksiyon
        private void InsertTracingStocks(string stockName, DateTime issuedDate, DateTime? returnedDate, int stockId, int studentId)
        {
            try
            {
                string query = "INSERT INTO TblStockTracing (stockName, issuedDate, returnedDate, stockId, studentId) " +
                               "VALUES (@stockName, @issuedDate, @returnedDate, @stockId, @studentId)";
                SqlParameter[] parameters = {
            new SqlParameter("@stockName", stockName),
            new SqlParameter("@issuedDate", issuedDate),
            new SqlParameter("@returnedDate", returnedDate.HasValue ? (object)returnedDate.Value : DBNull.Value),
            new SqlParameter("@stockId", stockId),
            new SqlParameter("@studentId", studentId)
        };
                Con.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Silme Metodu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStockTracing.SelectedRows.Count > 0)
            {
                int tracingId = Convert.ToInt32(dgvStockTracing.SelectedRows[0].Cells["ID"].Value);
                DeleteTracingStock(tracingId);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz malzemeyi seçin.");
            }
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            FilterStockTracing filterForm = new FilterStockTracing(userPermissions);
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                string nameFilter = filterForm.SelectedName;
                string stockAreaFilter = filterForm.SelectedStockArea;
                DateTime? issuedDateFilter = filterForm.SelectedIssuedDate;
                DateTime? returnedDateFilter = filterForm.SelectedReturnedDate;
                string studentNameFilter = filterForm.SelectedStudentName;
                string studentNumberFilter = filterForm.SelectedStudentNumber;

                ApplyFilter(nameFilter, stockAreaFilter, issuedDateFilter, returnedDateFilter, studentNameFilter, studentNumberFilter);
            }
        }

        // Filtreleme Metodu
        private void ApplyFilter(string nameFilter, string stockAreaFilter, DateTime? issuedDateFilter, DateTime? returnedDateFilter, string studentNameFilter, string studentNumberFilter)
        {
            try
            {
                string query = "SELECT k.stockTracingId AS 'ID', k.stockName AS 'Malzeme Adı', k.issuedDate AS 'Veriliş Tarihi', k.returnedDate AS 'Teslim Alınan Tarih', " +
                               "t.stockArea AS 'Bulunduğu Yer', s.studentName AS 'Teslim Alan Öğrenci', s.studentNumber AS 'Öğrenci Numarası', s.studentTC AS 'Öğrenci TC', " +
                               "s.studentPhone AS 'Öğrenci Telefon No', m.teamName AS 'Öğrenci Takımı' " +
                               "FROM TblStockTracing k " +
                               "JOIN TblStudent s ON k.studentId = s.studentId " +
                               "LEFT JOIN TblStock t ON k.stockId = t.stockId " +
                               "LEFT JOIN TblStockArea sa ON t.stockAreaId = sa.stockAreaId " +
                               "LEFT JOIN TblTeam m ON s.studentTeamId = m.teamId " +
                               "WHERE 1=1";

                if (!string.IsNullOrEmpty(nameFilter))
                {
                    query += " AND k.stockName LIKE @nameFilter";
                }
                if (!string.IsNullOrEmpty(stockAreaFilter))
                {
                    query += " AND t.stockArea = @stockAreaFilter";
                }
                if (issuedDateFilter.HasValue)
                {
                    query += " AND k.issuedDate >= @issuedDateFilter";
                }
                if (returnedDateFilter.HasValue)
                {
                    query += " AND k.returnedDate <= @returnedDateFilter";
                }
                if (!string.IsNullOrEmpty(studentNameFilter))
                {
                    query += " AND s.studentName LIKE @studentNameFilter";
                }
                if (!string.IsNullOrEmpty(studentNumberFilter))
                {
                    query += " AND s.studentNumber = @studentNumberFilter";
                }

                SqlParameter[] parameters = {
            new SqlParameter("@nameFilter", nameFilter),
            new SqlParameter("@stockAreaFilter", stockAreaFilter),
            new SqlParameter("@issuedDateFilter", issuedDateFilter),
            new SqlParameter("@returnedDateFilter", returnedDateFilter),
            new SqlParameter("@studentNameFilter", studentNameFilter),
            new SqlParameter("@studentNumberFilter", studentNumberFilter)
        };

                DataTable dt = Con.GetData(query, parameters);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvStockTracing.DataSource = dt;
                    dgvStockTracing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvStockTracing.ClearSelection();
                    lblStockTracing.Text = $"Toplam Rapor Sayısı: {dt.Rows.Count}";
                }
                else
                {
                    dgvStockTracing.DataSource = null;
                    lblStockTracing.Text = "Toplam Rapor Sayısı: 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Güncelleme Metodu
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStockTracing.SelectedRows.Count > 0)
            {
                int tracingId = Convert.ToInt32(dgvStockTracing.SelectedRows[0].Cells["ID"].Value);
                string stockName = txtStockName.Text;
                DateTime issuedDate = dtpIssuedDate.Value;
                DateTime? returnedDate = dtpReturnedDate.Value;
                int stockId;
                int studentId;

                if (TryGetStockIdAndArea(stockName, out stockId, out _))
                {
                    if (TryGetStudentId(txtStudentName.Text, txtStudentNumber.Text, out studentId))
                    {
                        UpdateTracingStock(tracingId, stockName, issuedDate, returnedDate, stockId, studentId);
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bilgileri bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Malzeme bilgileri bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz malzemeyi seçin.");
            }
        }

        // Butonlar ile Sayfa Yönlendirmeleri
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowTracingStocks();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF dosyası|*.pdf";
                saveFileDialog.Title = "PDF olarak kaydet";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    Con.ExportDataGridViewToPdf(dgvStockTracing, saveFileDialog.FileName);
                }
            }
        }

        private void pictureReport_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Report"))
            {
                ReportMenu stock = new ReportMenu(userPermissions);
                stock.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("ReportInfo"))
            {
                ReportMenuInfo stock = new ReportMenuInfo(userPermissions);
                stock.Show();
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