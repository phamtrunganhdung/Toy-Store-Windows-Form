using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class TableDA
    {
        public List<Table> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            //Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Table_GetAll;
            // Đọc dữ liệu, trả về danh sách các đối tượng Food
            SqlDataReader reader = command.ExecuteReader();
            List<Table> list = new List<Table>();
            while (reader.Read())
            {
                Table table = new Table();
                table.ID = Convert.ToInt32(reader["ID"]);
                table.Name = reader["Name"].ToString();
                table.Status = Convert.ToInt32(reader["Status"]);
                table.Capacity = Convert.ToInt32(reader["Capacity"]);
                list.Add(table);
            }
            // Đóng kết nối và trả về danh sách
            sqlConn.Close();
            return list;
        }
        public int Insert_Update_Delete(Table table, int action)
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            // Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.config
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            //Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Table_InsertUpdateDelete;
            // Thêm các tham số cho thủ tục; Các tham số này chính là các tham số trong thủ tục;
            //ID là tham số có giá trị lấy ra khi thêm và truyền vào khi xoá, sửa
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = table.ID;
            //Các biến còn lại chỉ truyền vào
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 1000)
            .Value = table.Name;
            command.Parameters.Add("@Status", SqlDbType.Int)
            .Value = table.Status;
            command.Parameters.Add("@Capacity", SqlDbType.Int)
            .Value = table.Capacity;
            command.Parameters.Add("@Action", SqlDbType.Int)
            .Value = action;
            int result = command.ExecuteNonQuery();
            // Thực thi lệnh
            if (result > 0) // Nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }
    }
}
