namespace TYK_App
{
    partial class FilterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterUser));
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            btnFilter = new Button();
            label2 = new Label();
            cboUserRole = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(labelBack);
            panel1.Controls.Add(pictureBack);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 3;
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.ForeColor = Color.White;
            labelBack.Location = new Point(65, 28);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(96, 28);
            labelBack.TabIndex = 4;
            labelBack.Text = "Geri Dön";
            labelBack.Click += labelBack_Click;
            // 
            // pictureBack
            // 
            pictureBack.Image = (Image)resources.GetObject("pictureBack.Image");
            pictureBack.Location = new Point(19, 28);
            pictureBack.Name = "pictureBack";
            pictureBack.Size = new Size(40, 42);
            pictureBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBack.TabIndex = 3;
            pictureBack.TabStop = false;
            pictureBack.Click += pictureBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 83);
            label1.Name = "label1";
            label1.Size = new Size(653, 28);
            label1.TabIndex = 2;
            label1.Text = "Teknoloji Yarışmaları Koordinatörlüğü Takip Uygulaması Version 1.0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 595);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 19);
            panel2.TabIndex = 155;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(428, 261);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 161;
            label3.Text = "Kullanıcı Adı";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(428, 292);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(323, 34);
            txtUsername.TabIndex = 160;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(51, 261);
            label4.Name = "label4";
            label4.Size = new Size(133, 28);
            label4.TabIndex = 158;
            label4.Text = "Kullanıcı Rolü";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(331, 389);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(135, 43);
            btnFilter.TabIndex = 157;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(294, 148);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 156;
            label2.Text = "Filreleme Sayfası";
            // 
            // cboUserRole
            // 
            cboUserRole.FormattingEnabled = true;
            cboUserRole.Location = new Point(51, 292);
            cboUserRole.Name = "cboUserRole";
            cboUserRole.Size = new Size(287, 28);
            cboUserRole.TabIndex = 162;
            // 
            // FilterUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 614);
            Controls.Add(cboUserRole);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(btnFilter);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FilterUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelBack;
        private PictureBox pictureBack;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private Button btnFilter;
        private Label label2;
        private ComboBox cboUserRole;
    }
}