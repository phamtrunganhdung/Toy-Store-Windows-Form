using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnTapGiuaKi
{
   public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }
        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }
        public SinhVien this [int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.DanhSach.RemoveAt(i);
        }
        public SinhVien Tim( object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in DanhSach)
            {
                if (ss(obj, sv) == 0)
                    svresult = sv;
                break;
            }
            return svresult;
        }
        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int i;
            int count = this.DanhSach.Count - 1;
            bool kq = false;
            for ( i = 0; i < count; i++)
            {
                if (ss(obj, this[i]) == 0)
                   this[i] = svsua;
                kq = true;
            }
            return kq;
        }
        public void DocTuFile()
        {
            string filename = @"../../DanhSachSV.txt", line;
            SinhVien sv;
            string[] s;
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            while((line = sr.ReadLine()) != null)
            {
                sv = new SinhVien();
                s = line.Split('\t');
                sv.mssv = s[0];
                sv.hoTen = s[1];
                sv.ten = s[2];
                sv.ngaySinh = DateTime.Parse(s[3]);
                sv.lop = s[4];
                sv.cmnd = s[5];
                sv.sdt = s[6];
                sv.diaChi = s[7];
                sv.gioiTinh = false;
                if (s[8] == "1")
                    sv.gioiTinh = true;
                string[] monhoc = s[9].Split(',');
                foreach (string mon in monhoc)
                    sv.dsMonHoc.Add(mon);
                this.Them(sv);
            }
            sr.Close();
        }
        public void GhiVaoFile()
        {
            string filename = @"../../DanhSachSV.txt";
            StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Open));
            foreach (var sv in DanhSach)
            {
                sw.Write(sv.mssv);
                sw.Write('\t');
                sw.Write(sv.hoTen);
                sw.Write("\t");
                sw.Write(sv.ten);
                sw.Write("\t");
                sw.Write(sv.ngaySinh.ToShortDateString());
                sw.Write("\t");
                sw.Write(sv.diaChi);
                sw.Write("\t");
                sw.Write(sv.lop);
                sw.Write("\t");
                sw.Write(sv.cmnd);
                sw.Write("\t");
                sw.Write(sv.sdt);
                sw.Write("\t");
                sw.Write("1");
                if (sv.gioiTinh == false)
                    sw.Write("0");
                sw.Write("\t");
                foreach (var mh in sv.dsMonHoc)
                    sw.Write(mh + ',');
            }sw.WriteLine();
            sw.Close();
        }
    }
}
