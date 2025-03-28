namespace TYK_App
{
    partial class Stocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stocks));
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            label16 = new Label();
            pictureExit = new PictureBox();
            panel2 = new Panel();
            cboStockArea = new ComboBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label6 = new Label();
            label3 = new Label();
            txtStockNumber = new TextBox();
            txtStockName = new TextBox();
            label4 = new Label();
            dgvStocksInfo = new DataGridView();
            label7 = new Label();
            pictureReport = new PictureBox();
            pictureStudent = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            btnFilter = new Button();
            label19 = new Label();
            label14 = new Label();
            label2 = new Label();
            pictureStock = new PictureBox();
            label11 = new Label();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            pictureTeam = new PictureBox();
            btnClear = new Button();
            btnNonFilter = new Button();
            label18 = new Label();
            lblStock = new Label();
            btnPdf = new Button();
            label25 = new Label();
            pictureUser = new PictureBox();
            pictureCategory = new PictureBox();
            label23 = new Label();
            label24 = new Label();
            label5 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStocksInfo).BeginInit();
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
            panel1.Controls.Add(label16);
            panel1.Controls.Add(pictureExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 125);
            panel1.TabIndex = 3;
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
            label1.Location = new Point(647, 76);
            label1.Name = "label1";
            label1.Size = new Size(653, 28);
            label1.TabIndex = 1;
            label1.Text = "Teknoloji Yarışmaları Koordinatörlüğü Takip Uygulaması Version 1.0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(1805, 53);
            label16.Name = "label16";
            label16.Size = new Size(92, 28);
            label16.TabIndex = 168;
            label16.Text = "Çıkış Yap";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureExit
            // 
            pictureExit.Image = (Image)resources.GetObject("pictureExit.Image");
            pictureExit.Location = new Point(1743, 53);
            pictureExit.Name = "pictureExit";
            pictureExit.Size = new Size(56, 51);
            pictureExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureExit.TabIndex = 160;
            pictureExit.TabStop = false;
            pictureExit.Click += pictureExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1036);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 19);
            panel2.TabIndex = 135;
            // 
            // cboStockArea
            // 
            cboStockArea.FormattingEnabled = true;
            cboStockArea.Location = new Point(282, 613);
            cboStockArea.Name = "cboStockArea";
            cboStockArea.Size = new Size(323, 28);
            cboStockArea.TabIndex = 148;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(503, 680);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 35);
            btnDelete.TabIndex = 147;
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
            btnEdit.Location = new Point(394, 680);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(103, 35);
            btnEdit.TabIndex = 146;
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
            btnAdd.Location = new Point(282, 680);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 35);
            btnAdd.TabIndex = 145;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(282, 573);
            label6.Name = "label6";
            label6.Size = new Size(159, 28);
            label6.TabIndex = 140;
            label6.Text = "Bulunduğu Alan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(282, 483);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 139;
            label3.Text = "Adet";
            // 
            // txtStockNumber
            // 
            txtStockNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockNumber.Location = new Point(282, 514);
            txtStockNumber.Name = "txtStockNumber";
            txtStockNumber.Size = new Size(323, 34);
            txtStockNumber.TabIndex = 138;
            // 
            // txtStockName
            // 
            txtStockName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockName.Location = new Point(282, 420);
            txtStockName.Name = "txtStockName";
            txtStockName.Size = new Size(323, 34);
            txtStockName.TabIndex = 137;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(282, 389);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 136;
            label4.Text = "Malzeme Adı";
            // 
            // dgvStocksInfo
            // 
            dgvStocksInfo.BackgroundColor = Color.Teal;
            dgvStocksInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStocksInfo.Location = new Point(679, 351);
            dgvStocksInfo.Name = "dgvStocksInfo";
            dgvStocksInfo.RowHeadersWidth = 51;
            dgvStocksInfo.RowTemplate.Height = 29;
            dgvStocksInfo.Size = new Size(915, 582);
            dgvStocksInfo.TabIndex = 165;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(827, 117);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 162;
            // 
            // pictureReport
            // 
            pictureReport.Image = (Image)resources.GetObject("pictureReport.Image");
            pictureReport.Location = new Point(982, 146);
            pictureReport.Name = "pictureReport";
            pictureReport.Size = new Size(68, 57);
            pictureReport.SizeMode = PictureBoxSizeMode.Zoom;
            pictureReport.TabIndex = 163;
            pictureReport.TabStop = false;
            pictureReport.Click += pictureReport_Click;
            // 
            // pictureStudent
            // 
            pictureStudent.Image = (Image)resources.GetObject("pictureStudent.Image");
            pictureStudent.Location = new Point(383, 146);
            pictureStudent.Name = "pictureStudent";
            pictureStudent.Size = new Size(77, 51);
            pictureStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStudent.TabIndex = 152;
            pictureStudent.TabStop = false;
            pictureStudent.Click += pictureStudent_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(1050, 146);
            label9.Name = "label9";
            label9.Size = new Size(118, 28);
            label9.TabIndex = 164;
            label9.Text = "Rapor Takip\r\n";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(1071, 306);
            label10.Name = "label10";
            label10.Size = new Size(167, 28);
            label10.TabIndex = 149;
            label10.Text = "Malzeme Bilgileri";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(682, 300);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(111, 41);
            btnFilter.TabIndex = 161;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Teal;
            label19.Location = new Point(1169, 106);
            label19.Name = "label19";
            label19.Size = new Size(0, 28);
            label19.TabIndex = 150;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Teal;
            label14.Location = new Point(859, 146);
            label14.Name = "label14";
            label14.Size = new Size(117, 28);
            label14.TabIndex = 159;
            label14.Text = "Malzemeler";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(449, 117);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 151;
            // 
            // pictureStock
            // 
            pictureStock.Image = (Image)resources.GetObject("pictureStock.Image");
            pictureStock.Location = new Point(779, 146);
            pictureStock.Name = "pictureStock";
            pictureStock.Size = new Size(74, 57);
            pictureStock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStock.TabIndex = 158;
            pictureStock.TabStop = false;
            pictureStock.Click += pictureStock_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(466, 146);
            label11.Name = "label11";
            label11.Size = new Size(106, 28);
            label11.TabIndex = 153;
            label11.Text = "Öğrenciler";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Teal;
            label15.Location = new Point(1024, 117);
            label15.Name = "label15";
            label15.Size = new Size(0, 28);
            label15.TabIndex = 157;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Teal;
            label13.Location = new Point(647, 117);
            label13.Name = "label13";
            label13.Size = new Size(0, 28);
            label13.TabIndex = 154;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(686, 146);
            label12.Name = "label12";
            label12.Size = new Size(87, 28);
            label12.TabIndex = 156;
            label12.Text = "Takımlar";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureTeam
            // 
            pictureTeam.Image = (Image)resources.GetObject("pictureTeam.Image");
            pictureTeam.Location = new Point(591, 131);
            pictureTeam.Name = "pictureTeam";
            pictureTeam.Size = new Size(89, 92);
            pictureTeam.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTeam.TabIndex = 155;
            pictureTeam.TabStop = false;
            pictureTeam.Click += pictureTeam_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MediumSeaGreen;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(282, 721);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(323, 38);
            btnClear.TabIndex = 166;
            btnClear.Text = "Seçimi Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnNonFilter
            // 
            btnNonFilter.BackColor = Color.MediumSeaGreen;
            btnNonFilter.FlatStyle = FlatStyle.Flat;
            btnNonFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNonFilter.ForeColor = Color.White;
            btnNonFilter.Location = new Point(799, 300);
            btnNonFilter.Name = "btnNonFilter";
            btnNonFilter.Size = new Size(181, 41);
            btnNonFilter.TabIndex = 167;
            btnNonFilter.Text = "Filtreyi Temizle";
            btnNonFilter.UseVisualStyleBackColor = false;
            btnNonFilter.Click += btnNonFilter_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Teal;
            label18.Location = new Point(282, 780);
            label18.Name = "label18";
            label18.Size = new Size(356, 84);
            label18.TabIndex = 169;
            label18.Text = "* Güncellemek veya silmek istediğiniz\r\ntakımın satırını tıklayarak işleminizi\r\nyapabilirsiniz.";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.ForeColor = Color.Teal;
            lblStock.Location = new Point(1314, 320);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(0, 28);
            lblStock.TabIndex = 170;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.LightSlateGray;
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPdf.ForeColor = Color.White;
            btnPdf.Location = new Point(1396, 939);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(198, 41);
            btnPdf.TabIndex = 171;
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
            label25.Location = new Point(1446, 146);
            label25.Name = "label25";
            label25.Size = new Size(109, 28);
            label25.TabIndex = 178;
            label25.Text = "Kullanıcılar";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureUser
            // 
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(1366, 144);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(74, 59);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 177;
            pictureUser.TabStop = false;
            pictureUser.Click += pictureUser_Click;
            // 
            // pictureCategory
            // 
            pictureCategory.Image = (Image)resources.GetObject("pictureCategory.Image");
            pictureCategory.Location = new Point(1164, 146);
            pictureCategory.Name = "pictureCategory";
            pictureCategory.Size = new Size(89, 65);
            pictureCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCategory.TabIndex = 175;
            pictureCategory.TabStop = false;
            pictureCategory.Click += pictureCategory_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Teal;
            label23.Location = new Point(1249, 146);
            label23.Name = "label23";
            label23.Size = new Size(111, 28);
            label23.TabIndex = 176;
            label23.Text = "Kategoriler";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Teal;
            label24.Location = new Point(1374, 139);
            label24.Name = "label24";
            label24.Size = new Size(0, 28);
            label24.TabIndex = 174;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(1312, 106);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 172;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(1167, 117);
            label8.Name = "label8";
            label8.Size = new Size(0, 28);
            label8.TabIndex = 173;
            // 
            // Stocks
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
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(btnPdf);
            Controls.Add(lblStock);
            Controls.Add(label18);
            Controls.Add(btnNonFilter);
            Controls.Add(btnClear);
            Controls.Add(dgvStocksInfo);
            Controls.Add(label7);
            Controls.Add(pictureReport);
            Controls.Add(pictureStudent);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btnFilter);
            Controls.Add(label19);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(pictureStock);
            Controls.Add(label11);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(pictureTeam);
            Controls.Add(cboStockArea);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtStockNumber);
            Controls.Add(txtStockName);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Stocks";
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
        private Panel panel2;
        private ComboBox cboStockArea;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label6;
        private Label label3;
        private TextBox txtStockNumber;
        private TextBox txtStockName;
        private Label label4;
        private DataGridView dgvStocksInfo;
        private Label label7;
        private PictureBox pictureReport;
        private PictureBox pictureStudent;
        private Label label9;
        private Label label10;
        private Button btnFilter;
        private Label label19;
        private PictureBox pictureExit;
        private Label label14;
        private Label label2;
        private PictureBox pictureStock;
        private Label label11;
        private Label label15;
        private Label label13;
        private Label label12;
        private PictureBox pictureTeam;
        private Button btnClear;
        private Button btnNonFilter;
        private Label label16;
        private Label label18;
        private Label lblStock;
        private Button btnPdf;
        private Label label25;
        private PictureBox pictureUser;
        private PictureBox pictureCategory;
        private Label label23;
        private Label label24;
        private Label label5;
        private Label label8;
    }
}