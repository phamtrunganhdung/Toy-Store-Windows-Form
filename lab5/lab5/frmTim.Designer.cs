namespace lab5
{
    partial class frmTim
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.CheckBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cbTen = new System.Windows.Forms.CheckBox();
            this.txtMSSV = new System.Windows.Forms.MaskedTextBox();
            this.cbMSSV = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(445, 288);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(273, 288);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 25;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboLop
            // 
            this.cboLop.Enabled = false;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK38",
            "CTK39",
            "CTK40",
            "CTK41",
            "CTK42",
            "CTK43"});
            this.cboLop.Location = new System.Drawing.Point(355, 234);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(191, 21);
            this.cboLop.TabIndex = 24;
            // 
            // cbLop
            // 
            this.cbLop.AutoSize = true;
            this.cbLop.Location = new System.Drawing.Point(257, 236);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(44, 17);
            this.cbLop.TabIndex = 23;
            this.cbLop.Text = "Lớp";
            this.cbLop.UseVisualStyleBackColor = true;
            this.cbLop.CheckedChanged += new System.EventHandler(this.cbLop_CheckedChanged);
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(355, 199);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(191, 20);
            this.txtTen.TabIndex = 22;
            // 
            // cbTen
            // 
            this.cbTen.AutoSize = true;
            this.cbTen.Location = new System.Drawing.Point(257, 201);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(45, 17);
            this.cbTen.TabIndex = 21;
            this.cbTen.Text = "Tên";
            this.cbTen.UseVisualStyleBackColor = true;
            this.cbTen.CheckedChanged += new System.EventHandler(this.cbTen_CheckedChanged);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Enabled = false;
            this.txtMSSV.Location = new System.Drawing.Point(355, 163);
            this.txtMSSV.Mask = "0000000";
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(191, 20);
            this.txtMSSV.TabIndex = 20;
            // 
            // cbMSSV
            // 
            this.cbMSSV.AutoSize = true;
            this.cbMSSV.Location = new System.Drawing.Point(257, 165);
            this.cbMSSV.Name = "cbMSSV";
            this.cbMSSV.Size = new System.Drawing.Size(56, 17);
            this.cbMSSV.TabIndex = 19;
            this.cbMSSV.Text = "MSSV";
            this.cbMSSV.UseVisualStyleBackColor = true;
            this.cbMSSV.CheckedChanged += new System.EventHandler(this.cbMSSV_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chọn tiêu chí tìm kiếm";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.cbTen);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.cbMSSV);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.CheckBox cbLop;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.CheckBox cbTen;
        private System.Windows.Forms.MaskedTextBox txtMSSV;
        private System.Windows.Forms.CheckBox cbMSSV;
        private System.Windows.Forms.Label label1;
    }
}