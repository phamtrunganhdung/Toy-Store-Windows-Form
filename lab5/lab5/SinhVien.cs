using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTenLot { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public string SoCMND { get; set; }
        public string SoDT { get; set; }
        public bool GioiTinh { get; set; }
        public List<string> MonHocDangKy { get; set; }

        public SinhVien()
        {
            MonHocDangKy = new List<string>();
        }

        public SinhVien(string ms, string htl, string t, DateTime ngay,
        string dc, string lop, string cmnd, bool gt, string sdt, List<string> mh)
        {
            this.MaSo = ms;
            this.HoTenLot = htl;
            this.Ten = t;
            this.NgaySinh = ngay;
            this.Lop = lop;
            this.SoCMND = cmnd;
            this.SoDT = sdt;
            this.DiaChi = dc;
            this.GioiTinh = gt;
            this.MonHocDangKy = mh;
        }
    }
}
