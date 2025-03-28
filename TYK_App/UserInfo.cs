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
    public partial class UserInfo : Form
    {
        private Functions Con;
        private List<string> userPermissions;
        public UserInfo(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            LoadUserInfo();
        }

        // Kullanıcı adı ve şifre bilgisini ilgili alanlara çekme
        private void LoadUserInfo()
        {
            txtUsername.Text = Functions.Username;
            txtPassword.Text = Functions.Password;
        }

        // Güncelleme Metodu
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text;
            string newPassword = txtPassword.Text;

            if (Functions.Username != newUsername || Functions.Password != newPassword)
            {
                if (Con.UpdateUserInfo(Functions.Username, newUsername, newPassword))
                {
                    Functions.Username = newUsername;
                    Functions.Password = newPassword;
                    MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı bilgileri güncellenemedi.");
                }
            }
            else
            {
                MessageBox.Show("Değişiklik yapılmadı.");
            }
        }

        // BUtonlar ile Sayfa Yönlendirmeleri
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
