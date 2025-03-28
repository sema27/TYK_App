using System;
using System.Data;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class FilterReportTracing : Form
    {
        Functions Con;
        public int? SelectedCategory { get; private set; }
        public string SelectedTeam { get; private set; }
        public string SelectedCaptain { get; private set; }
        public bool? SelectedReport { get; private set; }
        public bool? SelectedAppealed { get; private set; }
        public bool? SelectedFinalist { get; private set; }

        private List<string> userPermissions;
        public FilterReportTracing(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            LoadComboBoxOptions();
            LoadCategories();
        }

        private void LoadComboBoxOptions()
        {
            cboReportResult.Items.Add("Geçti");
            cboReportResult.Items.Add("Kaldı");

            cboAppealed.Items.Add("İtiraz Edildi");
            cboAppealed.Items.Add("İtiraz Edilmedi");

            cboFinalist.Items.Add("Finalist");
            cboFinalist.Items.Add("Finalist Değil");
        }

        private void LoadCategories()
        {
            try
            {
                string query = "SELECT categoryId, categoryName FROM TblCategory";
                DataTable dt = Con.GetData(query);

                DataRow emptyRow = dt.NewRow();
                emptyRow["categoryId"] = DBNull.Value;
                emptyRow["categoryName"] = "";
                dt.Rows.InsertAt(emptyRow, 0);

                cboCategory.DisplayMember = "categoryName";
                cboCategory.ValueMember = "categoryId";
                cboCategory.DataSource = dt;
                cboCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SelectedCategory = cboCategory.SelectedIndex != -1 ? (int?)cboCategory.SelectedValue : null;
            SelectedTeam = txtTeam.Text;
            SelectedCaptain = txtCaptain.Text;
            SelectedReport = cboReportResult.SelectedIndex != -1 ? (bool?)(cboReportResult.SelectedItem.ToString() == "Geçti") : null;
            SelectedAppealed = cboAppealed.SelectedIndex != -1 ? (bool?)(cboAppealed.SelectedItem.ToString() == "İtiraz Edildi") : null;
            SelectedFinalist = cboFinalist.SelectedIndex != -1 ? (bool?)(cboFinalist.SelectedItem.ToString() == "Finalist") : null;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Report"))
            {
                ReportTracing report = new ReportTracing(userPermissions);
                report.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("ReportInfo"))
            {
                ReportTracingInfo report = new ReportTracingInfo(userPermissions);
                report.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Raporlar sayfasına erişim izniniz yok.");
            }
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Report"))
            {
                ReportTracing report = new ReportTracing(userPermissions);
                report.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("ReportInfo"))
            {
                ReportTracingInfo report = new ReportTracingInfo(userPermissions);
                report.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Raporlar sayfasına erişim izniniz yok.");
            }
        }
    }
}
