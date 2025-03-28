namespace TYK_App
{
    partial class FilterReportTracing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterReportTracing));
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            cboCategory = new ComboBox();
            cboFinalist = new ComboBox();
            label2 = new Label();
            cboAppealed = new ComboBox();
            label17 = new Label();
            cboReportResult = new ComboBox();
            txtCaptain = new TextBox();
            txtTeam = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            btnFilter = new Button();
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
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(23, 216);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(323, 28);
            cboCategory.TabIndex = 176;
            // 
            // cboFinalist
            // 
            cboFinalist.FormattingEnabled = true;
            cboFinalist.Location = new Point(433, 391);
            cboFinalist.Name = "cboFinalist";
            cboFinalist.Size = new Size(323, 28);
            cboFinalist.TabIndex = 175;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(435, 360);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 174;
            label2.Text = "Finalist Durumu";
            // 
            // cboAppealed
            // 
            cboAppealed.FormattingEnabled = true;
            cboAppealed.Location = new Point(433, 308);
            cboAppealed.Name = "cboAppealed";
            cboAppealed.Size = new Size(323, 28);
            cboAppealed.TabIndex = 173;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Teal;
            label17.Location = new Point(433, 277);
            label17.Name = "label17";
            label17.Size = new Size(137, 28);
            label17.TabIndex = 172;
            label17.Text = "İtiraz Durumu";
            // 
            // cboReportResult
            // 
            cboReportResult.FormattingEnabled = true;
            cboReportResult.Location = new Point(433, 229);
            cboReportResult.Name = "cboReportResult";
            cboReportResult.Size = new Size(323, 28);
            cboReportResult.TabIndex = 171;
            // 
            // txtCaptain
            // 
            txtCaptain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCaptain.Location = new Point(23, 384);
            txtCaptain.Name = "txtCaptain";
            txtCaptain.Size = new Size(323, 34);
            txtCaptain.TabIndex = 170;
            // 
            // txtTeam
            // 
            txtTeam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTeam.Location = new Point(23, 302);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(323, 34);
            txtTeam.TabIndex = 169;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(23, 353);
            label8.Name = "label8";
            label8.Size = new Size(139, 28);
            label8.TabIndex = 168;
            label8.Text = "Takım Kaptanı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(23, 271);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 167;
            label5.Text = "Takım";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(433, 198);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 166;
            label6.Text = "Rapor Sonucu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(23, 185);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 165;
            label4.Text = "Kategori";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(315, 473);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(125, 34);
            btnFilter.TabIndex = 177;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // FilterReportTracing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 614);
            Controls.Add(btnFilter);
            Controls.Add(cboCategory);
            Controls.Add(cboFinalist);
            Controls.Add(label2);
            Controls.Add(cboAppealed);
            Controls.Add(label17);
            Controls.Add(cboReportResult);
            Controls.Add(txtCaptain);
            Controls.Add(txtTeam);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilterReportTracing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FilterReportTracing";
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
        private ComboBox cboCategory;
        private ComboBox cboFinalist;
        private Label label2;
        private ComboBox cboAppealed;
        private Label label17;
        private ComboBox cboReportResult;
        private TextBox txtCaptain;
        private TextBox txtTeam;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Button btnFilter;
    }
}