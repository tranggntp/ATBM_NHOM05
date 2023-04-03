namespace PhanHe1
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            danhsachUser = new Button();
            PanelMenu = new Panel();
            CapQuyen = new Button();
            panelChildForm = new Panel();
            XemDanhSachRole = new Button();
            QuanLyUser_Role = new Button();
            dangxuat = new Button();
            ThuHoiQuyen = new Button();
            ChinhSuaQuyen = new Button();
            UserXemQuyen = new Button();
            panel1 = new Panel();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // danhsachUser
            // 
            danhsachUser.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            danhsachUser.Location = new Point(58, 13);
            danhsachUser.Margin = new Padding(2);
            danhsachUser.Name = "danhsachUser";
            danhsachUser.Size = new Size(130, 60);
            danhsachUser.TabIndex = 0;
            danhsachUser.Text = "Xem Danh Sách User";
            danhsachUser.UseVisualStyleBackColor = true;
            danhsachUser.Click += danhsachUser_Click;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.Transparent;
            PanelMenu.Controls.Add(ChinhSuaQuyen);
            PanelMenu.Controls.Add(CapQuyen);
            PanelMenu.Controls.Add(panelChildForm);
            PanelMenu.Controls.Add(XemDanhSachRole);
            PanelMenu.Controls.Add(QuanLyUser_Role);
            PanelMenu.Controls.Add(dangxuat);
            PanelMenu.Controls.Add(ThuHoiQuyen);
            PanelMenu.Controls.Add(UserXemQuyen);
            PanelMenu.Controls.Add(danhsachUser);
            PanelMenu.Location = new Point(-4, -2);
            PanelMenu.Margin = new Padding(3, 2, 3, 2);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(1198, 120);
            PanelMenu.TabIndex = 1;
            // 
            // CapQuyen
            // 
            CapQuyen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CapQuyen.Location = new Point(594, 13);
            CapQuyen.Margin = new Padding(2);
            CapQuyen.Name = "CapQuyen";
            CapQuyen.Size = new Size(130, 60);
            CapQuyen.TabIndex = 12;
            CapQuyen.Text = "Cấp Quyền";
            CapQuyen.UseVisualStyleBackColor = true;
            CapQuyen.Click += CapQuyen_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.Location = new Point(6, 121);
            panelChildForm.Margin = new Padding(3, 2, 3, 2);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(866, 360);
            panelChildForm.TabIndex = 2;
            // 
            // XemDanhSachRole
            // 
            XemDanhSachRole.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            XemDanhSachRole.Location = new Point(192, 13);
            XemDanhSachRole.Margin = new Padding(2);
            XemDanhSachRole.Name = "XemDanhSachRole";
            XemDanhSachRole.Size = new Size(130, 60);
            XemDanhSachRole.TabIndex = 11;
            XemDanhSachRole.Text = "Xem Danh Sách Role";
            XemDanhSachRole.UseVisualStyleBackColor = true;
            XemDanhSachRole.Click += XemDanhSachRole_Click;
            // 
            // QuanLyUser_Role
            // 
            QuanLyUser_Role.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            QuanLyUser_Role.Location = new Point(326, 13);
            QuanLyUser_Role.Margin = new Padding(2);
            QuanLyUser_Role.Name = "QuanLyUser_Role";
            QuanLyUser_Role.Size = new Size(130, 60);
            QuanLyUser_Role.TabIndex = 10;
            QuanLyUser_Role.Text = "Quản Lý User/ Role";
            QuanLyUser_Role.UseVisualStyleBackColor = true;
            QuanLyUser_Role.Click += QuanLyUser_Role_Click;
            // 
            // dangxuat
            // 
            dangxuat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dangxuat.Location = new Point(1040, 31);
            dangxuat.Margin = new Padding(2);
            dangxuat.Name = "dangxuat";
            dangxuat.Size = new Size(92, 26);
            dangxuat.TabIndex = 9;
            dangxuat.Text = "Đăng Xuất";
            dangxuat.UseVisualStyleBackColor = true;
            dangxuat.Click += dangxuat_Click;
            // 
            // ThuHoiQuyen
            // 
            ThuHoiQuyen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ThuHoiQuyen.Location = new Point(728, 13);
            ThuHoiQuyen.Margin = new Padding(2);
            ThuHoiQuyen.Name = "ThuHoiQuyen";
            ThuHoiQuyen.Size = new Size(130, 60);
            ThuHoiQuyen.TabIndex = 8;
            ThuHoiQuyen.Text = "Thu Hồi Quyền Trên User";
            ThuHoiQuyen.UseVisualStyleBackColor = true;
            ThuHoiQuyen.Click += ThuHoiQuyen_Click;
            // 
            // ChinhSuaQuyen
            // 
            ChinhSuaQuyen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChinhSuaQuyen.Location = new Point(862, 13);
            ChinhSuaQuyen.Margin = new Padding(2);
            ChinhSuaQuyen.Name = "ChinhSuaQuyen";
            ChinhSuaQuyen.Size = new Size(130, 60);
            ChinhSuaQuyen.TabIndex = 4;
            ChinhSuaQuyen.Text = "Thu Hồi Quyền Trên Role";
            ChinhSuaQuyen.UseVisualStyleBackColor = true;
            ChinhSuaQuyen.Click += ChinhSuaQuyen_Click;
            // 
            // UserXemQuyen
            // 
            UserXemQuyen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UserXemQuyen.Location = new Point(460, 13);
            UserXemQuyen.Margin = new Padding(2);
            UserXemQuyen.Name = "UserXemQuyen";
            UserXemQuyen.Size = new Size(130, 60);
            UserXemQuyen.TabIndex = 1;
            UserXemQuyen.Text = "Xem Quyền của User/ Role";
            UserXemQuyen.UseVisualStyleBackColor = true;
            UserXemQuyen.Click += UserXemQuyen_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(2, 119);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 510);
            panel1.TabIndex = 2;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 631);
            Controls.Add(panel1);
            Controls.Add(PanelMenu);
            Margin = new Padding(2);
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChu";
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button danhsachUser;
        private Panel PanelMenu;
        private Panel panelChildForm;
        private Button ChinhSuaQuyen;
        private Button UserXemQuyen;
        private Button dangxuat;
        private Button ThuHoiQuyen;
        private Button QuanLyUser_Role;
        private Button XemDanhSachRole;
        private Panel panel1;
        private Button CapQuyen;
    }
}