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
            string privileges = txtBox_Privileges.Text.Trim().ToUpper();
            string table = txtBox_Table.Text.Trim().ToUpper();

            string sql = "revoke " + privileges + " ON " + table + " FROM " + role;
            Functions.RunSQL(sql);
            MessageBox.Show("Revoke thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_xacnhan_Click1(object sender, EventArgs e)
        {
            if (txtBox_Role.Text.Trim().Length == 0 || txtBox_Privileges.Text.Trim().Length == 0 || txtBox_Table.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Run_SP_RevokePrivilegesFromRole();
        }
    }

}
