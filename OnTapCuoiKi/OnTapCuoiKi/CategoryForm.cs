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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getDataToDgv();
        }
        private void getDataToDgv()
        {
            string query = "SELECT * FROM Category";
            dgvCategory.DataSource = Function.GetDataToTable(query);
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            fillCombo();
        }
        private void fillCombo()
        {
            List<int> comboSource = new List<int>();
            comboSource.Add(0);
            comboSource.Add(1);
            cboType.DataSource = comboSource;
        }

        private void dgvCategory_Click(object sender, EventArgs e)
        {
            txtID.Text = dgvCategory.SelectedCells[0].Value.ToString();
            txtName.Text = dgvCategory.SelectedCells[1].Value.ToString();
            cboType.Text = dgvCategory.SelectedCells[2].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
        private void clearText()
        {
            txtID.Text = "";
            txtName.Text = "";
            cboType.Text = "";
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
        private bool checkName()
        {
            string query = "SELECT Name FROM Category WHERE Name = N'" + txtName.Text + "'";
            if(Function.GetFieldValue(query) == txtName.Text)
            return true;
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkName() == true || txtName.Text == "" || cboType.Text == "")
            {
                MessageBox.Show("error");
            }else
            {
                string query = "INSERT INTO Category (Name,Type) VALUES (N'" + txtName.Text + "', N'" + cboType.Text + "')";
                Function.RunSQLExecuteNonQuery(query);
                getDataToDgv();
                clearText();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkName() == true || txtName.Text == "" || cboType.Text == "")
            {
                MessageBox.Show("error");
            }
            else
            {
                string query = "UPDATE Category SET Name = N'" + txtName.Text + "', Type = N'" + cboType.Text + "' WHERE ID = N'" + txtID.Text + "'";
                Function.RunSQLExecuteNonQuery(query);
                getDataToDgv();
                clearText();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Sure ?", "Delete", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string query = "DELETE * FROM Category WHERE ID = N'" + txtID.Text + "'";
                Function.RunSQLExecuteNonQuery(query);
                getDataToDgv();
                clearText();
            }
            else if(res == DialogResult.No)
            {
                clearText();
            }
        }
    }
}
