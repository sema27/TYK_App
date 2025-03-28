using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class Login : Form
    {
        private string selectedRole = "";
        Functions Con;
        public static List<string> UserPermissions { get; private set; }

        public Login()
        {
            InitializeComponent();
            Con = new Functions();
            btnLogin.Click += new EventHandler(btnLogin_Click);
            txtPassword.UseSystemPasswordChar = true;

            btnYetkiliPersonel.Click += (s, e) => SetRole("yetkili personel", "Yetkili Personel");
            btnPersonel.Click += (s, e) => SetRole("personel", "     Personel");
            btnYonetici.Click += (s, e) => SetRole("yönetici", "     Yönetici");

            // Set a default role on form load
            this.Load += (s, e) => SetRole("yetkili personel", "Yetkili Personel");

            // Enter tuşuna basıldığında da giriş yapılmasını sağla
            this.KeyDown += new KeyEventHandler(Login_KeyDown);
            txtPassword.KeyDown += new KeyEventHandler(Login_KeyDown);  // Parola alanında da enter ile giriş yapılabilir
            txtName.KeyDown += new KeyEventHandler(Login_KeyDown);      // Kullanıcı adı alanında da enter ile giriş yapılabilir
        }

        // Kullanıcı rolünü ve giriş sayfasındaki labelı ayarlayan metod
        private void SetRole(string role, string labelText)
        {
            selectedRole = role;
            lblRole.Text = labelText;
        }

        // Enter tuşuna basılınca giriş yapılmasını sağlayan metod
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick(); // Giriş butonunu tetikle
            }
        }

        // Kullanıcının izinlerini veritabanından alan metod
        public List<string> GetUserPermissions(string username)
        {
            List<string> permissions = new List<string>();

            string query = "SELECT p.pageName FROM TblUserAuthorities ua " +
                           "JOIN TblPages p ON ua.pageId = p.pageId " +
                           "JOIN TblUser u ON ua.userId = u.userId " +
                           "WHERE u.userName = @username";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username)
            };

            DataTable dt = Con.GetData(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                permissions.Add(row["pageName"].ToString());
            }

            return permissions;
        }

        // Kullanıcı adı ve şifre doğrulaması yapan metod
        private string AuthenticateUser(string username, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            string query = "SELECT userRole FROM TblUser WHERE userName = @username AND password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        return reader["userRole"].ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
                    return null;
                }
            }
        }

        // Butonlar ile Sayfa Yönlendirmeleri
        public void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi girin.");
                return;
            }

            string role = AuthenticateUser(username, password);

            if (role == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                return;
            }

            if ((selectedRole == "yönetici" && role != "yönetici") ||
                (selectedRole == "yetkili personel" && role != "yetkili personel") ||
                (selectedRole == "personel" && role != "personel"))
            {
                MessageBox.Show($"Yalnızca {selectedRole} rolüne sahip kullanıcılar bu ekrana giriş yapabilir.", "Yetkisiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Functions.Username = username;
            Functions.Password = password;

            // Kullanıcı izinlerini alma
            UserPermissions = GetUserPermissions(username);

            if (UserPermissions.Count == 0)
            {
                MessageBox.Show("Erişim yetkiniz yok!");
                return;
            }

            OpenStudentForm(UserPermissions);
        }

        private void OpenStudentForm(List<string> permissions)
        {
            if (permissions.Contains("Student"))
            {
                Students students = new Students(permissions);
                students.Show();
                this.Hide();
            }
            else if (permissions.Contains("StudentInfo"))
            {
                StudentInfo studentInfo = new StudentInfo(permissions);
                studentInfo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Öğrenci bilgilerine erişim izniniz yok.");
                return;
            }
        }
    }
}
