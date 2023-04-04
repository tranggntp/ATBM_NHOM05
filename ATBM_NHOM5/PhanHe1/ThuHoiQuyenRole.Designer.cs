namespace PhanHe1
{
    partial class ThuHoiQuyenRole
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBox_Role = new TextBox();
            button1 = new Button();
            cbx_privilege = new ComboBox();
            cbx_table = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(465, 55);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 0;
            label1.Text = "THU HỒI QUYỀN ROLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(331, 129);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 1;
            label2.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(331, 184);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 2;
            label3.Text = "Privileges";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(331, 238);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 3;
            label4.Text = "Table";
            // 
            // txtBox_Role
            // 
            txtBox_Role.Location = new Point(465, 134);
            txtBox_Role.Name = "txtBox_Role";
            txtBox_Role.Size = new Size(244, 23);
            txtBox_Role.TabIndex = 5;
            txtBox_Role.TextChanged += txtBox_Role_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(551, 322);
            button1.Name = "button1";
            button1.Size = new Size(89, 36);
            button1.TabIndex = 7;
            button1.Text = "Revoke";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_xacnhan_Click1;
            // 
            // cbx_privilege
            // 
            cbx_privilege.FormattingEnabled = true;
            cbx_privilege.Location = new Point(465, 189);
            cbx_privilege.Name = "cbx_privilege";
            cbx_privilege.Size = new Size(244, 23);
            cbx_privilege.TabIndex = 8;
            // 
            // cbx_table
            // 
            cbx_table.FormattingEnabled = true;
            cbx_table.Location = new Point(465, 240);
            cbx_table.Name = "cbx_table";
            cbx_table.Size = new Size(244, 23);
            cbx_table.TabIndex = 9;
            // 
            // ThuHoiQuyenRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 471);
            Controls.Add(cbx_table);
            Controls.Add(cbx_privilege);
            Controls.Add(button1);
            Controls.Add(txtBox_Role);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThuHoiQuyenRole";
            Text = "ThuHoiQuyenRole";
            Load += ThuHoiQuyenRole_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBox_Role;
        private Button button1;
        private ComboBox cbx_privilege;
        private ComboBox cbx_table;
    }
}