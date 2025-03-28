namespace TYK_App
{
    partial class StockTracing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockTracing));
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            pictureExit = new PictureBox();
            dgvStockTracing = new DataGridView();
            pictureReport = new PictureBox();
            pictureStudent = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            btnFilter = new Button();
            label14 = new Label();
            pictureStock = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            pictureTeam = new PictureBox();
            cboStockArea = new ComboBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label6 = new Label();
            label3 = new Label();
            txtStockName = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            dtpIssuedDate = new DateTimePicker();
            dtpReturnedDate = new DateTimePicker();
            label7 = new Label();
            txtStudentNumber = new TextBox();
            txtStudentName = new TextBox();
            label8 = new Label();
            btnNonFilter = new Button();
            btnClear = new Button();
            label18 = new Label();
            lblStockTracing = new Label();
            btnPdf = new Button();
            label25 = new Label();
            pictureUser = new PictureBox();
            pictureCategory = new PictureBox();
            label23 = new Label();
            label24 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockTracing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).BeginInit();
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
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 125);
            panel1.TabIndex = 4;
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.ForeColor = Color.White;
            labelBack.Location = new Point(85, 39);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(133, 28);
            labelBack.TabIndex = 98;
            labelBack.Text = "Menüye Dön";
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
            label1.Location = new Point(659, 76);
            label1.Name = "label1";
            label1.Size = new Size(653, 28);
            label1.TabIndex = 1;
            label1.Text = "Teknoloji Yarışmaları Koordinatörlüğü Takip Uygulaması Version 1.0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1810, 53);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 198;
            label5.Text = "Çıkış Yap";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureExit
            // 
            pictureExit.Image = (Image)resources.GetObject("pictureExit.Image");
            pictureExit.Location = new Point(1748, 53);
            pictureExit.Name = "pictureExit";
            pictureExit.Size = new Size(56, 51);
            pictureExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureExit.TabIndex = 182;
            pictureExit.TabStop = false;
            pictureExit.Click += pictureExit_Click;
            // 
            // dgvStockTracing
            // 
            dgvStockTracing.BackgroundColor = Color.Teal;
            dgvStockTracing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockTracing.Location = new Point(709, 334);
            dgvStockTracing.Name = "dgvStockTracing";
            dgvStockTracing.RowHeadersWidth = 51;
            dgvStockTracing.RowTemplate.Height = 29;
            dgvStockTracing.Size = new Size(956, 626);
            dgvStockTracing.TabIndex = 186;
            // 
            // pictureReport
            // 
            pictureReport.Image = (Image)resources.GetObject("pictureReport.Image");
            pictureReport.Location = new Point(1000, 151);
            pictureReport.Name = "pictureReport";
            pictureReport.Size = new Size(68, 57);
            pictureReport.SizeMode = PictureBoxSizeMode.Zoom;
            pictureReport.TabIndex = 184;
            pictureReport.TabStop = false;
            pictureReport.Click += pictureReport_Click;
            // 
            // pictureStudent
            // 
            pictureStudent.Image = (Image)resources.GetObject("pictureStudent.Image");
            pictureStudent.Location = new Point(420, 151);
            pictureStudent.Name = "pictureStudent";
            pictureStudent.Size = new Size(77, 51);
            pictureStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStudent.TabIndex = 176;
            pictureStudent.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(1068, 151);
            label9.Name = "label9";
            label9.Size = new Size(118, 28);
            label9.TabIndex = 185;
            label9.Text = "Rapor Takip\r\n";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(1105, 294);
            label10.Name = "label10";
            label10.Size = new Size(220, 28);
            label10.TabIndex = 175;
            label10.Text = "Malzeme Takip Bilgileri";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(712, 289);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(111, 39);
            btnFilter.TabIndex = 183;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Teal;
            label14.Location = new Point(877, 151);
            label14.Name = "label14";
            label14.Size = new Size(117, 28);
            label14.TabIndex = 181;
            label14.Text = "Malzemeler";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureStock
            // 
            pictureStock.Image = (Image)resources.GetObject("pictureStock.Image");
            pictureStock.Location = new Point(797, 151);
            pictureStock.Name = "pictureStock";
            pictureStock.Size = new Size(74, 57);
            pictureStock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStock.TabIndex = 180;
            pictureStock.TabStop = false;
            pictureStock.Click += pictureStock_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(503, 151);
            label11.Name = "label11";
            label11.Size = new Size(106, 28);
            label11.TabIndex = 177;
            label11.Text = "Öğrenciler";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(704, 151);
            label12.Name = "label12";
            label12.Size = new Size(87, 28);
            label12.TabIndex = 179;
            label12.Text = "Takımlar";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureTeam
            // 
            pictureTeam.Image = (Image)resources.GetObject("pictureTeam.Image");
            pictureTeam.Location = new Point(609, 136);
            pictureTeam.Name = "pictureTeam";
            pictureTeam.Size = new Size(89, 92);
            pictureTeam.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTeam.TabIndex = 178;
            pictureTeam.TabStop = false;
            // 
            // cboStockArea
            // 
            cboStockArea.FormattingEnabled = true;
            cboStockArea.Location = new Point(301, 595);
            cboStockArea.Name = "cboStockArea";
            cboStockArea.Size = new Size(323, 28);
            cboStockArea.TabIndex = 174;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(522, 795);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 36);
            btnDelete.TabIndex = 173;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.PaleTurquoise;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(413, 795);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 36);
            btnUpdate.TabIndex = 172;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(301, 795);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 36);
            btnAdd.TabIndex = 171;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(301, 564);
            label6.Name = "label6";
            label6.Size = new Size(159, 28);
            label6.TabIndex = 170;
            label6.Text = "Bulunduğu Alan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(301, 414);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 169;
            label3.Text = "Veriliş Tarihi";
            // 
            // txtStockName
            // 
            txtStockName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockName.Location = new Point(301, 366);
            txtStockName.Name = "txtStockName";
            txtStockName.Size = new Size(323, 34);
            txtStockName.TabIndex = 167;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(301, 335);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 166;
            label4.Text = "Malzeme Adı";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1036);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 19);
            panel2.TabIndex = 187;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(301, 490);
            label2.Name = "label2";
            label2.Size = new Size(181, 28);
            label2.TabIndex = 188;
            label2.Text = "Teslim Alınan Tarih";
            // 
            // dtpIssuedDate
            // 
            dtpIssuedDate.CalendarMonthBackground = Color.White;
            dtpIssuedDate.Location = new Point(301, 445);
            dtpIssuedDate.Name = "dtpIssuedDate";
            dtpIssuedDate.Size = new Size(323, 27);
            dtpIssuedDate.TabIndex = 189;
            // 
            // dtpReturnedDate
            // 
            dtpReturnedDate.CalendarMonthBackground = Color.White;
            dtpReturnedDate.Location = new Point(301, 521);
            dtpReturnedDate.Name = "dtpReturnedDate";
            dtpReturnedDate.Size = new Size(323, 27);
            dtpReturnedDate.TabIndex = 190;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(301, 713);
            label7.Name = "label7";
            label7.Size = new Size(175, 28);
            label7.TabIndex = 194;
            label7.Text = "Öğrenci Numarası";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentNumber.Location = new Point(301, 744);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(323, 34);
            txtStudentNumber.TabIndex = 193;
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentName.Location = new Point(301, 671);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(323, 34);
            txtStudentName.TabIndex = 192;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(301, 640);
            label8.Name = "label8";
            label8.Size = new Size(192, 28);
            label8.TabIndex = 191;
            label8.Text = "Teslim Alan Öğrenci";
            // 
            // btnNonFilter
            // 
            btnNonFilter.BackColor = Color.MediumSeaGreen;
            btnNonFilter.FlatStyle = FlatStyle.Flat;
            btnNonFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNonFilter.ForeColor = Color.White;
            btnNonFilter.Location = new Point(829, 289);
            btnNonFilter.Name = "btnNonFilter";
            btnNonFilter.Size = new Size(181, 39);
            btnNonFilter.TabIndex = 196;
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
            btnClear.Location = new Point(301, 837);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(323, 38);
            btnClear.TabIndex = 197;
            btnClear.Text = "Seçimi Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Teal;
            label18.Location = new Point(301, 876);
            label18.Name = "label18";
            label18.Size = new Size(356, 84);
            label18.TabIndex = 199;
            label18.Text = "* Güncellemek veya silmek istediğiniz\r\ntakımın satırını tıklayarak işleminiz\r\n yapabilirsiniz.";
            // 
            // lblStockTracing
            // 
            lblStockTracing.AutoSize = true;
            lblStockTracing.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStockTracing.ForeColor = Color.Teal;
            lblStockTracing.Location = new Point(1435, 303);
            lblStockTracing.Name = "lblStockTracing";
            lblStockTracing.Size = new Size(0, 28);
            lblStockTracing.TabIndex = 200;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.LightSlateGray;
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPdf.ForeColor = Color.White;
            btnPdf.Location = new Point(1467, 966);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(198, 41);
            btnPdf.TabIndex = 201;
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
            label25.Location = new Point(1474, 151);
            label25.Name = "label25";
            label25.Size = new Size(109, 28);
            label25.TabIndex = 206;
            label25.Text = "Kullanıcılar";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureUser
            // 
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(1394, 149);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(74, 59);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 205;
            pictureUser.TabStop = false;
            pictureUser.Click += pictureUser_Click;
            // 
            // pictureCategory
            // 
            pictureCategory.Image = (Image)resources.GetObject("pictureCategory.Image");
            pictureCategory.Location = new Point(1192, 151);
            pictureCategory.Name = "pictureCategory";
            pictureCategory.Size = new Size(89, 65);
            pictureCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCategory.TabIndex = 203;
            pictureCategory.TabStop = false;
            pictureCategory.Click += pictureCategory_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Teal;
            label23.Location = new Point(1277, 151);
            label23.Name = "label23";
            label23.Size = new Size(111, 28);
            label23.TabIndex = 204;
            label23.Text = "Kategoriler";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Teal;
            label24.Location = new Point(1402, 144);
            label24.Name = "label24";
            label24.Size = new Size(0, 28);
            label24.TabIndex = 202;
            // 
            // StockTracing
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
            Controls.Add(lblStockTracing);
            Controls.Add(label18);
            Controls.Add(btnClear);
            Controls.Add(btnNonFilter);
            Controls.Add(label7);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtStudentName);
            Controls.Add(label8);
            Controls.Add(dtpReturnedDate);
            Controls.Add(dtpIssuedDate);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(dgvStockTracing);
            Controls.Add(pictureReport);
            Controls.Add(pictureStudent);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btnFilter);
            Controls.Add(label14);
            Controls.Add(pictureStock);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(pictureTeam);
            Controls.Add(cboStockArea);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtStockName);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "StockTracing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Malzeme Takip Sayfası";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockTracing).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelBack;
        private PictureBox pictureBack;
        private Label label1;
        private DataGridView dgvStockTracing;
        private PictureBox pictureReport;
        private PictureBox pictureStudent;
        private Label label9;
        private Label label10;
        private Button btnFilter;
        private PictureBox pictureExit;
        private Label label14;
        private PictureBox pictureStock;
        private Label label11;
        private Label label12;
        private PictureBox pictureTeam;
        private ComboBox cboStockArea;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label6;
        private Label label3;
        private TextBox txtStockName;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private DateTimePicker dtpIssuedDate;
        private DateTimePicker dtpReturnedDate;
        private Label label7;
        private TextBox txtStudentNumber;
        private TextBox txtStudentName;
        private Label label8;
        private Button btnNonFilter;
        private Button btnClear;
        private Label label5;
        private Label label18;
        private Label lblStockTracing;
        private Button btnPdf;
        private Label label25;
        private PictureBox pictureUser;
        private PictureBox pictureCategory;
        private Label label23;
        private Label label24;
    }
}