namespace TYK_App
{
    partial class FilterFixedStock
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterFixedStock));
			panel1 = new Panel();
			labelBack = new Label();
			pictureBack = new PictureBox();
			label1 = new Label();
			btnFilter = new Button();
			label2 = new Label();
			cboStockArea = new ComboBox();
			txtStockFeature = new TextBox();
			txtStockNo = new TextBox();
			label8 = new Label();
			label5 = new Label();
			label6 = new Label();
			txtStockName = new TextBox();
			label4 = new Label();
			panel2 = new Panel();
			txtStockNumber = new TextBox();
			label17 = new Label();
			txtSerialNo = new TextBox();
			label3 = new Label();
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
			panel1.TabIndex = 1;
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
			label1.Location = new Point(49, 82);
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
			btnFilter.Location = new Point(332, 487);
			btnFilter.Name = "btnFilter";
			btnFilter.Size = new Size(125, 34);
			btnFilter.TabIndex = 123;
			btnFilter.Text = "Filtrele";
			btnFilter.UseVisualStyleBackColor = false;
			btnFilter.Click += btnFilter_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Teal;
			label2.Location = new Point(302, 149);
			label2.Name = "label2";
			label2.Size = new Size(172, 28);
			label2.TabIndex = 106;
			label2.Text = "Filreleme Sayfası";
			// 
			// cboStockArea
			// 
			cboStockArea.FormattingEnabled = true;
			cboStockArea.Location = new Point(49, 427);
			cboStockArea.Name = "cboStockArea";
			cboStockArea.Size = new Size(323, 28);
			cboStockArea.TabIndex = 141;
			// 
			// txtStockFeature
			// 
			txtStockFeature.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtStockFeature.Location = new Point(433, 334);
			txtStockFeature.Name = "txtStockFeature";
			txtStockFeature.Size = new Size(323, 34);
			txtStockFeature.TabIndex = 140;
			// 
			// txtStockNo
			// 
			txtStockNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtStockNo.Location = new Point(49, 334);
			txtStockNo.Name = "txtStockNo";
			txtStockNo.Size = new Size(323, 34);
			txtStockNo.TabIndex = 139;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label8.ForeColor = Color.Teal;
			label8.Location = new Point(433, 303);
			label8.Name = "label8";
			label8.Size = new Size(79, 28);
			label8.TabIndex = 138;
			label8.Text = "Özelliği";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = Color.Teal;
			label5.Location = new Point(49, 303);
			label5.Name = "label5";
			label5.Size = new Size(148, 28);
			label5.TabIndex = 137;
			label5.Text = "Malzeme Kodu";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.Teal;
			label6.Location = new Point(49, 396);
			label6.Name = "label6";
			label6.Size = new Size(159, 28);
			label6.TabIndex = 136;
			label6.Text = "Bulunduğu Alan";
			// 
			// txtStockName
			// 
			txtStockName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtStockName.Location = new Point(49, 248);
			txtStockName.Name = "txtStockName";
			txtStockName.Size = new Size(323, 34);
			txtStockName.TabIndex = 133;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.Teal;
			label4.Location = new Point(49, 217);
			label4.Name = "label4";
			label4.Size = new Size(130, 28);
			label4.TabIndex = 132;
			label4.Text = "Malzeme Adı";
			// 
			// panel2
			// 
			panel2.BackColor = Color.Teal;
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 595);
			panel2.Name = "panel2";
			panel2.Size = new Size(800, 19);
			panel2.TabIndex = 142;
			// 
			// txtStockNumber
			// 
			txtStockNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtStockNumber.Location = new Point(433, 427);
			txtStockNumber.Name = "txtStockNumber";
			txtStockNumber.Size = new Size(323, 34);
			txtStockNumber.TabIndex = 144;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label17.ForeColor = Color.Teal;
			label17.Location = new Point(433, 396);
			label17.Name = "label17";
			label17.Size = new Size(55, 28);
			label17.TabIndex = 143;
			label17.Text = "Adet";
			// 
			// txtSerialNo
			// 
			txtSerialNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtSerialNo.Location = new Point(433, 248);
			txtSerialNo.Name = "txtSerialNo";
			txtSerialNo.Size = new Size(323, 34);
			txtSerialNo.TabIndex = 146;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Teal;
			label3.Location = new Point(433, 217);
			label3.Name = "label3";
			label3.Size = new Size(138, 28);
			label3.TabIndex = 145;
			label3.Text = "Seri Numarası";
			// 
			// FilterFixedStock
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(800, 614);
			Controls.Add(txtSerialNo);
			Controls.Add(label3);
			Controls.Add(txtStockNumber);
			Controls.Add(label17);
			Controls.Add(panel2);
			Controls.Add(cboStockArea);
			Controls.Add(txtStockFeature);
			Controls.Add(txtStockNo);
			Controls.Add(label8);
			Controls.Add(label5);
			Controls.Add(label6);
			Controls.Add(txtStockName);
			Controls.Add(label4);
			Controls.Add(btnFilter);
			Controls.Add(label2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FilterFixedStock";
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
        private Button btnFilter;
        private Label label2;
        private ComboBox cboStockArea;
        private TextBox txtStockFeature;
        private TextBox txtStockNo;
        private Label label8;
        private Label label5;
        private Label label6;
        private TextBox txtStockName;
        private Label label4;
        private Panel panel2;
        private TextBox txtStockNumber;
        private Label label17;
		private TextBox txtSerialNo;
		private Label label3;
	}
}