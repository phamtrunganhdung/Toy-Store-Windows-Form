using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
	public class SinhVien
	{
		public string MaSo { get; set; }
		public string HoTen { get; set; }
		public DateTime NgaySinh { get; set; }
		public string DiaChi { get; set; }
		public string Lop { get; set; }
		public string Hinh { get; set; }
		public bool GioiTinh { get; set; }
		public List<string> ChuyenNganh { get; set; }

		public SinhVien()
		{
			ChuyenNganh = new List<string>();
		}
		public SinhVien(string ms, string ht, DateTime ngay,
	  string dc, string lop, string hinh, bool gt, List<string> cn)
		{
			this.MaSo = ms;
			this.HoTen = ht;
			this.NgaySinh = ngay;
			this.DiaChi = dc;
			this.Lop = lop;
			this.Hinh = hinh;
			this.GioiTinh = gt;
			this.ChuyenNganh = cn;
		}
	}

	public delegate int SoSanh(object sv1, object sv2);

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
			get
			{
				return DanhSach[index];
			}
			set
			{
				DanhSach[index] = value;
			}
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
			count = this.DanhSach.Count - 1;
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
            string filename = @"C:\Users\Admin\Downloads\Lab3_Demo\Lab3_Demo\DanhSachSV.txt", t;
			string[] s;
			SinhVien sv;
			StreamReader sr = new StreamReader(
			new FileStream(filename, FileMode.Open));
			while ((t = sr.ReadLine()) != null)
			{
				s = t.Split('\t');
				sv = new SinhVien();
				sv.MaSo = s [0];
				sv.HoTen = s[1];
				sv.NgaySinh = DateTime.Parse(s[2]);
				sv.DiaChi = s[3];
				sv.Lop = s[4];
				sv.Hinh = s[5];
				sv.GioiTinh = false;
				if (s[6] == "1")
					sv.GioiTinh = true;
				string[] cn = s[7].Split('*');
				foreach (string c in cn)
					sv.ChuyenNganh.Add(c);
				this.Them(sv);
			}
		}
	}

	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmSinhVien());
		}
	}
}
