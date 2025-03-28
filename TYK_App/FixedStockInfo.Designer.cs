namespace TYK_App
{
    partial class FixedStockInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedStockInfo));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            btnNonFilter = new Button();
            dgvFixedStocksInfo = new DataGridView();
            label10 = new Label();
            btnFilter = new Button();
            label7 = new Label();
            pictureReport = new PictureBox();
            pictureStudent = new PictureBox();
            label9 = new Label();
            pictureUsers = new PictureBox();
            label14 = new Label();
            label2 = new Label();
            pictureStock = new PictureBox();
            label16 = new Label();
            label11 = new Label();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            pictureTeam = new PictureBox();
            panel2 = new Panel();
            lblFixedStock = new Label();
            btnPdf = new Button();
            pictureCategory = new PictureBox();
            label23 = new Label();
            label24 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFixedStocksInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(labelBack);
            panel1.Controls.Add(pictureBack);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 121);
            panel1.TabIndex = 153;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1736, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 204;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1798, 49);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 205;
            label3.Text = "Çıkış Yap";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.ForeColor = Color.White;
            labelBack.Location = new Point(71, 23);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(96, 28);
            labelBack.TabIndex = 7;
            labelBack.Text = "Geri Dön";
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
            label1.Location = new Point(601, 81);
            label1.Name = "label1";
            label1.Size = new Size(653, 28);
            label1.TabIndex = 5;
            label1.Text = "Teknoloji Yarışmaları Koordinatörlüğü Takip Uygulaması Version 1.0";
            // 
            // btnNonFilter
            // 
            btnNonFilter.BackColor = Color.MediumSeaGreen;
            btnNonFilter.FlatStyle = FlatStyle.Flat;
            btnNonFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNonFilter.ForeColor = Color.White;
            btnNonFilter.Location = new Point(472, 298);
            btnNonFilter.Name = "btnNonFilter";
            btnNonFilter.Size = new Size(181, 41);
            btnNonFilter.TabIndex = 183;
            btnNonFilter.Text = "Filtreyi Temizle";
            btnNonFilter.UseVisualStyleBackColor = false;
            btnNonFilter.Click += btnNonFilter_Click;
            // 
            // dgvFixedStocksInfo
            // 
            dgvFixedStocksInfo.BackgroundColor = Color.Teal;
            dgvFixedStocksInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFixedStocksInfo.Location = new Point(346, 345);
            dgvFixedStocksInfo.Name = "dgvFixedStocksInfo";
            dgvFixedStocksInfo.RowHeadersWidth = 51;
            dgvFixedStocksInfo.RowTemplate.Height = 29;
            dgvFixedStocksInfo.Size = new Size(1248, 593);
            dgvFixedStocksInfo.TabIndex = 182;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(824, 304);
            label10.Name = "label10";
            label10.Size = new Size(259, 28);
            label10.TabIndex = 180;
            label10.Text = "Demirbaş Malzeme Bilgileri";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(355, 298);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(111, 41);
            btnFilter.TabIndex = 181;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(703, 109);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 195;
            // 
            // pictureReport
            // 
            pictureReport.Image = (Image)resources.GetObject("pictureReport.Image");
            pictureReport.Location = new Point(982, 148);
            pictureReport.Name = "pictureReport";
            pictureReport.Size = new Size(68, 57);
            pictureReport.SizeMode = PictureBoxSizeMode.Zoom;
            pictureReport.TabIndex = 196;
            pictureReport.TabStop = false;
            pictureReport.Click += pictureReport_Click;
            // 
            // pictureStudent
            // 
            pictureStudent.Image = (Image)resources.GetObject("pictureStudent.Image");
            pictureStudent.Location = new Point(383, 148);
            pictureStudent.Name = "pictureStudent";
            pictureStudent.Size = new Size(77, 51);
            pictureStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStudent.TabIndex = 185;
            pictureStudent.TabStop = false;
            pictureStudent.Click += pictureStudent_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(1050, 148);
            label9.Name = "label9";
            label9.Size = new Size(118, 28);
            label9.TabIndex = 197;
            label9.Text = "Rapor Takip\r\n";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureUsers
            // 
            pictureUsers.Image = (Image)resources.GetObject("pictureUsers.Image");
            pictureUsers.Location = new Point(1376, 148);
            pictureUsers.Name = "pictureUsers";
            pictureUsers.Size = new Size(56, 51);
            pictureUsers.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUsers.TabIndex = 193;
            pictureUsers.TabStop = false;
            pictureUsers.Click += pictureExit_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Teal;
            label14.Location = new Point(859, 148);
            label14.Name = "label14";
            label14.Size = new Size(117, 28);
            label14.TabIndex = 192;
            label14.Text = "Malzemeler";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(325, 109);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 184;
            // 
            // pictureStock
            // 
            pictureStock.Image = (Image)resources.GetObject("pictureStock.Image");
            pictureStock.Location = new Point(779, 148);
            pictureStock.Name = "pictureStock";
            pictureStock.Size = new Size(74, 57);
            pictureStock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStock.TabIndex = 191;
            pictureStock.TabStop = false;
            pictureStock.Click += pictureStock_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Teal;
            label16.Location = new Point(1438, 148);
            label16.Name = "label16";
            label16.Size = new Size(109, 28);
            label16.TabIndex = 194;
            label16.Text = "Kullanıcılar";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(466, 148);
            label11.Name = "label11";
            label11.Size = new Size(106, 28);
            label11.TabIndex = 186;
            label11.Text = "Öğrenciler";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Teal;
            label15.Location = new Point(1122, 109);
            label15.Name = "label15";
            label15.Size = new Size(0, 28);
            label15.TabIndex = 190;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Teal;
            label13.Location = new Point(523, 109);
            label13.Name = "label13";
            label13.Size = new Size(0, 28);
            label13.TabIndex = 187;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(686, 148);
            label12.Name = "label12";
            label12.Size = new Size(87, 28);
            label12.TabIndex = 189;
            label12.Text = "Takımlar";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureTeam
            // 
            pictureTeam.Image = (Image)resources.GetObject("pictureTeam.Image");
            pictureTeam.Location = new Point(591, 133);
            pictureTeam.Name = "pictureTeam";
            pictureTeam.Size = new Size(89, 92);
            pictureTeam.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTeam.TabIndex = 188;
            pictureTeam.TabStop = false;
            pictureTeam.Click += pictureTeam_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1036);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 19);
            panel2.TabIndex = 198;
            // 
            // lblFixedStock
            // 
            lblFixedStock.AutoSize = true;
            lblFixedStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFixedStock.ForeColor = Color.Teal;
            lblFixedStock.Location = new Point(1297, 304);
            lblFixedStock.Name = "lblFixedStock";
            lblFixedStock.Size = new Size(0, 28);
            lblFixedStock.TabIndex = 199;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.LightSlateGray;
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPdf.ForeColor = Color.White;
            btnPdf.Location = new Point(1219, 944);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(198, 41);
            btnPdf.TabIndex = 200;
            btnPdf.Text = "Pdf Olarak Kaydet";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // pictureCategory
            // 
            pictureCategory.Image = (Image)resources.GetObject("pictureCategory.Image");
            pictureCategory.Location = new Point(1174, 148);
            pictureCategory.Name = "pictureCategory";
            pictureCategory.Size = new Size(89, 65);
            pictureCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCategory.TabIndex = 202;
            pictureCategory.TabStop = false;
            pictureCategory.Click += pictureCategory_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Teal;
            label23.Location = new Point(1259, 148);
            label23.Name = "label23";
            label23.Size = new Size(111, 28);
            label23.TabIndex = 203;
            label23.Text = "Kategoriler";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Teal;
            label24.Location = new Point(1384, 141);
            label24.Name = "label24";
            label24.Size = new Size(0, 28);
            label24.TabIndex = 201;
            // 
            // FixedStockInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pictureCategory);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(btnPdf);
            Controls.Add(lblFixedStock);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(pictureReport);
            Controls.Add(pictureStudent);
            Controls.Add(label9);
            Controls.Add(pictureUsers);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(pictureStock);
            Controls.Add(label16);
            Controls.Add(label11);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(pictureTeam);
            Controls.Add(btnNonFilter);
            Controls.Add(dgvFixedStocksInfo);
            Controls.Add(label10);
            Controls.Add(btnFilter);
            Controls.Add(panel1);
            Name = "FixedStockInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demirbaş Malzemeler Sayfası";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFixedStocksInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).EndInit();
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
        private DataGridView dgvFixedStocksInfo;
        private Label label10;
        private Button btnFilter;
        private Label label7;
        private PictureBox pictureReport;
        private PictureBox pictureStudent;
        private Label label9;
        private PictureBox pictureUsers;
        private Label label14;
        private Label label2;
        private PictureBox pictureStock;
        private Label label16;
        private Label label11;
        private Label label15;
        private Label label13;
        private Label label12;
        private PictureBox pictureTeam;
        private Panel panel2;
        private Label lblFixedStock;
        private Button btnPdf;
        private PictureBox pictureCategory;
        private Label label23;
        private Label label24;
        private PictureBox pictureBox1;
        private Label label3;
    }
}