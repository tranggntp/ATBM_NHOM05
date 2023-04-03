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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1
{
    public partial class SuaUser : Form
    {
        string U_name;
        string U_pass;
        public SuaUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DeleteUser_Click(object sender, EventArgs e)
        {
            // kiem tra text box username da duoc nhap du lieu hay chua
            if (Username.Text.Trim().Length == 0 || NewPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // kiem tra user co ton tai hay khong
            // lay du lieu tu text box kiem tra username co ton tai hay khong
            U_name = Username.Text.Trim().ToString().ToUpper();
            //neu ham kiem tra user tra ve 1 thi tuc la nguoi dung nay da ton tai trong scdl
            if (!Functions.CheckUserExisted(U_name))
            {
                MessageBox.Show("User không tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
            Functions.RunSQL(sql);
            U_name = Username.Text.Trim().ToString();
            U_pass = NewPass.Text.Trim().ToString();
            // thực hiện câu lệnh sql
            sql = "ALTER USER " + U_name + " IDENTIFIED BY " + U_pass;

            if (Functions.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Thay đổi password thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
    }
}
