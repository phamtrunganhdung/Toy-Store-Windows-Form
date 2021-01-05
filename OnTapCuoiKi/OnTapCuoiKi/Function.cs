using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapCuoiKi
{
    class Function
    {
        public static SqlConnection Con; 
        public static void Connect()
        {
            Con = new SqlConnection();
            Con.ConnectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        public static void DisConnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose();
                Con = null;
            }
        }

        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, Con);
            DataTable data = new DataTable();

            adap.Fill(data);

            return data;
        }

        public static void RunSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            cmd.Dispose();
            cmd = null;
        }

        public static void FillCombo(string sql, ComboBox cbo, string id, string name)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, Con);
            DataTable data = new DataTable();
            adap.Fill(data);

            cbo.DataSource = data;
            cbo.DisplayMember = name;
            cbo.ValueMember = id;
            
        }

        public static bool checkKey(string sql)
        {
            DataTable table = GetDataToTable(sql);
            if (table.Rows.Count > 0)
            {
                return true;
            }

            return false;

        }

        public static string GetFieldValue(string sql)
        {
            string value = "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                value = reader.GetValue(0).ToString();
            }

            reader.Close();
            return value;
        }
    }
}
