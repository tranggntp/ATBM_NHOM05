using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1.TRUONGPHONG
{
    public partial class FormMain_TRUONGPHONG : Form
    {
        Thread t;
        string InUsername;
        public FormMain_TRUONGPHONG(string username)
        {
            InitializeComponent();
            InUsername = username;
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
            foreach (Control prv_btn in panel1.Controls)
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
        public void openFormNhanVien(object obj)
        {
            Application.Run(new Form_NhanVien(InUsername));
        }
        public FormMain_TRUONGPHONG()
        {
            InitializeComponent();
        }
        public void OpenFormXemTTNhanVien()
        {
            Application.Run(new XemThongTinNhanVien());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            t = new Thread(OpenFormXemTTNhanVien);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void OpenFormPhanCong()
        {
            Application.Run(new PHANCONG());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            t = new Thread(OpenFormPhanCong);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(DangNhapLai);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(openFormNhanVien);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
