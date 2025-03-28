using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class FilterStockTracing : Form
    {
        Functions Con;
        public string SelectedName { get; private set; }
        public DateTime? SelectedIssuedDate { get; private set; }
        public DateTime? SelectedReturnedDate { get; private set; }
        public string SelectedStockArea { get; private set; }
        public string SelectedStudentName { get; private set; }
        public string SelectedStudentNumber { get; private set; }

        private List<string> userPermissions;
        public FilterStockTracing(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            LoadStockAreas();

            // Tarih alanlarını varsayılan olarak boş yap
            dtpIssuedDate.Format = DateTimePickerFormat.Custom;
            dtpIssuedDate.CustomFormat = " ";
            dtpReturnedDate.Format = DateTimePickerFormat.Custom;
            dtpReturnedDate.CustomFormat = " ";
        }

        private void LoadStockAreas()
        {
            string[] locations = { "Dolap 1", "Dolap 2", "Dolap 3", "Dolap 4", "Dolap 5", "Dolap 6", "Dolap 7", "Dolap 8", "Dolap 9", "Dolap 10", "Dolap 11", "Dolap 12",
            "Dolap 13", "Dolap 14", "Dolap 15", "Dolap 16","Dolap 17", "Dolap 18", "Tezgah"};
            cboStockArea.Items.AddRange(locations);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SelectedName = txtStockName.Text;
            SelectedStockArea = cboStockArea.Text;
            SelectedStudentName = txtStudentName.Text;
            SelectedStudentNumber = txtStudentNumber.Text;

            // Tarih alanlarını kontrol et ve değerlerini ayarla
            SelectedIssuedDate = dtpIssuedDate.CustomFormat == " " ? (DateTime?)null : dtpIssuedDate.Value;
            SelectedReturnedDate = dtpReturnedDate.CustomFormat == " " ? (DateTime?)null : dtpReturnedDate.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                StockTracing stock = new StockTracing(userPermissions);
                stock.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockTracingInfo stock = new StockTracingInfo(userPermissions);
                stock.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
        }
    }
}
