namespace TYK_App
{
    partial class FilterStockTracing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterStockTracing));
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            btnFilter = new Button();
            label2 = new Label();
            label7 = new Label();
            txtStudentNumber = new TextBox();
            txtStudentName = new TextBox();
            label8 = new Label();
            dtpReturnedDate = new DateTimePicker();
            dtpIssuedDate = new DateTimePicker();
            label3 = new Label();
            cboStockArea = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtStockName = new TextBox();
            label9 = new Label();
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
            panel1.Size = new Size(866, 125);
            panel1.TabIndex = 2;
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
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(367, 499);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(125, 34);
            btnFilter.TabIndex = 146;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(337, 161);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 145;
            label2.Text = "Filreleme Sayfası";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(491, 385);
            label7.Name = "label7";
            label7.Size = new Size(175, 28);
            label7.TabIndex = 206;
            label7.Text = "Öğrenci Numarası";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentNumber.Location = new Point(491, 416);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(323, 34);
            txtStudentNumber.TabIndex = 205;
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentName.Location = new Point(491, 343);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(323, 34);
            txtStudentName.TabIndex = 204;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(491, 312);
            label8.Name = "label8";
            label8.Size = new Size(192, 28);
            label8.TabIndex = 203;
            label8.Text = "Teslim Alan Öğrenci";
            // 
            // dtpReturnedDate
            // 
            dtpReturnedDate.CalendarMonthBackground = Color.White;
            dtpReturnedDate.Location = new Point(57, 423);
            dtpReturnedDate.Name = "dtpReturnedDate";
            dtpReturnedDate.Size = new Size(323, 27);
            dtpReturnedDate.TabIndex = 202;
            // 
            // dtpIssuedDate
            // 
            dtpIssuedDate.CalendarMonthBackground = Color.White;
            dtpIssuedDate.Location = new Point(57, 347);
            dtpIssuedDate.Name = "dtpIssuedDate";
            dtpIssuedDate.Size = new Size(323, 27);
            dtpIssuedDate.TabIndex = 201;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(57, 392);
            label3.Name = "label3";
            label3.Size = new Size(181, 28);
            label3.TabIndex = 200;
            label3.Text = "Teslim Alınan Tarih";
            // 
            // cboStockArea
            // 
            cboStockArea.FormattingEnabled = true;
            cboStockArea.Location = new Point(491, 267);
            cboStockArea.Name = "cboStockArea";
            cboStockArea.Size = new Size(323, 28);
            cboStockArea.TabIndex = 199;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(491, 236);
            label6.Name = "label6";
            label6.Size = new Size(159, 28);
            label6.TabIndex = 198;
            label6.Text = "Bulunduğu Alan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(57, 316);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 197;
            label5.Text = "Veriliş Tarihi";
            // 
            // txtStockName
            // 
            txtStockName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockName.Location = new Point(57, 268);
            txtStockName.Name = "txtStockName";
            txtStockName.Size = new Size(323, 34);
            txtStockName.TabIndex = 196;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(57, 237);
            label9.Name = "label9";
            label9.Size = new Size(130, 28);
            label9.TabIndex = 195;
            label9.Text = "Malzeme Adı";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 586);
            panel2.Name = "panel2";
            panel2.Size = new Size(866, 19);
            panel2.TabIndex = 207;
            // 
            // FilterStockTracing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(866, 605);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtStudentName);
            Controls.Add(label8);
            Controls.Add(dtpReturnedDate);
            Controls.Add(dtpIssuedDate);
            Controls.Add(label3);
            Controls.Add(cboStockArea);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtStockName);
            Controls.Add(label9);
            Controls.Add(btnFilter);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilterStockTracing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FilterStockTracing";
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
        private Button btnFilter;
        private Label label2;
        private Label label7;
        private TextBox txtStudentNumber;
        private TextBox txtStudentName;
        private Label label8;
        private DateTimePicker dtpReturnedDate;
        private DateTimePicker dtpIssuedDate;
        private Label label3;
        private ComboBox cboStockArea;
        private Label label6;
        private Label label5;
        private TextBox txtStockName;
        private Label label9;
        private Panel panel2;
    }
}