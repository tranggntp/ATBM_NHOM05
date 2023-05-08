using Oracle.ManagedDataAccess.Client;
using PhanHe1.NHANSU;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhanHe1
{
    public partial class Form_NhanVien : Form
    {
        Thread t;
        string InUserName;
        public Form_NhanVien(string username)
        {
            InitializeComponent();
            InUserName = username;
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
        private void Form_NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void xemNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemTTCaNhan());

            //           textBox1.Text=
        }

        private void xemPhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemPhanCong());   
        }

        private void xemPhongBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemPhongBan());
        }

        private void xemDeAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemDeAn());
        }

        public void DangNhapLai()
        {
            Application.Run(new DangNhap());
        }
        public void QuayLaiTDA()
        {
            Application.Run(new Form_TruongDeAn(InUserName));
        }
        public void QuayLaiTC()
        {
            Application.Run(new Form_TaiChinh(InUserName));
        }
        public void QuayLaiTP()
        {
            Application.Run(new FormMain_TRUONGPHONG(InUserName));
        }
        public void QuayLaiNS()
        {
            Application.Run(new FormMainNHANSU(InUserName));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (InUserName.Contains("NV_")) {
                t = new Thread(DangNhapLai);
            }
            else if (InUserName.Contains("TDA_")) 
            { 
                t = new Thread(QuayLaiTDA);
            }
            else if (InUserName.Contains("TC_"))
            {
                t = new Thread(QuayLaiTC);
            }
            else if (InUserName.Contains("TP_"))
            {
                t = new Thread(QuayLaiTP);
            }
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
