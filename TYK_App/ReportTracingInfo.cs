using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class ReportTracingInfo : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public ReportTracingInfo(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowReports();
            dgvReportInfo.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvReportInfo_CellFormatting); // CellFormatting olayını ekliyoruz
        }

        // Finalist Olma Durumuna Göre Renklendirme Yapan Metod
        private void dgvReportInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Hücreler üzerinde işlem yapacağımız sütunun indeksini alıyoruz
            int finalistColumnIndex = dgvReportInfo.Columns["Finalist Durumu"].Index;

            // Eğer işlem yaptığımız hücre bu sütundaysa
            if (e.ColumnIndex == finalistColumnIndex)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "Finalist")
                    {
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (e.Value.ToString() == "Finalist Değil")
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        // Verileri çekme ve tabloda gösterme
        private void ShowReports()
        {
            string query = @"
                SELECT 
                    r.reportTracingId AS ID, 
                    c.categoryName AS Kategori, 
                    t.teamName AS 'Takım', 
                    s.studentName AS 'Takım Kaptanı', 
                    CASE WHEN r.reportResult = 1 THEN 'Geçti' ELSE 'Kaldı' END AS 'Rapor Sonucu',
                    CASE WHEN r.isAppealed = 1 THEN 'İtiraz Edildi' ELSE 'İtiraz Edilmedi' END AS 'İtiraz Durumu',
                    CASE WHEN r.isFinalist = 1 THEN 'Finalist' ELSE 'Finalist Değil' END AS 'Finalist Durumu'
                FROM TblReportTracing r 
                JOIN TblCategory c ON r.categoryId = c.categoryId 
                LEFT JOIN TblTeam t ON r.teamId = t.teamId 
                LEFT JOIN TblStudent s ON t.teamCaptainId = s.studentId";

            DataTable dt = Con.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvReportInfo.DataSource = dt;
                dgvReportInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReportInfo.ClearSelection();
            }
            else
            {
                MessageBox.Show("Veri bulunamadı.");
            }
        }

        // Filtreleme Metodu
        private void ApplyFilter(int? selectedCategory, string selectedTeam, string selectedCaptain, bool? selectedReport, bool? selectedAppealed, bool? selectedFinalist)
        {
            string query = @"
                SELECT 
                    r.reportTracingId AS ID, 
                    c.categoryName AS Kategori, 
                    t.teamName AS 'Takım', 
                    s.studentName AS 'Takım Kaptanı', 
                    CASE WHEN r.reportResult = 1 THEN 'Geçti' ELSE 'Kaldı' END AS 'Rapor Sonucu',
                    CASE WHEN r.isAppealed = 1 THEN 'İtiraz Edildi' ELSE 'İtiraz Edilmedi' END AS 'İtiraz Durumu',
                    CASE WHEN r.isFinalist = 1 THEN 'Finalist' ELSE 'Finalist Değil' END AS 'Finalist Durumu'
                FROM TblReportTracing r 
                JOIN TblCategory c ON r.categoryId = c.categoryId 
                LEFT JOIN TblTeam t ON r.teamId = t.teamId 
                LEFT JOIN TblStudent s ON t.teamCaptainId = s.studentId
                WHERE 1=1";

            if (selectedCategory.HasValue)
                query += $" AND r.categoryId = {selectedCategory.Value}";
            if (!string.IsNullOrEmpty(selectedTeam))
                query += $" AND t.teamName LIKE '%{selectedTeam}%'";
            if (!string.IsNullOrEmpty(selectedCaptain))
                query += $" AND s.studentName LIKE '%{selectedCaptain}%'";
            if (selectedReport.HasValue)
                query += $" AND r.reportResult = {(selectedReport.Value ? 1 : 0)}";
            if (selectedAppealed.HasValue)
                query += $" AND r.isAppealed = {(selectedAppealed.Value ? 1 : 0)}";
            if (selectedFinalist.HasValue)
                query += $" AND r.isFinalist = {(selectedFinalist.Value ? 1 : 0)}";

            DataTable dt = Con.GetData(query);
            dgvReportInfo.DataSource = dt;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (FilterReportTracing filterForm = new FilterReportTracing(userPermissions))
            {
                if (filterForm.ShowDialog() == DialogResult.OK)
                {
                    ApplyFilter(filterForm.SelectedCategory, filterForm.SelectedTeam, filterForm.SelectedCaptain, filterForm.SelectedReport, filterForm.SelectedAppealed, filterForm.SelectedFinalist);
                }
            }
        }

        // Butonlar ile Sayfa Yönlendirmeleri
        private void pictureStudent_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Student"))
            {
                Students students = new Students(userPermissions);
                students.Show();
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
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowReports();
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
                    Con.ExportDataGridViewToPdf(dgvReportInfo, saveFileDialog.FileName);
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
