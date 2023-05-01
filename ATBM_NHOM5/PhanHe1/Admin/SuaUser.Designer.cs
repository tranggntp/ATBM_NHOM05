namespace PhanHe1
{
    partial class SuaUser
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
            button1 = new Button();
            panel1 = new Panel();
            NewPass = new TextBox();
            label3 = new Label();
            EditUser = new Button();
            Username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1056, 428);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 5;
            button1.Text = "Trở về";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(NewPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(EditUser);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 20);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 279);
            panel1.TabIndex = 4;
            // 
            // NewPass
            // 
            NewPass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            NewPass.Location = new Point(415, 139);
            NewPass.Margin = new Padding(3, 2, 3, 2);
            NewPass.Name = "NewPass";
            NewPass.PasswordChar = '•';
            NewPass.Size = new Size(277, 32);
            NewPass.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(226, 146);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 6;
            label3.Text = "Password mới";
            // 
            // EditUser
            // 
            EditUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EditUser.Location = new Point(507, 218);
            EditUser.Margin = new Padding(3, 2, 3, 2);
            EditUser.Name = "EditUser";
            EditUser.Size = new Size(92, 29);
            EditUser.TabIndex = 5;
            EditUser.Text = "Sửa";
            EditUser.UseVisualStyleBackColor = true;
            EditUser.Click += DeleteUser_Click;
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(415, 81);
            Username.Margin = new Padding(3, 2, 3, 2);
            Username.Name = "Username";
            Username.Size = new Size(277, 32);
            Username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(226, 88);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(475, 13);
            label1.Name = "label1";
            label1.Size = new Size(164, 45);
            label1.TabIndex = 0;
            label1.Text = "SỬA USER";
            // 
            // SuaUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 471);
            Controls.Add(button1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SuaUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuaUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button EditUser;
        private TextBox Username;
        private Label label2;
        private Label label1;
        private TextBox NewPass;
        private Label label3;
    }
}