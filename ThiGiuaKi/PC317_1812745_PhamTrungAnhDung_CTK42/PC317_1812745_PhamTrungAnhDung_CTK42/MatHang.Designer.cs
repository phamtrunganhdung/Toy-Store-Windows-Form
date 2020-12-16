namespace PC317_1812745_PhamTrungAnhDung_CTK42
{
    partial class MatHang
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
            this.lvMatHang = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvMatHang
            // 
            this.lvMatHang.Location = new System.Drawing.Point(12, 68);
            this.lvMatHang.Name = "lvMatHang";
            this.lvMatHang.Size = new System.Drawing.Size(598, 262);
            this.lvMatHang.TabIndex = 0;
            this.lvMatHang.UseCompatibleStateImageBehavior = false;
            // 
            // MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 342);
            this.Controls.Add(this.lvMatHang);
            this.Name = "MatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MatHang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMatHang;
    }
}