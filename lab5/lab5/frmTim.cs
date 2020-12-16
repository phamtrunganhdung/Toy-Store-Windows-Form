using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class frmTim : Form
    {
        public string MSSV { get; set; }
        public string Ten { get; set; }
        public string Lop { get; set; }
        public frmTim()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbMSSV.Checked) MSSV = txtMSSV.Text;
            if (cbTen.Checked) Ten = txtTen.Text;
            if (cbLop.Checked) Lop = cboLop.Text;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbMSSV_CheckedChanged(object sender, EventArgs e)
        {
            txtMSSV.Enabled = cbMSSV.Checked;
        }

        private void cbTen_CheckedChanged(object sender, EventArgs e)
        {
            txtTen.Enabled = cbTen.Checked;
        }

        private void cbLop_CheckedChanged(object sender, EventArgs e)
        {
            cboLop.Enabled = cbLop.Checked;
        }
    }
}
