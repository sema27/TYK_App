using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using System.Net.Mail;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;

namespace TYK_App
{
    public partial class Students : Form
    {
        Functions Con;
        private List<string> userPermissions;
        public Students(List<string> permissions)
        {
            InitializeComponent();
            userPermissions = permissions;
            Con = new Functions();
            ShowStudents();
            LoadTeams();
            dgvStudentInfo.SelectionChanged += new EventHandler(dgvStudentInfo_SelectionChanged);
            dgvStudentInfo.MouseClick += new MouseEventHandler(dgvStudentInfo_MouseClick);
            dgvStudentInfo.CellEnter += new DataGridViewCellEventHandler(dgvStudentInfo_CellEnter);
        }

        // Takımları Yükleme
        private void LoadTeams()
        {
            string query = "SELECT teamId, teamName FROM TblTeam ORDER BY teamName ASC";
            DataTable dt = Con.GetData(query);
            clbTeams.DataSource = dt;
            clbTeams.DisplayMember = "teamName";
            clbTeams.ValueMember = "teamId";
        }


        // Öğrenci Bilgilerini Gösterme
        private void ShowStudents()
        {
            string query = @"
    SELECT 
        s.studentId AS 'Öğrenci ID',
        s.studentName AS 'Ad Soyad', 
        s.studentNumber AS 'Öğrenci Numarası', 
        s.studentTC AS TC, 
        s.studentPhone AS Telefon, 
        s.studentMail AS 'Mail Adresi', 
        s.studentBirthDate AS 'Doğum Tarihi', 
        STRING_AGG(t.teamName, ', ') AS Takım, 
        s.studentDepartment AS Bölüm, 
        s.studentClass AS Sınıf 
    FROM 
        TblStudent s 
    LEFT JOIN 
        TblTeamMember tm ON s.studentId = tm.studentId
    LEFT JOIN 
        TblTeam t ON tm.teamId = t.teamId
    GROUP BY 
        s.studentId, s.studentName, s.studentNumber, s.studentTC, s.studentPhone, 
        s.studentMail, s.studentBirthDate, s.studentDepartment, s.studentClass;
    ";

            DataTable dt = Con.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvStudentInfo.DataSource = dt;
                dgvStudentInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStudentInfo.ClearSelection();

                lblTotalStudents.Text = $"Toplam Öğrenci Sayısı: {dt.Rows.Count}";
            }
            else
            {
                dgvStudentInfo.DataSource = null;
                lblTotalStudents.Text = "Toplam Öğrenci Sayısı: 0";
            }
        }



        // Excel Verileri Çekme
        private void LoadExcelToDatabase(string excelFilePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo fileInfo = new FileInfo(excelFilePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                DataTable dt = new DataTable();

                // Sütun başlıklarını ekleme
                for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                {
                    dt.Columns.Add(worksheet.Cells[1, col].Text.Trim());
                }

                // Satırları ekleme
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    bool isEmptyRow = true;
                    DataRow newRow = dt.NewRow();

                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        var cellValue = worksheet.Cells[row, col].Value;  // Burada 'Text' yerine 'Value' kullanıyoruz
                        string stringValue = cellValue?.ToString().Trim(); // Null kontrolü yapıyoruz

                        newRow[col - 1] = stringValue;

                        if (!string.IsNullOrWhiteSpace(stringValue))
                        {
                            isEmptyRow = false;
                        }
                    }

                    if (isEmptyRow)
                    {
                        continue; // Boş satırı geç
                    }

                    dt.Rows.Add(newRow);
                }

                var teams = GetTeams(); // Takımların alındığı metot

