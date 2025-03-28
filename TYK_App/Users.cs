using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class Users : Form
    {
        private Functions Con;

        private bool isUserManagementSelected = false;

        private List<string> userPermissions;

        public Users(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            LoadUsers();
            dgvUser.SelectionChanged += DgvUser_SelectionChanged;
            dgvUser.MouseClick += DgvUser_MouseClick;
            dgvUser.CellEnter += DgvUser_CellEnter;
        }

        // Verile çekme ve tabloda gösterme
        private void LoadUsers()
        {
            try
            {
                string query = "SELECT u.userId AS 'ID', u.userRole AS 'Kullanıcı Rolü', u.userName AS 'Kullanıcı Adı', u.password AS 'Şifre' FROM TblUser u";
                DataTable userDt = Con.GetData(query);

                dgvUser.DataSource = userDt;
                dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUser.ClearSelection();
                lblUser.Text = $"Toplam Kullanıcı Sayısı: {userDt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private int? GetSelectedUserId()
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgvUser.SelectedRows[0].Cells["ID"].Value);
            }
            return null;
        }

        private void DgvUser_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvUser.Rows[e.RowIndex];
                txtRole.Text = selectedRow.Cells["Kullanıcı Rolü"].Value?.ToString() ?? string.Empty;
                txtName.Text = selectedRow.Cells["Kullanıcı Adı"].Value?.ToString() ?? string.Empty;
                txtPassword.Text = selectedRow.Cells["Şifre"].Value?.ToString() ?? string.Empty;
            }
        }

        private void DgvUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvUser.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
            {
                ClearInputFields();
                ClearPermissions();
            }
        }

        private void DgvUser_SelectionChanged(object sender, EventArgs e)
        {
            int? userId = GetSelectedUserId();
            if (userId.HasValue)
            {
                DataGridViewRow selectedRow = dgvUser.SelectedRows[0];
                txtRole.Text = selectedRow.Cells["Kullanıcı Rolü"].Value.ToString();
                txtName.Text = selectedRow.Cells["Kullanıcı Adı"].Value.ToString();
                txtPassword.Text = selectedRow.Cells["Şifre"].Value.ToString();

                LoadUserPermissions(userId.Value);
            }
            else
            {
                ClearInputFields();
                ClearPermissions();
            }
        }

        // Kişi İzinlerini Belirleme
        private void LoadUserPermissions(int userId)
        {
            try
            {
                string query = "SELECT p.pageId FROM TblUserAuthorities ua " +
                               "INNER JOIN TblPages p ON ua.pageId = p.pageId " +
                               "WHERE ua.userId = @userId";
                SqlParameter[] parameters = { new SqlParameter("@userId", userId) };
                DataTable dt = Con.GetData(query, parameters);

                ClearPermissions();

                foreach (DataRow row in dt.Rows)
                {
                    int pageId = Convert.ToInt32(row["pageId"]);
                    RadioButton radioButton = GetRadioButtonForPageId(pageId);
                    if (radioButton != null)
                    {
                        radioButton.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Sayfa Erişimlerini belirleme
        private RadioButton GetRadioButtonForPageId(int pageId)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control panelControl in panel.Controls)
                    {
                        if (panelControl is RadioButton radioButton && radioButton.Tag is int tag && tag == pageId)
                        {
                            return radioButton;
                        }
                    }
                }
            }
            return null;
        }

        // İzinleri Silme
        private void ClearPermissions()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control panelControl in panel.Controls)
                    {
                        if (panelControl is RadioButton radioButton)
                        {
                            if (radioButton.Tag == null)
                            {
                                radioButton.Checked = false;
                            }
                            else
                            {
                                radioButton.Checked = false;
                            }
                        }
                    }
                }
            }
        }

        // Input alanlarını temizleme
        private void ClearInputFields()
        {
            txtRole.Clear();
            txtName.Clear();
            txtPassword.Clear();
        }

        // Kişi Ekleme
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                try
                {
                    InsertUser(txtRole.Text, txtName.Text, txtPassword.Text);
                    MessageBox.Show("Kullanıcı başarıyla eklendi.");
                    LoadUsers();
                    ClearInputFields();
                    ClearPermissions();
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

        // Input Alanlarındaki Veri Kontrolleri
        private bool ValidateUserInput()
        {
            return !string.IsNullOrEmpty(txtRole.Text) &&
                   !string.IsNullOrEmpty(txtName.Text) &&
                   !string.IsNullOrEmpty(txtPassword.Text);
        }

        // Kişi ekleme fonksiyonu
        private void InsertUser(string role, string name, string password)
        {
            try
            {
                string query = "INSERT INTO TblUser (userRole, userName, password) VALUES (@userRole, @userName, @password)";

                SqlParameter[] parameters = {
                    new SqlParameter("@userRole", role),
                    new SqlParameter("@userName", name),
                    new SqlParameter("@password", password)
                };

                Con.SetData(query, parameters);

                int userId = GetUserIdByName(name);
                SetUserPermissions(userId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // İsme Göre Id Çekme
        private int GetUserIdByName(string userName)
        {
            string query = "SELECT userId FROM TblUser WHERE userName = @userName";
            SqlParameter[] parameters = { new SqlParameter("@userName", userName) };
            DataTable dt = Con.GetData(query, parameters);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["userId"]);
            }
            throw new Exception("Kullanıcı ID bulunamadı.");
        }

        // Siilme Fonksiyonu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUser.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.");
                    return;
                }

                DialogResult result = MessageBox.Show("Kullanıcıyı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    return;
                }

                int selectedUserId = Convert.ToInt32(dgvUser.SelectedRows[0].Cells["ID"].Value);

                // İlk olarak TblUserAuthorities tablosundaki referansları silme
                string deleteAuthoritiesQuery = "DELETE FROM TblUserAuthorities WHERE userId = @userId";
                SqlParameter[] authorityParams = new SqlParameter[]
                {
        new SqlParameter("@userId", selectedUserId)
                };
                Con.SetData(deleteAuthoritiesQuery, authorityParams);

                // Ardından TblUser tablosundan kullanıcıyı silme
                string deleteUserQuery = "DELETE FROM TblUser WHERE userId = @userId";
                SqlParameter[] userParams = new SqlParameter[]
                {
        new SqlParameter("@userId", selectedUserId)
                };
                Con.SetData(deleteUserQuery, userParams);

                LoadUsers();
                MessageBox.Show("Kullanıcı Silindi !!!");

                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        // Güncelleme Metodu
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? userId = GetSelectedUserId();
            if (userId.HasValue)
            {
                if (ValidateUserInput())
                {
                    try
                    {
                        UpdateUser(userId.Value, txtRole.Text, txtName.Text, txtPassword.Text);
                        MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                        LoadUsers();
                        ClearInputFields();
                        ClearPermissions();
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
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kullanıcıyı seçin.");
            }
        }

        // Güncelleme metodunda kullanılan güncelleme fonksiyonu
        private void UpdateUser(int userId, string role, string name, string password)
        {
            string query = "UPDATE TblUser SET userRole = @userRole, userName = @userName, password = @password WHERE userId = @userId";

            SqlParameter[] parameters = {
                new SqlParameter("@userRole", role),
                new SqlParameter("@userName", name),
                new SqlParameter("@password", password),
                new SqlParameter("@userId", userId)
            };

            Con.SetData(query, parameters);

            // Tablodaki önceki izinleri temizleyin
            ClearUserPermissions(userId);

            // Yeni izinleri ayarlayın
            SetUserPermissions(userId);
        }

        private void ClearUserPermissions(int userId)
        {
            string query = "DELETE FROM TblUserAuthorities WHERE userId = @userId";
            SqlParameter[] parameters = { new SqlParameter("@userId", userId) };
            Con.SetData(query, parameters);
        }

        private void SetUserPermissions(int userId)
        {
            try
            {
                // İzin verilen sayfaları belirle
                List<int> allowedPages = new List<int>();

                foreach (Control control in this.Controls)
                {
                    if (control is Panel panel)
                    {
                        foreach (Control panelControl in panel.Controls)
                        {
                            if (panelControl is RadioButton radioButton && radioButton.Checked)
                            {
                                int pageId = (int)radioButton.Tag;
                                allowedPages.Add(pageId);
                            }
                        }
                    }
                }

                // Kullanıcının izinlerini ekleyin
                string insertPermissionsQuery = "INSERT INTO TblUserAuthorities (userId, pageId) VALUES (@userId, @pageId)";

                foreach (int pageId in allowedPages)
                {
                    SqlParameter[] parameters = {
                new SqlParameter("@userId", userId),
                new SqlParameter("@pageId", pageId)
            };

                    Con.SetData(insertPermissionsQuery, parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Filtrelemme Metodu
        private void ApplyFilter(string roleFilter, string nameFilter)
        {
            string query = "SELECT u.userId AS 'ID', u.userRole AS 'Kullanıcı Rolü', u.userName AS 'Kullanıcı Adı', u.password AS 'Şifre' FROM TblUser u WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(roleFilter))
            {
                query += " AND LOWER(u.userRole) LIKE @roleFilter";
                parameters.Add(new SqlParameter("@roleFilter", "%" + roleFilter.ToLower() + "%"));
            }
            if (!string.IsNullOrEmpty(nameFilter))
            {
                query += " AND LOWER(u.userName) LIKE @nameFilter";
                parameters.Add(new SqlParameter("@nameFilter", "%" + nameFilter.ToLower() + "%"));
            }
            DataTable dt = Con.GetData(query, parameters.ToArray());
            dgvUser.DataSource = dt;
            lblUser.Text = $"Toplam Kullanıcı Sayısı: {dt.Rows.Count}";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterUser filterForm = new FilterUser(userPermissions);
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                string roleFilter = filterForm.SelectedRole;
                string nameFilter = filterForm.SelectedUsername;

                ApplyFilter(roleFilter, nameFilter);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            ClearPermissions();
        }


        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // Kutucuklardan Birinin İşaretlenmesi
        private void chkCanEdit_Student_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCanEdit_Student.Checked)
            {
                chkCanView_Student.Checked = false;
            }
        }

        private void chkCanEdit_Team_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCanEdit_Team.Checked)
            {
                chkCanView_Team.Checked = false;
            }
        }

        private void chkCanEdit_Stock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCanEdit_Stock.Checked)
            {
                chkCanView_Stock.Checked = false;
            }
        }

        private void chkCanEdit_Report_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCanEdit_Report.Checked)
            {
                chkCanView_Report.Checked = false;
            }
        }

        private void chkCanEdit_Category_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCanEdit_Category.Checked)
            {
                chkCanView_Category.Checked = false;
            }
        }

        private void chkCanEdit_User_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCanEdit_Category.Checked)
            {
                chkCanView_Category.Checked = false;
            }
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
                MessageBox.Show("Kategoriler sayfasına erişim izniniz yok.");
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

        private void pictureBack_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void labelBack_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
