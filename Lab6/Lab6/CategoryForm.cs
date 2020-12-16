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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlComand = sqlConnection.CreateCommand();
            string query = "SELECT ID, Name, Type FROM Category";
            sqlComand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlComand.ExecuteReader();
            this.DisplayCategory(sqlDataReader);
            sqlConnection.Close();
        }
        private void DisplayCategory(SqlDataReader reader)
        {
            lvCategory.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                lvCategory.Items.Add(item);
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlComand = sqlConnection.CreateCommand();
            string query = "INSERT INTO Category(Name, [Type])" + "VALUES (N'" + txtCategoryName.Text + "', " + txtType.Text + ")";
            sqlComand.CommandText = query;
            sqlConnection.Open();
            int numOfRowsEffected = sqlComand.ExecuteNonQuery();
            sqlConnection.Close();
            if (numOfRowsEffected==1)
            {
                MessageBox.Show("Thêm nhóm món ăn thành công");
                btnLoad.PerformClick();
                txtCategoryName.Text = "";
                txtType.Text = "";
                txtCategoryID.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvCategory.SelectedItems[0];
            txtCategoryID.Text = item.Text;
            txtCategoryName.Text = item.SubItems[1].Text;
            if (item.SubItems[2].Text == "0")
                txtType.Text = "Thức uống";
            else
                txtType.Text = "Đồ ăn";

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            string query = "UPDATE Category SET Name = N'" + txtCategoryName.Text +
                                                       "', [Type] = " + txtType.Text + "WHERE ID = " + txtCategoryID.Text;
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (numOfRowsEffected == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];

                item.SubItems[1].Text = txtCategoryName.Text;
                item.SubItems[2].Text = txtType.Text;

                txtCategoryID.Text = "";
                txtCategoryName.Text = "";
                txtType.Text = "";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Cập nhật món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM Category " + "WHERE ID = " + txtCategoryID.Text;          

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(item);

                txtCategoryID.Text = "";
                txtCategoryName.Text = "";
                txtType.Text = "";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Xóa món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
                btnDelete.PerformClick();
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text != "")
            {
                FoodForm foodForm = new FoodForm();
                foodForm.Show(this);
                foodForm.LoadFood(Convert.ToInt32(txtCategoryID.Text));
            }
        }

        private void frmLoadListCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnshowHD_Click(object sender, EventArgs e)
        {
            BillForm billsForm = new BillForm();
            billsForm.Show(this);
        }

        private void btnRoleAccount_Click(object sender, EventArgs e)
        {
            Account AccountForm = new Account();
            AccountForm.Show(this);
        }
    }
}
