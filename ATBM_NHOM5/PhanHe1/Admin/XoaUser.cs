using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1
{
    public partial class XoaUser : Form
    {
        string U_name;
        public XoaUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            U_name = Username.Text.Trim().ToString().ToUpper();
            if (Username.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ dữ liệu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Functions.CheckUserExisted(U_name))
            {
                MessageBox.Show("User không tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
            Functions.RunSQL(sql);
            U_name = Username.Text.Trim().ToString();
            if (checkBox1.Checked == true)
            {
                sql = "DROP USER " + U_name + " CASCADE";
            }
            else
            {
                sql = "DROP USER " + U_name;
            }

            if (Functions.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Đã xóa user!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
    }
}
