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
            this.CapQuyen = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.XemDanhSachRole = new System.Windows.Forms.Button();
            this.QuanLyUser_Role = new System.Windows.Forms.Button();
            this.dangxuat = new System.Windows.Forms.Button();
            this.ThuHoiQuyen = new System.Windows.Forms.Button();
            this.ChinhSuaQuyen = new System.Windows.Forms.Button();
            this.UserXemQuyen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // danhsachUser
            // 
<<<<<<< HEAD
            this.danhsachUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.danhsachUser.Location = new System.Drawing.Point(10, 3);
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
            this.PanelMenu.Controls.Add(this.CapQuyen);
            this.PanelMenu.Controls.Add(this.panelChildForm);
            this.PanelMenu.Controls.Add(this.XemDanhSachRole);
            this.PanelMenu.Controls.Add(this.QuanLyUser_Role);
            this.PanelMenu.Controls.Add(this.dangxuat);
            this.PanelMenu.Controls.Add(this.ThuHoiQuyen);
            this.PanelMenu.Controls.Add(this.ChinhSuaQuyen);
            this.PanelMenu.Controls.Add(this.UserXemQuyen);
            this.PanelMenu.Controls.Add(this.danhsachUser);
            this.PanelMenu.Location = new System.Drawing.Point(-6, -3);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1246, 200);
