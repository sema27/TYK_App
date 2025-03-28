using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TYK_App
{
    public partial class FilterFixedStock : Form
    {
        Functions Con;
        public string SelectedName { get; private set; }
        public string SelectedSerialNo { get; private set; }
        public string SelectedStockNo { get; private set; }
        public string SelectedStockFeature { get; private set; }
        public string SelectedStockArea { get; private set; }
        public int? SelectedStockNumber { get; private set; }

        private List<string> userPermissions;
        public FilterFixedStock(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            LoadStockAreas();
        }
        private void LoadStockAreas()
        {
			try
			{
				string query = "SELECT stockArea FROM TblStockArea";
				DataTable dt = Con.GetData(query);

				cboStockArea.DisplayMember = "stockArea";
				cboStockArea.ValueMember = "stockAreaId";
				cboStockArea.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
        private void btnFilter_Click(object sender, EventArgs e)
        {
            SelectedName = txtStockName.Text;
			SelectedSerialNo = txtSerialNo.Text;
            SelectedStockNo = txtStockNo.Text;
            SelectedStockFeature = txtStockFeature.Text;
            SelectedStockArea = cboStockArea.Text;
            int stockNumber;
            if (int.TryParse(txtStockNumber.Text, out stockNumber))
            {
                SelectedStockNumber = stockNumber;
            }
            else
            {
                SelectedStockNumber = null;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void pictureBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                FixedStocks stock = new FixedStocks(userPermissions);
                stock.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                FixedStockInfo stock = new FixedStockInfo(userPermissions);
                stock.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Malzemler sayfasına erişim izniniz yok.");
            }
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                FixedStocks stock = new FixedStocks(userPermissions);
                stock.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                FixedStockInfo stock = new FixedStockInfo(userPermissions);
                stock.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Malzemler sayfasına erişim izniniz yok.");
            }
        }
    }
}
