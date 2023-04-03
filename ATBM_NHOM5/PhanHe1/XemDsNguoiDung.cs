using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1
{
    public partial class XemDsNguoiDung : Form
    {
        DataTable dtTableName = new DataTable();

        public XemDsNguoiDung()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadData_ListUsers()
        {
            string sql = "SELECT USERNAME, USER_ID, ACCOUNT_STATUS, CREATED  FROM dba_users ORDER BY CREATED DESC";

            dtTableName = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = dtTableName;
            // set Font cho tên cột
            dataGridView1.Font = new Font("Segoe UI", 13);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

            dataGridView1.Columns[0].HeaderText = "USERNAME";
            dataGridView1.Columns[1].HeaderText = "USER_ID";
            dataGridView1.Columns[2].HeaderText = "ACCOUNT_STATUS";
            dataGridView1.Columns[3].HeaderText = "CREATED";

            // set Font cho dữ liệu hiển thị trong cột
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // set kích thước cột
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 250;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void XemDsNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData_ListUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
