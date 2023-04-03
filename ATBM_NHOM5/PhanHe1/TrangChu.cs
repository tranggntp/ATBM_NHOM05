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
    public partial class TrangChu : Form
    {
        Thread t;
        public TrangChu(string username, string password)
        {
            InitializeComponent();
        }

        private Form activeform = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // xử lí chuyển màu khi click vào button
        private Button now_btn;
        private void DisableButton()
        {
            foreach (Control prv_btn in PanelMenu.Controls)
            {
                if (prv_btn.GetType() == typeof(Button))
                {
                    prv_btn.BackColor = Color.FromArgb(153, 180, 209);
                    prv_btn.ForeColor = Color.FromArgb(185, 203, 223);
                }
            }
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (now_btn != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(0, 43, 91);
                    now_btn = (Button)btnSender;
                    now_btn.BackColor = color;
                    now_btn.ForeColor = Color.White;

                }
            }
        }


        //xem danh sách user
        public void DangNhapLai()
        {
            Application.Run(new DangNhap());
        }
        private void dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(DangNhapLai);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void danhsachUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemDsNguoiDung());
            ActivateButton(sender);
        }

        private void XemDanhSachRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemDsRole());
            ActivateButton(sender);
        }

        private void QuanLyUser_Role_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLiUser_Role());
            ActivateButton(sender);
        }
        //UserXemQuyen_Click

        //private void danhsachUser_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new XemDsNguoiDung());
        //    ActivateButton(sender);
        //}

        private void UserXemQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemQuyen());
            ActivateButton(sender);
        }

        private void CapQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanQuyenHeThong());
            ActivateButton(sender);
        }

        private void ThuHoiQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThuHoiQuyenUser());
            ActivateButton(sender);
        }

        private void ChinhSuaQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThuHoiQuyenRole());
            ActivateButton(sender);
        }

        //private void XemDanhSachRole_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new XemDsRole());
        //    ActivateButton(sender);
        //}

        //private void QuanLyUser_Role_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new QuanLiUser_Role());
        //    ActivateButton(sender);
        //}

        //private void CapQuyen_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new TaoUser());
        //    ActivateButton(sender);
        //}
    }
}
