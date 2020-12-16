using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab6
{
    public partial class RoleAccount : Form
    {
        public RoleAccount()
        {
            InitializeComponent();
            LoadRoleAccount();
        }
        public void LoadRoleAccount()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM RoleAccount";
            sqlConnection.Open();

            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách nhóm tài khoản";

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataTable tb = new DataTable("RoleAccount");
            adapter.Fill(tb);

            dgvRoleAccount.DataSource = tb;

            dgvRoleAccount.Columns[0].ReadOnly = true;

            sqlConnection.Close();
        }
    }
}
