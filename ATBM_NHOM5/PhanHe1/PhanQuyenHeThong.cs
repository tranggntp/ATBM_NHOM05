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
    public partial class PhanQuyenHeThong : Form
    {
        // grant sys for user/role
        string[] list_of_privileges = { "SELECT", "SELECT WITH GRANT OPTION",
                                "INSERT", "INSERT WITH GRANT OPTION",
                                "UPDATE", "UPDATE WITH GRANT OPTION",
                                "DELETE", "DELETE WITH GRANT OPTION"};

        string privilege = string.Empty;
        string table = string.Empty;
        string user_role = string.Empty;

        // grant role to user
        string user2 = string.Empty;
        string role2 = string.Empty;

        public PhanQuyenHeThong()
        {
            InitializeComponent();
        }

        private void PhanQuyenHeThong_Load(object sender, EventArgs e)
        {
            // load list of privilege
            for (int i = 0; i < list_of_privileges.Length; i++)
            {
                cbx_privilege.Items.Add(list_of_privileges[i]);
            }

            // load list of tables
            string getTables = "SELECT table_name FROM user_tables";
            Functions.FillComboBox(getTables, cbx_table);
        }

        private void txtBox_user_role_TextChanged(object sender, EventArgs e)
        {
            user_role = txtBox_user_role.Text;
        }

        private void cbx_privilege_SelectedIndexChanged(object sender, EventArgs e)
        {
            privilege = cbx_privilege.SelectedItem.ToString();
        }

        private void cbx_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            table = cbx_table.SelectedItem.ToString();
        }

        private void Grant_Click(object sender, EventArgs e)
        {
            string query = "GRANT " + privilege + " ON " + table + " TO " + user_role;
            MessageBox.Show(query);
            Functions.RunSQLwithResult(query);
        }

        private void txtBox_User2_TextChanged(object sender, EventArgs e)
        {
            user2 = txtBox_User2.Text;
        }

        private void txtBox_Role2_TextChanged(object sender, EventArgs e)
        {
            role2 = txtBox_Role2.Text;
        }

        private void btn_RoleToUser_Click(object sender, EventArgs e)
        {
            string query = "GRANT " + role2 + " TO " + user2;
            MessageBox.Show(query);
            Functions.RunSQLwithResult(query);
        }
    }
}
