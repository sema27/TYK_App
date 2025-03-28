namespace TYK_App
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btnYonetici = new Button();
            btnPersonel = new Button();
            btnYetkiliPersonel = new Button();
            lblRole = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            txtPassword = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(btnYonetici);
            panel1.Controls.Add(btnPersonel);
            panel1.Controls.Add(btnYetkiliPersonel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 1055);
            panel1.TabIndex = 27;
            // 
            // btnYonetici
            // 
            btnYonetici.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYonetici.ForeColor = Color.Teal;
            btnYonetici.Location = new Point(35, 281);
            btnYonetici.Name = "btnYonetici";
            btnYonetici.Size = new Size(204, 118);
            btnYonetici.TabIndex = 2;
            btnYonetici.Text = "Yönetici Girişi";
            btnYonetici.UseVisualStyleBackColor = true;
            // 
            // btnPersonel
            // 
            btnPersonel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPersonel.ForeColor = Color.Teal;
            btnPersonel.Location = new Point(35, 685);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(204, 123);
            btnPersonel.TabIndex = 1;
            btnPersonel.Text = "Personel Girişi";
            btnPersonel.UseVisualStyleBackColor = true;
            // 
            // btnYetkiliPersonel
            // 
            btnYetkiliPersonel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYetkiliPersonel.ForeColor = Color.Teal;
            btnYetkiliPersonel.Location = new Point(35, 487);
            btnYetkiliPersonel.Name = "btnYetkiliPersonel";
            btnYetkiliPersonel.Size = new Size(204, 116);
            btnYetkiliPersonel.TabIndex = 0;
            btnYetkiliPersonel.Text = "Yetkili Personel Girişi";
            btnYetkiliPersonel.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.ForeColor = Color.Teal;
            lblRole.Location = new Point(991, 364);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(0, 50);
            lblRole.TabIndex = 37;
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1048, 431);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(682, 88);
            label1.Name = "label1";
            label1.Size = new Size(861, 124);
            label1.TabIndex = 35;
            label1.Text = "Teknoloji Yarışmaları Koordinatörlüğü\r\n Takip Uygulaması";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Teal;
            btnLogin.Location = new Point(1039, 802);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 73);
            btnLogin.TabIndex = 34;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(938, 698);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 33;
            label3.Text = "Şifre";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(938, 729);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(386, 34);
            txtPassword.TabIndex = 32;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(938, 641);
            txtName.Name = "txtName";
            txtName.Size = new Size(386, 34);
            txtName.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(938, 610);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 30;
            label2.Text = "Kullanıcı Adı";
            // 
            // Login
            // 
            AccessibleName = "Giriş Sayfası";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(lblRole);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Sayfası";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnYonetici;
        private Button btnPersonel;
        private Button btnYetkiliPersonel;
        private Label lblRole;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnLogin;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtName;
        private Label label2;
    }
}