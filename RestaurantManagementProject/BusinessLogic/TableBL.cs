using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class TableBL
    {

        TableDA tableDA = new TableDA();

        public List<Table> GetAll()
        {
            return tableDA.GetAll();
        }

        public Table GetByID(int ID)
        {
            // Lấy hết
            List<Table> list = GetAll();
            // Duyệt để tìm kiếm
            foreach (var item in list)
            {
                if (item.ID == ID) // Nếu gặp khoá chính
                    return item; // thì trả về kết quả
            }
            return null;
        }
        //Phương thức tìm kiếm theo khoá
        public List<Table> Find(string key)
        {
            List<Table> list = GetAll(); // Lấy hết
            List<Table> result = new List<Table>();
            // Duyệt theo danh sách
            foreach (var item in list)
            {
                // Nếu từng trường chứa từ khoá
                if (item.ID.ToString().Contains(key)
                || item.Name.Contains(key)
                || item.Status.ToString().Contains(key)
                || item.Capacity.ToString().Contains(key))
                    result.Add(item); // Thì thêm vào danh sách kết quả
            }
            return result;
        }
        //Phương thức thêm dữ liệu
        public int Insert(Table table)
        {
            return tableDA.Insert_Update_Delete(table, 0);
        }
        //Phương thức cập nhật dữ liệu
        public int Update(Table table)
        {
            return tableDA.Insert_Update_Delete(table, 1);
        }
        //Phương thức xoá dữ liệu với ID cho trước
        public int Delete(Table table)
        {
            return tableDA.Insert_Update_Delete(table, 2);
        }
    }
}
