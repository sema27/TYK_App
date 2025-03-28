using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Transactions;
using System.Drawing;

namespace TYK_App
{
    public partial class Teams : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public Teams(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowTeams();
            LoadCategories();
            dgvTeamsInfo.SelectionChanged += new EventHandler(dgvTeamsInfo_SelectionChanged);
            dgvTeamsInfo.MouseClick += new MouseEventHandler(dgvTeamsInfo_MouseClick);
        }

        // Kategori Bilgilerini Yükleme
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

        private void dgvTeamsInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeamsInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTeamsInfo.SelectedRows[0];
                txtTeamName.Text = selectedRow.Cells["Takım Adı"].Value?.ToString() ?? string.Empty;
                txtCommunity.Text = selectedRow.Cells["Topluluk Adı"].Value?.ToString() ?? string.Empty;
                cboCategory.Text = selectedRow.Cells["Kategori"].Value?.ToString() ?? string.Empty;
                txtTeamAdvisor.Text = selectedRow.Cells["Takım Danışmanı"].Value?.ToString() ?? string.Empty;
                txtTeamCaptain.Text = selectedRow.Cells["Takım Kaptanı"].Value?.ToString() ?? string.Empty;
            }
            else
            {
                ClearInputFields();
            }
        }

        // Takım Bilgilerini Çekme
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
    (SELECT COUNT(*) FROM TblTeamMember tm WHERE tm.teamId = t.teamId) AS 'Kişi Sayısı', 
    t.teamAdvisor AS 'Takım Danışmanı', 
    s.studentName AS 'Takım Kaptanı', 
    s.studentPhone AS 'Kaptan No'  
FROM 
    TblTeam t 
