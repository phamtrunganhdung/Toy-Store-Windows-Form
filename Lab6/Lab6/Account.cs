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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            LoadAccount();
        }
        public void LoadAccount()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Account";
            sqlConnection.Open();

            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách toàn bộ tài khoản";

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable("Account");
            da.Fill(dt);

            dgvAccount.DataSource = dt;

            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count == 0) return;

            var selectedRow = dgvAccount.SelectedRows[0];
            string AccountName = selectedRow.Cells[0].Value.ToString();

            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM Account WHERE AccountName = '" + AccountName +"'";
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                dgvAccount.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void dgvAccount_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RoleAccount rlAccount = new RoleAccount();
            rlAccount.Show(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM Account Where AccountName  = '" + dgvAccount.Rows[0].Cells["AccountName"].Value + "'";
            sqlCommand.ExecuteNonQuery();

            for (int i = 0; i < dgvAccount.Rows.Count - 1; i++)
            {
                string query = string.Format("" +
                    "INSERT INTO Account(AccountName, Password, FullName, Email, Tell, DateCreated)" + " " +
                    "VALUES (N'{0}', N'{1}', {2}, {3}, N'{4}', N'{5}')",
                    dgvAccount.Rows[i].Cells["AccountName"].Value,
                    dgvAccount.Rows[i].Cells["Password"].Value,
                    dgvAccount.Rows[i].Cells["FullName"].Value,
                    dgvAccount.Rows[i].Cells["Email"].Value,
                    dgvAccount.Rows[i].Cells["Tell"].Value);
                    dgvAccount.Rows[i].Cells["DateCreated"].Value.ToString();
                sqlCommand.CommandText = query;
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM Account Where AccountName  = '" + dgvAccount.Rows[0].Cells["AccountName"].Value + "'";
            sqlCommand.ExecuteNonQuery();

            for (int i = 0; i < dgvAccount.Rows.Count - 1; i++)
            {
                string query = string.Format("" +
                    "INSERT INTO Account(AccountName, Password, FullName, Email, Tell, DateCreated)" + " " +
                    "VALUES (N'{0}', N'{1}', {2}, {3}, N'{4}', N'{5}')",
                    dgvAccount.Rows[i].Cells["AccountName"].Value,
                    dgvAccount.Rows[i].Cells["Password"].Value,
                    dgvAccount.Rows[i].Cells["FullName"].Value,
                    dgvAccount.Rows[i].Cells["Email"].Value,
                    dgvAccount.Rows[i].Cells["Tell"].Value);
                dgvAccount.Rows[i].Cells["DateCreated"].Value.ToString();
                sqlCommand.CommandText = query;
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }
    }
}
