namespace TYK_App
{
    partial class StockMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMenu));
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            btnStock1 = new Button();
            btnStock2 = new Button();
            button2 = new Button();
            panel2 = new Panel();
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
            panel1.Size = new Size(1924, 125);
            panel1.TabIndex = 2;
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.ForeColor = Color.White;
            labelBack.Location = new Point(72, 45);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(96, 28);
            labelBack.TabIndex = 98;
            labelBack.Text = "Geri Dön";
            labelBack.Click += labelBack_Click;
            // 
            // pictureBack
            // 
            pictureBack.Image = (Image)resources.GetObject("pictureBack.Image");
            pictureBack.Location = new Point(26, 45);
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
            label1.Location = new Point(431, 76);
            label1.Name = "label1";
            label1.Size = new Size(653, 28);
            label1.TabIndex = 1;
            label1.Text = "Teknoloji Yarışmaları Koordinatörlüğü Takip Uygulaması Version 1.0";
            // 
            // btnStock1
            // 
            btnStock1.BackColor = Color.Teal;
            btnStock1.FlatStyle = FlatStyle.Flat;
            btnStock1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStock1.ForeColor = Color.White;
            btnStock1.Location = new Point(764, 306);
            btnStock1.Name = "btnStock1";
            btnStock1.Size = new Size(394, 175);
            btnStock1.TabIndex = 91;
            btnStock1.Text = "Demirbaş Listesi";
            btnStock1.UseVisualStyleBackColor = false;
            btnStock1.Click += btnStock1_Click;
            // 
            // btnStock2
            // 
            btnStock2.BackColor = Color.Teal;
            btnStock2.FlatStyle = FlatStyle.Flat;
            btnStock2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStock2.ForeColor = Color.White;
            btnStock2.Location = new Point(764, 545);
            btnStock2.Name = "btnStock2";
            btnStock2.Size = new Size(394, 175);
            btnStock2.TabIndex = 92;
            btnStock2.Text = "Malzemeler Listesi";
            btnStock2.UseVisualStyleBackColor = false;
            btnStock2.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(764, 779);
            button2.Name = "button2";
            button2.Size = new Size(394, 175);
            button2.TabIndex = 93;
            button2.Text = "Malzeme Takip Listesi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1042);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 13);
            panel2.TabIndex = 94;
            // 
            // StockMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(btnStock2);
            Controls.Add(btnStock1);
            Controls.Add(panel1);
            Name = "StockMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Malzemeler Menüsü";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelBack;
        private PictureBox pictureBack;
        private Label label1;
        private Button btnStock1;
        private Button btnStock2;
        private Button button2;
        private Panel panel2;
    }
}