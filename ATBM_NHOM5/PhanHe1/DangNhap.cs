using PhanHe1.QuanLyTrucTiep;
﻿using PhanHe1.NHANSU;
using PhanHe1.TRUONGPHONG;
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

        public void MoFormNhanVien()
        {
            Application.Run(new Form_NhanVien(username));
            //Application.Run(new Form_NhanVien(username, password));
        }

        public void MoFormTruongDeAn()
        {
            Application.Run(new Form_TruongDeAn(username));
            //Application.Run(new Form_NhanVien(username, password));
        }


        public void MoFormTaiChinh()
        {
            Application.Run(new Form_TaiChinh(username));
            //Application.Run(new Form_NhanVien(username, password));
        }

        public void MoFormQuanLyTrucTiep()
        {
            Application.Run(new Form_QuanLyTrucTiep(username));
            //Application.Run(new Form_NhanVien(username, password));
        }

        public void MoFormTruongPhong()
        {
            Application.Run(new FormMain_TRUONGPHONG(username));
            //Application.Run(new Form_NhanVien(username, password));
        }
        public void MoFormNhanSu()
        {
            Application.Run(new FormMainNHANSU(username));
            //Application.Run(new Form_NhanVien(username, password));
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            username = Username.Text.Trim().ToString();
            password = Password.Text.Trim().ToString();
            //username = "NV_NV016";
            //password = "123";

            //username = "TDA_NV006";
            //password = "123";

            //username = "TC_NV025";
            //password = "123";

            // nếu chưa có dữ liệu 
            if (username.Length == 0 | password.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            Login(username, password);

            if (username.Contains("AD_"))
            {
                this.Close();
                t = new Thread(MoFormAdmin);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                return;
            }

            if (username.Contains("NV_"))//Nhân viên bình thường
            {
                this.Close();
                t = new Thread(MoFormNhanVien);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                return;
            }

            if (username.Contains("TDA_"))//Trưởng đề án
            {
                this.Close();
                t = new Thread(MoFormTruongDeAn);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                return;
            }

            if (username.Contains("TC_"))//TC_NV025
            {
                this.Close();
                t = new Thread(MoFormTaiChinh);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                return;
            }
            if (username.Contains("TP_"))
            {
                this.Close();
                t = new Thread(MoFormTruongPhong);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                return;
            }
            if (username.Contains("NS_"))
            {
                this.Close();
                t = new Thread(MoFormNhanSu);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                return;
            }

            if (username.Contains("QLTT_"))
            {
                this.Close();
                t = new Thread(MoFormQuanLyTrucTiep);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                return;
            }

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
