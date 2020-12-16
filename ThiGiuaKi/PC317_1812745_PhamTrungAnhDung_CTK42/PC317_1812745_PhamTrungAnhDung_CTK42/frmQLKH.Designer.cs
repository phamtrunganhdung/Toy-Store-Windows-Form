namespace PC317_1812745_PhamTrungAnhDung_CTK42
{
    partial class frmKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtMaKH = new System.Windows.Forms.MaskedTextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgayMua = new System.Windows.Forms.DateTimePicker();
            this.chklbMatHang = new System.Windows.Forms.CheckedListBox();
            this.lvDSKH = new System.Windows.Forms.ListView();
            this.clhmakh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhtenkh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhdiachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhsdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhngaymua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhmathang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.ctms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày mua hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh sách các mặt hàng đã mua";
            // 
            // mtxtMaKH
            // 
            this.mtxtMaKH.Location = new System.Drawing.Point(157, 24);
            this.mtxtMaKH.Mask = "KH0000";
            this.mtxtMaKH.Name = "mtxtMaKH";
            this.mtxtMaKH.Size = new System.Drawing.Size(236, 22);
            this.mtxtMaKH.TabIndex = 6;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(157, 75);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(236, 22);
            this.txtTen.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(555, 27);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(236, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMua.Location = new System.Drawing.Point(157, 133);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(236, 22);
            this.dtpNgayMua.TabIndex = 11;
            // 
            // chklbMatHang
            // 
            this.chklbMatHang.FormattingEnabled = true;
            this.chklbMatHang.Items.AddRange(new object[] {
            "Áo khoác gió nam",
            "Áo khoác gió nữ",
            "Quần jean nam",
            "Quần jean nữ",
            "Áo thun nam",
            "Áo thun nữ",
            "Áo sơ mi nữ",
            "Váy ngắn",
            "Váy dài",
            "Set váy"});
            this.chklbMatHang.Location = new System.Drawing.Point(262, 207);
            this.chklbMatHang.Name = "chklbMatHang";
            this.chklbMatHang.Size = new System.Drawing.Size(529, 89);
            this.chklbMatHang.TabIndex = 12;
            // 
            // lvDSKH
            // 
            this.lvDSKH.CheckBoxes = true;
            this.lvDSKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhmakh,
            this.clhtenkh,
            this.clhdiachi,
            this.clhsdt,
            this.clhngaymua,
            this.clhmathang});
            this.lvDSKH.ContextMenuStrip = this.ctms1;
            this.lvDSKH.GridLines = true;
            this.lvDSKH.Location = new System.Drawing.Point(23, 363);
            this.lvDSKH.Name = "lvDSKH";
            this.lvDSKH.Size = new System.Drawing.Size(768, 225);
            this.lvDSKH.TabIndex = 13;
            this.lvDSKH.UseCompatibleStateImageBehavior = false;
            this.lvDSKH.View = System.Windows.Forms.View.Details;
            this.lvDSKH.SelectedIndexChanged += new System.EventHandler(this.lvDSKH_SelectedIndexChanged);
            // 
            // clhmakh
            // 
            this.clhmakh.Text = "Mã khách hàng";
            this.clhmakh.Width = 130;
            // 
            // clhtenkh
            // 
            this.clhtenkh.Text = "Tên khách hàng";
            this.clhtenkh.Width = 187;
            // 
            // clhdiachi
            // 
            this.clhdiachi.Text = "Địa chỉ";
            this.clhdiachi.Width = 195;
            // 
            // clhsdt
            // 
            this.clhsdt.Text = "Số điện thoại";
            this.clhsdt.Width = 136;
            // 
            // clhngaymua
            // 
            this.clhngaymua.Text = "Ngày mua";
            this.clhngaymua.Width = 129;
            // 
            // clhmathang
            // 
            this.clhmathang.Text = "Hàng đã mua";
            this.clhmathang.Width = 154;
            // 
            // ctms1
            // 
            this.ctms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemMặtHàngToolStripMenuItem,
            this.xóaKháchHàngToolStripMenuItem});
            this.ctms1.Name = "ctms1";
            this.ctms1.Size = new System.Drawing.Size(160, 48);
            // 
            // xemMặtHàngToolStripMenuItem
            // 
            this.xemMặtHàngToolStripMenuItem.Name = "xemMặtHàngToolStripMenuItem";
            this.xemMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.xemMặtHàngToolStripMenuItem.Text = "Xem mặt hàng";
            this.xemMặtHàngToolStripMenuItem.Click += new System.EventHandler(this.xemMặtHàngToolStripMenuItem_Click);
            // 
            // xóaKháchHàngToolStripMenuItem
            // 
            this.xóaKháchHàngToolStripMenuItem.Name = "xóaKháchHàngToolStripMenuItem";
            this.xóaKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.xóaKháchHàngToolStripMenuItem.Text = "Xóa khách hàng";
            this.xóaKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.xóaKháchHàngToolStripMenuItem_Click);
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(555, 75);
            this.mtxtSDT.Mask = "(999) 000-0000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(236, 22);
            this.mtxtSDT.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(262, 318);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(368, 318);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(489, 318);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(601, 318);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(75, 23);
            this.btnMacDinh.TabIndex = 18;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(716, 318);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(157, 318);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 600);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.lvDSKH);
            this.Controls.Add(this.chklbMatHang);
            this.Controls.Add(this.dtpNgayMua);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.mtxtMaKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ctms1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtMaKH;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgayMua;
        private System.Windows.Forms.CheckedListBox chklbMatHang;
        private System.Windows.Forms.ListView lvDSKH;
        private System.Windows.Forms.ColumnHeader clhmakh;
        private System.Windows.Forms.ColumnHeader clhtenkh;
        private System.Windows.Forms.ColumnHeader clhdiachi;
        private System.Windows.Forms.ColumnHeader clhsdt;
        private System.Windows.Forms.ColumnHeader clhngaymua;
        private System.Windows.Forms.ColumnHeader clhmathang;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ContextMenuStrip ctms1;
        private System.Windows.Forms.ToolStripMenuItem xemMặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaKháchHàngToolStripMenuItem;
        private System.Windows.Forms.Button btnTim;
    }
}

