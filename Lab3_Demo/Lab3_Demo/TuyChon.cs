using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
    public partial class TuyChon : Form
    {
        public int SapXep = 0;
        public TuyChon()
        {
            InitializeComponent();
        }

        private void btnThoatTC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (rdMaSV.Checked) SapXep = 0;
            else if (rdHoTen.Checked) SapXep = 1;
            else SapXep = 2;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

        }

        private void TuyChon_Load(object sender, EventArgs e)
        {

        }
    }
}
