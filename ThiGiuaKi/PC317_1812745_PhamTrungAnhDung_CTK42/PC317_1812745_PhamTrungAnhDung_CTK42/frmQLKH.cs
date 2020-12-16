using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC317_1812745_PhamTrungAnhDung_CTK42
{
    public partial class frmKhachHang : Form
    {
        QuanLyKhachHang qlkh;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private KhachHang GetKhachHang()
        {
            KhachHang kh = new KhachHang();
            List<string> mh = new List<string>();
            kh.maKH = this.mtxtMaKH.Text;
            kh.tenKH = this.txtTen.Text;
            kh.ngayMua = this.dtpNgayMua.Value;
            kh.soDienThoai = this.mtxtSDT.Text;
            kh.diaChi = this.txtDiaChi.Text;
            for (int i = 0; i < this.chklbMatHang.Items.Count; i++)
                if (chklbMatHang.GetItemChecked(i))
                    mh.Add(chklbMatHang.Items[i].ToString());
            kh.matHang = mh;
            return kh;
        }
        private void LoadListView()
        {
            this.lvDSKH.Items.Clear();
            foreach (KhachHang kh in qlkh.DanhSach)
            {
                ThemKH(kh);
            }
        }
        private void ThemKH(KhachHang kh)
        {
            ListViewItem lvitem = new ListViewItem(kh.maKH);
            lvitem.SubItems.Add(kh.tenKH);
            lvitem.SubItems.Add(kh.soDienThoai);
            lvitem.SubItems.Add(kh.diaChi);
            lvitem.SubItems.Add(kh.ngayMua.ToShortDateString());
            string mh = " ";
            foreach (string s in kh.matHang)
                mh += s + ",";
            mh = mh.Substring(0, mh.Length - 1);
            lvitem.SubItems.Add(mh);
            this.lvDSKH.Items.Add(lvitem);
        }
        private KhachHang GetKhachHangLV(ListViewItem lvitem)
        {
            KhachHang kh = new KhachHang();
            kh.maKH = lvitem.SubItems[0].Text;
            kh.tenKH = lvitem.SubItems[1].Text;
            kh.soDienThoai = lvitem.SubItems[2].Text;
            kh.diaChi = lvitem.SubItems[3].Text;
            kh.ngayMua = DateTime.Parse(lvitem.SubItems[4].Text);
            List<string> mh = new List<string>();
            string[] s = lvitem.SubItems[5].Text.Split(',');
            foreach (string t in s)
                mh.Add(t);
            kh.matHang = mh;
            return kh;
        }
        private void ThietLapThongTin(KhachHang kh)
        {
            this.mtxtMaKH.Text = kh.maKH;
            this.txtTen.Text = kh.tenKH;
            this.mtxtSDT.Text = kh.soDienThoai;
            this.txtDiaChi.Text = kh.diaChi;
            this.dtpNgayMua.Value = kh.ngayMua;
            for (int i = 0; i < this.chklbMatHang.Items.Count; i++)
                this.chklbMatHang.SetItemChecked(i, false);

            foreach (string s in kh.matHang)
            {
                for (int i = 0; i < this.chklbMatHang.Items.Count; i++)
                    if (s.CompareTo(this.chklbMatHang.Items[i]) == 0)
                        this.chklbMatHang.SetItemChecked(i, true);
            }
        }  
        private void Form1_Load(object sender, EventArgs e)
        {
            qlkh = new QuanLyKhachHang();
            qlkh.DocTuFile();
            LoadListView();
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            KhachHang sv = GetKhachHang();
            KhachHang kq = qlkh.Tim(sv.maKH, delegate(object obj1, object obj2)
            {
                return (obj2 as KhachHang).maKH.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Khách hàng đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlkh.Them(sv);
                this.qlkh.GhiFile();
                this.LoadListView();
            }
        }

        private void lvDSKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDSKH.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvDSKH.SelectedItems[0];
                KhachHang sv = GetKhachHangLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            KhachHang sv = obj2 as KhachHang;
            return sv.maKH.CompareTo(obj1);
        }
        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            KhachHang kh = GetKhachHang();
            bool kqsua;
            kqsua = qlkh.Sua(kh, kh.maKH, SoSanhTheoMa);
            if (kqsua)
            {

                this.LoadListView();
            }
            this.qlkh.GhiFile();
            this.btnMacDinh.PerformClick();
        }
        private void btnMacDinh_Click_1(object sender, EventArgs e)
        {
            this.mtxtMaKH.Text = "";
            this.txtTen.Text = "";
            this.dtpNgayMua.Value = DateTime.Now;
            this.mtxtSDT.Text = "";
            this.txtDiaChi.Text = "";
            for (int i = 0; i < this.chklbMatHang.Items.Count - 1; i++)
                this.chklbMatHang.SetItemChecked(i, false);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int count, i;
            KhachHang sv = GetKhachHang();
            ListViewItem lvitem;
            count = this.lvDSKH.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvDSKH.Items[i];
                if (lvitem.Checked)
                    qlkh.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.qlkh.GhiFile();
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }

        private void xemMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatHang mh = new MatHang();
            mh.Show();
        }

        private void xóaKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count, i;
            KhachHang sv = GetKhachHang();
            ListViewItem lvitem;
            count = this.lvDSKH.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvDSKH.Items[i];
                if (lvitem.Checked)
                    qlkh.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.qlkh.GhiFile();
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }
    }
}
