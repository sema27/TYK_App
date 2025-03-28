namespace TYK_App
{
    partial class Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            pictureExit = new PictureBox();
            label16 = new Label();
            label15 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtStudentNumber = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            txtTC = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            dgvStudentInfo = new DataGridView();
            dtpBirthDate = new DateTimePicker();
            btnAdd = new Button();
            btnEdit = new Button();
            label17 = new Label();
            label18 = new Label();
            txtMail = new TextBox();
            txtPhone = new TextBox();
            label19 = new Label();
            txtDepartment = new TextBox();
            txtClass = new TextBox();
            label5 = new Label();
            btnDelete = new Button();
            btnFilter = new Button();
            btnExcel = new Button();
            label14 = new Label();
            pictureStock = new PictureBox();
            label12 = new Label();
            pictureTeam = new PictureBox();
            label13 = new Label();
            label11 = new Label();
            pictureStudent = new PictureBox();
            label10 = new Label();
            label8 = new Label();
            pictureReport = new PictureBox();
            label20 = new Label();
            btnNonFilter = new Button();
            btnClear = new Button();
            label21 = new Label();
            lblTotalStudents = new Label();
            btnPdf = new Button();
            label22 = new Label();
            label24 = new Label();
            pictureCategory = new PictureBox();
            label23 = new Label();
            pictureUser = new PictureBox();
            label25 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            clbTeams = new CheckedListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(labelBack);
            panel1.Controls.Add(pictureBack);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureExit);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 111);
            panel1.TabIndex = 0;
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.Location = new Point(70, 38);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(196, 28);
            labelBack.TabIndex = 2;
            labelBack.Text = "Giriş Sayfasına Dön";
            labelBack.Click += labelBack_Click;
            // 
            // pictureBack
            // 
            pictureBack.Image = (Image)resources.GetObject("pictureBack.Image");
            pictureBack.Location = new Point(24, 38);
            pictureBack.Name = "pictureBack";
            pictureBack.Size = new Size(40, 42);
            pictureBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBack.TabIndex = 1;
            pictureBack.TabStop = false;
            pictureBack.Click += pictureBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(861, 69);
            label1.Name = "label1";
            label1.Size = new Size(653, 28);
            label1.TabIndex = 0;
            label1.Text = "Teknoloji Yarışmaları Koordinatörlüğü Takip Uygulaması Version 1.0";
            // 
            // pictureExit
            // 
            pictureExit.Image = (Image)resources.GetObject("pictureExit.Image");
            pictureExit.Location = new Point(1741, 48);
            pictureExit.Name = "pictureExit";
            pictureExit.Size = new Size(56, 51);
            pictureExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureExit.TabIndex = 73;
            pictureExit.TabStop = false;
            pictureExit.Click += pictureExit_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(1803, 52);
            label16.Name = "label16";
            label16.Size = new Size(92, 28);
            label16.TabIndex = 74;
            label16.Text = "Çıkış Yap";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Teal;
            label15.Location = new Point(1784, 37);
            label15.Name = "label15";
            label15.Size = new Size(0, 28);
            label15.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(1315, 233);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci Bilgileri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(67, 362);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 10;
            label3.Text = "Öğrenci Numarası";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentNumber.Location = new Point(67, 393);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(323, 34);
            txtStudentNumber.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(67, 306);
            txtName.Name = "txtName";
            txtName.Size = new Size(323, 34);
            txtName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(67, 275);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 7;
            label4.Text = "Ad - Soyad";
            // 
            // txtTC
            // 
            txtTC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTC.Location = new Point(67, 479);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(323, 34);
            txtTC.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(67, 448);
            label6.Name = "label6";
            label6.Size = new Size(49, 28);
            label6.TabIndex = 11;
            label6.Text = "T. C.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(70, 798);
            label7.Name = "label7";
            label7.Size = new Size(83, 28);
            label7.TabIndex = 18;
            label7.Text = "Bölümü";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1042);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 13);
            panel2.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(70, 711);
            label9.Name = "label9";
            label9.Size = new Size(134, 28);
            label9.TabIndex = 21;
            label9.Text = "Doğum Tarihi";
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.BackgroundColor = Color.Teal;
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvStudentInfo.DefaultCellStyle = dataGridViewCellStyle1;
            dgvStudentInfo.Location = new Point(816, 277);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.RowHeadersWidth = 51;
            dgvStudentInfo.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvStudentInfo.RowTemplate.Height = 29;
            dgvStudentInfo.Size = new Size(1039, 690);
            dgvStudentInfo.TabIndex = 25;
            dgvStudentInfo.CellEnter += dgvStudentInfo_CellEnter;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CalendarMonthBackground = Color.White;
            dtpBirthDate.Location = new Point(70, 742);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(323, 34);
            dtpBirthDate.TabIndex = 26;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(418, 751);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 34);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.PaleTurquoise;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(530, 751);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(103, 34);
            btnEdit.TabIndex = 29;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Teal;
            label17.Location = new Point(418, 275);
            label17.Name = "label17";
            label17.Size = new Size(70, 28);
            label17.TabIndex = 79;
            label17.Text = "Takımı";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Teal;
            label18.Location = new Point(67, 630);
            label18.Name = "label18";
            label18.Size = new Size(113, 28);
            label18.TabIndex = 78;
            label18.Text = "Mail Adresi";
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(67, 661);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(323, 34);
            txtMail.TabIndex = 77;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(67, 569);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(323, 34);
            txtPhone.TabIndex = 76;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Teal;
            label19.Location = new Point(67, 538);
            label19.Name = "label19";
            label19.Size = new Size(171, 28);
            label19.TabIndex = 75;
            label19.Text = "Telefon Numarası";
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepartment.Location = new Point(70, 829);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(323, 34);
            txtDepartment.TabIndex = 81;
            // 
            // txtClass
            // 
            txtClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClass.Location = new Point(70, 909);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(323, 34);
            txtClass.TabIndex = 83;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(70, 878);
            label5.Name = "label5";
            label5.Size = new Size(57, 28);
            label5.TabIndex = 82;
            label5.Text = "Sınıfı";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(639, 751);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 34);
            btnDelete.TabIndex = 85;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(816, 230);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(106, 41);
            btnFilter.TabIndex = 87;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click_1;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.CornflowerBlue;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(418, 839);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(323, 41);
            btnExcel.TabIndex = 88;
            btnExcel.Text = "Excel ile Aktar";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Teal;
            label14.Location = new Point(1035, 137);
            label14.Name = "label14";
            label14.Size = new Size(117, 28);
            label14.TabIndex = 72;
            label14.Text = "Malzemeler";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureStock
            // 
            pictureStock.Image = (Image)resources.GetObject("pictureStock.Image");
            pictureStock.Location = new Point(973, 137);
            pictureStock.Name = "pictureStock";
            pictureStock.Size = new Size(62, 57);
            pictureStock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStock.TabIndex = 71;
            pictureStock.TabStop = false;
            pictureStock.Click += pictureStock_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(880, 137);
            label12.Name = "label12";
            label12.Size = new Size(87, 28);
            label12.TabIndex = 69;
            label12.Text = "Takımlar";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureTeam
            // 
            pictureTeam.Image = (Image)resources.GetObject("pictureTeam.Image");
            pictureTeam.Location = new Point(796, 122);
            pictureTeam.Name = "pictureTeam";
            pictureTeam.Size = new Size(89, 92);
            pictureTeam.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTeam.TabIndex = 68;
            pictureTeam.TabStop = false;
            pictureTeam.Click += pictureTeam_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Teal;
            label13.Location = new Point(1035, 122);
            label13.Name = "label13";
            label13.Size = new Size(0, 28);
            label13.TabIndex = 67;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(674, 137);
            label11.Name = "label11";
            label11.Size = new Size(106, 28);
            label11.TabIndex = 66;
            label11.Text = "Öğrenciler";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureStudent
            // 
            pictureStudent.Image = (Image)resources.GetObject("pictureStudent.Image");
            pictureStudent.Location = new Point(601, 137);
            pictureStudent.Name = "pictureStudent";
            pictureStudent.Size = new Size(77, 51);
            pictureStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStudent.TabIndex = 65;
            pictureStudent.TabStop = false;
            pictureStudent.Click += pictureStudent_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(861, 122);
            label10.Name = "label10";
            label10.Size = new Size(0, 28);
            label10.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(1220, 122);
            label8.Name = "label8";
            label8.Size = new Size(0, 28);
            label8.TabIndex = 101;
            // 
            // pictureReport
            // 
            pictureReport.Image = (Image)resources.GetObject("pictureReport.Image");
            pictureReport.Location = new Point(1168, 137);
            pictureReport.Name = "pictureReport";
            pictureReport.Size = new Size(68, 57);
            pictureReport.SizeMode = PictureBoxSizeMode.Zoom;
            pictureReport.TabIndex = 102;
            pictureReport.TabStop = false;
            pictureReport.Click += pictureReport_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Teal;
            label20.Location = new Point(1236, 137);
            label20.Name = "label20";
            label20.Size = new Size(87, 28);
            label20.TabIndex = 103;
            label20.Text = "Raporlar";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNonFilter
            // 
            btnNonFilter.BackColor = Color.MediumSeaGreen;
            btnNonFilter.FlatStyle = FlatStyle.Flat;
            btnNonFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNonFilter.ForeColor = Color.White;
            btnNonFilter.Location = new Point(928, 230);
            btnNonFilter.Name = "btnNonFilter";
            btnNonFilter.Size = new Size(181, 41);
            btnNonFilter.TabIndex = 139;
            btnNonFilter.Text = "Filtreyi Temizle";
            btnNonFilter.UseVisualStyleBackColor = false;
            btnNonFilter.Click += btnNonFilter_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MediumSeaGreen;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(418, 791);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(323, 42);
            btnClear.TabIndex = 140;
            btnClear.Text = "Seçimi Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.Teal;
            label21.Location = new Point(418, 883);
            label21.Name = "label21";
            label21.Size = new Size(362, 84);
            label21.TabIndex = 142;
            label21.Text = "* Güncellemek veya silmek istediğiniz \r\ntakımın satırını tıklayarak işleminizi \r\nyapabilirsiniz.";
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalStudents.ForeColor = Color.Teal;
            lblTotalStudents.Location = new Point(1611, 236);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(0, 28);
            lblTotalStudents.TabIndex = 143;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.LightSlateGray;
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPdf.ForeColor = Color.White;
            btnPdf.Location = new Point(1657, 973);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(198, 41);
            btnPdf.TabIndex = 144;
            btnPdf.Text = "Pdf Olarak Kaydet";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Teal;
            label22.Location = new Point(1242, 122);
            label22.Name = "label22";
            label22.Size = new Size(0, 28);
            label22.TabIndex = 145;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Teal;
            label24.Location = new Point(1539, 130);
            label24.Name = "label24";
            label24.Size = new Size(0, 28);
            label24.TabIndex = 148;
            // 
            // pictureCategory
            // 
            pictureCategory.Image = (Image)resources.GetObject("pictureCategory.Image");
            pictureCategory.Location = new Point(1329, 137);
            pictureCategory.Name = "pictureCategory";
            pictureCategory.Size = new Size(89, 65);
            pictureCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCategory.TabIndex = 149;
            pictureCategory.TabStop = false;
            pictureCategory.Click += pictureCategory_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Teal;
            label23.Location = new Point(1414, 137);
            label23.Name = "label23";
            label23.Size = new Size(111, 28);
            label23.TabIndex = 150;
            label23.Text = "Kategoriler";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureUser
            // 
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(1531, 135);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(74, 59);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 151;
            pictureUser.TabStop = false;
            pictureUser.Click += pictureUser_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.White;
            label25.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Teal;
            label25.Location = new Point(1611, 137);
            label25.Name = "label25";
            label25.Size = new Size(109, 28);
            label25.TabIndex = 152;
            label25.Text = "Kullanıcılar";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // clbTeams
            // 
            clbTeams.FormattingEnabled = true;
            clbTeams.Location = new Point(418, 306);
            clbTeams.Name = "clbTeams";
            clbTeams.Size = new Size(323, 439);
            clbTeams.TabIndex = 153;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(clbTeams);
            Controls.Add(label25);
            Controls.Add(pictureUser);
            Controls.Add(pictureCategory);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label22);
            Controls.Add(btnPdf);
            Controls.Add(lblTotalStudents);
            Controls.Add(label21);
            Controls.Add(btnClear);
            Controls.Add(btnNonFilter);
            Controls.Add(label8);
            Controls.Add(pictureReport);
            Controls.Add(label20);
            Controls.Add(btnExcel);
            Controls.Add(btnFilter);
            Controls.Add(btnDelete);
            Controls.Add(panel1);
            Controls.Add(txtClass);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(pictureStudent);
            Controls.Add(txtDepartment);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(label17);
            Controls.Add(pictureTeam);
            Controls.Add(label18);
            Controls.Add(label12);
            Controls.Add(txtMail);
            Controls.Add(txtPhone);
            Controls.Add(label19);
            Controls.Add(pictureStock);
            Controls.Add(btnEdit);
            Controls.Add(label14);
            Controls.Add(btnAdd);
            Controls.Add(dtpBirthDate);
            Controls.Add(dgvStudentInfo);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(txtTC);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenciler Sayfası";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtStudentNumber;
        private TextBox txtName;
        private Label label4;
        private TextBox txtTC;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Label label9;
        private DataGridView dgvStudentInfo;
        private DateTimePicker dtpBirthDate;
        private Button btnAdd;
        private Button btnEdit;
        private Label label17;
        private Label label18;
        private TextBox txtMail;
        private TextBox txtPhone;
        private Label label19;
        private TextBox txtDepartment;
        private TextBox txtClass;
        private Label label5;
        private Button btnDelete;
        private Button btnFilter;
        private PictureBox pictureBack;
        private Label labelBack;
        private Button btnExcel;
        private Label label14;
        private PictureBox pictureStock;
        private PictureBox pictureExit;
        private Label label15;
        private Label label12;
        private PictureBox pictureTeam;
        private Label label13;
        private Label label11;
        private PictureBox pictureStudent;
        private Label label10;
        private Label label16;
        private Label label8;
        private PictureBox pictureReport;
        private Label label20;
        private Button btnNonFilter;
        private Button btnClear;
        private Label label21;
        private Label lblTotalStudents;
        private Button btnPdf;
        private Label label22;
        private Label label24;
        private PictureBox pictureCategory;
        private Label label23;
        private PictureBox pictureUser;
        private Label label25;
        private ContextMenuStrip contextMenuStrip1;
        private CheckedListBox clbTeams;
    }
}