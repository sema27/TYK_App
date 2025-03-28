namespace TYK_App
{
    partial class ReportMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMenu));
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            btnStudentTeamReport = new Button();
            btnFinalistReport = new Button();
            panel2 = new Panel();
            button1 = new Button();
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
            panel1.TabIndex = 3;
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
            label1.Location = new Point(604, 81);
            label1.Name = "label1";
            label1.Size = new Size(653, 28);
            label1.TabIndex = 1;
            label1.Text = "Teknoloji Yarışmaları Koordinatörlüğü Takip Uygulaması Version 1.0";
            // 
            // btnStudentTeamReport
            // 
            btnStudentTeamReport.BackColor = Color.Teal;
            btnStudentTeamReport.FlatStyle = FlatStyle.Flat;
            btnStudentTeamReport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentTeamReport.ForeColor = Color.White;
            btnStudentTeamReport.Location = new Point(693, 472);
            btnStudentTeamReport.Name = "btnStudentTeamReport";
            btnStudentTeamReport.Size = new Size(483, 188);
            btnStudentTeamReport.TabIndex = 95;
            btnStudentTeamReport.Text = "İstatistik Raporları";
            btnStudentTeamReport.UseVisualStyleBackColor = false;
            btnStudentTeamReport.Click += btnStudentTeamReport_Click;
            // 
            // btnFinalistReport
            // 
            btnFinalistReport.BackColor = Color.Teal;
            btnFinalistReport.FlatStyle = FlatStyle.Flat;
            btnFinalistReport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinalistReport.ForeColor = Color.White;
            btnFinalistReport.Location = new Point(693, 231);
            btnFinalistReport.Name = "btnFinalistReport";
            btnFinalistReport.Size = new Size(483, 188);
            btnFinalistReport.TabIndex = 94;
            btnFinalistReport.Text = "Takım Finalist Raporu";
            btnFinalistReport.UseVisualStyleBackColor = false;
            btnFinalistReport.Click += btnFinalistReport_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1042);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 13);
            panel2.TabIndex = 97;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(693, 728);
            button1.Name = "button1";
            button1.Size = new Size(483, 188);
            button1.TabIndex = 98;
            button1.Text = "Yarışma Takvimi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ReportMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(btnStudentTeamReport);
            Controls.Add(btnFinalistReport);
            Controls.Add(panel1);
            Name = "ReportMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raporlar Menüsü";
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
        private Button btnStudentTeamReport;
        private Button btnFinalistReport;
        private Panel panel2;
        private Button button1;
    }
}