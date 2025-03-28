using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TYK_App
{
    public partial class StockInfo : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public StockInfo(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowStocks();
        }

        // Verileri çekme ve tabloda gösterme
        private void ShowStocks()
        {
            string query = "SELECT s.stockId, s.stockName AS 'Malzeme Adı', s.stockNumber AS Adet, sa.stockArea AS 'Bulunduğu Yer' " +
                           "FROM TblStock s " +
                           "JOIN TblStockArea sa ON s.stockAreaId = sa.stockAreaId";
            DataTable dt = Con.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvStocksInfo.DataSource = dt;
                dgvStocksInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStocksInfo.ClearSelection();

                lblStock.Text = $"Toplam Malzeme Sayısı: {dt.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Veri bulunamadı.");
                lblStock.Text = $"Toplam Malzeme Sayısı: 0";
            }
        }

        // Filtreleme Metodu
        private void ApplyFilter(string nameFilter, int stockNumberFilter, string stockAreaFilter)
        {
            string query = "SELECT s.stockId, s.stockName AS 'Malzeme Adı', s.stockNumber AS 'Adet', s.stockArea AS 'Bulunduğu Yer' FROM TblStock s WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(nameFilter))
            {
                query += " AND LOWER(s.stockName) LIKE @nameFilter";
                parameters.Add(new SqlParameter("@nameFilter", "%" + nameFilter.ToLower() + "%"));
            }

            if (stockNumberFilter > 0)
            {
                query += " AND s.stockNumber = @stockNumberFilter";
                parameters.Add(new SqlParameter("@stockNumberFilter", stockNumberFilter));
            }

            if (!string.IsNullOrEmpty(stockAreaFilter))
            {
                query += " AND LOWER(s.stockArea) LIKE @stockAreaFilter";
                parameters.Add(new SqlParameter("@stockAreaFilter", "%" + stockAreaFilter.ToLower() + "%"));
            }

            DataTable dt = Con.GetData(query, parameters.ToArray());
            dgvStocksInfo.DataSource = dt;
            lblStock.Text = $"Toplam Malzeme Sayısı: {dt.Rows.Count}";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterStock filterForm = new FilterStock(userPermissions);
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                string nameFilter = filterForm.SelectedName;
                int number = filterForm.SelectedStockNumber;
                string stockAreaFilter = filterForm.SelectedStockArea;

                ApplyFilter(nameFilter, number, stockAreaFilter);
            }
        }


        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowStocks();
        }

        // Butonlar ile Sayfa Yönlendirmeleri
        private void pictureStock_Click_1(object sender, EventArgs e)
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

        private void pictureStudent_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Student"))
            {
                Students students = new Students(userPermissions);
                students.Show();
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

        private void pictureTeam_Click(object sender, EventArgs e)
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

        private void pictureReport_Click(object sender, EventArgs e)
        {
            if (userPermissions.Contains("Report"))
            {
                ReportMenu reportMenu = new ReportMenu(userPermissions);
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

        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    Con.ExportDataGridViewToPdf(dgvStocksInfo, saveFileDialog.FileName);
                }
            }
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

        private void pictureUser_Click(object sender, EventArgs e)
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
    }
}
