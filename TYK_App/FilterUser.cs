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
    public partial class FilterUser : Form
    {
        Functions Con;
        public string SelectedRole { get; private set; }
        public string SelectedUsername { get; private set; }
        private List<string> userPermissions;
        public FilterUser(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            LoadUserRole();
        }

        private void LoadUserRole()
        {
            try
            {
                string query = "SELECT DISTINCT userRole FROM TblUser";
                DataTable dt = Con.GetData(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboUserRole.DataSource = dt;
                    cboUserRole.DisplayMember = "userRole";
                    cboUserRole.ValueMember = "userRole";
                    cboUserRole.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Kullanıcı rollerini yüklerken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            SelectedUsername = txtUsername.Text;
            SelectedRole = cboUserRole.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("User"))
            {
                Users user = new Users(userPermissions);
                user.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcılar sayfasına erişim izniniz yok.");
            }
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("User"))
            {
                Users user = new Users(userPermissions);
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
