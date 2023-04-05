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
    public partial class XemDsRole : Form
    {
        DataTable dtTableName = new DataTable();
        public XemDsRole()
        {
            InitializeComponent();
        }

        private void LoadData_ListRoles()
        {
            string sql = "SELECT ROLE, ROLE_ID, PASSWORD_REQUIRED, AUTHENTICATION_TYPE FROM DBA_ROLES ORDER BY ROLE_ID DESC";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = dtTableName;
            // set Font cho tên cột
            dataGridView1.Font = new Font("Segoe UI", 13);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

            dataGridView1.Columns[0].HeaderText = "ROLE";
            dataGridView1.Columns[1].HeaderText = "ROLE_ID";
            dataGridView1.Columns[2].HeaderText = "PASSWORD_REQUIRED";
            dataGridView1.Columns[3].HeaderText = "AUTHENTICATION_TYPE";

            // set Font cho dữ liệu hiển thị trong cột
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // set kích thước cột
            dataGridView1.Columns[0].Width = 360;
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[2].Width = 350;
            dataGridView1.Columns[3].Width = 350;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void XemDsRole_Load(object sender, EventArgs e)
        {
            LoadData_ListRoles();
        }
    }
}
