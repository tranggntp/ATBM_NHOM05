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
    public partial class capNhatLuongPhuCap : Form
    {
        string[] list = { "LUONG", "PHUCAP" };
        public capNhatLuongPhuCap()
        {
            InitializeComponent();
        }
        private void Run_SP_CapNhatLuongPhuCap()
        {
            string tien = txtBox_tien.Text.Trim();
            string luongphucap = cbx_luongphucap.Text.Trim().ToUpper();
            string manv = txtBox_maNV.Text.Trim().ToUpper();

            string sql = "update AD_N5.NHANVIEN set " + luongphucap + " = " + tien + " where MANV = " + "'" + manv + "'";
            Functions.RunSQL(sql);
            MessageBox.Show("cap nhat thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            if (txtBox_tien.Text.Trim().Length == 0 || cbx_luongphucap.Text.Trim().Length == 0 || txtBox_maNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Run_SP_CapNhatLuongPhuCap();
        }
        private void capNhatLuongPhuCap_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Length; i++)
            {
                cbx_luongphucap.Items.Add(list[i]);
            }



        }

    }
}
