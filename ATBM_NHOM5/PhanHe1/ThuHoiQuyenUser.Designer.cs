namespace PhanHe1
{
    partial class ThuHoiQuyenUser
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
            txtB_UserName = new TextBox();
            button1 = new Button();
            label4 = new Label();
            cbx_privilege = new ComboBox();
            cbx_table = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(407, 56);
            label1.Name = "label1";
            label1.Size = new Size(348, 32);
            label1.TabIndex = 0;
            label1.Text = "THU HỒI QUYỀN NGƯỜI DÙNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(273, 124);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "UserName:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(273, 176);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "Privileges:";
            // 
            // txtB_UserName
            // 
            txtB_UserName.Location = new Point(428, 124);
            txtB_UserName.Name = "txtB_UserName";
            txtB_UserName.Size = new Size(291, 23);
            txtB_UserName.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(515, 305);
            button1.Name = "button1";
            button1.Size = new Size(88, 34);
            button1.TabIndex = 5;
            button1.Text = "Revoke";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_xacnhan_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(273, 232);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 6;
            label4.Text = "Table:";
            label4.Click += label4_Click;
            // 
            // cbx_privilege
            // 
            cbx_privilege.FormattingEnabled = true;
            cbx_privilege.Location = new Point(428, 176);
            cbx_privilege.Name = "cbx_privilege";
            cbx_privilege.Size = new Size(291, 23);
            cbx_privilege.TabIndex = 7;
            // 
            // cbx_table
            // 
            cbx_table.FormattingEnabled = true;
            cbx_table.Location = new Point(428, 234);
            cbx_table.Name = "cbx_table";
            cbx_table.Size = new Size(291, 23);
            cbx_table.TabIndex = 8;
            // 
            // ThuHoiQuyenUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 471);
            Controls.Add(cbx_table);
            Controls.Add(cbx_privilege);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtB_UserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThuHoiQuyenUser";
            Text = "ThuHoiQuyenUser";
            Load += ThuHoiQuyenUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtB_UserName;
        private Button button1;
        private Label label4;
        private ComboBox cbx_privilege;
        private ComboBox cbx_table;
    }
}