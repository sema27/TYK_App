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
    public partial class FilterStock : Form
    {
        Functions Con;
        public string SelectedName { get; private set; }
        public int SelectedStockNumber { get; private set; }
        public string SelectedStockArea { get; private set; }

        private List<string> userPermissions;
        public FilterStock(List<string> permissions)
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
                string query = "SELECT stockAreaId, stockArea FROM TblStockArea";
                DataTable dt = Con.GetData(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboStockArea.DataSource = dt;
                    cboStockArea.DisplayMember = "stockArea";
                    cboStockArea.ValueMember = "stockAreaId";
                    cboStockArea.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Stok alanları yüklenirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SelectedName = txtStockName.Text;
            int.TryParse(txtStockNumber.Text, out int number);
            SelectedStockNumber = number;
            SelectedStockArea = cboStockArea.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBack_Click(object sender, EventArgs e)
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

        private void labelBack_Click(object sender, EventArgs e)
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
    }
}
