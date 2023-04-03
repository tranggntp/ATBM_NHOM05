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
            Button Grant;
            txtBox_user_role = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbx_privilege = new ComboBox();
            label3 = new Label();
            cbx_table = new ComboBox();
            Table = new Label();
            Grant = new Button();
            SuspendLayout();
            // 
            // Grant
            // 
            Grant.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Grant.Location = new Point(268, 297);
            Grant.Margin = new Padding(3, 2, 3, 2);
            Grant.Name = "Grant";
            Grant.Size = new Size(147, 41);
            Grant.TabIndex = 12;
            Grant.Text = "Grant";
            Grant.UseVisualStyleBackColor = true;
            Grant.Click += Grant_Click;
            // 
            // txtBox_user_role
            // 
            txtBox_user_role.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_user_role.Location = new Point(207, 114);
            txtBox_user_role.Margin = new Padding(3, 2, 3, 2);
            txtBox_user_role.Name = "txtBox_user_role";
            txtBox_user_role.Size = new Size(277, 32);
            txtBox_user_role.TabIndex = 9;
            txtBox_user_role.TextChanged += txtBox_user_role_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 117);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 8;
            label2.Text = "Nhập User/Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 179);
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
            cbx_privilege.Location = new Point(207, 176);
            cbx_privilege.Margin = new Padding(2);
            cbx_privilege.Name = "cbx_privilege";
            cbx_privilege.Size = new Size(277, 33);
            cbx_privilege.TabIndex = 11;
            cbx_privilege.SelectedIndexChanged += cbx_privilege_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 37);
            label3.Name = "label3";
            label3.Size = new Size(648, 45);
            label3.TabIndex = 13;
            label3.Text = "GRANT QUYỀN HỆ THỐNG CHO ROLE/USER";
            // 
            // cbx_table
            // 
            cbx_table.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_table.FormattingEnabled = true;
            cbx_table.Location = new Point(207, 240);
            cbx_table.Margin = new Padding(2);
            cbx_table.Name = "cbx_table";
            cbx_table.Size = new Size(277, 33);
            cbx_table.TabIndex = 14;
            cbx_table.SelectedIndexChanged += cbx_table_SelectedIndexChanged;
            // 
            // Table
            // 
            Table.AutoSize = true;
            Table.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Table.Location = new Point(24, 243);
            Table.Name = "Table";
            Table.RightToLeft = RightToLeft.Yes;
            Table.Size = new Size(55, 25);
            Table.TabIndex = 15;
            Table.Text = "Bảng";
            // 
            // PhanQuyenHeThong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 478);
            Controls.Add(Table);
            Controls.Add(cbx_table);
            Controls.Add(label3);
            Controls.Add(Grant);
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
    }
}