namespace RestaurantManagementProject
{
    partial class TableForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbltrangthai = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.lblsucchua = new System.Windows.Forms.Label();
            this.lblthongke = new System.Windows.Forms.Label();
            this.grbDMTA = new System.Windows.Forms.GroupBox();
            this.lsvTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbchucnang = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbDMTA.SuspendLayout();
            this.grbchucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1096, 503);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 24);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(410, 205);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(281, 205);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(152, 205);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(30, 205);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Nhập lại";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(321, 150);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(173, 20);
            this.txtCapacity.TabIndex = 9;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(321, 90);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(173, 20);
            this.txtStatus.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 20);
            this.txtName.TabIndex = 7;
            // 
            // lbltrangthai
            // 
            this.lbltrangthai.AutoSize = true;
            this.lbltrangthai.Location = new System.Drawing.Point(21, 97);
            this.lbltrangthai.Name = "lbltrangthai";
            this.lbltrangthai.Size = new System.Drawing.Size(55, 13);
            this.lbltrangthai.TabIndex = 4;
            this.lbltrangthai.Text = "Trạng thái";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(21, 42);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(47, 13);
            this.lblten.TabIndex = 3;
            this.lblten.Text = "Tên bàn";
            // 
            // lblsucchua
            // 
            this.lblsucchua.AutoSize = true;
            this.lblsucchua.Location = new System.Drawing.Point(21, 150);
            this.lblsucchua.Name = "lblsucchua";
            this.lblsucchua.Size = new System.Drawing.Size(53, 13);
            this.lblsucchua.TabIndex = 3;
            this.lblsucchua.Text = "Sức chứa";
            // 
            // lblthongke
            // 
            this.lblthongke.AutoSize = true;
            this.lblthongke.Location = new System.Drawing.Point(563, 508);
            this.lblthongke.Name = "lblthongke";
            this.lblthongke.Size = new System.Drawing.Size(53, 13);
            this.lblthongke.TabIndex = 19;
            this.lblthongke.Text = "Thống kê";
            // 
            // grbDMTA
            // 
            this.grbDMTA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDMTA.Controls.Add(this.lsvTable);
            this.grbDMTA.Location = new System.Drawing.Point(550, 13);
            this.grbDMTA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDMTA.Name = "grbDMTA";
            this.grbDMTA.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDMTA.Size = new System.Drawing.Size(627, 281);
            this.grbDMTA.TabIndex = 18;
            this.grbDMTA.TabStop = false;
            this.grbDMTA.Text = "Danh sách bàn";
            // 
            // lsvTable
            // 
            this.lsvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvTable.GridLines = true;
            this.lsvTable.Location = new System.Drawing.Point(6, 13);
            this.lsvTable.Name = "lsvTable";
            this.lsvTable.Size = new System.Drawing.Size(615, 261);
            this.lsvTable.TabIndex = 0;
            this.lsvTable.UseCompatibleStateImageBehavior = false;
            this.lsvTable.View = System.Windows.Forms.View.Details;
            this.lsvTable.Click += new System.EventHandler(this.lsvTable_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên bàn";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trạng thái";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sức chứa";
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
            this.grbchucnang.Controls.Add(this.txtCapacity);
            this.grbchucnang.Controls.Add(this.txtStatus);
            this.grbchucnang.Controls.Add(this.txtName);
            this.grbchucnang.Controls.Add(this.lbltrangthai);
            this.grbchucnang.Controls.Add(this.lblten);
            this.grbchucnang.Controls.Add(this.lblsucchua);
            this.grbchucnang.Location = new System.Drawing.Point(12, 13);
            this.grbchucnang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbchucnang.Name = "grbchucnang";
            this.grbchucnang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbchucnang.Size = new System.Drawing.Size(532, 325);
            this.grbchucnang.TabIndex = 17;
            this.grbchucnang.TabStop = false;
            this.grbchucnang.Text = "Chức năng";
            this.grbchucnang.Enter += new System.EventHandler(this.grbchucnang_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thống kê";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1082, 306);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 24);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 351);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblthongke);
            this.Controls.Add(this.grbDMTA);
            this.Controls.Add(this.grbchucnang);
            this.Name = "TableForm";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.grbDMTA.ResumeLayout(false);
            this.grbchucnang.ResumeLayout(false);
            this.grbchucnang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbltrangthai;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lblsucchua;
        private System.Windows.Forms.Label lblthongke;
        private System.Windows.Forms.GroupBox grbDMTA;
        private System.Windows.Forms.GroupBox grbchucnang;
        private System.Windows.Forms.ListView lsvTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;

    }
}