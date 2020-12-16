using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
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
        public SinhVien this[int index]
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
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in DanhSach)
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;
        }
        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.DanhSach.Count;
            for (i = 0; i < count; i++)
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            return kq;
        }

        public void DocTuFile()
        {
            string filename = @"../../DanhSachSV.txt", line;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(
            new FileStream(filename, FileMode.Open));
            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split('\t');
                sv = new SinhVien();
                sv.MaSo = s[0];
                sv.HoTenLot = s[1];
                sv.Ten = s[2];
                sv.NgaySinh = DateTime.Parse(s[3]);
                sv.Lop = s[4];
                sv.SoCMND = s[5];
                sv.SoDT = s[6];
                sv.DiaChi = s[7];
                if (s[8] == "1")
                    sv.GioiTinh = true;
                else
                    sv.GioiTinh = false;
                string[] mh = s[9].Split(',');
                foreach (string c in mh)
                    sv.MonHocDangKy.Add(c);
                this.Them(sv);
            }
            sr.Close();
        }

        public void GhiFile()
        {
            string filename = @"../../DanhSachSV.txt";
            FileStream f = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(f); 

            foreach (var Sv in DanhSach)
            {
                sw.Write(Sv.MaSo);
                sw.Write("\t");
                sw.Write(Sv.HoTenLot);
                sw.Write("\t");
                sw.Write(Sv.Ten);
                sw.Write("\t");
                sw.Write(Sv.NgaySinh.ToShortDateString());
                sw.Write("\t");
                sw.Write(Sv.Lop);
                sw.Write("\t");
                sw.Write(Sv.SoCMND);
                sw.Write("\t");
                sw.Write(Sv.SoDT);
                sw.Write("\t");
                sw.Write(Sv.DiaChi);
                sw.Write("\t");
                if (Sv.GioiTinh == true)
                    sw.Write("1");
                else sw.Write("0");
                sw.Write("\t");
                foreach (var mh in Sv.MonHocDangKy)
                {
                    sw.Write(mh + ',');

                }
                sw.WriteLine();
            }    

            sw.Close();
        }
    }
}
