namespace PhanHe1
{
    partial class TaoUser
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
            panel1 = new Panel();
            CreateUser = new Button();
            Password = new TextBox();
            label3 = new Label();
            Username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CreateUser);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(39, 17);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 302);
            panel1.TabIndex = 0;
            // 
            // CreateUser
            // 
            CreateUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CreateUser.Location = new Point(500, 244);
            CreateUser.Margin = new Padding(3, 2, 3, 2);
            CreateUser.Name = "CreateUser";
            CreateUser.Size = new Size(92, 29);
            CreateUser.TabIndex = 5;
            CreateUser.Text = "Thêm";
            CreateUser.UseVisualStyleBackColor = true;
            CreateUser.Click += CreateUser_Click;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(428, 154);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.PasswordChar = '•';
            Password.Size = new Size(228, 32);
            Password.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(222, 161);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(428, 95);
            Username.Margin = new Padding(3, 2, 3, 2);
            Username.Name = "Username";
            Username.Size = new Size(228, 32);
            Username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(222, 102);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(466, 16);
            label1.Name = "label1";
            label1.Size = new Size(165, 45);
            label1.TabIndex = 0;
            label1.Text = "TẠO USER";
            // 
            // button1
            // 
            button1.Location = new Point(1036, 418);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 1;
            button1.Text = "Trở về";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TaoUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 471);
            Controls.Add(button1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TaoUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaoUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox Password;
        private Label label3;
        private TextBox Username;
        private Label label2;
        private Label label1;
        private Button CreateUser;
        private Button button1;
    }
}