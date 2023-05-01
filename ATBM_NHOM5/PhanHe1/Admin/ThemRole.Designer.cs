namespace PhanHe1
{
    partial class ThemRole
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
            CreateRole = new Button();
            RoleName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1040, 419);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 3;
            button1.Text = "Trở về";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(CreateRole);
            panel1.Controls.Add(RoleName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(38, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 302);
            panel1.TabIndex = 2;
            // 
            // CreateRole
            // 
            CreateRole.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CreateRole.Location = new Point(493, 202);
            CreateRole.Margin = new Padding(3, 2, 3, 2);
            CreateRole.Name = "CreateRole";
            CreateRole.Size = new Size(92, 29);
            CreateRole.TabIndex = 5;
            CreateRole.Text = "Thêm";
            CreateRole.UseVisualStyleBackColor = true;
            CreateRole.Click += CreateRole_Click;
            // 
            // RoleName
            // 
            RoleName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            RoleName.Location = new Point(430, 111);
            RoleName.Margin = new Padding(3, 2, 3, 2);
            RoleName.Name = "RoleName";
            RoleName.Size = new Size(228, 32);
            RoleName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(229, 118);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "RoleName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(465, 11);
            label1.Name = "label1";
            label1.Size = new Size(165, 45);
            label1.TabIndex = 0;
            label1.Text = "TẠO ROLE";
            label1.Click += label1_Click;
            // 
            // ThemRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 471);
            Controls.Add(button1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThemRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemRole";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button CreateRole;
        private TextBox RoleName;
        private Label label2;
        private Label label1;
    }
}