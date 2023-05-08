using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1.QuanLyTrucTiep
{
    public partial class Form_QuanLyTrucTiep : Form
    {
        Thread t;
        string UserName;

        public Form_QuanLyTrucTiep(string username)
        {
            InitializeComponent();
            UserName = username;
        }

        private Form activeForm = null;

        // khởi tạo form trong panel chính
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.ShowInTaskbar = false;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form_QuanLyTrucTiep_Load(object sender, EventArgs e)
        {

        }

        private void btn_XemDanhSachNguoiDung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemDanhSachNhanVien());
        }

        private void btn_XemPhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemDanhSachPhanCong());
        }
    }
}
