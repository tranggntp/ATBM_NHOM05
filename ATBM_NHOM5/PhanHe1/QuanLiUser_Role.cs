namespace PhanHe1
{
    public partial class QuanLiUser_Role : Form
    {
        Thread t;

        public QuanLiUser_Role()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void open_FormTaoUser(object obj)
        {
            Application.Run(new TaoUser());
        }
        private void themuser_Click(object sender, EventArgs e)
        {
            t = new Thread(open_FormTaoUser);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void open_FormXoaUser(object obj)
        {
            Application.Run(new XoaUser());
        }
        private void xoauser_Click(object sender, EventArgs e)
        {
            t = new Thread(open_FormXoaUser);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void open_FormSuaUser(object obj)
        {
            Application.Run(new SuaUser());
        }

        private void suauser_Click(object sender, EventArgs e)
        {
            t = new Thread(open_FormSuaUser);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void open_FormThemRole(object obj)
        {
            Application.Run(new ThemRole());
        }
        private void themrole_Click(object sender, EventArgs e)
        {
            t = new Thread(open_FormThemRole);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void open_FormXoaRole(object obj)
        {
            Application.Run(new XoaRole());
        }
        private void xoarole_Click(object sender, EventArgs e)
        {
            t = new Thread(open_FormXoaRole);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

    }
}