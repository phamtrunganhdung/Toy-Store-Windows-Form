using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapCuoiKi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            getDataToDgv();
        }
        private void getDataToDgv()
        {
            Function.Connect();
            string query = "SELECT * FROM Food";
            dgvFood.DataSource = Function.GetDataToTable(query);
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void dgvFood_Click(object sender, EventArgs e)
        {
            txtID.Text = dgvFood.SelectedCells[0].Value.ToString();
            txtName.Text = dgvFood.SelectedCells[1].Value.ToString();
            txtUnit.Text = dgvFood.SelectedCells[2].Value.ToString();
            txtFoodCategoryID.Text = dgvFood.SelectedCells[3].Value.ToString();
            txtPrice.Text = dgvFood.SelectedCells[4].Value.ToString();
            txtNotes.Text = dgvFood.SelectedCells[5].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
        private void clearText()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtUnit.Text = "";
            txtFoodCategoryID.Text = "";
            txtPrice.Text = "";
            txtNotes.Text = "";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtUnit.Text == "" || txtFoodCategoryID.Text == "" || txtPrice.Text == "" || checkName() == true)
            {
                MessageBox.Show("Add error");
             }
            else
            {
                string query = "INSERT INTO Food (Name,Unit,FoodCategoryID,Price,Notes) VALUES (N'" + txtName.Text + "', N'" + txtUnit.Text + "', N'" + txtFoodCategoryID.Text + "', N'" + txtPrice.Text + "', N'" + txtNotes.Text + "')";
                Function.RunSQL(query);
                getDataToDgv();
                clearText();
            }
            
        }
        private bool checkName()
        {
            string query = "SELECT Name FROM Food WHERE Name = N'" + txtName.Text + "'";
            string foodName =  Function.GetFieldValue(query);
            if(foodName == txtName.Text)
            return true;
                return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtUnit.Text == "" || txtFoodCategoryID.Text == "" || txtPrice.Text == "" || checkName() == true)
            {
                MessageBox.Show("Update error");
            }
            else
            {
                string query = "UPDATE Food SET Name = N'" + txtName.Text + "', Unit = N'" + txtUnit.Text + "', FoodCategoryID = N'" + txtFoodCategoryID.Text + "', Price = N'" + txtPrice.Text + "', Notes = N'" + txtNotes.Text + "' WHERE ID = N'" + txtID.Text + "'";
                Function.RunSQL(query);
                getDataToDgv();
                clearText();
            }        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure ?", "Delete", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                string query = "DELETE FROM Food WHERE ID = N'" + txtID.Text + "'";
                Function.RunSQL(query);
                getDataToDgv();
                clearText();
            }else if (result == DialogResult.No)
            {
                clearText();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain frmMain = new frmMain();
            DialogResult result = MessageBox.Show("Are you sure ?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                frmMain.Close();
                Function.DisConnect();
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
