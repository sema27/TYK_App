using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TYK_App
{
    public partial class StudentInfo : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public StudentInfo(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowStudents();
        }

        //Öğrenci Bilgilerini Gösterme
        private void ShowStudents()
        {
            string query = "SELECT s.studentId AS 'Öğrenci ID', s.studentName AS 'Ad Soyad', s.studentNumber AS 'Öğrenci Numarası', s.studentTC AS TC, " +
                           "s.studentPhone AS Telefon, s.studentMail AS 'Mail Adresi', s.studentBirthDate AS 'Doğum Tarihi', " +
                           "t.teamName AS Takım, s.studentDepartment AS Bölüm, s.studentClass AS Sınıf " +
                           "FROM TblStudent s " +
                           "LEFT JOIN TblTeam t ON s.studentTeamId = t.teamId";
            DataTable dt = Con.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvStudentInfo.DataSource = dt;
                dgvStudentInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStudentInfo.ClearSelection();

                lblTotalStudents.Text = $"Toplam Öğrenci Sayısı: {dt.Rows.Count}";
            }
            else
            {
                dgvStudentInfo.DataSource = null;
                lblTotalStudents.Text = "Toplam Öğrenci Sayısı: 0";
            }
        }

        // Filtreleme Metodu
        private void ApplyFilter(string name, string studentNumber, string tc, string phone, string email, int? teamId, string department, string className)
        {
            string query = "SELECT s.studentId AS 'ID', s.studentName AS 'Ad Soyad', s.studentNumber AS 'Öğrenci Numarası', s.studentTC AS TC, " +
                           "s.studentPhone AS Telefon, s.studentMail AS 'Mail Adresi', s.studentBirthDate AS 'Doğum Tarihi', " +
                           "t.teamName AS Takım, s.studentDepartment AS Bölüm, s.studentClass AS Sınıf " +
                           "FROM TblStudent s " +
                           "LEFT JOIN TblTeam t ON s.studentTeamId = t.teamId " +
                           "WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(name))
            {
                query += " AND LOWER(s.studentName) LIKE @name";
                parameters.Add(new SqlParameter("@name", "%" + name.ToLower() + "%"));
            }
            if (!string.IsNullOrEmpty(studentNumber))
            {
                query += " AND LOWER(s.studentNumber) LIKE @studentNumber";
                parameters.Add(new SqlParameter("@studentNumber", "%" + studentNumber.ToLower() + "%"));
            }
            if (!string.IsNullOrEmpty(tc))
            {
                query += " AND LOWER(s.studentTC) LIKE @tc";
                parameters.Add(new SqlParameter("@tc", "%" + tc.ToLower() + "%"));
            }
            if (!string.IsNullOrEmpty(phone))
            {
                query += " AND LOWER(s.studentPhone) LIKE @phone";
                parameters.Add(new SqlParameter("@phone", "%" + phone.ToLower() + "%"));
            }
            if (!string.IsNullOrEmpty(email))
            {
                query += " AND LOWER(s.studentMail) LIKE @mail";
                parameters.Add(new SqlParameter("@mail", "%" + email.ToLower() + "%"));
            }
            if (teamId.HasValue)
            {
                query += " AND s.studentTeamId = @teamId";
                parameters.Add(new SqlParameter("@teamId", teamId.Value));
            }
            if (!string.IsNullOrEmpty(department))
            {
                query += " AND LOWER(s.studentDepartment) LIKE @department";
                parameters.Add(new SqlParameter("@department", "%" + department.ToLower() + "%"));
            }
            if (!string.IsNullOrEmpty(className))
            {
                query += " AND LOWER(s.studentClass) LIKE @class";
                parameters.Add(new SqlParameter("@class", "%" + className.ToLower() + "%"));
            }

            DataTable dt = Con.GetData(query, parameters.ToArray());
            dgvStudentInfo.DataSource = dt;

            // Toplam öğrenci sayısını göster
            lblTotalStudents.Text = $"Toplam Öğrenci Sayısı: {dt.Rows.Count}";
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            FilterStudent filterForm = new FilterStudent(userPermissions);
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                string nameFilter = filterForm.SelectedName;
                string studentNumberFilter = filterForm.SelectedStudentNumber;
                string tcFilter = filterForm.SelectedTC;
                string phoneFilter = filterForm.SelectedPhone;
                string emailFilter = filterForm.SelectedEmail;
                int? teamFilter = filterForm.SelectedTeam;
                string departmentFilter = filterForm.SelectedDepartment;
                string classNameFilter = filterForm.SelectedClassName;

                ApplyFilter(nameFilter, studentNumberFilter, tcFilter, phoneFilter, emailFilter, teamFilter, departmentFilter, classNameFilter);
            }
        }

        // Butonlar ile Sayfa Yönlendirmeleri
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

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowStudents();
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

        private void pictureTeam_Click_1(object sender, EventArgs e)
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
                    Con.ExportDataGridViewToPdf(dgvStudentInfo, saveFileDialog.FileName);
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
    }
}
