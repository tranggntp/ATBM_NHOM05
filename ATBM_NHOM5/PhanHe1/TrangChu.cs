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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // xử lí chuyển màu khi click vào button
        private Button currentButton;
        private void DisableButton()
        {
            foreach (Control previousBtn in PanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(39, 39, 58);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#3f75a2");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }


        //xem danh sách user
        private void button1_Click(object sender, EventArgs e)
        {

        }

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

        private void RoleXemQuyen_Click(object sender, EventArgs e)
        {

        }

        private void UserXemQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemQuyenUser());
            ActivateButton(sender);
        }

        private void QuanLyUserRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLiUser_Role());
            ActivateButton(sender);
        }

        private void PQQTTable_Click(object sender, EventArgs e)
        {

        }

        private void PQUsertoRole_Click(object sender, EventArgs e)
        {

        }

        private void PQHthong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CapQuyen());
            ActivateButton(sender);
        }

        private void UserThuHoiQuyen_Click(object sender, EventArgs e)
        {

        }

        private void RoleThuHoiQuyen_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
