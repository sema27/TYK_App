using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class FilterCalendar : Form
    {
        Functions Con;
        public string NameFilter { get; private set; }
        public string LocationFilter { get; private set; }

        private List<string> userPermissions;

        public FilterCalendar(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Filtreleme kriterlerini al
            NameFilter = txtCompetition.Text;
            LocationFilter = txtLocation.Text; 

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Report"))
            {
                Calendar calendar = new Calendar(userPermissions);
                calendar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Raporlar sayfasına erişim izniniz yok.");
            }
        }
    }
}
