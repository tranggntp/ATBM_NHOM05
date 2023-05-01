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
    public partial class Form_TruongDeAn : Form
    {
        Thread t;
        string InUsername;
        public Form_TruongDeAn(string username)
        {
            InitializeComponent();
            InUsername= username;   
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(openFormNhanVien);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDeAn());
        }
        public void DangNhapLai()
        {
            Application.Run(new DangNhap());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(DangNhapLai);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
