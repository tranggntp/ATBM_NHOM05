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
            System.Windows.Forms.Button Grant;
            this.Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Quyen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            Grant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Grant
            // 
            Grant.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Grant.Location = new System.Drawing.Point(546, 407);
            Grant.Margin = new System.Windows.Forms.Padding(4);
            Grant.Name = "Grant";
            Grant.Size = new System.Drawing.Size(210, 69);
            Grant.TabIndex = 12;
            Grant.Text = "Grant";
            Grant.UseVisualStyleBackColor = true;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(479, 183);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(394, 45);
            this.Username.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(230, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhập User/Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(99, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quyền";
            // 
            // Quyen
            // 
            this.Quyen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quyen.FormattingEnabled = true;
            this.Quyen.Location = new System.Drawing.Point(479, 298);
            this.Quyen.Name = "Quyen";
            this.Quyen.Size = new System.Drawing.Size(394, 46);
            this.Quyen.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(100, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(968, 65);
            this.label3.TabIndex = 13;
            this.label3.Text = "GRANT QUYỀN HỆ THỐNG CHO ROLE/USER";
            // 
            // PhanQuyenHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(Grant);
            this.Controls.Add(this.Quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Name = "PhanQuyenHeThong";
            this.Text = "PhanQuyenHeThong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Username;
        private Label label2;
        private Label label1;
        private ComboBox Quyen;
        private Label label3;
    }
}