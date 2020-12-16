using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Lab6
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
            LoadBill();
        }
        public void LoadBill()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();

            sqlCommand.CommandText = "SELECT * FROM Bills ";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable("Bills");
            da.Fill(dt);

            dgvBills.DataSource = dt;

            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

        private void dgvBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BillDetailsForm billDetailsForm = new BillDetailsForm();
            billDetailsForm.Show(this);
            billDetailsForm.LoadBillDetails();
        }
    }
}
