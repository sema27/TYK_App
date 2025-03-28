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
    public partial class CategoryInfo : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public CategoryInfo(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowCategories();
        }

        // Verileri çekme ve tabloda gösterme
        private void ShowCategories()
        {
            string query = "SELECT c.categoryId AS 'ID',c.categoryName AS 'Kategori Adı' FROM TblCategory c";
            DataTable dt = Con.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvCategory.DataSource = dt;
                dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCategory.ClearSelection();
            }
            else
            {
                dgvCategory.DataSource = null;
            }
            lblCategory.Text = $"Toplam Kategori Sayısı: {dt.Rows.Count}";
        }

        // Filtreleme Metodu
        private void ApplyFilter(string nameFilter)
        {
            string query = "SELECT c.categoryId, c.categoryName AS 'Kategori Adı' FROM TblCategory c WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(nameFilter))
            {
                query += " AND LOWER(c.categoryName) LIKE @nameFilter";
                parameters.Add(new SqlParameter("@nameFilter", "%" + nameFilter.ToLower() + "%"));
            }

            DataTable dt = Con.GetData(query, parameters.ToArray());
            dgvCategory.DataSource = dt;
            lblCategory.Text = $"Toplam Kategori Sayısı: {dt.Rows.Count}";
        }

        // Buton ile Sayfa Yönlendirmeleri
        private void pictureBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterCategory filterForm = new FilterCategory(userPermissions);
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                string nameFilter = filterForm.CategoryName;

                ApplyFilter(nameFilter);
            }
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }
    }
}
