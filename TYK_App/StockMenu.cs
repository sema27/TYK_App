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
    public partial class StockMenu : Form
    {
        private List<string> userPermissions;
        public StockMenu(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
        }

        private void btnStock1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Raporlar sayfasına erişim izniniz yok.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                Stocks stock = new Stocks(userPermissions);
                stock.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockInfo stock = new StockInfo(userPermissions);
                stock.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Raporlar sayfasına erişim izniniz yok.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                MessageBox.Show("Raporlar sayfasına erişim izniniz yok.");
            }
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                Students student = new Students(userPermissions);
                student.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
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

        private void labelBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Student"))
            {
                Students student = new Students(userPermissions);
                student.Show();
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
