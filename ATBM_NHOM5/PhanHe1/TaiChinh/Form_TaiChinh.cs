using PhanHe1;
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
    public partial class Form_TaiChinh : Form
    {
        Thread t;
        string InUsername;
        public Form_TaiChinh(string username)
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

        public void openFormNhanVien(object obj)
        {
            Application.Run(new Form_NhanVien(InUsername));
        }

        public void DangNhapLai()
        {
            Application.Run(new DangNhap());
        }

        public void xemToanBoPhanCong()
        {
            Application.Run(new xemToanBoPhanCong());
        }

        public void xemToanBoNhanVien()
        {
            Application.Run(new xemToanBoNhanVien());
        }

        public void capNhatLuongPhuCap()
        {
            Application.Run(new capNhatLuongPhuCap());
        }


        private void btn_xemTTCN_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(openFormNhanVien);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(DangNhapLai);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void btn_xemToanBoPhanCong_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new xemToanBoPhanCong());
        }
        private void btn_xemToanBoNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new xemToanBoNhanVien());
        }

        private void btn_capNhatLuongPhuCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new capNhatLuongPhuCap());
        }
    }
}
