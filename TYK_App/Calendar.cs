using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class Calendar : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public Calendar(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowCalendar();
            dgvCalendar.CellClick += new DataGridViewCellEventHandler(dgvCalendar_CellClick);
        }

        // Verileri çekme ve tabloda gösterme
        private void ShowCalendar()
        {
            string query = @"
                SELECT 
                    calendarId AS ID, 
                    competitionName AS Yarışma, 
                    startDate AS 'Başlangıç Tarihi', 
                    endDate AS 'Bitiş Tarihi', 
                    competitionLocation AS 'Yer'
                FROM TblCalendar";

            DataTable dt = Con.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvCalendar.DataSource = dt;
                dgvCalendar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCalendar.ClearSelection();
            }
            else
            {
                MessageBox.Show("Veri bulunamadı.");
            }
        }

        // Input alanlarını temizlemek için kullanılan metot
        private void ClearInputFields()
        {
            txtCompetition.Text = "";
            txtLocation.Text = "";
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
        }

        // Ekleme Metodu
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCompetition.Text) || string.IsNullOrEmpty(txtLocation.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                string competitionName = txtCompetition.Text;
                string startDate = dtpStart.Value.ToString("yyyy-MM-dd");
                string endDate = dtpEnd.Value.ToString("yyyy-MM-dd");
                string location = txtLocation.Text;

                string query = "INSERT INTO TblCalendar (competitionName, startDate, endDate, competitionLocation) " +
                               "VALUES (@competitionName, @startDate, @endDate, @location)";

                SqlParameter[] parameters = {
            new SqlParameter("@competitionName", (object)competitionName ?? DBNull.Value),
            new SqlParameter("@startDate", (object)startDate ?? DBNull.Value),
            new SqlParameter("@endDate", (object)endDate ?? DBNull.Value),
            new SqlParameter("@location", (object)location ?? DBNull.Value)
        };

                Con.SetData(query, parameters);
                MessageBox.Show("Yarışma başarıyla eklendi!");
                ShowCalendar();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        //Güncelleme Metodu
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCalendar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.");
                    return;
                }

                int id = Convert.ToInt32(dgvCalendar.SelectedRows[0].Cells["ID"].Value);
                string competitionName = txtCompetition.Text;
                string startDate = dtpStart.Value.ToString("yyyy-MM-dd");
                string endDate = dtpEnd.Value.ToString("yyyy-MM-dd");
                string location = txtLocation.Text;

                string query = "UPDATE TblCalendar SET competitionName = @competitionName, startDate = @startDate, " +
                               "endDate = @endDate, competitionLocation = @location WHERE calendarId = @id";

                SqlParameter[] parameters = {
            new SqlParameter("@competitionName", (object)competitionName ?? DBNull.Value),
            new SqlParameter("@startDate", (object)startDate ?? DBNull.Value),
            new SqlParameter("@endDate", (object)endDate ?? DBNull.Value),
            new SqlParameter("@location", (object)location ?? DBNull.Value),
            new SqlParameter("@id", id)
        };

                int rowsAffected = Con.SetData(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Yarışma başarıyla güncellendi!");
                    ShowCalendar();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu. Lütfen tekrar deneyin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        //Silme Metodu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCalendar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
                    return;
                }

                int id = Convert.ToInt32(dgvCalendar.SelectedRows[0].Cells["ID"].Value);

                string query = "DELETE FROM TblCalendar WHERE calendarId = @id";

                SqlParameter[] parameters = {
            new SqlParameter("@id", id)
        };

                int rowsAffected = Con.SetData(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Yarışma başarıyla silindi!");
                    ShowCalendar(); // Refresh the calendar with updated data
                }
                else
                {
                    MessageBox.Show("Silme sırasında bir hata oluştu. Lütfen tekrar deneyin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Tabloda seçilen satırdaki verileri input alanlarına çekme
        private void dgvCalendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCompetition.Text = dgvCalendar.Rows[e.RowIndex].Cells["Yarışma"].Value.ToString();
                txtLocation.Text = dgvCalendar.Rows[e.RowIndex].Cells["Yer"].Value.ToString();
                dtpStart.Value = Convert.ToDateTime(dgvCalendar.Rows[e.RowIndex].Cells["Başlangıç Tarihi"].Value);
                dtpEnd.Value = Convert.ToDateTime(dgvCalendar.Rows[e.RowIndex].Cells["Bitiş Tarihi"].Value);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterCalendar filterForm = new FilterCalendar(userPermissions);

            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                string nameFilter = filterForm.NameFilter;
                string locationFilter = filterForm.LocationFilter;

                ApplyFilter(nameFilter, locationFilter);
            }
        }

        // Filtreleme Metodu
        private void ApplyFilter(string nameFilter, string locationFilter)
        {            StringBuilder query = new StringBuilder(@"
        SELECT 
            calendarId AS ID, 
            competitionName AS 'Yarışma', 
            startDate AS 'Başlangıç Tarihi', 
            endDate AS 'Bitiş Tarihi', 
            competitionLocation AS 'Yer'
        FROM TblCalendar
        WHERE 1=1");

            if (!string.IsNullOrEmpty(nameFilter))
            {
                query.Append(" AND competitionName LIKE @nameFilter");
            }

            if (!string.IsNullOrEmpty(locationFilter))
            {
                query.Append(" AND competitionLocation LIKE @locationFilter");
            }

            List<SqlParameter> parameters = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(nameFilter))
            {
                parameters.Add(new SqlParameter("@nameFilter", $"%{nameFilter}%"));
            }

            if (!string.IsNullOrEmpty(locationFilter))
            {
                parameters.Add(new SqlParameter("@locationFilter", $"%{locationFilter}%"));
            }

            // Verileri al
            DataTable dt = Con.GetData(query.ToString(), parameters.ToArray());

            // DataGridView'ı güncelle
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvCalendar.DataSource = dt;
                dgvCalendar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCalendar.ClearSelection();
            }
            else
            {
                dgvCalendar.DataSource = null;
                MessageBox.Show("Veri bulunamadı.");
            }
        }

        // Input Alanlarını Temizleyen Metod
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF dosyası|*.pdf";
                saveFileDialog.Title = "PDF olarak kaydet";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    Con.ExportDataGridViewToPdf(dgvCalendar, saveFileDialog.FileName);
                }
            }
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowCalendar();
        }
    }
}