=======
            this.danhsachUser.Location = new System.Drawing.Point(15, 13);
            this.danhsachUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.danhsachUser.Name = "danhsachUser";
            this.danhsachUser.Size = new System.Drawing.Size(129, 57);
            this.danhsachUser.TabIndex = 0;
            this.danhsachUser.Text = "danh sach User";
            this.danhsachUser.UseVisualStyleBackColor = true;
            this.danhsachUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelMenu.Controls.Add(this.dangxuat);
            this.PanelMenu.Controls.Add(this.RoleThuHoiQuyen);
            this.PanelMenu.Controls.Add(this.UserThuHoiQuyen);
            this.PanelMenu.Controls.Add(this.PQHthong);
            this.PanelMenu.Controls.Add(this.PQUsertoRole);
            this.PanelMenu.Controls.Add(this.PQQTTable);
            this.PanelMenu.Controls.Add(this.QuanLyUserRole);
            this.PanelMenu.Controls.Add(this.RoleXemQuyen);
            this.PanelMenu.Controls.Add(this.UserXemQuyen);
            this.PanelMenu.Controls.Add(this.danhsachUser);
            this.PanelMenu.Location = new System.Drawing.Point(-5, -2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(996, 160);
>>>>>>> main
            this.PanelMenu.TabIndex = 1;
            // 
            // CapQuyen
            // 
<<<<<<< HEAD
            this.CapQuyen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CapQuyen.Location = new System.Drawing.Point(793, 5);
            this.CapQuyen.Name = "CapQuyen";
            this.CapQuyen.Size = new System.Drawing.Size(225, 103);
            this.CapQuyen.TabIndex = 12;
            this.CapQuyen.Text = "Cấp Quyền";
            this.CapQuyen.UseVisualStyleBackColor = true;
            this.CapQuyen.Click += new System.EventHandler(this.CapQuyen_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(9, 201);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1237, 600);
            this.panelChildForm.TabIndex = 2;
            // 
            // XemDanhSachRole
            // 
            this.XemDanhSachRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XemDanhSachRole.Location = new System.Drawing.Point(195, 0);
            this.XemDanhSachRole.Name = "XemDanhSachRole";
            this.XemDanhSachRole.Size = new System.Drawing.Size(194, 103);
            this.XemDanhSachRole.TabIndex = 11;
            this.XemDanhSachRole.Text = "Xem Danh Sách Role";
            this.XemDanhSachRole.UseVisualStyleBackColor = true;
            this.XemDanhSachRole.Click += new System.EventHandler(this.XemDanhSachRole_Click);
            // 
            // QuanLyUser_Role
            // 
            this.QuanLyUser_Role.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuanLyUser_Role.Location = new System.Drawing.Point(388, 2);
            this.QuanLyUser_Role.Name = "QuanLyUser_Role";
            this.QuanLyUser_Role.Size = new System.Drawing.Size(181, 103);
            this.QuanLyUser_Role.TabIndex = 10;
            this.QuanLyUser_Role.Text = "Quản Lý User/ Role";
            this.QuanLyUser_Role.UseVisualStyleBackColor = true;
            this.QuanLyUser_Role.Click += new System.EventHandler(this.QuanLyUser_Role_Click);
            // 
            // dangxuat
            // 
            this.dangxuat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dangxuat.Location = new System.Drawing.Point(1101, 123);
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.Size = new System.Drawing.Size(132, 44);
            this.dangxuat.TabIndex = 9;
            this.dangxuat.Text = "Đăng Xuất";
            this.dangxuat.UseVisualStyleBackColor = true;
            this.dangxuat.Click += new System.EventHandler(this.dangxuat_Click);
            // 
            // ThuHoiQuyen
            // 
            this.ThuHoiQuyen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThuHoiQuyen.Location = new System.Drawing.Point(1011, 3);
            this.ThuHoiQuyen.Name = "ThuHoiQuyen";
            this.ThuHoiQuyen.Size = new System.Drawing.Size(225, 103);
            this.ThuHoiQuyen.TabIndex = 8;
            this.ThuHoiQuyen.Text = "Thu Hồi Quyền";
            this.ThuHoiQuyen.UseVisualStyleBackColor = true;
            this.ThuHoiQuyen.Click += new System.EventHandler(this.ThuHoiQuyen_Click);
            // 
            // ChinhSuaQuyen
            // 
            this.ChinhSuaQuyen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChinhSuaQuyen.Location = new System.Drawing.Point(126, 109);
            this.ChinhSuaQuyen.Name = "ChinhSuaQuyen";
            this.ChinhSuaQuyen.Size = new System.Drawing.Size(225, 85);
            this.ChinhSuaQuyen.TabIndex = 4;
            this.ChinhSuaQuyen.Text = "Chỉnh Sửa Quyền";
            this.ChinhSuaQuyen.UseVisualStyleBackColor = true;
            this.ChinhSuaQuyen.Click += new System.EventHandler(this.ChinhSuaQuyen_Click);
            // 
            // UserXemQuyen
            // 
            this.UserXemQuyen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserXemQuyen.Location = new System.Drawing.Point(567, 3);
            this.UserXemQuyen.Name = "UserXemQuyen";
            this.UserXemQuyen.Size = new System.Drawing.Size(225, 103);
            this.UserXemQuyen.TabIndex = 1;
            this.UserXemQuyen.Text = "Xem Quyền của User/ Role";
            this.UserXemQuyen.UseVisualStyleBackColor = true;
            this.UserXemQuyen.Click += new System.EventHandler(this.UserXemQuyen_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 600);
            this.panel1.TabIndex = 2;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 805);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