JOIN TblCategory k ON t.categoryId = k.categoryId
LEFT JOIN TblStudent s ON t.teamCaptainId = s.studentId;
";

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
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Hatası: {sqlEx.Message}", "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Genel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvTeamsInfo_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvTeamsInfo.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None)
            {
                ClearInputFields();
            }
        }

        // Takım Ekleme
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTeamName.Text) || string.IsNullOrWhiteSpace(txtCommunity.Text) ||
                    string.IsNullOrWhiteSpace(cboCategory.Text) || string.IsNullOrWhiteSpace(txtTeamCaptain.Text))
                {
                    MessageBox.Show("Eksik Veri !!!");
                    return;
                }

                string teamName = txtTeamName.Text;
                string community = txtCommunity.Text;
                int categoryId = Convert.ToInt32(cboCategory.SelectedValue);
                string teamAdvisor = txtTeamAdvisor.Text;
                string teamCaptainName = txtTeamCaptain.Text;

                // Aynı isimde bir takım olup olmadığını kontrol et
                string queryCheckTeam = "SELECT COUNT(*) FROM TblTeam WHERE teamName = @teamName";
                SqlParameter[] checkTeamParams = new SqlParameter[] { new SqlParameter("@teamName", teamName) };
                DataTable dtCheckTeam = Con.GetData(queryCheckTeam, checkTeamParams);

                if (Convert.ToInt32(dtCheckTeam.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Bu isimde bir takım zaten mevcut.");
                    return;
                }

                // Kaptan ID'sini al
                string queryGetCaptainId = "SELECT studentId FROM TblStudent WHERE studentName = @studentName";
                SqlParameter[] getCaptainIdParams = new SqlParameter[] { new SqlParameter("@studentName", teamCaptainName) };
                DataTable dtCaptain = Con.GetData(queryGetCaptainId, getCaptainIdParams);

                if (dtCaptain.Rows.Count == 0)
                {
                    MessageBox.Show("Kaptan bulunamadı!");
                    return;
                }

                int teamCaptainId = Convert.ToInt32(dtCaptain.Rows[0]["studentId"]);
                SqlTransaction transaction = Con.BeginTransaction();

                try
                {
                    // İlk olarak takımı ekliyoruz
                    string queryInsertTeam = @"
            INSERT INTO TblTeam (teamName, community, categoryId, teamAdvisor, teamCaptainId) 
            VALUES (@teamName, @community, @categoryId, @teamAdvisor, @teamCaptainId);
            SELECT SCOPE_IDENTITY();"; // Yeni eklenen takımın ID'sini almak için

                    SqlParameter[] insertTeamParams = new SqlParameter[] {
            new SqlParameter("@teamName", teamName),
            new SqlParameter("@community", community),
            new SqlParameter("@categoryId", categoryId),
            new SqlParameter("@teamAdvisor", teamAdvisor),
            new SqlParameter("@teamCaptainId", teamCaptainId)
        };

                    // Transaction ile birlikte sorguyu çalıştırıyoruz
                    int newTeamId = Convert.ToInt32(Con.SetDataWithTransaction(queryInsertTeam, insertTeamParams, transaction));

                    // Eğer kimlik değeri 0 veya negatifse, işlemin başarısız olduğunu kontrol edin
                    if (newTeamId == 0)
                    {
                        MessageBox.Show("Yeni takım eklenemedi!");
                        transaction.Rollback(); // Eğer ekleme başarısızsa işlemi geri alıyoruz
                        return;
                    }

                    // Kaptanı takım üyesi olarak TblTeamMember tablosuna ekliyoruz
                    string queryInsertTeamMember = "INSERT INTO TblTeamMember (teamId, studentId) VALUES (@teamId, @studentId)";
                    SqlParameter[] insertTeamMemberParams = new SqlParameter[] {
            new SqlParameter("@teamId", newTeamId),
            new SqlParameter("@studentId", teamCaptainId)
        };

                    // Transaction ile birlikte kaptan ekleniyor
                    Con.SetDataWithTransaction(queryInsertTeamMember, insertTeamMemberParams, transaction);

                    // Eğer her şey başarılı olursa transaction'ı commit ediyoruz
                    transaction.Commit();
                    MessageBox.Show("Takım başarıyla eklendi ve kaptan üye olarak eklendi, ID: " + newTeamId);
                }
                catch (Exception ex)
                {
                    // Hata meydana gelirse transaction'ı geri alıyoruz (rollback)
                    transaction.Rollback();
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Input Alanlarını Temizleme
        private void ClearInputFields()
        {
            txtTeamName.Text = "";
            cboCategory.SelectedIndex = -1;
            txtCommunity.Text = "";
            txtTeamAdvisor.Text = "";
            txtTeamCaptain.Text = "";
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

        // Filtreleme Metodu
        private void ApplyFilter(int? categoryId, string community, string teamName, string teamAdvisor, string teamCaptainName)
        {
            string query = @"
    SELECT 
        t.teamId AS 'ID',
        t.teamName AS 'Takım Adı', 
        t.community AS 'Topluluk Adı', 
        k.categoryName AS 'Kategori', 
        (SELECT COUNT(DISTINCT s.studentId) + 
                CASE WHEN t.teamCaptainId IS NOT NULL THEN 1 ELSE 0 END
         FROM TblStudent s
         WHERE s.studentTeamId = t.teamId) AS 'Kişi Sayısı', 
        t.teamAdvisor AS 'Takım Danışmanı', 
        (SELECT s.studentName 
         FROM TblStudent s 
         WHERE s.studentId = t.teamCaptainId) AS 'Takım Kaptanı',
        (SELECT s.studentPhone
         FROM TblStudent s 
         WHERE s.studentId = t.teamCaptainId) AS 'Kaptan No'
    FROM 
        TblTeam t 
    JOIN TblCategory k ON t.categoryId = k.categoryId 
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
                query += @"
        AND EXISTS (
            SELECT 1 
            FROM TblStudent s 
            WHERE s.studentId = t.teamCaptainId 
            AND s.studentName LIKE @teamCaptainName)";
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
                dgvTeamsInfo.DataSource = null;
                MessageBox.Show("No data found.");
            }

            lblTotalTeams.Text = $"Toplam Takım Sayısı: {dt.Rows.Count}";
        }

        // Güncelleme Metodu
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTeamsInfo.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir takım seçin.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTeamName.Text) || string.IsNullOrWhiteSpace(txtCommunity.Text) ||
                    string.IsNullOrWhiteSpace(cboCategory.Text) || string.IsNullOrWhiteSpace(txtTeamCaptain.Text))
                {
                    MessageBox.Show("Eksik Veri !!!");
                    return;
                }

                int selectedTeamId = Convert.ToInt32(dgvTeamsInfo.SelectedRows[0].Cells["ID"].Value);
                string teamName = txtTeamName.Text;
                string community = txtCommunity.Text;
                int categoryId = Convert.ToInt32(cboCategory.SelectedValue);
                string teamAdvisor = txtTeamAdvisor.Text;
                string teamCaptainName = txtTeamCaptain.Text;

                // Kaptan ID'sini al
                string queryGetCaptainId = "SELECT studentId FROM TblStudent WHERE studentName = @studentName";
                SqlParameter[] getCaptainIdParams = new SqlParameter[] { new SqlParameter("@studentName", teamCaptainName) };
                DataTable dtCaptain = Con.GetData(queryGetCaptainId, getCaptainIdParams);

                if (dtCaptain.Rows.Count == 0)
                {
                    MessageBox.Show("Kaptan bulunamadı!");
                    return;
                }

                int teamCaptainId = Convert.ToInt32(dtCaptain.Rows[0]["studentId"]);

                // Takım güncelleme sorgusu
                string queryUpdateTeam = @"
    UPDATE TblTeam
    SET teamName = @teamName, 
        community = @community, 
        categoryId = @categoryId, 
        teamAdvisor = @teamAdvisor,
        teamCaptainId = @teamCaptainId
    WHERE teamId = @teamId";
                SqlParameter[] updateTeamParams = new SqlParameter[] {
            new SqlParameter("@teamName", teamName),
            new SqlParameter("@community", community),
            new SqlParameter("@categoryId", categoryId),
            new SqlParameter("@teamAdvisor", teamAdvisor),
            new SqlParameter("@teamCaptainId", teamCaptainId),
            new SqlParameter("@teamId", selectedTeamId)
        };
                Con.SetData(queryUpdateTeam, updateTeamParams);

                // Kaptanı takım üyesi olarak güncelleme
                string queryDeleteCaptainAsMember = "DELETE FROM TblTeamMember WHERE teamId = @teamId AND studentId = @studentId";
                SqlParameter[] deleteCaptainParams = new SqlParameter[] {
            new SqlParameter("@teamId", selectedTeamId),
            new SqlParameter("@studentId", teamCaptainId)
        };
                Con.SetData(queryDeleteCaptainAsMember, deleteCaptainParams);

                // Kaptanı tekrar ekleme
                string queryInsertCaptainAsMember = "INSERT INTO TblTeamMember (teamId, studentId) VALUES (@teamId, @studentId)";
                SqlParameter[] insertCaptainParams = new SqlParameter[] {
            new SqlParameter("@teamId", selectedTeamId),
            new SqlParameter("@studentId", teamCaptainId)
        };
                Con.SetData(queryInsertCaptainAsMember, insertCaptainParams);

                ShowTeams();
                MessageBox.Show("Takım Güncellendi ve Kaptan Üye Olarak Güncellendi!!!");
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Silme Metodu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTeamsInfo.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir takım seçin.");
                    return;
                }

                int selectedTeamId = Convert.ToInt32(dgvTeamsInfo.SelectedRows[0].Cells["ID"].Value);

                // Takım üyelerini silme
                string queryDeleteMembers = "DELETE FROM TblTeamMember WHERE teamId = @teamId";
                SqlParameter[] deleteMembersParams = new SqlParameter[] { new SqlParameter("@teamId", selectedTeamId) };
                Con.SetData(queryDeleteMembers, deleteMembersParams);

                // Takımı silme
                string queryDeleteTeam = "DELETE FROM TblTeam WHERE teamId = @teamId";
                SqlParameter[] deleteTeamParams = new SqlParameter[] { new SqlParameter("@teamId", selectedTeamId) };
                Con.SetData(queryDeleteTeam, deleteTeamParams);

                ShowTeams();
                MessageBox.Show("Takım Silindi ve Üyeleri de Silindi!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Pdf Oluşturma
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
            if (userPermissions.Contains("Team"))
            {
                StockMenu stockMenu = new StockMenu(userPermissions);
                stockMenu.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("TeamInfo"))
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
            if (userPermissions.Contains("Team"))
            {
                ReportMenu reportMenu = new ReportMenu(userPermissions);
                reportMenu.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("TeamInfo"))
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
            ShowTeams();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
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
