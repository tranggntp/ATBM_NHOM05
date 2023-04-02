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
            dangxuat = new Button();
            RoleThuHoiQuyen = new Button();
            UserThuHoiQuyen = new Button();
            PQHthong = new Button();
            PQUsertoRole = new Button();
            PQQTTable = new Button();
            QuanLyUserRole = new Button();
            RoleXemQuyen = new Button();
            UserXemQuyen = new Button();
            panelChildForm = new Panel();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // danhsachUser
            // 
            danhsachUser.Location = new Point(13, 10);
            danhsachUser.Margin = new Padding(2, 2, 2, 2);
            danhsachUser.Name = "danhsachUser";
            danhsachUser.Size = new Size(113, 43);
            danhsachUser.TabIndex = 0;
            danhsachUser.Text = "danh sach User";
            danhsachUser.UseVisualStyleBackColor = true;
            danhsachUser.Click += button1_Click;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = SystemColors.ActiveCaption;
            PanelMenu.Controls.Add(dangxuat);
            PanelMenu.Controls.Add(RoleThuHoiQuyen);
            PanelMenu.Controls.Add(UserThuHoiQuyen);
            PanelMenu.Controls.Add(PQHthong);
            PanelMenu.Controls.Add(PQUsertoRole);
            PanelMenu.Controls.Add(PQQTTable);
            PanelMenu.Controls.Add(QuanLyUserRole);
            PanelMenu.Controls.Add(RoleXemQuyen);
            PanelMenu.Controls.Add(UserXemQuyen);
            PanelMenu.Controls.Add(danhsachUser);
            PanelMenu.Location = new Point(-4, -2);
            PanelMenu.Margin = new Padding(3, 2, 3, 2);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(872, 120);
            PanelMenu.TabIndex = 1;
            // 
            // dangxuat
            // 
            dangxuat.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dangxuat.Location = new Point(728, 85);
            dangxuat.Margin = new Padding(2, 2, 2, 2);
            dangxuat.Name = "dangxuat";
            dangxuat.Size = new Size(108, 31);
            dangxuat.TabIndex = 9;
            dangxuat.Text = "dangxuat";
            dangxuat.UseVisualStyleBackColor = true;
            dangxuat.Click += dangxuat_Click;
            // 
            // RoleThuHoiQuyen
            // 
            RoleThuHoiQuyen.Location = new Point(450, 67);
            RoleThuHoiQuyen.Margin = new Padding(2, 2, 2, 2);
            RoleThuHoiQuyen.Name = "RoleThuHoiQuyen";
            RoleThuHoiQuyen.Size = new Size(132, 43);
            RoleThuHoiQuyen.TabIndex = 8;
            RoleThuHoiQuyen.Text = "RoleThuHoiQuyen";
            RoleThuHoiQuyen.UseVisualStyleBackColor = true;
            RoleThuHoiQuyen.Click += RoleThuHoiQuyen_Click;
            // 
            // UserThuHoiQuyen
            // 
            UserThuHoiQuyen.Location = new Point(302, 67);
            UserThuHoiQuyen.Margin = new Padding(2, 2, 2, 2);
            UserThuHoiQuyen.Name = "UserThuHoiQuyen";
            UserThuHoiQuyen.Size = new Size(120, 43);
            UserThuHoiQuyen.TabIndex = 7;
            UserThuHoiQuyen.Text = "UserThuHoiQuyen";
            UserThuHoiQuyen.UseVisualStyleBackColor = true;
            UserThuHoiQuyen.Click += UserThuHoiQuyen_Click;
            // 
            // PQHthong
            // 
            PQHthong.Location = new Point(170, 67);
            PQHthong.Margin = new Padding(2, 2, 2, 2);
            PQHthong.Name = "PQHthong";
            PQHthong.Size = new Size(109, 43);
            PQHthong.TabIndex = 6;
            PQHthong.Text = "PQHthong";
            PQHthong.UseVisualStyleBackColor = true;
            PQHthong.Click += PQHthong_Click;
            // 
            // PQUsertoRole
            // 
            PQUsertoRole.Location = new Point(26, 67);
            PQUsertoRole.Margin = new Padding(2, 2, 2, 2);
            PQUsertoRole.Name = "PQUsertoRole";
            PQUsertoRole.Size = new Size(109, 43);
            PQUsertoRole.TabIndex = 5;
            PQUsertoRole.Text = "PQUsertoRole";
            PQUsertoRole.UseVisualStyleBackColor = true;
            PQUsertoRole.Click += PQUsertoRole_Click;
            // 
            // PQQTTable
            // 
            PQQTTable.Location = new Point(571, 10);
            PQQTTable.Margin = new Padding(2, 2, 2, 2);
            PQQTTable.Name = "PQQTTable";
            PQQTTable.Size = new Size(109, 43);
            PQQTTable.TabIndex = 4;
            PQQTTable.Text = "PQQTTable";
            PQQTTable.UseVisualStyleBackColor = true;
            PQQTTable.Click += PQQTTable_Click;
            // 
            // QuanLyUserRole
            // 
            QuanLyUserRole.Location = new Point(426, 10);
            QuanLyUserRole.Margin = new Padding(2, 2, 2, 2);
            QuanLyUserRole.Name = "QuanLyUserRole";
            QuanLyUserRole.Size = new Size(109, 43);
            QuanLyUserRole.TabIndex = 3;
            QuanLyUserRole.Text = "QuanLyUserRole";
            QuanLyUserRole.UseVisualStyleBackColor = true;
            QuanLyUserRole.Click += QuanLyUserRole_Click;
            // 
            // RoleXemQuyen
            // 
            RoleXemQuyen.Location = new Point(281, 10);
            RoleXemQuyen.Margin = new Padding(2, 2, 2, 2);
            RoleXemQuyen.Name = "RoleXemQuyen";
            RoleXemQuyen.Size = new Size(109, 43);
            RoleXemQuyen.TabIndex = 2;
            RoleXemQuyen.Text = "RoleXemQuyen";
            RoleXemQuyen.UseVisualStyleBackColor = true;
            RoleXemQuyen.Click += RoleXemQuyen_Click;
            // 
            // UserXemQuyen
            // 
            UserXemQuyen.Location = new Point(146, 10);
            UserXemQuyen.Margin = new Padding(2, 2, 2, 2);
            UserXemQuyen.Name = "UserXemQuyen";
            UserXemQuyen.Size = new Size(109, 43);
            UserXemQuyen.TabIndex = 1;
            UserXemQuyen.Text = "UserXemQuyen";
            UserXemQuyen.UseVisualStyleBackColor = true;
            UserXemQuyen.Click += UserXemQuyen_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.Location = new Point(9, 118);
            panelChildForm.Margin = new Padding(3, 2, 3, 2);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(859, 360);
            panelChildForm.TabIndex = 2;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 486);
            Controls.Add(panelChildForm);
            Controls.Add(PanelMenu);
            Margin = new Padding(2, 2, 2, 2);
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
        private Button PQQTTable;
        private Button QuanLyUserRole;
        private Button RoleXemQuyen;
        private Button UserXemQuyen;
        private Button dangxuat;
        private Button RoleThuHoiQuyen;
        private Button UserThuHoiQuyen;
        private Button PQHthong;
        private Button PQUsertoRole;
    }
}