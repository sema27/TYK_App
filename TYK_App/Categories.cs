using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class Categories : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public Categories(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowCategories();
            dgvCategory.SelectionChanged += new EventHandler(dgvCategory_SelectionChanged);
            dgvCategory.MouseClick += new MouseEventHandler(dgvCategory_MouseClick);
            dgvCategory.CellEnter += new DataGridViewCellEventHandler(dgvCategory_CellEnter);
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
                txtCategory.Clear();
            }
            else
            {
                dgvCategory.DataSource = null;
            }
            lblCategory.Text = $"Toplam Kategori Sayısı: {dt.Rows.Count}";
        }


        private void dgvCategory_CellEnter(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCategory.Rows[e.RowIndex];

                txtCategory.Text = selectedRow.Cells["Kategori Adı"].Value.ToString() ?? string.Empty;
            }
        }

        private void dgvCategory_MouseClick(object? sender, MouseEventArgs e)
        {
            if (dgvCategory.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
            {
                ClearInputFields();
            }
        }

        // Input alanlarını temizlemek için kullanılan metot
        private void ClearInputFields()
        {
            txtCategory.Clear();
        }

        private void dgvCategory_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCategory.SelectedRows[0];
                txtCategory.Text = selectedRow.Cells["Kategori Adı"].Value.ToString();
            }
            else
            {
                ClearInputFields();
            }
        }

        // Ekleme Metodu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategory.Text))
            {
                string categoryName = txtCategory.Text;

                try
                {
                    string query = "INSERT INTO TblCategory (categoryName) " +
                               "VALUES (@categoryName)";

                    SqlParameter[] parameters = {
                    new SqlParameter("@categoryName", (object)categoryName ?? DBNull.Value)
                };

                    Con.SetData(query, parameters);

                    MessageBox.Show("Kategori başarıyla eklendi.");
                    ShowCategories();
                    ClearInputFields();
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
            if (dgvCategory.SelectedRows.Count > 0)
            {
                if (!string.IsNullOrEmpty(txtCategory.Text))
                {
                    try
                    {
                        int categoryId = Convert.ToInt32(dgvCategory.SelectedRows[0].Cells["ID"].Value);

                        string query = "UPDATE TblCategory SET categoryName = @categoryName WHERE categoryId = @categoryId";
                        SqlParameter[] parameters = {
                    new SqlParameter("@categoryName", txtCategory.Text),
                    new SqlParameter("@categoryId", categoryId)
                };

                        Con.SetData(query, parameters);
                        MessageBox.Show("Kategori başarıyla güncellendi.");
                        ShowCategories();
                        ClearInputFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz kategori bilgilerini girin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kategoriyi seçin.");
            }
        }

        // Silme Metodu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                try
                {
                    int userId = Convert.ToInt32(dgvCategory.SelectedRows[0].Cells["ID"].Value);

                    string query = "DELETE FROM TblCategory WHERE categoryId = @categoryId";
                    SqlParameter[] parameters = {
                new SqlParameter("@categoryId", userId)
            };

                    Con.SetData(query, parameters);
                    MessageBox.Show("Kategori başarıyla silindi.");
                    ShowCategories();
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kategoriyi seçin.");
            }
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

        // Input Alanlarını Temizleyen Metod
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowCategories();
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

        private void pictureReport_Click_1(object sender, EventArgs e)
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

        private void pictureExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
