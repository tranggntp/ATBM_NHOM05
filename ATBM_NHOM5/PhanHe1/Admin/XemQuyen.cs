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
    public partial class XemQuyen : Form
    {
        DataTable dtTableName = new DataTable();
        string grantee;
        public XemQuyen()
        {
            InitializeComponent();
        }

        private void LoadData_UserOrRolePrivlege()
        {
            string grantee = Username.Text.Trim().ToString().ToUpper();
            if (Functions.CheckUserExisted(grantee) || Functions.CheckRoleExisted(grantee))//user/role có tồn tại
            {
                string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + grantee + "'";
                dtTableName = Functions.GetDataToTable(sql);
                dataGridView1.DataSource = dtTableName;

                dataGridView1.Font = new Font("Segoe UI", 13);
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

                dataGridView1.Columns[0].HeaderText = "GRANTEE";
                dataGridView1.Columns[1].HeaderText = "OWNER";
                dataGridView1.Columns[2].HeaderText = "TABLE_NAME";
                dataGridView1.Columns[3].HeaderText = "GRANTOR";
                dataGridView1.Columns[4].HeaderText = "PRIVILEGE";
                dataGridView1.Columns[5].HeaderText = "GRANTABLE";
                dataGridView1.Columns[6].HeaderText = "HIERARCHY";
                dataGridView1.Columns[7].HeaderText = "COMMON";
                dataGridView1.Columns[8].HeaderText = "TYPE";
                dataGridView1.Columns[9].HeaderText = "INHERITED";

                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[4].Width = 190;
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].Width = 130;
                dataGridView1.Columns[8].Width = 120;
                dataGridView1.Columns[9].Width = 150;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            else
            {
                MessageBox.Show("User/ Role vừa nhập không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void View_Click(object sender, EventArgs e)
        {
            LoadData_UserOrRolePrivlege();
        }
    }
}
