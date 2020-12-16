using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace lab5
{
    public partial class frmThongTinSV : Form
    {
        QuanLySinhVien qlsv;
        private readonly List<SinhVien> dsSinhVien;
        public frmThongTinSV()
        {
            InitializeComponent();
        }

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> mh = new List<string>();
            sv.MaSo = this.mtxtMSSV.Text;
            sv.HoTenLot = this.txtHoTenlot.Text;
            sv.Ten = this.txtTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.Lop = this.cboLop.Text;
            sv.SoCMND = this.mtxtCMND.Text;
            sv.SoDT = this.mtxtSoDT.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.chklbMonHoc.Items.Count; i++)
                if (chklbMonHoc.GetItemChecked(i))
                    mh.Add(chklbMonHoc.Items[i].ToString());
            sv.MonHocDangKy = mh;
            return sv;
        }

        private void LoadListView()
        {
            this.lvDSSV.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTenLot);
            lvitem.SubItems.Add(sv.Ten);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SoCMND);
            lvitem.SubItems.Add(sv.SoDT);
            lvitem.SubItems.Add(sv.DiaChi);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string mh = " ";
            foreach (string s in sv.MonHocDangKy)
                mh += s + ",";
            mh = mh.Substring(0, mh.Length - 1);
            lvitem.SubItems.Add(mh);
            this.lvDSSV.Items.Add(lvitem);
        }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTenLot = lvitem.SubItems[1].Text;
            sv.Ten = lvitem.SubItems[2].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.SoCMND = lvitem.SubItems[5].Text;
            sv.SoDT = lvitem.SubItems[6].Text;
            sv.DiaChi = lvitem.SubItems[7].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[8].Text == "Nam")
                sv.GioiTinh = true;
            List<string> mh = new List<string>();
            string[] s = lvitem.SubItems[9].Text.Split(',');
            foreach (string t in s)
                mh.Add(t);
            sv.MonHocDangKy = mh;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MaSo;
            this.txtHoTenlot.Text = sv.HoTenLot;
            this.txtTen.Text = sv.Ten;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.cboLop.Text = sv.Lop;
            this.mtxtCMND.Text = sv.SoCMND;
            this.mtxtSoDT.Text = sv.SoDT;
            this.txtDiaChi.Text = sv.DiaChi;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;

            for (int i = 0; i < this.chklbMonHoc.Items.Count; i++)
                this.chklbMonHoc.SetItemChecked(i, false);

            foreach (string s in sv.MonHocDangKy)
            {
                for (int i = 0; i < this.chklbMonHoc.Items.Count; i++)
                    if (s.CompareTo(this.chklbMonHoc.Items[i]) == 0)
                        this.chklbMonHoc.SetItemChecked(i, true);
            }
        }       
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void grbDSSV_Enter(object sender, EventArgs e)
        {

        }

        private void frmThongTinSV_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.qlsv.GhiFile();
                this.LoadListView();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                Application.Exit();

        }

        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDSSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvDSSV.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kqsua)
            {
                
                this.LoadListView();
            }
            this.qlsv.GhiFile();
            this.btnMacDinh.PerformClick();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            SinhVien sv = GetSinhVien();
            ListViewItem lvitem;
            count = this.lvDSSV.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvDSSV.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.qlsv.GhiFile();
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }

        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMSSV.Text = "";
            this.txtHoTenlot.Text = "";
            this.txtTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.cboLop.Text = "";
            this.mtxtCMND.Text = "";
            this.mtxtSoDT.Text = "";
            this.txtDiaChi.Text = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < this.chklbMonHoc.Items.Count - 1; i++)
                this.chklbMonHoc.SetItemChecked(i, false);

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTim frmTim = new frmTim();
            frmTim.Show();
        }
    }
}
