using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1
{
    public partial class ThemRole : Form
    {
        string R_name;
        string dbName;
        public ThemRole()
        {
            dbName = dbName;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateRole_Click(object sender, EventArgs e)
        {
            R_name = RoleName.Text.Trim().ToString().ToUpper();
            if (Functions.CheckRoleExisted(R_name) || Functions.CheckUserExisted(R_name))
            {
                {
                    MessageBox.Show("Tên này đã được sử dụng!!! Vui lòng chọn tên khác", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            //kiem tra cac text box da duoc nhap du lieu hay chua
            if (RoleName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ dữ liệu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // lay du lieu tu text box kiem tra role co ton tai hay khong
            R_name = RoleName.Text.Trim().ToString().ToUpper();
            //neu ham kiem tra role tra ve 1 thi tuc la role nay da ton tai trong scdl
            if (Functions.CheckRoleExisted(R_name))
            {
                MessageBox.Show("Role đã tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // cho phep chay cac lenh khong duoc phep
            string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
            Functions.RunSQL(sql);
            R_name = RoleName.Text.Trim().ToString().ToUpper();
            sql = "CREATE ROLE " + R_name;
            Functions.RunSQL(sql);
            MessageBox.Show("Thêm role thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RoleName.Text = "";
        }
    }
}