                foreach (DataRow row in dt.Rows)
                {
                    string studentTC = CleanAndConvertToText(row["studentTC"].ToString(), 20);  // CleanAndConvertToText metoduyla düzelt
                    string studentPhone = CleanAndConvertToText(row["studentPhone"].ToString(), 20);
                    string studentNumber = CleanAndConvertToText(row["studentNumber"].ToString(), 20);
                    string teamName = row["studentTeamId"].ToString();
                    DateTime? studentBirthDate = DateTime.TryParse(row["studentBirthDate"].ToString(), out DateTime birthDate) ? (DateTime?)birthDate : null;

                    int? studentTeamId = teams.ContainsKey(teamName) ? teams[teamName] : (int?)null;

                    List<int> selectedTeamIds = studentTeamId.HasValue ? new List<int> { studentTeamId.Value } : new List<int>();

                    if (Con.IsStudentExists(studentTC, out string studentName))
                    {
                        continue; // Mevcut öğrenci varsa ekleme işlemi durdurulur
                    }

                    InsertStudent(row["studentName"].ToString(), studentNumber, studentTC, studentPhone, row["studentMail"].ToString(),
                                  studentBirthDate, row["studentDepartment"].ToString(), row["studentClass"].ToString(), selectedTeamIds);
                }
            }
        }

        // Metin olarak gelen hücre değerlerini düzgün işlemek için yardımcı metot
        private string CleanAndConvertToText(string value, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return null; // Boş veri varsa null olarak döndür
            }

            // Eğer değer bilimsel gösterimdeyse bunu sayısal formata çevirelim
            if (decimal.TryParse(value, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out decimal result))
            {
                return result.ToString(); // Sayısal ise düz string haline çevir
            }

            // Son olarak maksimum uzunluğu kesip döndürüyoruz
            return value.Length > maxLength ? value.Substring(0, maxLength) : value;
        }


        private string ProcessCellValue(object cellValue, int maxLength)
        {
            if (cellValue == null)
            {
                return null;
            }

            string value = cellValue.ToString().Trim();

            return value.Length > maxLength ? value.Substring(0, maxLength) : value;
        }


        private void InsertStudent(string name, string studentNumber, string studentTC, string studentPhone, string email,
                           DateTime? birthDate, string department, string className, List<int> selectedTeamIds)
        {
            Functions Con = new Functions();
            SqlTransaction transaction = null;

            try
            {
                // Transaction başlat
                transaction = Con.BeginTransaction();

                // Öğrenciyi eklemek için SQL sorgusu
                string studentQuery = "INSERT INTO TblStudent (studentName, studentNumber, studentTC, studentPhone, studentMail, " +
                                      "studentBirthDate, studentDepartment, studentClass) " +
                                      "VALUES (@studentName, @studentNumber, @studentTC, @studentPhone, @studentMail, @studentBirthDate, @studentDepartment, @studentClass);" +
                                      "SELECT SCOPE_IDENTITY();"; // Eklenen öğrencinin ID'sini almak için

                SqlParameter[] studentParameters = {
            new SqlParameter("@studentName", (object)name ?? DBNull.Value),
            new SqlParameter("@studentNumber", (object)studentNumber ?? DBNull.Value),
            new SqlParameter("@studentTC", (object)studentTC ?? DBNull.Value),
            new SqlParameter("@studentPhone", (object)studentPhone ?? DBNull.Value),
            new SqlParameter("@studentMail", (object)email ?? DBNull.Value),
            new SqlParameter("@studentBirthDate", birthDate.HasValue ? (object)birthDate.Value : DBNull.Value),
            new SqlParameter("@studentDepartment", (object)department ?? DBNull.Value),
            new SqlParameter("@studentClass", (object)className ?? DBNull.Value)
        };

                // Öğrenciyi ekle ve yeni eklenen öğrencinin ID'sini al
                int newStudentId = Convert.ToInt32(Con.SetDataWithTransaction(studentQuery, studentParameters, transaction));

                // Öğrenciyi seçilen takımlara eklemek için SQL sorgusu
                if (selectedTeamIds != null && selectedTeamIds.Count > 0)
                {
                    foreach (int teamId in selectedTeamIds)
                    {
                        string teamMemberQuery = "INSERT INTO TblTeamMember (studentId, teamId) VALUES (@studentId, @teamId);";
                        SqlParameter[] teamMemberParameters = {
                    new SqlParameter("@studentId", newStudentId),
                    new SqlParameter("@teamId", teamId)
                };
                        Con.SetDataWithTransaction(teamMemberQuery, teamMemberParameters, transaction);
                    }
                }

                // İşlem başarılıysa transaction'ı tamamla
                Con.CommitTransaction(transaction);
                //MessageBox.Show("Öğrenci başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                // Hata durumunda transaction'ı geri al
                Con.RollbackTransaction(transaction);
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private Dictionary<string, int> GetTeams()
        {
            Dictionary<string, int> teams = new Dictionary<string, int>();

            try
            {
                string query = "SELECT teamId, teamName FROM TblTeam";
                DataTable dt = Con.GetData(query);

                // Veri olup olmadığını kontrol et
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        // teamName ve teamId'nin boş olup olmadığını kontrol et
                        if (row["teamName"] != DBNull.Value && row["teamId"] != DBNull.Value)
                        {
                            string teamName = row["teamName"].ToString();
                            int teamId = Convert.ToInt32(row["teamId"]);

                            // Eğer aynı isimde başka bir takım varsa duruma göre ele al
                            if (!teams.ContainsKey(teamName))
                            {
                                teams[teamName] = teamId;
                            }
                            else
                            {
                                MessageBox.Show($"Aynı isimde birden fazla takım bulundu: {teamName}. Bu takım atlanacak.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Takım bilgileri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return teams;
        }



        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidTC(string tc)
        {
            return tc.Length == 11 && long.TryParse(tc, out _);
        }

        private bool IsValidPhone(string phone)
        {
            return phone.Length >= 10 && phone.Length <= 11 && phone.All(char.IsDigit);
        }

        private void FillStudentDetails(DataGridViewRow selectedRow)
        {
            // Öğrenci bilgilerini doldur
            txtName.Text = selectedRow.Cells["Ad Soyad"].Value?.ToString() ?? string.Empty;
            txtStudentNumber.Text = selectedRow.Cells["Öğrenci Numarası"].Value?.ToString() ?? string.Empty;
            txtTC.Text = selectedRow.Cells["TC"].Value?.ToString() ?? string.Empty;
            txtPhone.Text = selectedRow.Cells["Telefon"].Value?.ToString() ?? string.Empty;
            txtMail.Text = selectedRow.Cells["Mail Adresi"].Value?.ToString() ?? string.Empty;

            if (selectedRow.Cells["Doğum Tarihi"].Value != DBNull.Value)
            {
                dtpBirthDate.Value = Convert.ToDateTime(selectedRow.Cells["Doğum Tarihi"].Value);
            }
            else
            {
                dtpBirthDate.Value = DateTime.Now;
            }

            LoadTeams();

            // Seçili takımları işaretlemeden önce tüm işaretlemeleri temizle
            for (int i = 0; i < clbTeams.Items.Count; i++)
            {
                clbTeams.SetItemChecked(i, false);
            }

            // Seçili takımları işaretle
            string teamNames = selectedRow.Cells["Takım"].Value?.ToString() ?? string.Empty;

            if (!string.IsNullOrEmpty(teamNames))
            {
                var selectedTeams = teamNames.Split(new[] { ", " }, StringSplitOptions.None);
                foreach (var team in selectedTeams)
                {
                    for (int i = 0; i < clbTeams.Items.Count; i++)
                    {
                        DataRowView row = clbTeams.Items[i] as DataRowView;

                        if (row != null && row["teamName"].ToString().Trim() == team.Trim()) // Takım isimlerini kontrol ederken boşlukları da kaldırıyoruz
                        {
                            clbTeams.SetItemChecked(i, true); // Eğer takım isimleri eşleşirse işaretliyoruz
                            break;
                        }
                    }
                }
            }

            // Diğer öğrenci bilgilerini doldur
            txtDepartment.Text = selectedRow.Cells["Bölüm"].Value?.ToString() ?? string.Empty;
            txtClass.Text = selectedRow.Cells["Sınıf"].Value?.ToString() ?? string.Empty;
        }

        private void dgvStudentInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudentInfo.SelectedRows.Count > 0)
            {
                FillStudentDetails(dgvStudentInfo.SelectedRows[0]);
            }
            else
            {
                ClearInputFields();
            }
        }

        private void dgvStudentInfo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FillStudentDetails(dgvStudentInfo.Rows[e.RowIndex]);
            }
        }

        private void dgvStudentInfo_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvStudentInfo.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
            {
                ClearInputFields();
            }
        }

        // Filtreleme Metodu
        private void ApplyFilter(string name, string studentNumber, string tc, string phone, string email, int? teamId, string department, string className)
        {
            string query = @"
    SELECT s.studentId AS 'Öğrenci ID', 
           s.studentName AS 'Ad Soyad', 
           s.studentNumber AS 'Öğrenci Numarası', 
           s.studentTC AS TC, 
           s.studentPhone AS Telefon, 
           s.studentMail AS 'Mail Adresi', 
           s.studentBirthDate AS 'Doğum Tarihi', 
           STRING_AGG(t.teamName, ', ') AS Takım,
           s.studentDepartment AS Bölüm, 
           s.studentClass AS Sınıf 
    FROM TblStudent s
    LEFT JOIN TblTeamMember tm ON s.studentId = tm.studentId  -- Ara tablo
    LEFT JOIN TblTeam t ON tm.teamId = t.teamId  -- Takımlar tablosu
    WHERE 1 = 1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(name))
            {
                query += " AND LOWER(s.studentName) LIKE @name";
                parameters.Add(new SqlParameter("@name", "%" + name.ToLower() + "%"));
            }
            if (!string.IsNullOrEmpty(studentNumber))
            {
                query += " AND LOWER(s.studentNumber) LIKE @studentNumber";
                parameters.Add(new SqlParameter("@studentNumber", "%" + studentNumber.ToLower() + "%"));
            }
            if (!string.IsNullOrEmpty(tc))
            {
                query += " AND LOWER(s.studentTC) LIKE @tc";
                parameters.Add(new SqlParameter("@tc", "%" + tc.ToLower() + "%"));
            }
            if (!string.IsNullOrEmpty(phone))
            {
                query += " AND LOWER(s.studentPhone) LIKE @phone";
                parameters.Add(new SqlParameter("@phone", "%" + phone.ToLower() + "%"));
            }
            if (!string.IsNullOrEmpty(email))
            {
                query += " AND LOWER(s.studentMail) LIKE @email"; 
                parameters.Add(new SqlParameter("@email", "%" + email.ToLower() + "%"));
            }
            if (teamId.HasValue)
            {
                query += " AND tm.teamId = @teamId";  
                parameters.Add(new SqlParameter("@teamId", teamId.Value));
            }
            if (!string.IsNullOrEmpty(department))
            {
                query += " AND LOWER(s.studentDepartment) LIKE @department";
                parameters.Add(new SqlParameter("@department", "%" + department.ToLower() + "%"));
            }
            if (!string.IsNullOrEmpty(className))
            {
                query += " AND LOWER(s.studentClass) LIKE @class";
                parameters.Add(new SqlParameter("@class", "%" + className.ToLower() + "%"));
            }

            query += " GROUP BY s.studentId, s.studentName, s.studentNumber, s.studentTC, s.studentPhone, s.studentMail, s.studentBirthDate, s.studentDepartment, s.studentClass";
            query += " ORDER BY s.studentName ASC"; 

            DataTable dt = Con.GetData(query, parameters.ToArray());
            dgvStudentInfo.DataSource = dt;

            lblTotalStudents.Text = $"Toplam Öğrenci Sayısı: {dt.Rows.Count}";
        }


        private void ClearInputFields()
        {
            txtName.Clear();
            txtStudentNumber.Clear();
            txtTC.Clear();
            txtPhone.Clear();
            txtMail.Clear();
            dtpBirthDate.Text = "";
            for (int i = 0; i < clbTeams.Items.Count; i++)
            {
                clbTeams.SetItemChecked(i, false);
            }
            txtDepartment.Clear();
            txtClass.Clear();
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            FilterStudent filterForm = new FilterStudent(userPermissions);
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                string nameFilter = filterForm.SelectedName;
                string studentNumberFilter = filterForm.SelectedStudentNumber;
                string tcFilter = filterForm.SelectedTC;
                string phoneFilter = filterForm.SelectedPhone;
                string emailFilter = filterForm.SelectedEmail;
                int? teamFilter = filterForm.SelectedTeam;
                string departmentFilter = filterForm.SelectedDepartment;
                string classNameFilter = filterForm.SelectedClassName;

                ApplyFilter(nameFilter, studentNumberFilter, tcFilter, phoneFilter, emailFilter, teamFilter, departmentFilter, classNameFilter);
            }
        }


        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xlsm;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadExcelToDatabase(filePath);
                ShowStudents();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtStudentNumber.Text) &&
                !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtPhone.Text))
            {
                // E-posta, TC kimlik ve telefon numarası kontrolü
                if (!IsValidEmail(txtMail.Text))
                {
                    MessageBox.Show("Geçerli bir e-posta adresi girin.");
                    return;
                }

                if (!IsValidTC(txtTC.Text))
                {
                    MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır.");
                    return;
                }

                if (!IsValidPhone(txtPhone.Text))
                {
                    MessageBox.Show("Telefon numarası geçerli olmalıdır (10-11 haneli ve sadece rakamlar).");
                    return;
                }

                // Seçilen takım ID'lerini topla
                List<int> selectedTeamIds = new List<int>();
                foreach (var item in clbTeams.CheckedItems) // clbTeams çoklu takım seçimi için bir CheckedListBox
                {
                    DataRowView row = item as DataRowView;
                    if (row != null)
                    {
                        selectedTeamIds.Add(Convert.ToInt32(row["teamId"])); // CheckedListBox'taki takımların ID'lerini al
                    }
                }

                // Eğer takım seçilmemişse uyarı ver
                if (selectedTeamIds.Count == 0)
                {
                    MessageBox.Show("Lütfen en az bir takım seçin.");
                    return;
                }

                // Öğrenci ekleme işlemi
                InsertStudent(txtName.Text, txtStudentNumber.Text, txtTC.Text, txtPhone.Text, txtMail.Text,
                              dtpBirthDate.Value, txtDepartment.Text, txtClass.Text, selectedTeamIds);

                ShowStudents(); 
                ClearInputFields(); 
            }
            else
            {
                MessageBox.Show("Lütfen gerekli tüm bilgileri girin.");
            }
        }



        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudentInfo.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz öğrenciyi seçin!");
                    return;
                }

                DialogResult result = MessageBox.Show("Öğrenciyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int studentId = Convert.ToInt32(dgvStudentInfo.SelectedRows[0].Cells["Öğrenci ID"].Value);

                    // Öğrencinin bulunduğu takımları al
                    string selectTeamsQuery = "SELECT teamId FROM TblTeamMember WHERE studentId = @studentId";
                    SqlParameter[] selectParams = new SqlParameter[]
                    {
                new SqlParameter("@studentId", studentId)
                    };
                    DataTable teamData = Con.GetData(selectTeamsQuery, selectParams);

                    // Öğrenciyi ve ilişkili kayıtları sil
                    string deleteQueries = @"
                DELETE FROM TblTeamMember WHERE studentId = @studentId;
                DELETE FROM TblStudent WHERE studentId = @studentId";
                    SqlParameter[] deleteParams = new SqlParameter[]
                    {
                new SqlParameter("@studentId", studentId)
                    };
                    Con.SetData(deleteQueries, deleteParams);

                    // Takımlardaki kişi sayısını güncelle
                    foreach (DataRow row in teamData.Rows)
                    {
                        int teamId = Convert.ToInt32(row["teamId"]);
                        string updateTeamCountQuery = "UPDATE TblTeam SET memberCount = (SELECT COUNT(*) FROM TblTeamMember WHERE teamId = @teamId) WHERE teamId = @teamId";
                        SqlParameter[] updateParams = new SqlParameter[]
                        {
                    new SqlParameter("@teamId", teamId)
                        };
                        Con.SetData(updateTeamCountQuery, updateParams);
                    }

                    ShowStudents(); // Öğrenci listesini güncelle
                    MessageBox.Show("Öğrenci silindi ve takım üyeleri güncellendi!");

                    ClearInputFields(); // Input alanlarını temizle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvStudentInfo.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dgvStudentInfo.SelectedRows[0].Cells["Öğrenci ID"].Value);


                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtStudentNumber.Text) &&
                    !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtPhone.Text))
                {
                    // E-posta, TC kimlik ve telefon numarası kontrolü
                    if (!IsValidEmail(txtMail.Text))
                    {
                        MessageBox.Show("Geçerli bir e-posta adresi girin.");
                        return;
                    }

                    if (!IsValidTC(txtTC.Text))
                    {
                        MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır.");
                        return;
                    }

                    if (!IsValidPhone(txtPhone.Text))
                    {
                        MessageBox.Show("Telefon numarası geçerli olmalıdır (10-11 haneli ve sadece rakamlar).");
                        return;
                    }


                    List<int> selectedTeamIds = new List<int>();
                    foreach (var item in clbTeams.CheckedItems)
                    {
                        if (item is DataRowView row)
                        {

                            var teamId = row["teamId"];
                            if (teamId != DBNull.Value)
                            {
                                selectedTeamIds.Add(Convert.ToInt32(teamId));
                            }
                        }
                    }

                    // Öğrenci güncelleme işlemi
                    UpdateStudent(studentId, txtName.Text, txtStudentNumber.Text, txtTC.Text, txtPhone.Text, txtMail.Text,
                                  dtpBirthDate.Value, selectedTeamIds, txtDepartment.Text, txtClass.Text);

                    ShowStudents();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Lütfen gerekli tüm bilgileri girin.");
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek öğrenciyi seçin.");
            }
        }


        private void UpdateStudent(int studentId, string name, string studentNumber, string studentTC, string studentPhone, string email, DateTime? birthDate, List<int> teamIds, string department, string className)
        {
            try
            {

                string query = "UPDATE TblStudent SET studentName = @studentName, studentNumber = @studentNumber, studentTC = @studentTC, " +
                               "studentPhone = @studentPhone, studentMail = @studentMail, studentBirthDate = @studentBirthDate, " +
                               "studentDepartment = @studentDepartment, studentClass = @studentClass " +
                               "WHERE studentId = @studentId";

                SqlParameter[] parameters = {
            new SqlParameter("@studentName", (object)name ?? DBNull.Value),
            new SqlParameter("@studentNumber", (object)studentNumber ?? DBNull.Value),
            new SqlParameter("@studentTC", (object)studentTC ?? DBNull.Value),
            new SqlParameter("@studentPhone", (object)studentPhone ?? DBNull.Value),
            new SqlParameter("@studentMail", (object)email ?? DBNull.Value),
            new SqlParameter("@studentBirthDate", birthDate.HasValue ? (object)birthDate.Value : DBNull.Value),
            new SqlParameter("@studentDepartment", (object)department ?? DBNull.Value),
            new SqlParameter("@studentClass", (object)className ?? DBNull.Value),
            new SqlParameter("@studentId", studentId)
        };

                int rowsAffected = Con.SetData(query, parameters);

                if (rowsAffected > 0)
                {

                    string deleteTeamsQuery = "DELETE FROM TblTeamMember WHERE studentId = @studentId";
                    SqlParameter[] deleteParams = {
                new SqlParameter("@studentId", studentId)
            };
                    Con.SetData(deleteTeamsQuery, deleteParams);


                    foreach (int teamId in teamIds)
                    {
                        string insertTeamQuery = "INSERT INTO TblTeamMember (studentId, teamId) VALUES (@studentId, @teamId)";
                        SqlParameter[] insertParams = {
                    new SqlParameter("@studentId", studentId),
                    new SqlParameter("@teamId", teamId)
                };
                        Con.SetData(insertTeamQuery, insertParams);
                    }

                    MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu. Lütfen tekrar deneyin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
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
                    Con.ExportDataGridViewToPdf(dgvStudentInfo, saveFileDialog.FileName);
                }
            }
        }

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
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnNonFilter_Click(object sender, EventArgs e)
        {
            ShowStudents();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
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