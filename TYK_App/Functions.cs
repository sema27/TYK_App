using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data;
using System.Data.SqlClient;
using Font = iTextSharp.text.Font;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using System.Transactions;

namespace TYK_App
{
    public class Functions
    {
        private SqlConnection Con;
        private string ConStr;
        private static string _username;
        private static string _password;
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Functions()
        {
            ConStr = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            Con = new SqlConnection(ConStr);
        }

        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool UpdateUserInfo(string oldUsername, string newUsername, string newPassword)
        {
            string query = "UPDATE TblUser SET userName = @newUsername, password = @newPassword WHERE userName = @oldUsername";
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@newUsername", newUsername);
                command.Parameters.AddWithValue("@newPassword", newPassword);
                command.Parameters.AddWithValue("@oldUsername", oldUsername);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı güncelleme hatası: " + ex.Message);
                    return false;
                }
            }
        }

        public SqlTransaction BeginTransaction()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            transaction = Con.BeginTransaction();
            return transaction;
        }

        // Transaction ile birlikte SQL sorgusu çalıştırır ve yeni eklenen kimliği döndürür
        public object SetDataWithTransaction(string query, SqlParameter[] parameters, SqlTransaction transaction)
        {
            using (SqlCommand cmd = new SqlCommand(query, Con, transaction))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                // SCOPE_IDENTITY() gibi bir değer döndürüyorsa ExecuteScalar() kullanın
                return cmd.ExecuteScalar(); // Kimlik değeri (ID) veya SELECT sorgusundan ilk satırı döndürür
            }
        }


        // Transaction'ı başarılı bir şekilde tamamlar (commit)
        public void CommitTransaction(SqlTransaction transaction)
        {
            try
            {
                transaction?.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction commit hatası: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        // Transaction'ı geri alır (rollback)
        public void RollbackTransaction(SqlTransaction transaction)
        {
            try
            {
                transaction?.Rollback();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction rollback hatası: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        public DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public int SetData(string query, SqlParameter[] parameters = null)
        {
            int cnt = 0;
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    cnt = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
            return cnt;
        }
        public object GetScalar(string query, params SqlParameter[] parameters)
        {
            object result = null;

            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);

                    connection.Open();
                    result = command.ExecuteScalar();
                }
            }

            return result;
        }

        public object GetSingleValue(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public bool IsStudentExists(string studentTC, out string studentName)
        {
            string query = "SELECT StudentName FROM TblStudent WHERE StudentTC = @StudentTC";
            SqlParameter[] parameters = { new SqlParameter("@StudentTC", studentTC) };
            studentName = null;

            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddRange(parameters);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        studentName = result.ToString();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Hata mesajı göster
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close(); // Bağlantıyı kapat
                }
            }

            return false; // Öğrenci yok
        }

        public bool IsRegistrationNoExists(string stockNo, out string stockName)
        {
            string query = "SELECT stockName FROM TblFixedStock WHERE registrationNo = @registrationNo";
            SqlParameter[] parameters = { new SqlParameter("@registrationNo", stockNo) };
            stockName = null;

            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddRange(parameters);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        stockName = result.ToString();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Hata mesajı göster
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close(); // Bağlantıyı kapat
                }
            }

            return false; // Öğrenci yok
        }
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Hata mesajı göster
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close(); // Bağlantıyı kapat
                }
            }

            return dt;
        }

        public void ExportDataGridViewToPdf(DataGridView dgv, string filePath)
        {
            try
            {
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("Tablo boş.");
                    return;
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                using (Document doc = new Document(PageSize.A4.Rotate()))
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                {
                    doc.Open();

                    // Türkçe karakterleri destekleyen bir font ekleyin
                    string arialTtf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                    BaseFont bf = BaseFont.CreateFont(arialTtf, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    Font font = new Font(bf, 10, Font.NORMAL);

                    PdfPTable table = new PdfPTable(dgv.Columns.Count);

                    // Sütun genişliklerini içerik uzunluğuna göre dinamik olarak ayarla
                    float[] columnWidths = new float[dgv.Columns.Count];
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        float maxWidth = dgv.Columns[i].HeaderText.Length;
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string cellValue = row.Cells[i].Value?.ToString() ?? string.Empty;
                                if (cellValue.Length > maxWidth)
                                {
                                    maxWidth = cellValue.Length;
                                }
                            }
                        }
                        columnWidths[i] = maxWidth + 5f; // Biraz boşluk ekleme
                    }
                    table.SetWidths(columnWidths);

                    // Başlıkları ekleme
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                        cell.HorizontalAlignment = Element.ALIGN_LEFT;
                        table.AddCell(cell);
                    }

                    // Satırları ekle
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? string.Empty, font));
                                pdfCell.HorizontalAlignment = Element.ALIGN_LEFT;
                                table.AddCell(pdfCell);
                            }
                        }
                    }

                    doc.Add(table);
                    doc.Close();
                }

                MessageBox.Show("PDF başarıyla oluşturuldu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PDF oluşturulurken hata oluştu: {ex.Message}");
            }
        }
    }
}

