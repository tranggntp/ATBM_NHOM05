namespace PhanHe1
{
    partial class PhanQuyenHeThong
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
            Button btn_RoleToUser;
            Button btn_grant;
            txtBox_user_role = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbx_privilege = new ComboBox();
            label3 = new Label();
            cbx_table = new ComboBox();
            Table = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBox_User2 = new TextBox();
            txtBox_Role2 = new TextBox();
            label_attribute = new Label();
            cbx_attribute = new ComboBox();
            checkBox_WGO = new CheckBox();
            btn_RoleToUser = new Button();
            btn_grant = new Button();
            SuspendLayout();
            // 
            // btn_RoleToUser
            // 
            btn_RoleToUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_RoleToUser.Location = new Point(821, 313);
            btn_RoleToUser.Margin = new Padding(3, 2, 3, 2);
            btn_RoleToUser.Name = "btn_RoleToUser";
            btn_RoleToUser.Size = new Size(147, 41);
            btn_RoleToUser.TabIndex = 21;
            btn_RoleToUser.Text = "Grant";
            btn_RoleToUser.UseVisualStyleBackColor = true;
            btn_RoleToUser.Click += btn_RoleToUser_Click;
            // 
            // txtBox_user_role
            // 
            txtBox_user_role.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_user_role.Location = new Point(208, 94);
            txtBox_user_role.Margin = new Padding(3, 2, 3, 2);
            txtBox_user_role.Name = "txtBox_user_role";
            txtBox_user_role.Size = new Size(117, 32);
            txtBox_user_role.TabIndex = 9;
            txtBox_user_role.TextChanged += txtBox_user_role_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 97);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 8;
            label2.Text = "Nhập User/Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(382, 97);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(67, 25);
            label1.TabIndex = 10;
            label1.Text = "Quyền";
            // 
            // cbx_privilege
            // 
            cbx_privilege.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_privilege.FormattingEnabled = true;
            cbx_privilege.Location = new Point(454, 94);
            cbx_privilege.Margin = new Padding(2);
            cbx_privilege.Name = "cbx_privilege";
            cbx_privilege.Size = new Size(117, 33);
            cbx_privilege.TabIndex = 11;
            cbx_privilege.SelectedIndexChanged += cbx_privilege_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(313, 9);
            label3.Name = "label3";
            label3.Size = new Size(507, 37);
            label3.TabIndex = 13;
            label3.Text = "CẤP QUYỀN HỆ THỐNG CHO USER/ROLE";
            // 
            // cbx_table
            // 
            cbx_table.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_table.FormattingEnabled = true;
            cbx_table.Location = new Point(692, 94);
            cbx_table.Margin = new Padding(2);
            cbx_table.Name = "cbx_table";
            cbx_table.Size = new Size(117, 33);
            cbx_table.TabIndex = 14;
            cbx_table.SelectedIndexChanged += cbx_table_SelectedIndexChanged;
            // 
            // Table
            // 
            Table.AutoSize = true;
            Table.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Table.Location = new Point(632, 97);
            Table.Name = "Table";
            Table.RightToLeft = RightToLeft.Yes;
            Table.Size = new Size(55, 25);
            Table.TabIndex = 15;
            Table.Text = "Bảng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(432, 245);
            label4.Name = "label4";
            label4.Size = new Size(269, 37);
            label4.TabIndex = 16;
            label4.Text = "CẤP ROLE CHO USER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(83, 313);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 17;
            label5.Text = "Nhập User";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(410, 313);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 18;
            label6.Text = "Nhập Role";
            // 
            // txtBox_User2
            // 
            txtBox_User2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_User2.Location = new Point(190, 310);
            txtBox_User2.Margin = new Padding(3, 2, 3, 2);
            txtBox_User2.Name = "txtBox_User2";
            txtBox_User2.Size = new Size(117, 32);
            txtBox_User2.TabIndex = 19;
            txtBox_User2.TextChanged += txtBox_User2_TextChanged;
            // 
            // txtBox_Role2
            // 
            txtBox_Role2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Role2.Location = new Point(515, 310);
            txtBox_Role2.Margin = new Padding(3, 2, 3, 2);
            txtBox_Role2.Name = "txtBox_Role2";
            txtBox_Role2.Size = new Size(117, 32);
            txtBox_Role2.TabIndex = 22;
            txtBox_Role2.TextChanged += txtBox_Role2_TextChanged;
            // 
            // label_attribute
            // 
            label_attribute.AutoSize = true;
            label_attribute.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_attribute.Location = new Point(883, 97);
            label_attribute.Name = "label_attribute";
            label_attribute.RightToLeft = RightToLeft.Yes;
            label_attribute.Size = new Size(102, 25);
            label_attribute.TabIndex = 24;
            label_attribute.Text = "Thuộc tính";
            // 
            // cbx_attribute
            // 
            cbx_attribute.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_attribute.FormattingEnabled = true;
            cbx_attribute.Location = new Point(990, 94);
            cbx_attribute.Margin = new Padding(2);
            cbx_attribute.Name = "cbx_attribute";
            cbx_attribute.Size = new Size(117, 33);
            cbx_attribute.TabIndex = 23;
            cbx_attribute.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBox_WGO
            // 
            checkBox_WGO.AutoSize = true;
            checkBox_WGO.Location = new Point(883, 173);
            checkBox_WGO.Name = "checkBox_WGO";
            checkBox_WGO.Size = new Size(142, 19);
            checkBox_WGO.TabIndex = 25;
            checkBox_WGO.Text = "WITH GRANT OPTION";
            checkBox_WGO.UseVisualStyleBackColor = true;
            checkBox_WGO.CheckedChanged += checkBox_WGO_CheckedChanged;
            // 
            // btn_grant
            // 
            btn_grant.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_grant.Location = new Point(492, 158);
            btn_grant.Margin = new Padding(3, 2, 3, 2);
            btn_grant.Name = "btn_grant";
            btn_grant.Size = new Size(147, 41);
            btn_grant.TabIndex = 12;
            btn_grant.Text = "Grant";
            btn_grant.UseVisualStyleBackColor = true;
            btn_grant.Click += Grant_Click;
            // 
            // PhanQuyenHeThong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 478);
            Controls.Add(checkBox_WGO);
            Controls.Add(label_attribute);
            Controls.Add(cbx_attribute);
            Controls.Add(txtBox_Role2);
            Controls.Add(btn_RoleToUser);
            Controls.Add(txtBox_User2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Table);
            Controls.Add(cbx_table);
            Controls.Add(label3);
            Controls.Add(btn_grant);
            Controls.Add(cbx_privilege);
            Controls.Add(label1);
            Controls.Add(txtBox_user_role);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "PhanQuyenHeThong";
            Text = "PhanQuyenHeThong";
            Load += PhanQuyenHeThong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox_user_role;
        private Label label2;
        private Label label1;
        private ComboBox cbx_privilege;
        private Label label3;
        private ComboBox cbx_table;
        private Label Table;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBox_User2;
        private TextBox txtBox_Role2;
        private Label label_attribute;
        private ComboBox cbx_attribute;
        private CheckBox checkBox_WGO;
    }
}