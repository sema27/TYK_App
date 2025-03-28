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
    public partial class CalendarInfo : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public CalendarInfo(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowCalendar();
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

        // Filtreleme Metodu
        private void ApplyFilter(string nameFilter, string locationFilter)
        {
            StringBuilder query = new StringBuilder(@"
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

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowCalendar();
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

        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
