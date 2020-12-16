using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1_Trang60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string phai;

            if (this.rdNam.Checked == true)
                phai = "Nam";
            else
                phai = "Nu";
            ListViewItem lvitem = new ListViewItem(new string[] { this.mtxtMaNV.Text, this.txtHoVaTen.Text, this.dtpNgaySinh.Text, phai, this.txtDiaChi.Text, this.txtEmail.Text, this.mtxtSDT.Text, this.cboPhongBan.Text, this.txtHinh.Text });
            this.lvDSNV.Items.Add(lvitem);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvDSNV.Items.Count; i++)
            {
                if (lvDSNV.Items[i].Selected)
                {
                    lvDSNV.Items.RemoveAt(i);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = 0;
            string a = "Nam";
            if (rdNu.Checked)
                a = "Nu";
            for (i = 0; i < lvDSNV.Items.Count; i++)
            {
                if (lvDSNV.Items[i].Text == mtxtMaNV.Text)
                {
                    lvDSNV.Items[i].SubItems[1].Text = txtHoVaTen.Text;
                    lvDSNV.Items[i].SubItems[2].Text = dtpNgaySinh.Text;
                    lvDSNV.Items[i].SubItems[3].Text = a;
                    lvDSNV.Items[i].SubItems[4].Text = txtDiaChi.Text;
                    lvDSNV.Items[i].SubItems[5].Text = txtEmail.Text;
                    lvDSNV.Items[i].SubItems[6].Text = mtxtSDT.Text;
                    lvDSNV.Items[i].SubItems[7].Text = cboPhongBan.Text;
                    lvDSNV.Items[i].SubItems[8].Text = txtHinh.Text;
                    return;
                }
            }
            ListViewItem item = new ListViewItem(new string[] { mtxtMaNV.Text, txtHoVaTen.Text, dtpNgaySinh.Text, a, txtDiaChi.Text, txtEmail.Text, mtxtSDT.Text, cboPhongBan.Text, txtHinh.Text });
            this.lvDSNV.Items.AddRange(new ListViewItem[] { item });
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        private void Reset()
        {
            this.mtxtMaNV.Text = "";
            this.txtHoVaTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cboPhongBan.Text = "";
            this.txtHinh.Text = "";
            this.rdNam.Checked = true;
            this.mtxtSDT.Text = "";
            this.txtEmail.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.openFiledlg = new OpenFileDialog();
            this.openFiledlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
                                 + "*.jpg;*.jpeg;*.gif;*.bmp;*.tif;*.tiff;*.png|"
                                 + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
                                 + "GIF files (*.gif)|*.gif| BMP files(*.bmp)|*.bmp|"
                                 + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
                                 + "PNG files (*.png)|*.png| All files (*.*)|*.*";
            if(this.openFiledlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                this.txtHinh.Text = this.openFiledlg.FileName.ToString();
                this.pbImage.ImageLocation = this.txtHinh.Text;
                this.pbImage.Image = new Bitmap(this.pbImage.ImageLocation);
                this.pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
