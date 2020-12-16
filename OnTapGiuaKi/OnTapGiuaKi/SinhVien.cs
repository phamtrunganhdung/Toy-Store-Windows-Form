using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapGiuaKi
{
    public class SinhVien
    {
        public string mssv { get; set; }
        public string hoTen { get; set; }
        public string ten { get; set; }
        public string cmnd { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
        public string lop { get; set; }
        public DateTime ngaySinh { get; set; }
        public bool gioiTinh { get; set; }
        public List<string> dsMonHoc { get; set; }
        public SinhVien()
        {
            dsMonHoc = new List<string>();
        }
        public SinhVien(string mssv, string hoten, string ten, string cmnd, string diachi, string sdt, string lop, DateTime ngaysinh, bool gioitinh, List<string> monhoc)
        {
            this.mssv = mssv;
            this.hoTen = hoten;
            this.ten = ten;
            this.cmnd = cmnd;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.lop = lop;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.dsMonHoc = monhoc;
        }
    }
    
}
