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
            //Application.Run(new frmMain());
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
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
            //if (username.Substring(2) == "AD")
            //AD_1
            if (username.Contains("AD"))
            {
                this.Close();
                t = new Thread(MoFormAdmin);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                return;
            }
            // Kiểm tra tên đăng nhập           

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
    }
}
