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
    public partial class ThuHoiQuyenRole : Form
    {
        string[] list_of_privileges = { "SELECT",
                                "INSERT",
                                "UPDATE",
                                "DELETE", };
        public ThuHoiQuyenRole()
        {
            InitializeComponent();
        }


       

        private void txtBox_Role_TextChanged(object sender, EventArgs e)
        {

        }
        private void Run_SP_RevokePrivilegesFromRole()
        {
            string role = txtBox_Role.Text.Trim().ToUpper();
            string privileges = cbx_privilege.Text.Trim().ToUpper();
            string table = cbx_table.Text.Trim().ToUpper();

            string sql = "revoke " + privileges + " ON " + table + " FROM " + role;
            Functions.RunSQL(sql);
            MessageBox.Show("Revoke thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_xacnhan_Click1(object sender, EventArgs e)
        {
            if (txtBox_Role.Text.Trim().Length == 0 || cbx_privilege.Text.Trim().Length == 0 || cbx_table.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Run_SP_RevokePrivilegesFromRole();
        }

        private void ThuHoiQuyenRole_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < list_of_privileges.Length; i++)
            {
                cbx_privilege.Items.Add(list_of_privileges[i]);
            }

            // load list of tables
            string getTables = "SELECT table_name FROM user_tables";
            Functions.FillComboBox(getTables, cbx_table);
        }
    }

}
