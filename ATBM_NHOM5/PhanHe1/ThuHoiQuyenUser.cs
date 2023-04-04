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

        string[] list_of_privileges = { "SELECT",
                                "INSERT",
                                "UPDATE",
                                "DELETE", };
        public ThuHoiQuyenUser()
        {
            InitializeComponent();
        }

        private void Run_SP_RevokePrivilegesFromUser()
        {
            string userName = txtB_UserName.Text.Trim().ToUpper();
            string privileges = cbx_privilege.SelectedItem.ToString();
            string table = cbx_table.SelectedItem.ToString();





            string sql = "revoke " + privileges + " ON " + table + " FROM " + userName;
            Functions.RunSQL(sql);
            MessageBox.Show("Revoke thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (txtB_UserName.Text.Trim().Length == 0 || cbx_table.Text.Trim().Length == 0 || cbx_privilege.Text.Trim().Length == 0)
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

        private void ThuHoiQuyenUser_Load(object sender, EventArgs e)
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
