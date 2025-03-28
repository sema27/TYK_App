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
    public partial class StockMenuInfo : Form
    {
        private List<string> userPermissions;
        public StockMenuInfo(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
        }

        private void btnStock1_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                FixedStocks stockMenu = new FixedStocks(userPermissions);
                stockMenu.Show();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                FixedStockInfo stockMenu = new FixedStockInfo(userPermissions);
                stockMenu.Show();
            }
            else
            {
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
            this.Hide();
        }

        private void btnStock2_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                Stocks stock = new Stocks(userPermissions);
                stock.Show();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockInfo stock = new StockInfo(userPermissions);
                stock.Show();
            }
            else
            {
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                StockTracing stock = new StockTracing(userPermissions);
                stock.Show();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockTracingInfo stock = new StockTracingInfo(userPermissions);
                stock.Show();
            }
            else
            {
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
            this.Hide();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Student"))
            {
                Students teamsForm = new Students(userPermissions);
                teamsForm.Show();
            }
            else if (userPermissions.Contains("StudentInfo"))
            {
                StudentInfo student = new StudentInfo(userPermissions);
                student.Show();
            }
            else
            {
                MessageBox.Show("Öğrenciler sayfasına erişim izniniz yok.");
            }
            this.Hide();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Student"))
            {
                Students teamsForm = new Students(userPermissions);
                teamsForm.Show();
            }
            else if (userPermissions.Contains("StudentInfo"))
            {
                StudentInfo student = new StudentInfo(userPermissions);
                student.Show();
            }
            else
            {
                MessageBox.Show("Öğrenciler sayfasına erişim izniniz yok.");
            }
            this.Hide();
        }
    }
}
