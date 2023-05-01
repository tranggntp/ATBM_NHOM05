namespace PhanHe1
{
    partial class Form_NhanVien
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
            this.xemNhanVien = new System.Windows.Forms.Button();
            this.xemPhanCong = new System.Windows.Forms.Button();
            this.xemPhongBan = new System.Windows.Forms.Button();
            this.xemDeAn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xemNhanVien
            // 
            this.xemNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xemNhanVien.Location = new System.Drawing.Point(29, 28);
            this.xemNhanVien.Name = "xemNhanVien";
            this.xemNhanVien.Size = new System.Drawing.Size(186, 100);
            this.xemNhanVien.TabIndex = 1;
            this.xemNhanVien.Text = "Xem Thông Tin Cá Nhân";
            this.xemNhanVien.UseVisualStyleBackColor = true;
            this.xemNhanVien.Click += new System.EventHandler(this.xemNhanVien_Click);
            // 
            // xemPhanCong
            // 
            this.xemPhanCong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xemPhanCong.Location = new System.Drawing.Point(239, 28);
            this.xemPhanCong.Name = "xemPhanCong";
            this.xemPhanCong.Size = new System.Drawing.Size(186, 100);
            this.xemPhanCong.TabIndex = 2;
            this.xemPhanCong.Text = "Xem Phân Công";
            this.xemPhanCong.UseVisualStyleBackColor = true;
            this.xemPhanCong.Click += new System.EventHandler(this.xemPhanCong_Click);
            // 
            // xemPhongBan
            // 
            this.xemPhongBan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xemPhongBan.Location = new System.Drawing.Point(443, 28);
            this.xemPhongBan.Name = "xemPhongBan";
            this.xemPhongBan.Size = new System.Drawing.Size(186, 100);
            this.xemPhongBan.TabIndex = 3;
            this.xemPhongBan.Text = "Xem Phòng Ban";
            this.xemPhongBan.UseVisualStyleBackColor = true;
            this.xemPhongBan.Click += new System.EventHandler(this.xemPhongBan_Click);
            // 
            // xemDeAn
            // 
            this.xemDeAn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xemDeAn.Location = new System.Drawing.Point(649, 28);
            this.xemDeAn.Name = "xemDeAn";
            this.xemDeAn.Size = new System.Drawing.Size(186, 100);
            this.xemDeAn.TabIndex = 4;
            this.xemDeAn.Text = "Xem Đề Án";
            this.xemDeAn.UseVisualStyleBackColor = true;
            this.xemDeAn.Click += new System.EventHandler(this.xemDeAn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 531);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(987, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xemDeAn);
            this.Controls.Add(this.xemPhongBan);
            this.Controls.Add(this.xemPhanCong);
            this.Controls.Add(this.xemNhanVien);
            this.Name = "Form_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_NhanVien";
            this.Load += new System.EventHandler(this.Form_NhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button xemNhanVien;
        private Button xemPhanCong;
        private Button xemPhongBan;
        private Button xemDeAn;
        private Panel panel1;
        private Button button1;
    }
}