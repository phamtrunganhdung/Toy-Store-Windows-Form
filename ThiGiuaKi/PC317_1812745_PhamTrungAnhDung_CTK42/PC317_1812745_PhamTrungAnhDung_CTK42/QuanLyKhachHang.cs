using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC317_1812745_PhamTrungAnhDung_CTK42
{
        public class QuanLyKhachHang
    {
        public delegate int SoSanh(object obj1, object obj2);
        public List<KhachHang> DanhSach;
        public QuanLyKhachHang()
        {
            DanhSach = new List<KhachHang>();
        }
        public void Them(KhachHang kh)
        {
            this.DanhSach.Add(kh);
        }
        public KhachHang this[int index]
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
        public KhachHang Tim(object obj, SoSanh ss)
        {
            KhachHang khresult = null;
            foreach (KhachHang kh in DanhSach)
                if (ss(obj, kh) == 0)
                {
                    khresult = kh;
                    break;
                }
            return khresult;
        }
        public bool Sua(KhachHang khsua, object obj, SoSanh ss)
        {
            int i, count;
            bool ketqua = false;
            count = this.DanhSach.Count;
            for (i = 0; i < count; i++)
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = khsua;
                    ketqua = true;
                    break;
                }
            return ketqua;
        }

        public void DocTuFile()
        {
            string filename = @"../../DSKH.txt", line;
            string[] s;
            KhachHang kh;
            StreamReader sr = new StreamReader(
            new FileStream(filename, FileMode.Open));
            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split('\t');
                kh = new KhachHang();
                kh.maKH = s[0];
                kh.tenKH = s[1];
                kh.soDienThoai = s[2];
                kh.diaChi = s[3];
                kh.ngayMua = DateTime.Parse(s[4]);               
                string[] mh = s[5].Split(',');
                foreach (string c in mh)
                    kh.matHang.Add(c);
                this.Them(kh);
            }
            sr.Close();
        }

        public void GhiFile()
        {
            string filename = @"../../DSKH.txt";
            FileStream f = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(f);

            foreach (var Kh in DanhSach)
            {
                sw.Write(Kh.maKH);
                sw.Write("\t");
                sw.Write(Kh.tenKH);
                sw.Write("\t");
                sw.Write(Kh.soDienThoai);
                sw.Write("\t");
                sw.Write(Kh.diaChi);
                sw.Write("\t");
                sw.Write(Kh.ngayMua.ToShortDateString());
                sw.Write("\t");
                foreach (var mh in Kh.matHang)
                {
                    sw.Write(mh + ',');

                }
                sw.WriteLine();
            }

            sw.Close();
        }
    }
}
