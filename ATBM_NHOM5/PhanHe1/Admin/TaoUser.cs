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

namespace PhanHe1
{
    public partial class TaoUser : Form
    {
        string U_name;
        string U_pass;
        string dbName;
        public TaoUser()
        {
            dbName = dbName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            U_name = Username.Text.Trim().ToString().ToUpper();
            if (Functions.CheckRoleExisted(U_name) || Functions.CheckUserExisted(U_name))
            {
                {
                    MessageBox.Show("Tên này đã được sử dụng!!! Vui lòng chọn tên khác", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            // kiem tra cac text box da duoc nhap du lieu hay chua
            if (Username.Text.Trim().Length == 0 || Password.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ dữ liệu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // lay du lieu tu text box kiem tra username co ton tai hay khong
            U_name = Username.Text.Trim().ToString().ToUpper();
            //neu ham kiem tra user tra ve 1 thi tuc la nguoi dung nay da ton tai trong scdl
            if (Functions.CheckUserExisted(U_name))
            {
                MessageBox.Show("User đã tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // cho phep chay cac lenh khong duoc phep
            string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
            Functions.RunSQL(sql);
            U_name = Username.Text.Trim().ToString();
            U_pass = Password.Text.Trim().ToString();
            sql = "CREATE USER " + U_name + " IDENTIFIED BY " + U_pass;
            Functions.RunSQL(sql);
            MessageBox.Show("Thêm User thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Username.Text = "";
            Password.Text = "";
        }
    }
}
