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
            this.danhsachUser = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.XemRoleCuaUser = new System.Windows.Forms.Button();
            this.ChinhSuaQuyen = new System.Windows.Forms.Button();
            this.CapQuyen = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.XemDanhSachRole = new System.Windows.Forms.Button();
            this.QuanLyUser_Role = new System.Windows.Forms.Button();
            this.dangxuat = new System.Windows.Forms.Button();
            this.ThuHoiQuyen = new System.Windows.Forms.Button();
            this.UserXemQuyen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // danhsachUser
            // 
            this.danhsachUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.danhsachUser.Location = new System.Drawing.Point(17, 20);
            this.danhsachUser.Name = "danhsachUser";
            this.danhsachUser.Size = new System.Drawing.Size(186, 100);
            this.danhsachUser.TabIndex = 0;
            this.danhsachUser.Text = "Xem Danh Sách User";
            this.danhsachUser.UseVisualStyleBackColor = true;
            this.danhsachUser.Click += new System.EventHandler(this.danhsachUser_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Transparent;
            this.PanelMenu.Controls.Add(this.XemRoleCuaUser);
            this.PanelMenu.Controls.Add(this.ChinhSuaQuyen);
            this.PanelMenu.Controls.Add(this.CapQuyen);
            this.PanelMenu.Controls.Add(this.panelChildForm);
            this.PanelMenu.Controls.Add(this.XemDanhSachRole);
            this.PanelMenu.Controls.Add(this.QuanLyUser_Role);
            this.PanelMenu.Controls.Add(this.dangxuat);
            this.PanelMenu.Controls.Add(this.ThuHoiQuyen);
            this.PanelMenu.Controls.Add(this.UserXemQuyen);
            this.PanelMenu.Controls.Add(this.danhsachUser);
            this.PanelMenu.Location = new System.Drawing.Point(-6, -3);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1711, 180);
            this.PanelMenu.TabIndex = 1;
            // 
            // XemRoleCuaUser
            // 
            this.XemRoleCuaUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XemRoleCuaUser.Location = new System.Drawing.Point(975, 20);
            this.XemRoleCuaUser.Name = "XemRoleCuaUser";
            this.XemRoleCuaUser.Size = new System.Drawing.Size(186, 100);
            this.XemRoleCuaUser.TabIndex = 13;
            this.XemRoleCuaUser.Text = "Xem Role của User";
            this.XemRoleCuaUser.UseVisualStyleBackColor = true;
            this.XemRoleCuaUser.Click += new System.EventHandler(this.XemRoleCuaUser_Click);
            // 
            // ChinhSuaQuyen
            // 
            this.ChinhSuaQuyen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChinhSuaQuyen.Location = new System.Drawing.Point(1360, 22);
            this.ChinhSuaQuyen.Name = "ChinhSuaQuyen";
            this.ChinhSuaQuyen.Size = new System.Drawing.Size(186, 100);
            this.ChinhSuaQuyen.TabIndex = 4;
            this.ChinhSuaQuyen.Text = "Thu Hồi Quyền Trên Role";
            this.ChinhSuaQuyen.UseVisualStyleBackColor = true;
            this.ChinhSuaQuyen.Click += new System.EventHandler(this.ChinhSuaQuyen_Click);
            // 
            // CapQuyen
            // 
            this.CapQuyen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CapQuyen.Location = new System.Drawing.Point(783, 20);
            this.CapQuyen.Name = "CapQuyen";
            this.CapQuyen.Size = new System.Drawing.Size(186, 100);
            this.CapQuyen.TabIndex = 12;
            this.CapQuyen.Text = "Cấp Quyền";
            this.CapQuyen.UseVisualStyleBackColor = true;
            this.CapQuyen.Click += new System.EventHandler(this.CapQuyen_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(9, 202);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1237, 600);
            this.panelChildForm.TabIndex = 2;
            // 
            // XemDanhSachRole
            // 
            this.XemDanhSachRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XemDanhSachRole.Location = new System.Drawing.Point(208, 20);
            this.XemDanhSachRole.Name = "XemDanhSachRole";
            this.XemDanhSachRole.Size = new System.Drawing.Size(186, 100);
            this.XemDanhSachRole.TabIndex = 11;
            this.XemDanhSachRole.Text = "Xem Danh Sách Role";
            this.XemDanhSachRole.UseVisualStyleBackColor = true;
            this.XemDanhSachRole.Click += new System.EventHandler(this.XemDanhSachRole_Click);
            // 
            // QuanLyUser_Role
            // 
            this.QuanLyUser_Role.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuanLyUser_Role.Location = new System.Drawing.Point(400, 20);
            this.QuanLyUser_Role.Name = "QuanLyUser_Role";
            this.QuanLyUser_Role.Size = new System.Drawing.Size(186, 100);
            this.QuanLyUser_Role.TabIndex = 10;
            this.QuanLyUser_Role.Text = "Quản Lý User/ Role";
            this.QuanLyUser_Role.UseVisualStyleBackColor = true;
            this.QuanLyUser_Role.Click += new System.EventHandler(this.QuanLyUser_Role_Click);
            // 
            // dangxuat
            // 
            this.dangxuat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dangxuat.Location = new System.Drawing.Point(1519, 137);
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.Size = new System.Drawing.Size(162, 43);
            this.dangxuat.TabIndex = 9;
            this.dangxuat.Text = "Đăng Xuất";
            this.dangxuat.UseVisualStyleBackColor = true;
            this.dangxuat.Click += new System.EventHandler(this.dangxuat_Click);
            // 
            // ThuHoiQuyen
            // 
            this.ThuHoiQuyen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThuHoiQuyen.Location = new System.Drawing.Point(1168, 20);
            this.ThuHoiQuyen.Name = "ThuHoiQuyen";
            this.ThuHoiQuyen.Size = new System.Drawing.Size(186, 100);
            this.ThuHoiQuyen.TabIndex = 8;
            this.ThuHoiQuyen.Text = "Thu Hồi Quyền Trên User";
            this.ThuHoiQuyen.UseVisualStyleBackColor = true;
            this.ThuHoiQuyen.Click += new System.EventHandler(this.ThuHoiQuyen_Click);
            // 
            // UserXemQuyen
            // 
            this.UserXemQuyen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserXemQuyen.Location = new System.Drawing.Point(591, 20);
            this.UserXemQuyen.Name = "UserXemQuyen";
            this.UserXemQuyen.Size = new System.Drawing.Size(186, 100);
            this.UserXemQuyen.TabIndex = 1;
            this.UserXemQuyen.Text = "Xem Quyền của User/ Role";
            this.UserXemQuyen.UseVisualStyleBackColor = true;
            this.UserXemQuyen.Click += new System.EventHandler(this.UserXemQuyen_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1675, 771);
            this.panel1.TabIndex = 2;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 944);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Button XemRoleCuaUser;
    }
}