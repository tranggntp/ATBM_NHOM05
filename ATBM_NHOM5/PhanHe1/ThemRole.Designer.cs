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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateUser = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreateUser);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 403);
            this.panel1.TabIndex = 2;
            // 
            // CreateUser
            // 
            this.CreateUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateUser.Location = new System.Drawing.Point(316, 294);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(105, 39);
            this.CreateUser.TabIndex = 5;
            this.CreateUser.Text = "Thêm";
            this.CreateUser.UseVisualStyleBackColor = true;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(352, 168);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(260, 39);
            this.Username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(143, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "RoleName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(256, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO ROLE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ThemRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "ThemRole";
            this.Text = "ThemRole";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button CreateUser;
        private TextBox Username;
        private Label label2;
        private Label label1;
    }
}