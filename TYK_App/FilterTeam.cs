using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class FilterTeam : Form
    {
        public string SelectedTeam { get; private set; }
        public int? SelectedCategory { get; private set; }
        public string SelectedCommunity { get; private set; }
        public string SelectedAdvisor { get; private set; }
        public string SelectedCaptain { get; private set; }
        public string SelectedLogo { get; private set; }

        Functions Con;

        private List<string> userPermissions;
        public FilterTeam(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            LoadCategories();
        }

        private void LoadCategories()
        {
            string query = "SELECT categoryId, categoryName FROM TblCategory";
            DataTable dt = Con.GetData(query);

            // Kategoriler çekilirken boş seçeneği eklemek için
            DataRow emptyRow = dt.NewRow();
            emptyRow["categoryId"] = DBNull.Value;
            emptyRow["categoryName"] = "";
            dt.Rows.InsertAt(emptyRow, 0);

            // Combo box'a kategorileri yükleme
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "categoryName";
            cboCategory.ValueMember = "categoryId";

            // Combo box'un varsayılan seçeneğini boş olarak ayarlama
            cboCategory.SelectedIndex = -1;
        }
        private void pictureBack_Click_1(object sender, EventArgs e)
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

        private void labelBack_Click_1(object sender, EventArgs e)
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

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            try
            {
                SelectedTeam = txtTeamName.Text;
                SelectedCategory = cboCategory.SelectedValue as int?;
                SelectedCommunity = txtCommunity.Text;
                SelectedAdvisor = txtTeamAdvisor.Text;
                SelectedLogo = txtLogoPath.Text;
                SelectedCaptain = txtTeamCaptain.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
