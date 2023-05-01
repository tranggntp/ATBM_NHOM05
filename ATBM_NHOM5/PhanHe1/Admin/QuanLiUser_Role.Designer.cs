namespace PhanHe1
{
    partial class QuanLiUser_Role
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            suauser = new Button();
            xoauser = new Button();
            themuser = new Button();
            label1 = new Label();
            panel2 = new Panel();
            xoarole = new Button();
            themrole = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(suauser);
            panel1.Controls.Add(xoauser);
            panel1.Controls.Add(themuser);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(233, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 319);
            panel1.TabIndex = 0;
            // 
            // suauser
            // 
            suauser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            suauser.Location = new Point(104, 237);
            suauser.Margin = new Padding(3, 2, 3, 2);
            suauser.Name = "suauser";
            suauser.Size = new Size(133, 40);
            suauser.TabIndex = 3;
            suauser.Text = "SỬA";
            suauser.UseVisualStyleBackColor = true;
            suauser.Click += suauser_Click;
            // 
            // xoauser
            // 
            xoauser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            xoauser.Location = new Point(104, 167);
            xoauser.Margin = new Padding(3, 2, 3, 2);
            xoauser.Name = "xoauser";
            xoauser.Size = new Size(133, 40);
            xoauser.TabIndex = 2;
            xoauser.Text = "XÓA";
            xoauser.UseVisualStyleBackColor = true;
            xoauser.Click += xoauser_Click;
            // 
            // themuser
            // 
            themuser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            themuser.Location = new Point(104, 93);
            themuser.Margin = new Padding(3, 2, 3, 2);
            themuser.Name = "themuser";
            themuser.Size = new Size(133, 40);
            themuser.TabIndex = 1;
            themuser.Text = "THÊM ";
            themuser.UseVisualStyleBackColor = true;
            themuser.Click += themuser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 34);
            label1.Name = "label1";
            label1.Size = new Size(234, 45);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ USER";
            // 
            // panel2
            // 
            panel2.Controls.Add(xoarole);
            panel2.Controls.Add(themrole);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(576, 11);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 319);
            panel2.TabIndex = 1;
            // 
            // xoarole
            // 
            xoarole.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            xoarole.Location = new Point(108, 208);
            xoarole.Margin = new Padding(3, 2, 3, 2);
            xoarole.Name = "xoarole";
            xoarole.Size = new Size(133, 40);
            xoarole.TabIndex = 4;
            xoarole.Text = "XÓA";
            xoarole.UseVisualStyleBackColor = true;
            xoarole.Click += xoarole_Click;
            // 
            // themrole
            // 
            themrole.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            themrole.Location = new Point(108, 123);
            themrole.Margin = new Padding(3, 2, 3, 2);
            themrole.Name = "themrole";
            themrole.Size = new Size(133, 40);
            themrole.TabIndex = 4;
            themrole.Text = "THÊM ";
            themrole.UseVisualStyleBackColor = true;
            themrole.Click += themrole_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 34);
            label2.Name = "label2";
            label2.Size = new Size(234, 45);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÝ ROLE";
            label2.Click += label2_Click;
            // 
            // QuanLiUser_Role
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 471);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuanLiUser_Role";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button themuser;
        private Button suauser;
        private Button xoauser;
        private Button xoarole;
        private Button themrole;
    }
}