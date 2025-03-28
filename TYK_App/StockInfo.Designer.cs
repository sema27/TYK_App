namespace TYK_App
{
    partial class StockInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInfo));
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            label16 = new Label();
            label15 = new Label();
            pictureExit = new PictureBox();
            btnNonFilter = new Button();
            dgvStocksInfo = new DataGridView();
            label10 = new Label();
            btnFilter = new Button();
            label8 = new Label();
            pictureReport = new PictureBox();
            label20 = new Label();
            label2 = new Label();
            pictureStudent = new PictureBox();
            label11 = new Label();
            label13 = new Label();
            pictureTeam = new PictureBox();
            label12 = new Label();
            pictureStock = new PictureBox();
            label14 = new Label();
            panel2 = new Panel();
            lblStock = new Label();
            btnPdf = new Button();
            label25 = new Label();
            pictureUser = new PictureBox();
            pictureCategory = new PictureBox();
            label23 = new Label();
            label24 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStocksInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).BeginInit();
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
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(pictureExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 121);
            panel1.TabIndex = 152;
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.ForeColor = Color.White;
            labelBack.Location = new Point(71, 23);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(133, 28);
            labelBack.TabIndex = 7;
            labelBack.Text = "Menüye Dön";
            labelBack.Click += labelBack_Click;
            // 
            // pictureBack
            // 
            pictureBack.Image = (Image)resources.GetObject("pictureBack.Image");
            pictureBack.Location = new Point(25, 23);
            pictureBack.Name = "pictureBack";
            pictureBack.Size = new Size(40, 42);
            pictureBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBack.TabIndex = 6;
            pictureBack.TabStop = false;
            pictureBack.Click += pictureBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(644, 77);
            label1.Name = "label1";
            label1.Size = new Size(653, 28);
            label1.TabIndex = 5;
            label1.Text = "Teknoloji Yarışmaları Koordinatörlüğü Takip Uygulaması Version 1.0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(1809, 45);
            label16.Name = "label16";
            label16.Size = new Size(92, 28);
            label16.TabIndex = 182;
            label16.Text = "Çıkış Yap";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Teal;
            label15.Location = new Point(1790, 30);
            label15.Name = "label15";
            label15.Size = new Size(0, 28);
            label15.TabIndex = 178;
            // 
            // pictureExit
            // 
            pictureExit.Image = (Image)resources.GetObject("pictureExit.Image");
            pictureExit.Location = new Point(1747, 45);
            pictureExit.Name = "pictureExit";
            pictureExit.Size = new Size(56, 51);
            pictureExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureExit.TabIndex = 181;
            pictureExit.TabStop = false;
            pictureExit.Click += pictureExit_Click;
            // 
            // btnNonFilter
            // 
            btnNonFilter.BackColor = Color.MediumSeaGreen;
            btnNonFilter.FlatStyle = FlatStyle.Flat;
            btnNonFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNonFilter.ForeColor = Color.White;
            btnNonFilter.Location = new Point(486, 261);
            btnNonFilter.Name = "btnNonFilter";
            btnNonFilter.Size = new Size(181, 41);
            btnNonFilter.TabIndex = 171;
            btnNonFilter.Text = "Filtreyi Temizle";
            btnNonFilter.UseVisualStyleBackColor = false;
            btnNonFilter.Click += btnNonFilter_Click;
            // 
            // dgvStocksInfo
            // 
            dgvStocksInfo.BackgroundColor = Color.Teal;
            dgvStocksInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStocksInfo.Location = new Point(365, 308);
            dgvStocksInfo.Name = "dgvStocksInfo";
            dgvStocksInfo.RowHeadersWidth = 51;
            dgvStocksInfo.RowTemplate.Height = 29;
            dgvStocksInfo.Size = new Size(1244, 635);
            dgvStocksInfo.TabIndex = 170;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(881, 267);
            label10.Name = "label10";
            label10.Size = new Size(167, 28);
            label10.TabIndex = 168;
            label10.Text = "Malzeme Bilgileri";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(369, 261);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(111, 41);
            btnFilter.TabIndex = 169;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(1031, 130);
            label8.Name = "label8";
            label8.Size = new Size(0, 28);
            label8.TabIndex = 183;
            // 
            // pictureReport
            // 
            pictureReport.Image = (Image)resources.GetObject("pictureReport.Image");
            pictureReport.Location = new Point(979, 145);
            pictureReport.Name = "pictureReport";
            pictureReport.Size = new Size(68, 57);
            pictureReport.SizeMode = PictureBoxSizeMode.Zoom;
            pictureReport.TabIndex = 184;
            pictureReport.TabStop = false;
            pictureReport.Click += pictureReport_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Teal;
            label20.Location = new Point(1047, 145);
            label20.Name = "label20";
            label20.Size = new Size(118, 28);
            label20.TabIndex = 185;
            label20.Text = "Rapor Takip\r\n";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(644, 130);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 172;
            // 
            // pictureStudent
            // 
            pictureStudent.Image = (Image)resources.GetObject("pictureStudent.Image");
            pictureStudent.Location = new Point(384, 145);
            pictureStudent.Name = "pictureStudent";
            pictureStudent.Size = new Size(77, 51);
            pictureStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStudent.TabIndex = 173;
            pictureStudent.TabStop = false;
            pictureStudent.Click += pictureStudent_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(467, 145);
            label11.Name = "label11";
            label11.Size = new Size(106, 28);
            label11.TabIndex = 174;
            label11.Text = "Öğrenciler";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Teal;
            label13.Location = new Point(842, 130);
            label13.Name = "label13";
            label13.Size = new Size(0, 28);
            label13.TabIndex = 175;
            // 
            // pictureTeam
            // 
            pictureTeam.Image = (Image)resources.GetObject("pictureTeam.Image");
            pictureTeam.Location = new Point(579, 130);
            pictureTeam.Name = "pictureTeam";
            pictureTeam.Size = new Size(89, 92);
            pictureTeam.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTeam.TabIndex = 176;
            pictureTeam.TabStop = false;
            pictureTeam.Click += pictureTeam_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(674, 145);
            label12.Name = "label12";
            label12.Size = new Size(87, 28);
            label12.TabIndex = 177;
            label12.Text = "Takımlar";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureStock
            // 
            pictureStock.Image = (Image)resources.GetObject("pictureStock.Image");
            pictureStock.Location = new Point(780, 145);
            pictureStock.Name = "pictureStock";
            pictureStock.Size = new Size(62, 57);
            pictureStock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStock.TabIndex = 179;
            pictureStock.TabStop = false;
            pictureStock.Click += pictureStock_Click_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Teal;
            label14.Location = new Point(842, 145);
            label14.Name = "label14";
            label14.Size = new Size(117, 28);
            label14.TabIndex = 180;
            label14.Text = "Malzemeler";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1042);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 13);
            panel2.TabIndex = 186;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.ForeColor = Color.Teal;
            lblStock.Location = new Point(1232, 274);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(0, 28);
            lblStock.TabIndex = 187;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.LightSlateGray;
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPdf.ForeColor = Color.White;
            btnPdf.Location = new Point(1411, 949);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(198, 41);
            btnPdf.TabIndex = 188;
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
            label25.Location = new Point(1453, 145);
            label25.Name = "label25";
            label25.Size = new Size(109, 28);
            label25.TabIndex = 193;
            label25.Text = "Kullanıcılar";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureUser
            // 
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(1373, 143);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(74, 59);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 192;
            pictureUser.TabStop = false;
            pictureUser.Click += pictureUser_Click;
            // 
            // pictureCategory
            // 
            pictureCategory.Image = (Image)resources.GetObject("pictureCategory.Image");
            pictureCategory.Location = new Point(1171, 145);
            pictureCategory.Name = "pictureCategory";
            pictureCategory.Size = new Size(89, 65);
            pictureCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCategory.TabIndex = 190;
            pictureCategory.TabStop = false;
            pictureCategory.Click += pictureCategory_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Teal;
            label23.Location = new Point(1256, 145);
            label23.Name = "label23";
            label23.Size = new Size(111, 28);
            label23.TabIndex = 191;
            label23.Text = "Kategoriler";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Teal;
            label24.Location = new Point(1381, 138);
            label24.Name = "label24";
            label24.Size = new Size(0, 28);
            label24.TabIndex = 189;
            // 
            // StockInfo
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
            Controls.Add(lblStock);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(pictureReport);
            Controls.Add(label20);
            Controls.Add(label2);
            Controls.Add(pictureStudent);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(pictureTeam);
            Controls.Add(label12);
            Controls.Add(pictureStock);
            Controls.Add(label14);
            Controls.Add(btnNonFilter);
            Controls.Add(dgvStocksInfo);
            Controls.Add(label10);
            Controls.Add(btnFilter);
            Controls.Add(panel1);
            Name = "StockInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Malzemeler Sayfası";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStocksInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).EndInit();
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
        private Button btnNonFilter;
        private DataGridView dgvStocksInfo;
        private Label label10;
        private Button btnFilter;
        private Label label8;
        private PictureBox pictureReport;
        private Label label20;
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
        private Panel panel2;
        private Label lblStock;
        private Button btnPdf;
        private Label label25;
        private PictureBox pictureUser;
        private PictureBox pictureCategory;
        private Label label23;
        private Label label24;
    }
}