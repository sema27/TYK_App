namespace TYK_App
{
    partial class FilterCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterCalendar));
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            txtCompetition = new TextBox();
            label4 = new Label();
            btnFilter = new Button();
            label2 = new Label();
            txtLocation = new TextBox();
            label6 = new Label();
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
            panel1.TabIndex = 4;
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
            // txtCompetition
            // 
            txtCompetition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompetition.Location = new Point(72, 316);
            txtCompetition.Name = "txtCompetition";
            txtCompetition.Size = new Size(323, 34);
            txtCompetition.TabIndex = 163;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(72, 285);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 162;
            label4.Text = "Yarışma";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(308, 414);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(135, 43);
            btnFilter.TabIndex = 161;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(291, 170);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 160;
            label2.Text = "Filreleme Sayfası";
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLocation.Location = new Point(421, 316);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(323, 34);
            txtLocation.TabIndex = 169;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(421, 285);
            label6.Name = "label6";
            label6.Size = new Size(40, 28);
            label6.TabIndex = 168;
            label6.Text = "Yer";
            // 
            // FilterCalendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 614);
            Controls.Add(txtLocation);
            Controls.Add(label6);
            Controls.Add(txtCompetition);
            Controls.Add(label4);
            Controls.Add(btnFilter);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilterCalendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FilterCalendar";
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
        private TextBox txtCompetition;
        private Label label4;
        private Button btnFilter;
        private Label label2;
        private TextBox txtLocation;
        private Label label6;
    }
}