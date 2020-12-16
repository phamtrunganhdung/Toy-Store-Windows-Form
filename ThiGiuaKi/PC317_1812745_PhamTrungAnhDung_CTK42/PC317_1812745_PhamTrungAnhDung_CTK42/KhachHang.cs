using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC317_1812745_PhamTrungAnhDung_CTK42
{
    public class KhachHang
    {
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public DateTime ngayMua { get; set; }
        public List<string> matHang { get; set; }
        public KhachHang()
        {
            matHang = new List<string>();
        }
        public KhachHang(string makh, string tenkh, string diachi, string sdt, DateTime ngaymua, List<string> mathang)
        {
            this.maKH = makh;
            this.tenKH = tenkh;
            this.diaChi = diachi;
            this.soDienThoai = sdt;
            this.ngayMua = ngaymua;
            this.matHang = mathang;
        }
    }
}
