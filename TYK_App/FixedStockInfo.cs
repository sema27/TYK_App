using DocumentFormat.OpenXml.Bibliography;
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
    public partial class FixedStockInfo : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public FixedStockInfo(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowFixedStocks();
        }

        // Verileri çekme ve tabloda gösterme
        private void ShowFixedStocks()
        {
            string query = "SELECT s.stockName AS 'Malzeme Adı', s.stockNo AS 'Malzeme Kodu', s.stockFeature AS 'Özellikler', s.stockArea AS 'Bulunduğu Yer', s.stockNumber AS Adet FROM TblFixedStock s";
            DataTable dt = Con.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvFixedStocksInfo.DataSource = dt;
                dgvFixedStocksInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvFixedStocksInfo.ClearSelection();

                lblFixedStock.Text = $"Toplam Malzeme Sayısı: {dt.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Veri bulunamadı.");
                lblFixedStock.Text = $"Toplam Malzeme Sayısı: 0";
            }
        }

        // Filtreleme Metodu
        private void ApplyFilter(string nameFilter, string stockNoFilter, string stockFeatureFilter, string stockAreaFilter, int? stockNumber)
        {
            string query = "SELECT s.stockName AS 'Malzeme Adı', s.stockNo AS 'Malzeme Kodu', s.stockFeature AS 'Özellikler', s.stockArea AS 'Bulunduğu Yer', s.stockNumber AS Adet FROM TblFixedStock s WHERE 1=1";

            if (!string.IsNullOrEmpty(nameFilter)) query += $" AND s.stockName LIKE '%{nameFilter.ToLower()}%'";
            if (!string.IsNullOrEmpty(stockNoFilter)) query += $" AND s.stockNo LIKE '%{stockNoFilter.ToLower()}%'";
            if (!string.IsNullOrEmpty(stockFeatureFilter)) query += $" AND s.stockFeature LIKE '%{stockFeatureFilter.ToLower()}%'";
            if (!string.IsNullOrEmpty(stockAreaFilter)) query += $" AND s.stockArea LIKE '%{stockAreaFilter.ToLower()}%'";
            if (stockNumber.HasValue) query += $" AND s.stockNumber = {stockNumber.Value}";

            DataTable dt = Con.GetData(query);
            dgvFixedStocksInfo.DataSource = dt;
            lblFixedStock.Text = $"Toplam Malzeme Sayısı: {dt.Rows.Count}";
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterFixedStock filterForm = new FilterFixedStock(userPermissions);
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                string nameFilter = filterForm.SelectedName;
                string stockNoFilter = filterForm.SelectedStockNo;
                string stockFeatureFilter = filterForm.SelectedStockFeature;
                string stockAreaFilter = filterForm.SelectedStockArea;
                int? stockNumber = filterForm.SelectedStockNumber;

                ApplyFilter(nameFilter, stockNoFilter, stockFeatureFilter, stockAreaFilter, stockNumber);
            }
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowFixedStocks();
        }

        // Butonlar ile Sayfa Yönlendirmeleri
        private void pictureBack_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                StockMenu stock = new StockMenu(userPermissions);
                stock.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockMenuInfo stock = new StockMenuInfo(userPermissions);
                stock.Show();
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
                StockMenu stock = new StockMenu(userPermissions);
                stock.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockMenuInfo stock = new StockMenuInfo(userPermissions);
                stock.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
        }

        private void pictureTeam_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Team"))
            {
                Teams team = new Teams(userPermissions);
                team.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("TeamInfo"))
            {
                TeamInfo team = new TeamInfo(userPermissions);
                team.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Takımlar sayfasına erişim izniniz yok.");
            }
        }

        private void pictureStudent_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Student"))
            {
                Students teamsForm = new Students(userPermissions);
                teamsForm.Show();
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

        private void pictureStock_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Stock"))
            {
                StockMenu stock = new StockMenu(userPermissions);
                stock.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("StockInfo"))
            {
                StockMenuInfo stock = new StockMenuInfo(userPermissions);
                stock.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Malzemeler sayfasına erişim izniniz yok.");
            }
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("User"))
            {
                Users user = new Users(userPermissions);
                user.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("UserInfo"))
            {
                UserInfo user = new UserInfo(userPermissions);
                user.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcılar sayfasına erişim izniniz yok.");
            }
        }

        private void pictureReport_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Report"))
            {
                ReportTracing report = new ReportTracing(userPermissions);
                report.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("ReportInfo"))
            {
                ReportMenuInfo report = new ReportMenuInfo(userPermissions);
                report.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Raporlar sayfasına erişim izniniz yok.");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF dosyası|*.pdf";
                saveFileDialog.Title = "PDF olarak kaydet";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    Con.ExportDataGridViewToPdf(dgvFixedStocksInfo, saveFileDialog.FileName);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureCategory_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Category"))
            {
                Categories category = new Categories(userPermissions);
                category.Show();
                this.Hide();
            }
            else if (userPermissions.Contains("CategoryInfo"))
            {
                CategoryInfo category = new CategoryInfo(userPermissions);
                category.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kategoriler sayfasına erişim izniniz yok.");
            }
        }
    }
}
