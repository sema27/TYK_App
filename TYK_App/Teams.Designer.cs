namespace TYK_App
{
    partial class Teams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teams));
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            pictureExit = new PictureBox();
            label19 = new Label();
            label16 = new Label();
            label15 = new Label();
            dgvTeamsInfo = new DataGridView();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            txtCommunity = new TextBox();
            txtTeamName = new TextBox();
            label4 = new Label();
            label10 = new Label();
            label2 = new Label();
            pictureStudent = new PictureBox();
            label11 = new Label();
            label13 = new Label();
            pictureTeam = new PictureBox();
            label12 = new Label();
            pictureStock = new PictureBox();
            label14 = new Label();
            txtTeamAdvisor = new TextBox();
            txtTeamCaptain = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel2 = new Panel();
            cboCategory = new ComboBox();
            btnFilter = new Button();
            label7 = new Label();
            pictureReport = new PictureBox();
            label9 = new Label();
            btnNonFilter = new Button();
            btnClear = new Button();
            label18 = new Label();
            lblTotalTeams = new Label();
            btnPdf = new Button();
            label25 = new Label();
            pictureUser = new PictureBox();
            pictureCategory = new PictureBox();
            label23 = new Label();
            label24 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeamsInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(labelBack);
            panel1.Controls.Add(pictureBack);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureExit);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 125);
            panel1.TabIndex = 1;
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.ForeColor = Color.White;
            labelBack.Location = new Point(85, 39);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(196, 28);
            labelBack.TabIndex = 98;
            labelBack.Text = "Giriş Sayfasına Dön";
            labelBack.Click += labelBack_Click;
            // 
            // pictureBack
            // 
            pictureBack.Image = (Image)resources.GetObject("pictureBack.Image");
            pictureBack.Location = new Point(39, 39);
            pictureBack.Name = "pictureBack";
            pictureBack.Size = new Size(40, 42);
            pictureBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBack.TabIndex = 97;
            pictureBack.TabStop = false;
            pictureBack.Click += pictureBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(674, 85);
            label1.Name = "label1";
            label1.Size = new Size(653, 28);
            label1.TabIndex = 1;
            label1.Text = "Teknoloji Yarışmaları Koordinatörlüğü Takip Uygulaması Version 1.0";
            // 
            // pictureExit
            // 
            pictureExit.Image = (Image)resources.GetObject("pictureExit.Image");
            pictureExit.Location = new Point(1765, 53);
            pictureExit.Name = "pictureExit";
            pictureExit.Size = new Size(56, 51);
            pictureExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureExit.TabIndex = 84;
            pictureExit.TabStop = false;
            pictureExit.Click += pictureExit_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Teal;
            label19.Location = new Point(1838, 28);
            label19.Name = "label19";
            label19.Size = new Size(0, 28);
            label19.TabIndex = 64;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(1827, 53);
            label16.Name = "label16";
            label16.Size = new Size(92, 28);
            label16.TabIndex = 85;
            label16.Text = "Çıkış Yap";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Teal;
            label15.Location = new Point(1808, 38);
            label15.Name = "label15";
            label15.Size = new Size(0, 28);
            label15.TabIndex = 81;
            // 
            // dgvTeamsInfo
            // 
            dgvTeamsInfo.BackgroundColor = Color.Teal;
            dgvTeamsInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeamsInfo.Location = new Point(674, 350);
            dgvTeamsInfo.Name = "dgvTeamsInfo";
            dgvTeamsInfo.RowHeadersWidth = 51;
            dgvTeamsInfo.RowTemplate.Height = 29;
            dgvTeamsInfo.Size = new Size(988, 614);
            dgvTeamsInfo.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(312, 708);
            label8.Name = "label8";
            label8.Size = new Size(139, 28);
            label8.TabIndex = 38;
            label8.Text = "Takım Kaptanı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(312, 626);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 37;
            label5.Text = "Takım Danışmanı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(312, 548);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 35;
            label6.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(312, 467);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 34;
            label3.Text = "Topluluk Adı";
            // 
            // txtCommunity
            // 
            txtCommunity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCommunity.Location = new Point(312, 498);
            txtCommunity.Name = "txtCommunity";
            txtCommunity.Size = new Size(323, 34);
            txtCommunity.TabIndex = 33;
            // 
            // txtTeamName
            // 
            txtTeamName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTeamName.Location = new Point(312, 419);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(323, 34);
            txtTeamName.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(312, 388);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 31;
            label4.Text = "Takım Adı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(1117, 319);
            label10.Name = "label10";
            label10.Size = new Size(138, 28);
            label10.TabIndex = 49;
            label10.Text = "Takım Bilgileri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(680, 131);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 75;
            // 
            // pictureStudent
            // 
            pictureStudent.Image = (Image)resources.GetObject("pictureStudent.Image");
            pictureStudent.Location = new Point(425, 152);
            pictureStudent.Name = "pictureStudent";
            pictureStudent.Size = new Size(77, 51);
            pictureStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStudent.TabIndex = 76;
            pictureStudent.TabStop = false;
            pictureStudent.Click += pictureStudent_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(508, 152);
            label11.Name = "label11";
            label11.Size = new Size(106, 28);
            label11.TabIndex = 77;
            label11.Text = "Öğrenciler";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Teal;
            label13.Location = new Point(878, 131);
            label13.Name = "label13";
            label13.Size = new Size(0, 28);
            label13.TabIndex = 78;
            // 
            // pictureTeam
            // 
            pictureTeam.Image = (Image)resources.GetObject("pictureTeam.Image");
            pictureTeam.Location = new Point(615, 131);
            pictureTeam.Name = "pictureTeam";
            pictureTeam.Size = new Size(89, 92);
            pictureTeam.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTeam.TabIndex = 79;
            pictureTeam.TabStop = false;
            pictureTeam.Click += pictureTeam_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(710, 146);
            label12.Name = "label12";
            label12.Size = new Size(87, 28);
            label12.TabIndex = 80;
            label12.Text = "Takımlar";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureStock
            // 
            pictureStock.Image = (Image)resources.GetObject("pictureStock.Image");
            pictureStock.Location = new Point(803, 146);
            pictureStock.Name = "pictureStock";
            pictureStock.Size = new Size(74, 57);
            pictureStock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStock.TabIndex = 82;
            pictureStock.TabStop = false;
            pictureStock.Click += pictureStock_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Teal;
            label14.Location = new Point(883, 146);
            label14.Name = "label14";
            label14.Size = new Size(117, 28);
            label14.TabIndex = 83;
            label14.Text = "Malzemeler";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTeamAdvisor
            // 
            txtTeamAdvisor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTeamAdvisor.Location = new Point(312, 657);
            txtTeamAdvisor.Name = "txtTeamAdvisor";
            txtTeamAdvisor.Size = new Size(323, 34);
            txtTeamAdvisor.TabIndex = 87;
            // 
            // txtTeamCaptain
            // 
            txtTeamCaptain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTeamCaptain.Location = new Point(312, 739);
            txtTeamCaptain.Name = "txtTeamCaptain";
            txtTeamCaptain.Size = new Size(323, 34);
            txtTeamCaptain.TabIndex = 88;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(533, 797);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 35);
            btnDelete.TabIndex = 92;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.PaleTurquoise;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(424, 797);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(103, 35);
            btnEdit.TabIndex = 91;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(312, 797);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 35);
            btnAdd.TabIndex = 90;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1036);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 19);
            panel2.TabIndex = 93;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(312, 579);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(323, 28);
            cboCategory.TabIndex = 94;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(674, 300);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(118, 44);
            btnFilter.TabIndex = 97;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(1058, 131);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 98;
            // 
            // pictureReport
            // 
            pictureReport.Image = (Image)resources.GetObject("pictureReport.Image");
            pictureReport.Location = new Point(1006, 146);
            pictureReport.Name = "pictureReport";
            pictureReport.Size = new Size(68, 57);
            pictureReport.SizeMode = PictureBoxSizeMode.Zoom;
            pictureReport.TabIndex = 99;
            pictureReport.TabStop = false;
            pictureReport.Click += pictureReport_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(1074, 146);
            label9.Name = "label9";
            label9.Size = new Size(118, 28);
            label9.TabIndex = 100;
            label9.Text = "Rapor Takip\r\n";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNonFilter
            // 
            btnNonFilter.BackColor = Color.MediumSeaGreen;
            btnNonFilter.FlatStyle = FlatStyle.Flat;
            btnNonFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNonFilter.ForeColor = Color.White;
            btnNonFilter.Location = new Point(798, 300);
            btnNonFilter.Name = "btnNonFilter";
            btnNonFilter.Size = new Size(181, 44);
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
            btnClear.Location = new Point(312, 838);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(323, 38);
            btnClear.TabIndex = 140;
            btnClear.Text = "Seçimi Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Teal;
            label18.Location = new Point(312, 880);
            label18.Name = "label18";
            label18.Size = new Size(356, 84);
            label18.TabIndex = 141;
            label18.Text = "* Güncellemek veya silmek istediğiniz\r\ntakımın satırını tıklayarak işleminizi\r\nyapabilirsiniz.";
            // 
            // lblTotalTeams
            // 
            lblTotalTeams.AutoSize = true;
            lblTotalTeams.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalTeams.ForeColor = Color.Teal;
            lblTotalTeams.Location = new Point(1400, 316);
            lblTotalTeams.Name = "lblTotalTeams";
            lblTotalTeams.Size = new Size(0, 28);
            lblTotalTeams.TabIndex = 157;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.LightSlateGray;
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPdf.ForeColor = Color.White;
            btnPdf.Location = new Point(1464, 970);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(198, 41);
            btnPdf.TabIndex = 158;
            btnPdf.Text = "Pdf Olarak Kaydet";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.White;
            label25.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Teal;
            label25.Location = new Point(1480, 146);
            label25.Name = "label25";
            label25.Size = new Size(109, 28);
            label25.TabIndex = 163;
            label25.Text = "Kullanıcılar";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureUser
            // 
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(1400, 144);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(74, 59);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 162;
            pictureUser.TabStop = false;
            pictureUser.Click += pictureUser_Click;
            // 
            // pictureCategory
            // 
            pictureCategory.Image = (Image)resources.GetObject("pictureCategory.Image");
            pictureCategory.Location = new Point(1198, 146);
            pictureCategory.Name = "pictureCategory";
            pictureCategory.Size = new Size(89, 65);
            pictureCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCategory.TabIndex = 160;
            pictureCategory.TabStop = false;
            pictureCategory.Click += pictureCategory_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Teal;
            label23.Location = new Point(1283, 146);
            label23.Name = "label23";
            label23.Size = new Size(111, 28);
            label23.TabIndex = 161;
            label23.Text = "Kategoriler";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Teal;
            label24.Location = new Point(1408, 139);
            label24.Name = "label24";
            label24.Size = new Size(0, 28);
            label24.TabIndex = 159;
            // 
            // Teams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label25);
            Controls.Add(pictureUser);
            Controls.Add(pictureCategory);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(btnPdf);
            Controls.Add(lblTotalTeams);
            Controls.Add(label18);
            Controls.Add(btnClear);
            Controls.Add(btnNonFilter);
            Controls.Add(label7);
            Controls.Add(pictureReport);
            Controls.Add(label9);
            Controls.Add(btnFilter);
            Controls.Add(cboCategory);
            Controls.Add(panel2);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtTeamCaptain);
            Controls.Add(txtTeamAdvisor);
            Controls.Add(label2);
            Controls.Add(pictureStudent);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(pictureTeam);
            Controls.Add(label12);
            Controls.Add(pictureStock);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(dgvTeamsInfo);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtCommunity);
            Controls.Add(txtTeamName);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "Teams";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Takımlar Sayfası";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeamsInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvTeamsInfo;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label3;
        private TextBox txtCommunity;
        private TextBox txtTeamName;
        private Label label4;
        private Label label10;
        private Label label19;
        private PictureBox pictureExit;
        private Label label2;
        private PictureBox pictureStudent;
        private Label label11;
        private Label label13;
        private PictureBox pictureTeam;
        private Label label12;
        private Label label15;
        private Label label16;
        private PictureBox pictureStock;
        private Label label14;
        private Label label1;
        private TextBox txtTeamAdvisor;
        private TextBox txtTeamCaptain;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private OpenFileDialog openFileDialog1;
        private Panel panel2;
        private ComboBox cboCategory;
        private Label labelBack;
        private PictureBox pictureBack;
        private Button btnFilter;
        private Label label7;
        private PictureBox pictureReport;
        private Label label9;
        private Button btnNonFilter;
        private Button btnClear;
        private Label label18;
        private Label lblTotalTeams;
        private Button btnPdf;
        private Label label25;
        private PictureBox pictureUser;
        private PictureBox pictureCategory;
        private Label label23;
        private Label label24;
    }
}