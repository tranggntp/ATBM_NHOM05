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
    public partial class XemRolecuaUser : Form
    {
        DataTable dtTableName = new DataTable();
        string grantee;
        public XemRolecuaUser()
        {
            InitializeComponent();
        }
        private void LoadData_RoleUser()
        {
            string grantee = Username.Text.Trim().ToString().ToUpper();
            if (Functions.CheckUserExisted(grantee) || Functions.CheckRoleExisted(grantee))//user/role có tồn tại
            {
                string sql = "SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + grantee + "'";
                dtTableName = Functions.GetDataToTable(sql);
                dataGridView1.DataSource = dtTableName;

                dataGridView1.Font = new Font("Segoe UI", 13);
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

                dataGridView1.Columns[0].HeaderText = "GRANTEE";
                dataGridView1.Columns[1].HeaderText = "GRANTED_ROLE";
                dataGridView1.Columns[2].HeaderText = "ADMIN_OPTION";
                dataGridView1.Columns[3].HeaderText = "DELEGATE_OPTION";
                dataGridView1.Columns[4].HeaderText = "DEFAULT_ROLE";
                dataGridView1.Columns[5].HeaderText = "COMMON";
                dataGridView1.Columns[6].HeaderText = "INHERITED";


                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                dataGridView1.Columns[0].Width = 215;
                dataGridView1.Columns[1].Width = 215;
                dataGridView1.Columns[2].Width = 230;
                dataGridView1.Columns[3].Width = 250;
                dataGridView1.Columns[4].Width = 200;
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].Width = 170;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            else
            {
                MessageBox.Show("User vừa nhập không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ViewRole_Click(object sender, EventArgs e)
        {
            LoadData_RoleUser();
        }
    }
}
