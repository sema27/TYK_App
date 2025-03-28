using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class StockTracingInfo : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public StockTracingInfo(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowTracingStocks();
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

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvStockTracingInfo.DataSource = dt;
                dgvStockTracingInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStockTracingInfo.ClearSelection();

                lblStockTracing.Text = $"Toplam Rapor Sayısı: {dt.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Veri bulunamadı.");
                lblStockTracing.Text = $"Toplam Rapor Sayısı: 0";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
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
            string query = "SELECT k.stockTracingId AS 'ID', k.stockName AS 'Malzeme Adı', k.issuedDate AS 'Veriliş Tarihi', k.returnedDate AS 'Teslim Alınan Tarih', " +
                           "t.stockArea AS 'Bulunduğu Alan', s.studentName AS 'Teslim Alan Öğrenci', s.studentNumber AS 'Öğrenci Numarası', s.studentTC AS 'Öğrenci TC', " +
                           "s.studentPhone AS 'Öğrenci Telefon No', m.teamName AS 'Öğrenci Takımı' " +
                           "FROM TblStockTracing k " +
                           "JOIN TblStudent s ON k.studentId = s.studentId " +
                           "LEFT JOIN TblStock t ON k.stockId = t.stockId " +
                           "LEFT JOIN TblTeam m ON s.studentTeamId = m.teamId " +
                           "WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(nameFilter))
            {
                query += " AND LOWER(k.stockName) LIKE @nameFilter";
                parameters.Add(new SqlParameter("@nameFilter", "%" + nameFilter.ToLower() + "%"));
            }

            if (!string.IsNullOrEmpty(stockAreaFilter))
            {
                query += " AND LOWER(t.stockArea) LIKE @stockAreaFilter";
                parameters.Add(new SqlParameter("@stockAreaFilter", "%" + stockAreaFilter.ToLower() + "%"));
            }

            if (issuedDateFilter.HasValue)
            {
                query += " AND k.issuedDate = @issuedDateFilter";
                parameters.Add(new SqlParameter("@issuedDateFilter", issuedDateFilter.Value));
            }

            if (returnedDateFilter.HasValue)
            {
                query += " AND k.returnedDate = @returnedDateFilter";
                parameters.Add(new SqlParameter("@returnedDateFilter", returnedDateFilter.Value));
            }

            if (!string.IsNullOrEmpty(studentNameFilter))
            {
                query += " AND LOWER(s.studentName) LIKE @studentNameFilter";
                parameters.Add(new SqlParameter("@studentNameFilter", "%" + studentNameFilter.ToLower() + "%"));
            }

            if (!string.IsNullOrEmpty(studentNumberFilter))
            {
                query += " AND s.studentNumber = @studentNumberFilter";
                parameters.Add(new SqlParameter("@studentNumberFilter", studentNumberFilter));
            }

            DataTable dt = Con.GetData(query, parameters.ToArray());
            dgvStockTracingInfo.DataSource = dt;

            // Check if the data table is empty
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Filtreleme sonucunda veri bulunamadı.");
            }
            lblStockTracing.Text = $"Toplam Rapor Sayısı: {dt.Rows.Count}";
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowTracingStocks();
        }

        // Butonlar ile Sayfa Yönlendirmeleri
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
            Login login = new Login();
            login.Show();
            this.Hide();
        }

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

        private void pictureStock_Click_1(object sender, EventArgs e)
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
                    Con.ExportDataGridViewToPdf(dgvStockTracingInfo, saveFileDialog.FileName);
                }
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
