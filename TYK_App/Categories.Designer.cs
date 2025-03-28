namespace TYK_App
{
    partial class Categories
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            label21 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtCategory = new TextBox();
            label4 = new Label();
            dgvCategory = new DataGridView();
            label2 = new Label();
            btnNonFilter = new Button();
            btnFilter = new Button();
            lblCategory = new Label();
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label7 = new Label();
            pictureExit = new PictureBox();
            label19 = new Label();
            label16 = new Label();
            label15 = new Label();
            label25 = new Label();
            pictureUser = new PictureBox();
            pictureCategory = new PictureBox();
            label23 = new Label();
            label24 = new Label();
            label8 = new Label();
            pictureReport = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            pictureStudent = new PictureBox();
            label11 = new Label();
            label13 = new Label();
            pictureTeam = new PictureBox();
            label12 = new Label();
            pictureStock = new PictureBox();
            label14 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).BeginInit();
            SuspendLayout();
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.Teal;
            label21.Location = new Point(379, 650);
            label21.Name = "label21";
            label21.Size = new Size(356, 84);
            label21.TabIndex = 158;
            label21.Text = "* Güncellemek veya silmek istediğiniz\r\ntakımın satırını tıklayarak işleminizi\r\nyapabilirsiniz.";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MediumSeaGreen;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(379, 596);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(327, 42);
            btnClear.TabIndex = 157;
            btnClear.Text = "Seçimi Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(600, 556);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 34);
            btnDelete.TabIndex = 156;
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
            btnEdit.Location = new Point(491, 555);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 35);
            btnEdit.TabIndex = 155;
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
            btnAdd.Location = new Point(379, 556);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 34);
            btnAdd.TabIndex = 154;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.Location = new Point(379, 495);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(327, 34);
            txtCategory.TabIndex = 153;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(379, 459);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 148;
            label4.Text = "Kategori Adı";
            // 
            // dgvCategory
            // 
            dgvCategory.BackgroundColor = Color.Teal;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.Location = new Point(741, 360);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvCategory.RowTemplate.Height = 29;
            dgvCategory.Size = new Size(862, 581);
            dgvCategory.TabIndex = 147;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(1108, 321);
            label2.Name = "label2";
            label2.Size = new Size(173, 28);
            label2.TabIndex = 146;
            label2.Text = "Kategori Bilgileri";
            // 
            // btnNonFilter
            // 
            btnNonFilter.BackColor = Color.MediumSeaGreen;
            btnNonFilter.FlatStyle = FlatStyle.Flat;
            btnNonFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNonFilter.ForeColor = Color.White;
            btnNonFilter.Location = new Point(836, 315);
            btnNonFilter.Name = "btnNonFilter";
            btnNonFilter.Size = new Size(163, 41);
            btnNonFilter.TabIndex = 162;
            btnNonFilter.Text = "Filtreyi Temizle";
            btnNonFilter.UseVisualStyleBackColor = false;
            btnNonFilter.Click += btnNonFilter_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(746, 315);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(88, 41);
            btnFilter.TabIndex = 161;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.Teal;
            lblCategory.Location = new Point(1358, 326);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(0, 28);
            lblCategory.TabIndex = 163;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(labelBack);
            panel1.Controls.Add(pictureBack);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureExit);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 125);
            panel1.TabIndex = 164;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(684, 82);
            label7.Name = "label7";
            label7.Size = new Size(653, 28);
            label7.TabIndex = 1;
            label7.Text = "Teknoloji Yarışmaları Koordinatörlüğü Takip Uygulaması Version 1.0";
            // 
            // pictureExit
            // 
            pictureExit.Image = (Image)resources.GetObject("pictureExit.Image");
            pictureExit.Location = new Point(1716, 59);
            pictureExit.Name = "pictureExit";
            pictureExit.Size = new Size(56, 51);
            pictureExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureExit.TabIndex = 84;
            pictureExit.TabStop = false;
            pictureExit.Click += pictureExit_Click_1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Teal;
            label19.Location = new Point(1789, 34);
            label19.Name = "label19";
            label19.Size = new Size(0, 28);
            label19.TabIndex = 64;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(1778, 59);
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
            label15.Location = new Point(1759, 44);
            label15.Name = "label15";
            label15.Size = new Size(0, 28);
            label15.TabIndex = 81;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.White;
            label25.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Teal;
            label25.Location = new Point(1571, 153);
            label25.Name = "label25";
            label25.Size = new Size(109, 28);
            label25.TabIndex = 217;
            label25.Text = "Kullanıcılar";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureUser
            // 
            pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new Point(1491, 151);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(74, 59);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 216;
            pictureUser.TabStop = false;
            pictureUser.Click += pictureUser_Click;
            // 
            // pictureCategory
            // 
            pictureCategory.Image = (Image)resources.GetObject("pictureCategory.Image");
            pictureCategory.Location = new Point(1289, 153);
            pictureCategory.Name = "pictureCategory";
            pictureCategory.Size = new Size(89, 65);
            pictureCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCategory.TabIndex = 214;
            pictureCategory.TabStop = false;
            pictureCategory.Click += pictureCategory_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Teal;
            label23.Location = new Point(1374, 153);
            label23.Name = "label23";
            label23.Size = new Size(111, 28);
            label23.TabIndex = 215;
            label23.Text = "Kategoriler";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Teal;
            label24.Location = new Point(1499, 146);
            label24.Name = "label24";
            label24.Size = new Size(0, 28);
            label24.TabIndex = 213;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(1149, 138);
            label8.Name = "label8";
            label8.Size = new Size(0, 28);
            label8.TabIndex = 210;
            // 
            // pictureReport
            // 
            pictureReport.Image = (Image)resources.GetObject("pictureReport.Image");
            pictureReport.Location = new Point(1097, 153);
            pictureReport.Name = "pictureReport";
            pictureReport.Size = new Size(68, 57);
            pictureReport.SizeMode = PictureBoxSizeMode.Zoom;
            pictureReport.TabIndex = 211;
            pictureReport.TabStop = false;
            pictureReport.Click += pictureReport_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(1165, 153);
            label9.Name = "label9";
            label9.Size = new Size(118, 28);
            label9.TabIndex = 212;
            label9.Text = "Rapor Takip\r\n";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(771, 138);
            label10.Name = "label10";
            label10.Size = new Size(0, 28);
            label10.TabIndex = 202;
            // 
            // pictureStudent
            // 
            pictureStudent.Image = (Image)resources.GetObject("pictureStudent.Image");
            pictureStudent.Location = new Point(516, 159);
            pictureStudent.Name = "pictureStudent";
            pictureStudent.Size = new Size(77, 51);
            pictureStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStudent.TabIndex = 203;
            pictureStudent.TabStop = false;
            pictureStudent.Click += pictureStudent_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(599, 159);
            label11.Name = "label11";
            label11.Size = new Size(106, 28);
            label11.TabIndex = 204;
            label11.Text = "Öğrenciler";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Teal;
            label13.Location = new Point(969, 138);
            label13.Name = "label13";
            label13.Size = new Size(0, 28);
            label13.TabIndex = 205;
            // 
            // pictureTeam
            // 
            pictureTeam.Image = (Image)resources.GetObject("pictureTeam.Image");
            pictureTeam.Location = new Point(706, 138);
            pictureTeam.Name = "pictureTeam";
            pictureTeam.Size = new Size(89, 92);
            pictureTeam.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTeam.TabIndex = 206;
            pictureTeam.TabStop = false;
            pictureTeam.Click += pictureTeam_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(801, 153);
            label12.Name = "label12";
            label12.Size = new Size(87, 28);
            label12.TabIndex = 207;
            label12.Text = "Takımlar";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureStock
            // 
            pictureStock.Image = (Image)resources.GetObject("pictureStock.Image");
            pictureStock.Location = new Point(894, 153);
            pictureStock.Name = "pictureStock";
            pictureStock.Size = new Size(74, 57);
            pictureStock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStock.TabIndex = 208;
            pictureStock.TabStop = false;
            pictureStock.Click += pictureStock_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Teal;
            label14.Location = new Point(974, 153);
            label14.Name = "label14";
            label14.Size = new Size(117, 28);
            label14.TabIndex = 209;
            label14.Text = "Malzemeler";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1036);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 19);
            panel2.TabIndex = 218;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel2);
            Controls.Add(label25);
            Controls.Add(pictureUser);
            Controls.Add(pictureCategory);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label8);
            Controls.Add(pictureReport);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(pictureStudent);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(pictureTeam);
            Controls.Add(label12);
            Controls.Add(pictureStock);
            Controls.Add(label14);
            Controls.Add(panel1);
            Controls.Add(lblCategory);
            Controls.Add(btnNonFilter);
            Controls.Add(btnFilter);
            Controls.Add(label21);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtCategory);
            Controls.Add(label4);
            Controls.Add(dgvCategory);
            Controls.Add(label2);
            Name = "Categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategoriler Sayfası";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label21;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtCategory;
        private Label label4;
        private DataGridView dgvCategory;
        private Label label2;
        private Button btnNonFilter;
        private Button btnFilter;
        private Label lblCategory;
        private Panel panel1;
        private Label labelBack;
        private PictureBox pictureBack;
        private Label label7;
        private PictureBox pictureExit;
        private Label label19;
        private Label label16;
        private Label label15;
        private Label label25;
        private PictureBox pictureUser;
        private PictureBox pictureCategory;
        private Label label23;
        private Label label24;
        private Label label8;
        private PictureBox pictureReport;
        private Label label9;
        private Label label10;
        private PictureBox pictureStudent;
        private Label label11;
        private Label label13;
        private PictureBox pictureTeam;
        private Label label12;
        private PictureBox pictureStock;
        private Label label14;
        private Panel panel2;
    }
}