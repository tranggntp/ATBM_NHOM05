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
    public partial class DangNhap : Form
    {
        Thread t;
        string username, password;
        public DangNhap()
        {
            InitializeComponent();
        }

        public void MoFormRevokeUser()
        {
            Application.Run(new ThuHoiQuyenUser());
        }

        public void MoFormAdmin()
        {
            Application.Run(new TrangChu(username, password));
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            //username = Username.Text.Trim().ToString();
            //password = Password.Text.Trim().ToString();
            username = "U_AD";
            password = "0";

            // nếu chưa có dữ liệu 
            if (username.Length == 0 | password.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Login(username, password);
            //U_AD
            if (username.Substring(2) == "AD")
            //AD_1
            //if (username.Substring(0,2) == "AD")
            {
                //TrangChu admin = new TrangChu(username, password);
                //admin.Show();
                //this.Hide();
                this.Close();
                t = new Thread(MoFormAdmin);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                return;
            }
            // Kiểm tra tên đăng nhập           

                //if (Run_SP_KTTenDangNhap() == 0)
                //{
                //    MessageBox.Show("Tên đăng nhập không tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtUsername.Focus();
                //    return;
                //}

                //Kiểm tra mật khẩu ứng với tên đăng nhập
                //if (Run_SP_KTMatKhau() == 0)
                //{
                //    MessageBox.Show("Mật khẩu không chính xác !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtPassword.Text = "";
                //    txtPassword.Focus();
                //    return;
                //}

                //Run_SP_DangNhap();

                // nếu acc này bị khóa
                //if (loaitk == -1)
                //{
                //    MessageBox.Show("Tài khoản này đã bị khóa !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                // ngắt kết nối vô danh
                //Functions.Disconnect();

                // kết nối với database tương ứng với loại acc

                //Functions.Connect(Functions.get_ConnectString(loaitk));
                //// mở giao diện tương ứng từng loại acc                 
                //this.Close();
                //t = new Thread(open_FormMain);
                //t.SetApartmentState(ApartmentState.STA);
                //t.Start();
        }

        private void Login(String username, String password)
        {
            try
            {
                Functions.InitConnection(username, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // nếu chưa có dữ liệu 
    }
}
