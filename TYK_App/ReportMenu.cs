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
    public partial class ReportMenu : Form
    {
        private List<string> userPermissions;
        public ReportMenu(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
        }

        private void btnFinalistReport_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Report"))
            {
                ReportTracing reportMenu = new ReportTracing(userPermissions);
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

        private void btnStudentTeamReport_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Report"))
            {
                StatisticsReport reportMenu = new StatisticsReport(userPermissions);
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

        private void pictureBack_Click(object sender, EventArgs e)
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

        private void labelBack_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Report"))
            {
                Calendar calendar = new Calendar(userPermissions);
                calendar.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("ReportInfo"))
            {
                CalendarInfo calendar = new CalendarInfo(userPermissions);
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
