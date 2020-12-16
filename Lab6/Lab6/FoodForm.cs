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
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }
        public void LoadFood(int CategoryID)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT Name FROM Category WHERE ID =" + CategoryID;
            sqlConnection.Open();
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách món ăn thuộc nhóm: " + catName;
            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + CategoryID;
            

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable("Food");
            da.Fill(dt);

            dgvFood.DataSource = dt;

            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM Food Where FoodCategoryID  = " + dgvFood.Rows[0].Cells["FoodCategoryID"].Value;
            sqlCommand.ExecuteNonQuery();

            for (int i = 0; i < dgvFood.Rows.Count - 1; i++)
            {
                string query = string.Format("" +
                    "INSERT INTO Food(Name, Unit, FoodCategoryID, Price, Notes)" + " " +
                    "VALUES (N'{0}', N'{1}', {2}, {3}, N'{4}')",
                    dgvFood.Rows[i].Cells["Name"].Value,
                    dgvFood.Rows[i].Cells["Unit"].Value,
                    dgvFood.Rows[i].Cells["FoodCategoryID"].Value,
                    dgvFood.Rows[i].Cells["Price"].Value,
                    dgvFood.Rows[i].Cells["Notes"].Value).ToString();
                sqlCommand.CommandText = query;
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0) return;

            var selectedRow = dgvFood.SelectedRows[0];
            string foodID = selectedRow.Cells[0].Value.ToString();

            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            string query = "DELETE FROM Food WHERE ID = " + foodID;
            sqlCommand.CommandText = query;

            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if(numOfRowsEffected == 1)
            {
                dgvFood.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }
    }
}
