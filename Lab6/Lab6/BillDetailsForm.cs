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
    public partial class BillDetailsForm : Form
    {
        public BillDetailsForm()
        {
            InitializeComponent();
        }
        public void LoadBillDetails()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();

            sqlCommand.CommandText = "SELECT * FROM BillDetails ";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable("BillDetails");
            da.Fill(dt);

            dgvBillDetails.DataSource = dt;

            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
    }
}
