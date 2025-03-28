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
    public partial class FilterStudent : Form
    {
        public string SelectedName { get; private set; }
        public string SelectedStudentNumber { get; private set; }
        public string SelectedTC { get; private set; }
        public string SelectedPhone { get; private set; }
        public string SelectedEmail { get; private set; }
        public int? SelectedTeam { get; private set; }
        public string SelectedDepartment { get; private set; }
        public string SelectedClassName { get; private set; }

        Functions Con;

        private List<string> userPermissions;
        public FilterStudent(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            LoadTeams();
        }

        private void LoadTeams()
        {
            string Query = "SELECT teamId, teamName FROM TblTeam";
            DataTable dt = Con.GetData(Query);

            // Takımlar çekilirken boş seçeneği eklemek için
            DataRow emptyRow = dt.NewRow();
            emptyRow["teamId"] = DBNull.Value;
            emptyRow["teamName"] = "";
            dt.Rows.InsertAt(emptyRow, 0);

            // Combo box'a takımları yükleme
            cbTeam.DataSource = dt;
            cbTeam.DisplayMember = "teamName";
            cbTeam.ValueMember = "teamId";

            // Combo box'un varsayılan seçeneğini boş olarak ayarlama
            cbTeam.SelectedIndex = -1;
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            SelectedName = txtName.Text;
            SelectedStudentNumber = txtStudentNumber.Text;
            SelectedTC = txtTC.Text;
            SelectedPhone = txtPhone.Text;
            SelectedEmail = txtMail.Text;
            SelectedDepartment = txtDepartment.Text;
            SelectedClassName = txtClass.Text;

            // Takım seçilmişse SelectedValue'dan takımId al, değilse null bırak
            if (cbTeam.SelectedValue != null && int.TryParse(cbTeam.SelectedValue.ToString(), out int teamId))
            {
                SelectedTeam = teamId;
            }
            else
            {
                SelectedTeam = null;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void labelBack_Click(object sender, EventArgs e)
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

        private void pictureBack_Click(object sender, EventArgs e)
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
    }
}
