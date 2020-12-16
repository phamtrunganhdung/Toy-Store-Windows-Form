namespace RestaurantManagementProject
{
    partial class FoodForm
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
            this.grbchucnang = new System.Windows.Forms.GroupBox();
            this.grbDMTA = new System.Windows.Forms.GroupBox();
            this.lblthongke = new System.Windows.Forms.Label();
            this.lbldongia = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.lbldonvi = new System.Windows.Forms.Label();
            this.lblloai = new System.Windows.Forms.Label();
            this.lblnote = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lsvFood = new System.Windows.Forms.ListView();
            this.clhSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDonvi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhghichu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xemDanhSáchBànĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbchucnang.SuspendLayout();
            this.grbDMTA.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbchucnang
            // 
            this.grbchucnang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbchucnang.Controls.Add(this.btnDelete);
            this.grbchucnang.Controls.Add(this.btnUpdate);
            this.grbchucnang.Controls.Add(this.btnAdd);
            this.grbchucnang.Controls.Add(this.btnClear);
            this.grbchucnang.Controls.Add(this.txtNotes);
            this.grbchucnang.Controls.Add(this.cbbCategory);
            this.grbchucnang.Controls.Add(this.txtPrice);
            this.grbchucnang.Controls.Add(this.txtUnit);
            this.grbchucnang.Controls.Add(this.txtName);
            this.grbchucnang.Controls.Add(this.lblnote);
            this.grbchucnang.Controls.Add(this.lblloai);
            this.grbchucnang.Controls.Add(this.lbldonvi);
            this.grbchucnang.Controls.Add(this.lblten);
            this.grbchucnang.Controls.Add(this.lbldongia);
            this.grbchucnang.Location = new System.Drawing.Point(12, 47);
            this.grbchucnang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbchucnang.Name = "grbchucnang";
            this.grbchucnang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbchucnang.Size = new System.Drawing.Size(532, 501);
            this.grbchucnang.TabIndex = 0;
            this.grbchucnang.TabStop = false;
            this.grbchucnang.Text = "Chức năng";
            // 
            // grbDMTA
            // 
            this.grbDMTA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDMTA.Controls.Add(this.lsvFood);
            this.grbDMTA.Location = new System.Drawing.Point(550, 47);
            this.grbDMTA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDMTA.Name = "grbDMTA";
            this.grbDMTA.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDMTA.Size = new System.Drawing.Size(627, 452);
            this.grbDMTA.TabIndex = 1;
            this.grbDMTA.TabStop = false;
            this.grbDMTA.Text = "Danh mục thức ăn";
            // 
            // lblthongke
            // 
            this.lblthongke.AutoSize = true;
            this.lblthongke.Location = new System.Drawing.Point(563, 521);
            this.lblthongke.Name = "lblthongke";
            this.lblthongke.Size = new System.Drawing.Size(52, 14);
            this.lblthongke.TabIndex = 2;
            this.lblthongke.Text = "Thống kê";
            // 
            // lbldongia
            // 
            this.lbldongia.AutoSize = true;
            this.lbldongia.Location = new System.Drawing.Point(21, 150);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(43, 14);
            this.lbldongia.TabIndex = 3;
            this.lbldongia.Text = "Đơn giá";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(21, 42);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(79, 14);
            this.lblten.TabIndex = 3;
            this.lblten.Text = "Tên thực phẩm";
            // 
            // lbldonvi
            // 
            this.lbldonvi.AutoSize = true;
            this.lbldonvi.Location = new System.Drawing.Point(21, 97);
            this.lbldonvi.Name = "lbldonvi";
            this.lbldonvi.Size = new System.Drawing.Size(61, 14);
            this.lbldonvi.TabIndex = 4;
            this.lbldonvi.Text = "Đơn vị tính";
            // 
            // lblloai
            // 
            this.lblloai.AutoSize = true;
            this.lblloai.Location = new System.Drawing.Point(21, 211);
            this.lblloai.Name = "lblloai";
            this.lblloai.Size = new System.Drawing.Size(81, 14);
            this.lblloai.TabIndex = 5;
            this.lblloai.Text = "Loại thực phẩm";
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Location = new System.Drawing.Point(21, 274);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(42, 14);
            this.lblnote.TabIndex = 6;
            this.lblnote.Text = "Ghi chú";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(321, 90);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(173, 20);
            this.txtUnit.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(321, 150);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(173, 20);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Text = "0";
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(135, 202);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(357, 22);
            this.cbbCategory.TabIndex = 10;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(135, 267);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(357, 166);
            this.txtNotes.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(39, 451);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Nhập lại";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(161, 451);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(290, 451);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 451);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lsvFood
            // 
            this.lsvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhSTT,
            this.clhTen,
            this.clhDonvi,
            this.clhGia,
            this.clhLoai,
            this.clhghichu});
            this.lsvFood.FullRowSelect = true;
            this.lsvFood.GridLines = true;
            this.lsvFood.Location = new System.Drawing.Point(7, 19);
            this.lsvFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvFood.MultiSelect = false;
            this.lsvFood.Name = "lsvFood";
            this.lsvFood.Size = new System.Drawing.Size(614, 425);
            this.lsvFood.TabIndex = 0;
            this.lsvFood.UseCompatibleStateImageBehavior = false;
            this.lsvFood.View = System.Windows.Forms.View.Details;
            this.lsvFood.SelectedIndexChanged += new System.EventHandler(this.lsvFood_SelectedIndexChanged);
            this.lsvFood.Click += new System.EventHandler(this.lsvFood_Click);
            // 
            // clhSTT
            // 
            this.clhSTT.Text = "STT";
            this.clhSTT.Width = 56;
            // 
            // clhTen
            // 
            this.clhTen.Text = "Tên thực phẩm";
            this.clhTen.Width = 147;
            // 
            // clhDonvi
            // 
            this.clhDonvi.Text = "ĐVT";
            this.clhDonvi.Width = 94;
            // 
            // clhGia
            // 
            this.clhGia.Text = "Giá";
            this.clhGia.Width = 103;
            // 
            // clhLoai
            // 
            this.clhLoai.Text = "Loại thực phẩm";
            this.clhLoai.Width = 114;
            // 
            // clhghichu
            // 
            this.clhghichu.Text = "Ghi chú";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1096, 516);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 24);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemDanhSáchBànĂnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xemDanhSáchBànĂnToolStripMenuItem
            // 
            this.xemDanhSáchBànĂnToolStripMenuItem.Name = "xemDanhSáchBànĂnToolStripMenuItem";
            this.xemDanhSáchBànĂnToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.xemDanhSáchBànĂnToolStripMenuItem.Text = "Xem danh sách bàn ăn";
            this.xemDanhSáchBànĂnToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchBànĂnToolStripMenuItem_Click_1);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 561);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblthongke);
            this.Controls.Add(this.grbDMTA);
            this.Controls.Add(this.grbchucnang);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm-xóa-sửa bảng FOOD";
            this.Load += new System.EventHandler(this.FoodForm_Load);
            this.grbchucnang.ResumeLayout(false);
            this.grbchucnang.PerformLayout();
            this.grbDMTA.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbchucnang;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.Label lblloai;
        private System.Windows.Forms.Label lbldonvi;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lbldongia;
        private System.Windows.Forms.GroupBox grbDMTA;
        private System.Windows.Forms.ListView lsvFood;
        private System.Windows.Forms.ColumnHeader clhSTT;
        private System.Windows.Forms.ColumnHeader clhTen;
        private System.Windows.Forms.ColumnHeader clhDonvi;
        private System.Windows.Forms.ColumnHeader clhGia;
        private System.Windows.Forms.ColumnHeader clhLoai;
        private System.Windows.Forms.ColumnHeader clhghichu;
        private System.Windows.Forms.Label lblthongke;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchBànĂnToolStripMenuItem;
    }
}

