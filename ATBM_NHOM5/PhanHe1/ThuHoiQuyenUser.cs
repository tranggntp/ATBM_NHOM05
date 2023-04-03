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
    public partial class ThuHoiQuyenUser : Form
    {
        public ThuHoiQuyenUser()
        {
            InitializeComponent();
        }

        private void Run_SP_RevokePrivilegesFromUser()
        {
            string userName = txtB_UserName.Text.Trim().ToUpper();
            string privileges = txtB_Privileges.Text.Trim().ToUpper();
            string table = txtBox_Table.Text.Trim().ToUpper();





            string sql = "revoke " + privileges + " ON " + table + " FROM " + userName;
            Functions.RunSQL(sql);
            MessageBox.Show("Revoke thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (txtB_UserName.Text.Trim().Length == 0 || txtB_Privileges.Text.Trim().Length == 0 || txtBox_Table.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Run_SP_RevokePrivilegesFromUser();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
