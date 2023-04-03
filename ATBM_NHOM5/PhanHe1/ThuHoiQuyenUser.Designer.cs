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
            txtBox_Table = new TextBox();
            txtB_Privileges = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(407, 56);
            label1.Name = "label1";
            label1.Size = new Size(302, 32);
            label1.TabIndex = 0;
            label1.Text = "Thu hồi quyền người dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(273, 124);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "UserName:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(273, 176);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 2;
            label3.Text = "Privileges";
            // 
            // txtB_UserName
            // 
            txtB_UserName.Location = new Point(407, 122);
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
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(273, 232);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 6;
            label4.Text = "Table";
            label4.Click += label4_Click;
            // 
            // txtBox_Table
            // 
            txtBox_Table.Location = new Point(407, 230);
            txtBox_Table.Name = "txtBox_Table";
            txtBox_Table.Size = new Size(291, 23);
            txtBox_Table.TabIndex = 7;
            // 
            // txtB_Privileges
            // 
            txtB_Privileges.Location = new Point(407, 178);
            txtB_Privileges.Name = "txtB_Privileges";
            txtB_Privileges.Size = new Size(291, 23);
            txtB_Privileges.TabIndex = 8;
            // 
            // ThuHoiQuyenUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 471);
            Controls.Add(txtB_Privileges);
            Controls.Add(txtBox_Table);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtB_UserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThuHoiQuyenUser";
            Text = "ThuHoiQuyenUser";
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
        private TextBox txtBox_Table;
        private TextBox txtB_Privileges;
    }
}