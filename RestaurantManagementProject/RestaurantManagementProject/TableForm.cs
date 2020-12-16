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
using DataAccess;
using BusinessLogic;

namespace RestaurantManagementProject
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }
        List<Table> listTable = new List<Table>();

        Table tableCurrent = new Table();

        private void grbchucnang_Enter(object sender, EventArgs e)
        {

        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadTableDataToListView();

        }
        private void LoadTable()
        {
            TableBL tableBL = new TableBL();
            listTable = tableBL.GetAll();
        }
        public void LoadTableDataToListView()
        {
            TableBL tableBl = new TableBL();
            // Lấy dữ liệu
            listTable = tableBl.GetAll();
            int count = 1; // Biến số thứ tự
            // Xoá dữ liệu trong ListView
            lsvTable.Items.Clear();
            // Duyệt mảng dữ liệu để đưa vào ListView
            foreach (var table in listTable)
            {
                // Số thứ tự
                ListViewItem item = lsvTable.Items.Add(count.ToString());
                item.SubItems.Add(table.Name);
                item.SubItems.Add(table.Status.ToString());
                item.SubItems.Add(table.Capacity.ToString());
                count++;
            }
        }

        private void lsvTable_Click(object sender, EventArgs e)
        {
            // Duyệt toàn bộ dữ liệu trong ListView
            for (int i = 0; i < lsvTable.Items.Count; i++)
            {
                // Nếu có dòng được chọn thì lấy dòng đó
                if (lsvTable.Items[i].Selected)
                {// Lấy các tham số và gán dữ liệu vào các ô
                    tableCurrent = listTable[i];
                    txtName.Text = tableCurrent.Name;
                    txtStatus.Text = tableCurrent.Status.ToString();
                    txtCapacity.Text = tableCurrent.Capacity.ToString();

                }
            }
        }
        public int InsertTable()
        {
            //Khai báo đối tượng Food từ tầng DataAccess
            Table table = new Table();
            table.ID = 0;
            // Kiểm tra nếu các ô nhập khác rỗng
            if (txtName.Text == "" || txtStatus.Text == "" || txtCapacity.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                table.Name = txtName.Text;
                txtStatus.Text = table.Status.ToString();
                txtCapacity.Text = table.Capacity.ToString();
                int status = 0;
                try
                {
                    // Cố gắng lấy giá trị
                    status = int.Parse(txtStatus.Text);
                }
                catch
                {
                    // Nếu sai, gán giá = 0
                    status = 0;
                }
                table.Status = status;
                TableBL tablebl = new TableBL();
                // Chèn dữ liệu vào bảng
                return tablebl.Insert(table);
            }
            return -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng có chắc chắn xoá hay không? Nếu đồng ý thì
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá mẫu tin này?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TableBL tablebl = new TableBL();
                if (tablebl.Delete(tableCurrent) > 0)// Nếu xoá thành công
                {
                    MessageBox.Show("Xoá bàn thành công");
                    // Tải tữ liệu lên ListView
                    LoadTableDataToListView();
                }
                else MessageBox.Show("Xoá không thành công");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Duyệt toàn bộ dữ liệu trong ListView
            for (int i = 0; i < lsvTable.Items.Count; i++)
            {
                // Nếu có dòng được chọn thì lấy dòng đó
                if (lsvTable.Items[i].Selected)
                {// Lấy các tham số và gán dữ liệu vào các ô
                    tableCurrent = listTable[i];
                    txtName.Text = tableCurrent.Name;
                    txtStatus.Text = tableCurrent.Status.ToString();
                    txtCapacity.Text = tableCurrent.Capacity.ToString();
                }
            }
        }
        public int UpdateTable()
        {
            //Khai báo đối tượng Food và lấy đối tượng hiện hành
            Table table = tableCurrent;
            // Kiểm tra nếu các ô nhập khác rỗng
            if (txtName.Text == "" || txtStatus.Text == "" || txtCapacity.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                table.Name = txtName.Text;
                txtStatus.Text = table.Status.ToString();
                txtCapacity.Text = table.Capacity.ToString();
                int status = 0;
                try
                {
                    // Chuyển giá trị từ kiểu văn bản qua kiểu int
                    status = int.Parse(txtStatus.Text);
                }
                catch
                {
                    // Nếu sai, gán giá = 0
                    status = 0;
                }
                table.Status = status;
                TableBL tableBL = new TableBL();
                // Cập nhật dữ liệu trong bảng
                return tableBL.Update(table);
            }
            return -1;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int result = UpdateTable();
            if (result > 0) // Nếu cập nhật thành công
            {
                // Thông báo kết quả
                MessageBox.Show("Cập nhật dữ liệu thành công");
                // Tải lại dữ liệu cho ListView
                LoadTableDataToListView();
            }
            // Nếu thêm không thành công thì thông báo cho người dùng
            else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = InsertTable();
            if (result > 0) // Nếu thêm thành công
            {
                // Thông báo kết quả
                MessageBox.Show("Thêm dữ liệu thành công");
                // Tải lại dữ liệu cho ListView
                LoadTableDataToListView();
            }
            // Nếu thêm không thành công thì thông báo cho người dùng
            else MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
        }
    }
}
