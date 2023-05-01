namespace PhanHe1
{
    partial class XoaRole
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
            DeleteRole = new Button();
            Rolename = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1062, 428);
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
            panel1.Controls.Add(DeleteRole);
            panel1.Controls.Add(Rolename);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 21);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 403);
            panel1.TabIndex = 4;
            // 
            // DeleteRole
            // 
            DeleteRole.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteRole.Location = new Point(768, 128);
            DeleteRole.Margin = new Padding(3, 2, 3, 2);
            DeleteRole.Name = "DeleteRole";
            DeleteRole.Size = new Size(92, 29);
            DeleteRole.TabIndex = 5;
            DeleteRole.Text = "Xóa";
            DeleteRole.UseVisualStyleBackColor = true;
            DeleteRole.Click += DeleteUser_Click;
            // 
            // Rolename
            // 
            Rolename.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Rolename.Location = new Point(425, 127);
            Rolename.Margin = new Padding(3, 2, 3, 2);
            Rolename.Name = "Rolename";
            Rolename.Size = new Size(277, 32);
            Rolename.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(244, 130);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "RoleName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(481, 17);
            label1.Name = "label1";
            label1.Size = new Size(166, 45);
            label1.TabIndex = 0;
            label1.Text = "XÓA ROLE";
            // 
            // XoaRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 471);
            Controls.Add(button1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "XoaRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XoaRole";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button DeleteRole;
        private TextBox Rolename;
        private Label label2;
        private Label label1;
    }
}