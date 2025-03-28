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
    public partial class ReportTracing : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public ReportTracing(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowReports();
            LoadCategories();
            LoadComboBoxOptions();
            dgvReportInfo.SelectionChanged += new EventHandler(dgvReportInfo_SelectionChanged);
            dgvReportInfo.MouseClick += new MouseEventHandler(dgvReportInfo_MouseClick);
            dgvReportInfo.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvReportInfo_CellFormatting);
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

        private void dgvReportInfo_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvReportInfo.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None)
            {
                ClearInputFields();
            }
        }

        private void dgvReportInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReportInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvReportInfo.SelectedRows[0];
                cboCategory.Text = selectedRow.Cells["Kategori"].Value?.ToString() ?? string.Empty;
                txtTeam.Text = selectedRow.Cells["Takım"].Value?.ToString() ?? string.Empty;
                txtCaptain.Text = selectedRow.Cells["Takım Kaptanı"].Value?.ToString() ?? string.Empty;
                cboReportResult.Text = selectedRow.Cells["Rapor Sonucu"].Value?.ToString() ?? string.Empty;
                cboAppealed.Text = selectedRow.Cells["İtiraz Durumu"].Value?.ToString() ?? string.Empty;
                cboFinalist.Text = selectedRow.Cells["Finalist Durumu"].Value?.ToString() ?? string.Empty;
            }
            else
            {
                ClearInputFields();
            }
        }

        // Input Alanlarını Temizleme
        private void ClearInputFields()
        {
            cboCategory.SelectedIndex = -1;
            txtTeam.Text = "";
            txtCaptain.Text = "";
            cboReportResult.SelectedIndex = -1;
            cboAppealed.SelectedIndex = -1;
            cboFinalist.SelectedIndex = -1;
        }

        // Combobox ların Yüklenmesi
        private void LoadComboBoxOptions()
        {
            cboReportResult.Items.Add("Geçti");
            cboReportResult.Items.Add("Kaldı");

            cboAppealed.Items.Add("İtiraz Edildi");
            cboAppealed.Items.Add("İtiraz Edilmedi");

            cboFinalist.Items.Add("Finalist");
            cboFinalist.Items.Add("Finalist Değil");
        }

        // Kategori Verilerinin Çekilmesi
        private void LoadCategories()
        {
            try
            {
                string query = "SELECT categoryId, categoryName FROM TblCategory";
                DataTable dt = Con.GetData(query);

                cboCategory.DisplayMember = "categoryName";
                cboCategory.ValueMember = "categoryId";
                cboCategory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        // Takıma ait bilgileri veritabanından bulma
        private int GetTeamId(string teamName, string captainName)
        {
            string query = $"SELECT teamId FROM TblTeam WHERE teamName = '{teamName}' AND teamCaptainId = (SELECT studentId FROM TblStudent WHERE studentName = '{captainName}')";
            DataTable dt = Con.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["teamId"]);
            }
            else
            {
                throw new Exception("Takım bulunamadı.");
            }
        }

        // Ekleme Metodu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTeam.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                int categoryId = (int)cboCategory.SelectedValue;
                string teamName = txtTeam.Text;
                string captainName = txtCaptain.Text;

                int reportResult = cboReportResult.SelectedItem.ToString() == "Geçti" ? 1 : 0;
                int isAppealed = cboAppealed.SelectedItem.ToString() == "İtiraz Edildi" ? 1 : 0;
                int isFinalist = cboFinalist.SelectedItem.ToString() == "Finalist" ? 1 : 0;

                int teamId = GetTeamId(teamName, captainName);

                string query = $"INSERT INTO TblReportTracing (categoryId, teamId, reportResult, isAppealed, isFinalist) " +
                               $"VALUES ({categoryId}, {teamId}, {reportResult}, {isAppealed}, {isFinalist})";

                Con.SetData(query);
                MessageBox.Show("Yeni rapor başarıyla eklendi.");
                ShowReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // Silme Metodu
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReportInfo.SelectedRows.Count > 0)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtTeam.Text))
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurun.");
                        return;
                    }

                    DataGridViewRow selectedRow = dgvReportInfo.SelectedRows[0];
                    int reportId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                    int categoryId = (int)cboCategory.SelectedValue;
                    string teamName = txtTeam.Text;
                    string captainName = txtCaptain.Text;

                    int reportResult = cboReportResult.SelectedItem.ToString() == "Geçti" ? 1 : 0;
                    int isAppealed = cboAppealed.SelectedItem.ToString() == "İtiraz Edildi" ? 1 : 0;
                    int isFinalist = cboFinalist.SelectedItem.ToString() == "Finalist" ? 1 : 0;

                    int teamId = GetTeamId(teamName, captainName);

                    string query = $"UPDATE TblReportTracing SET categoryId = {categoryId}, teamId = {teamId}, " +
                                   $"reportResult = {reportResult}, isAppealed = {isAppealed}, isFinalist = {isFinalist} " +
                                   $"WHERE reportTracingId = {reportId}";

                    Con.SetData(query);
                    MessageBox.Show("Rapor başarıyla güncellendi.");
                    ShowReports();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir satır seçin.");
            }
        }

        // Silme Metodu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReportInfo.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvReportInfo.SelectedRows[0];
                    int reportId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                    string query = $"DELETE FROM TblReportTracing WHERE reportTracingId = {reportId}";
                    Con.SetData(query);

                    MessageBox.Show("Rapor başarıyla silindi.");
                    ShowReports();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowReports();
        }

        // Butonlar ile Sayfa Yönlendirmeleri
        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBack_Click(object sender, EventArgs e)
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

        private void labelBack_Click(object sender, EventArgs e)
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
