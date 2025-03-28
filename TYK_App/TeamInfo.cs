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
    public partial class TeamInfo : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public TeamInfo(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowTeams();
        }

        // Takım Verilerini Gösterme
        private void ShowTeams()
        {
            try
            {
                string query = @"
        SELECT 
            t.teamId AS 'ID',
            t.teamName AS 'Takım Adı', 
            t.community AS 'Topluluk Adı', 
            k.categoryName AS 'Kategori', 
            (SELECT COUNT(*) FROM TblStudent s WHERE s.studentTeamId = t.teamId) AS 'Kişi Sayısı', 
            t.teamAdvisor AS 'Takım Danışmanı', 
            s.studentName AS 'Takım Kaptanı', 
            s.studentPhone AS 'Kaptan No'
        FROM 
            TblTeam t 
            JOIN TblCategory k ON t.categoryId = k.categoryId 
            LEFT JOIN TblStudent s ON t.teamCaptainId = s.studentId;";

                DataTable dt = Con.GetData(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvTeamsInfo.DataSource = dt;
                    dgvTeamsInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvTeamsInfo.ClearSelection();

                    lblTotalTeams.Text = $"Toplam Takım Sayısı: {dt.Rows.Count}";
                }
                else
                {
                    dgvTeamsInfo.DataSource = null;
                    lblTotalTeams.Text = "Toplam Takım Sayısı: 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Filtreleme Metodu
        private void ApplyFilter(int? categoryId, string community, string teamName, string teamAdvisor, string teamCaptainName)
        {
            string query = @"
            SELECT 
                t.teamId AS 'ID',
                t.teamName AS 'Takım Adı', 
                t.community AS 'Topluluk Adı', 
                k.categoryName AS 'Kategori', 
                (SELECT COUNT(*) FROM TblStudent s WHERE s.studentTeamId = t.teamId) AS 'Kişi Sayısı', 
                t.teamAdvisor AS 'Takım Danışmanı', 
                s.studentName AS 'Takım Kaptanı', 
                s.studentPhone AS 'Kaptan No'
            FROM 
                TblTeam t 
                JOIN TblCategory k ON t.categoryId = k.categoryId 
                LEFT JOIN TblStudent s ON t.teamCaptainId = s.studentId 
            WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(community))
            {
                query += " AND t.community LIKE @community";
                parameters.Add(new SqlParameter("@community", "%" + community + "%"));
            }
            if (!string.IsNullOrEmpty(teamAdvisor))
            {
                query += " AND t.teamAdvisor LIKE @teamAdvisor";
                parameters.Add(new SqlParameter("@teamAdvisor", "%" + teamAdvisor + "%"));
            }
            if (!string.IsNullOrEmpty(teamName))
            {
                query += " AND t.teamName LIKE @teamName";
                parameters.Add(new SqlParameter("@teamName", "%" + teamName + "%"));
            }
            if (!string.IsNullOrEmpty(teamCaptainName))
            {
                query += " AND s.studentName LIKE @teamCaptainName";
                parameters.Add(new SqlParameter("@teamCaptainName", "%" + teamCaptainName + "%"));
            }
            if (categoryId.HasValue)
            {
                query += " AND t.categoryId = @categoryId";
                parameters.Add(new SqlParameter("@categoryId", categoryId.Value));
            }

            DataTable dt = Con.GetData(query, parameters.ToArray());

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvTeamsInfo.DataSource = dt;
                dgvTeamsInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("No data found.");
            }

            lblTotalTeams.Text = $"Toplam Takım Sayısı: {dt.Rows.Count}";
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterTeam filterForm = new FilterTeam(userPermissions);
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(
                    filterForm.SelectedCategory,
                    filterForm.SelectedCommunity,
                    filterForm.SelectedTeam,
                    filterForm.SelectedAdvisor,
                    filterForm.SelectedCaptain);
            }
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowTeams();
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
                    Con.ExportDataGridViewToPdf(dgvTeamsInfo, saveFileDialog.FileName);
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
