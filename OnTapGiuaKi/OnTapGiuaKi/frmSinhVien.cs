using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapGiuaKi
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien qlsv;
        private List<SinhVien> dssv;
        public frmSinhVien()
        {
            InitializeComponent();
        }
        public void LoadListView()
        {

            this.lvDSSV.Clear();
            foreach (var sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.mssv);
            lvitem.SubItems.Add(sv.hoTen);
            lvitem.SubItems.Add(sv.ten);
            lvitem.SubItems.Add(sv.ngaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.lop);
            lvitem.SubItems.Add(sv.cmnd);
            lvitem.SubItems.Add(sv.sdt);
            lvitem.SubItems.Add(sv.diaChi);
            string gt = "Nữ";
            if (sv.gioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string mh = " ";
            foreach (string s in sv.dsMonHoc)
                mh += s + ",";
            mh = mh.Substring(0, mh.Length - 1);
            lvitem.SubItems.Add(mh);
            this.lvDSSV.Items.Add(lvitem);
        }
        private sinhvien getsinhvien()
        {
            sinhvien sv = new sinhvien();
            list<string> monhoc = new list<string>();
            sv.mssv = this.mtxtmssv.text;
            sv.hoten = this.txthotenlot.text;
            sv.ten = this.txtten.text;
            sv.ngaysinh = this.dtpngaysinh.value;
            sv.lop = this.cbolop.text;
            sv.sdt = this.mtxtsodt.text;
            sv.cmnd = this.mtxtcmnd.text;
            sv.diachi = this.txtdiachi.text;
            sv.gioitinh = true;
            if (rdnu.checked)
                sv.gioitinh = false;
                for (int i = 0; i < chklbmonhoc.items.count; i++)
                {
                    if (chklbmonhoc.getitemchecked(i))
                    {
                        monhoc.add(chklbmonhoc.items[i].tostring());
                    }
                    sv.dsmonhoc = monhoc;
                }
                return sv;
                }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.mssv = lvitem.SubItems[0].Text;
            sv.hoTen = lvitem.SubItems[1].Text;
            sv.ten = lvitem.SubItems[2].Text;
            sv.ngaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.lop = lvitem.SubItems[4].Text;
            sv.cmnd = lvitem.SubItems[5].Text;
            sv.sdt = lvitem.SubItems[6].Text;
            sv.diaChi = lvitem.SubItems[7].Text;
            sv.gioiTinh = false;
            if (lvitem.SubItems[8].Text == "Nam")
                sv.gioiTinh = true;
            List<string> mh = new List<string>();
            string[] s = lvitem.SubItems[9].Text.Split(',');
            foreach (string t in s)
                mh.Add(t);
            sv.dsMonHoc = mh;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.mssv;
            this.txtHoTenlot.Text = sv.hoTen;
            this.txtTen.Text = sv.ten;
            this.dtpNgaySinh.Value = sv.ngaySinh;
            this.cboLop.Text = sv.lop;
            this.mtxtCMND.Text = sv.cmnd;
            this.mtxtSoDT.Text = sv.sdt;
            this.txtDiaChi.Text = sv.diaChi;
            if (sv.gioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;

            for (int i = 0; i < this.chklbMonHoc.Items.Count; i++)
                this.chklbMonHoc.SetItemChecked(i, false);

            foreach (string s in sv.dsMonHoc)
            {
                for (int i = 0; i < this.chklbMonHoc.Items.Count; i++)
                    if (s.CompareTo(this.chklbMonHoc.Items[i]) == 0)
                        this.chklbMonHoc.SetItemChecked(i, true);
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }
    }
}
