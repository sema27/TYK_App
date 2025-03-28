namespace TYK_App
{
    partial class FilterStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterStock));
            panel1 = new Panel();
            labelBack = new Label();
            pictureBack = new PictureBox();
            label1 = new Label();
            cboStockArea = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            txtStockNumber = new TextBox();
            txtStockName = new TextBox();
            label4 = new Label();
            btnFilter = new Button();
            label2 = new Label();
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
            panel1.Size = new Size(800, 125);
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
            // cboStockArea
            // 
            cboStockArea.FormattingEnabled = true;
            cboStockArea.Location = new Point(434, 357);
            cboStockArea.Name = "cboStockArea";
            cboStockArea.Size = new Size(323, 28);
            cboStockArea.TabIndex = 153;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(434, 326);
            label6.Name = "label6";
            label6.Size = new Size(159, 28);
            label6.TabIndex = 148;
            label6.Text = "Bulunduğu Alan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(55, 326);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 147;
            label3.Text = "Adet";
            // 
            // txtStockNumber
            // 
            txtStockNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockNumber.Location = new Point(55, 357);
            txtStockNumber.Name = "txtStockNumber";
            txtStockNumber.Size = new Size(323, 34);
            txtStockNumber.TabIndex = 146;
            // 
            // txtStockName
            // 
            txtStockName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockName.Location = new Point(239, 278);
            txtStockName.Name = "txtStockName";
            txtStockName.Size = new Size(323, 34);
            txtStockName.TabIndex = 145;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(239, 247);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 144;
            label4.Text = "Malzeme Adı";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.CornflowerBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(337, 437);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(135, 43);
            btnFilter.TabIndex = 143;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(300, 162);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 142;
            label2.Text = "Filreleme Sayfası";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 595);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 19);
            panel2.TabIndex = 154;
            // 
            // FilterStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 614);
            Controls.Add(panel2);
            Controls.Add(cboStockArea);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtStockNumber);
            Controls.Add(txtStockName);
            Controls.Add(label4);
            Controls.Add(btnFilter);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilterStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FilterStock";
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
        private ComboBox cboStockArea;
        private Label label6;
        private Label label3;
        private TextBox txtStockNumber;
        private TextBox txtStockName;
        private Label label4;
        private Button btnFilter;
        private Label label2;
        private Panel panel2;
    }
}