=======
            this.dangxuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dangxuat.Location = new System.Drawing.Point(832, 114);
            this.dangxuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.Size = new System.Drawing.Size(123, 41);
            this.dangxuat.TabIndex = 9;
            this.dangxuat.Text = "dangxuat";
            this.dangxuat.UseVisualStyleBackColor = true;
            this.dangxuat.Click += new System.EventHandler(this.dangxuat_Click);
            // 
            // RoleThuHoiQuyen
            // 
            this.RoleThuHoiQuyen.Location = new System.Drawing.Point(514, 89);
            this.RoleThuHoiQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoleThuHoiQuyen.Name = "RoleThuHoiQuyen";
            this.RoleThuHoiQuyen.Size = new System.Drawing.Size(151, 57);
            this.RoleThuHoiQuyen.TabIndex = 8;
            this.RoleThuHoiQuyen.Text = "RoleThuHoiQuyen";
            this.RoleThuHoiQuyen.UseVisualStyleBackColor = true;
            this.RoleThuHoiQuyen.Click += new System.EventHandler(this.RoleThuHoiQuyen_Click);
            // 
            // UserThuHoiQuyen
            // 
            this.UserThuHoiQuyen.Location = new System.Drawing.Point(346, 89);
            this.UserThuHoiQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserThuHoiQuyen.Name = "UserThuHoiQuyen";
            this.UserThuHoiQuyen.Size = new System.Drawing.Size(138, 57);
            this.UserThuHoiQuyen.TabIndex = 7;
            this.UserThuHoiQuyen.Text = "UserThuHoiQuyen";
            this.UserThuHoiQuyen.UseVisualStyleBackColor = true;
            this.UserThuHoiQuyen.Click += new System.EventHandler(this.UserThuHoiQuyen_Click);
            // 
            // PQHthong
            // 
            this.PQHthong.Location = new System.Drawing.Point(194, 89);
            this.PQHthong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PQHthong.Name = "PQHthong";
            this.PQHthong.Size = new System.Drawing.Size(125, 57);
            this.PQHthong.TabIndex = 6;
            this.PQHthong.Text = "PQHthong";
            this.PQHthong.UseVisualStyleBackColor = true;
            this.PQHthong.Click += new System.EventHandler(this.PQHthong_Click);
            // 
            // PQUsertoRole
            // 
            this.PQUsertoRole.Location = new System.Drawing.Point(30, 89);
            this.PQUsertoRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PQUsertoRole.Name = "PQUsertoRole";
            this.PQUsertoRole.Size = new System.Drawing.Size(125, 57);
            this.PQUsertoRole.TabIndex = 5;
            this.PQUsertoRole.Text = "PQUsertoRole";
            this.PQUsertoRole.UseVisualStyleBackColor = true;
            this.PQUsertoRole.Click += new System.EventHandler(this.PQUsertoRole_Click);
            // 
            // PQQTTable
            // 
            this.PQQTTable.Location = new System.Drawing.Point(653, 13);
            this.PQQTTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PQQTTable.Name = "PQQTTable";
            this.PQQTTable.Size = new System.Drawing.Size(125, 57);
            this.PQQTTable.TabIndex = 4;
            this.PQQTTable.Text = "PQQTTable";
            this.PQQTTable.UseVisualStyleBackColor = true;
            this.PQQTTable.Click += new System.EventHandler(this.PQQTTable_Click);
            // 
            // QuanLyUserRole
            // 
            this.QuanLyUserRole.Location = new System.Drawing.Point(487, 13);
            this.QuanLyUserRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuanLyUserRole.Name = "QuanLyUserRole";
            this.QuanLyUserRole.Size = new System.Drawing.Size(125, 57);
            this.QuanLyUserRole.TabIndex = 3;
            this.QuanLyUserRole.Text = "QuanLyUserRole";
            this.QuanLyUserRole.UseVisualStyleBackColor = true;
            this.QuanLyUserRole.Click += new System.EventHandler(this.QuanLyUserRole_Click);
            // 
            // RoleXemQuyen
            // 
            this.RoleXemQuyen.Location = new System.Drawing.Point(322, 13);
            this.RoleXemQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoleXemQuyen.Name = "RoleXemQuyen";
            this.RoleXemQuyen.Size = new System.Drawing.Size(125, 57);
            this.RoleXemQuyen.TabIndex = 2;
            this.RoleXemQuyen.Text = "RoleXemQuyen";
            this.RoleXemQuyen.UseVisualStyleBackColor = true;
            this.RoleXemQuyen.Click += new System.EventHandler(this.RoleXemQuyen_Click);
            // 
            // UserXemQuyen
            // 
            this.UserXemQuyen.Location = new System.Drawing.Point(167, 13);
            this.UserXemQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserXemQuyen.Name = "UserXemQuyen";
            this.UserXemQuyen.Size = new System.Drawing.Size(125, 57);
            this.UserXemQuyen.TabIndex = 1;
            this.UserXemQuyen.Text = "UserXemQuyen";
            this.UserXemQuyen.UseVisualStyleBackColor = true;
            this.UserXemQuyen.Click += new System.EventHandler(this.UserXemQuyen_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(10, 158);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(960, 480);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 648);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.PanelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> main
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
    }
}