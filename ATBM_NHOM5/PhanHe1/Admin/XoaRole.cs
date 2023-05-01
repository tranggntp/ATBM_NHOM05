using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PhanHe1
{
    public partial class XoaRole : Form
    {
        string R_name;
        public XoaRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            R_name = Rolename.Text.Trim().ToString().ToUpper();
            if (Rolename.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ dữ liệu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Functions.CheckRoleExisted(R_name))
            {
                MessageBox.Show("Role không tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
            Functions.RunSQL(sql);
            R_name = Rolename.Text.Trim().ToString();
            sql = "DROP ROLE " + R_name;

            if (Functions.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Đã xóa Role!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
    }
}
