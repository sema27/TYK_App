using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;

namespace TYK_App
{
    public partial class StatisticsReport : Form
    {
        Functions Con;

        private List<string> userPermissions;
        public StatisticsReport(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            LoadComboBox();
            UpdateChart("Bölüm İstatistikleri");
        }

        // Combobox verilerinin yüklenmesi
        private void LoadComboBox()
        {
            cbReport.Items.Add("Bölüm İstatistikleri");
            cbReport.Items.Add("Sınıf İstatistikleri");
            cbReport.Items.Add("Kategori İstatistikleri");
            cbReport.SelectedIndexChanged += new EventHandler(cbReport_SelectedIndexChanged);
            cbReport.SelectedIndex = 0;
        }

        // Combobox değişikliğine göre grafiğin güncellenmesi
        private void cbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cbReport.SelectedItem.ToString();
            UpdateChart(selectedOption);
        }

        // Grafik güncelleme
        private void UpdateChart(string selectedOption)
        {
            string query = "";
            string xValueMember = "";
            string yValueMembers = "StudentCount";
            string chartTitle = "";

            if (selectedOption == "Bölüm İstatistikleri")
            {
                query = "SELECT studentDepartment AS Category, COUNT(*) AS StudentCount FROM TblStudent GROUP BY studentDepartment";
                xValueMember = "Category";
                chartTitle = "Bölüm İstatistikleri";
            }
            else if (selectedOption == "Sınıf İstatistikleri")
            {
                query = "SELECT studentClass AS Category, COUNT(*) AS StudentCount FROM TblStudent GROUP BY studentClass";
                xValueMember = "Category";
                chartTitle = "Sınıf İstatistikleri";
            }
            else if (selectedOption == "Kategori İstatistikleri")
            {
                query = "SELECT c.categoryName AS Category, COUNT(*) AS StudentCount " +
                        "FROM TblTeam t INNER JOIN TblCategory c ON t.categoryId = c.categoryId GROUP BY c.categoryName;";
                xValueMember = "Category";
                chartTitle = "Kategori İstatistikleri";
            }

            DataTable dt = Con.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                chart1.Series.Clear();
                Series series = new Series("Series1")
                {
                    XValueMember = xValueMember,
                    YValueMembers = yValueMembers,
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true // Dilimlerin üzerinde değerlerin gösterilmesi için
                };

                chart1.Series.Add(series);
                chart1.DataSource = dt;
                chart1.DataBind();

                // Dilimlerin üzerindeki etiketleri kısalt
                foreach (var point in series.Points)
                {
                    string label = point.AxisLabel;
                    // Dilimlerin üzerindeki yazılar kısaltılmış olacak
                    point.Label = label.Length > 5 ? label.Substring(0, 5) + "..." : label;
                }

                // Legend (yan taraftaki renklerin yanında açıklamalar) etiketleri olduğu gibi kalsın
                series.LegendText = "#VALX (#VALY) - #PERCENT{P0}";

                chart1.Titles.Clear();
                Title title = chart1.Titles.Add(chartTitle);
                title.Font = new Font("Arial", 16, FontStyle.Bold);
            }
            else
            {
                MessageBox.Show("Seçilen kriter için veri bulunamadı.");
                chart1.Series.Clear();
                chart1.Titles.Clear();
            }
        }

        // Butonlar ile Sayfa Yönlendirmeleri
        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void pictureStock_Click(object sender, EventArgs e)
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

        private void pictureBack_Click(object sender, EventArgs e)
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

        private void labelBack_Click(object sender, EventArgs e)
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

        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Grafiği PDF Olarak Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                {
                    PdfWriter writer = new PdfWriter(fs);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    // Chart'ı resim olarak kaydediyoruz
                    MemoryStream ms = new MemoryStream();
                    chart1.SaveImage(ms, ChartImageFormat.Png);
                    ms.Seek(0, SeekOrigin.Begin);

                    ImageData imageData = ImageDataFactory.Create(ms.ToArray());
                    iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(imageData);
                    document.Add(pdfImage);

                    document.Close();
                    MessageBox.Show("Grafik başarıyla PDF olarak kaydedildi.");
                }
            }
        }
    }
}
