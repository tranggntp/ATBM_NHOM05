namespace PhanHe1.QuanLyTrucTiep
{
    partial class Form_QuanLyTrucTiep
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
            btn_XemDanhSachNguoiDung = new Button();
            btn_XemPhanCong = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btn_XemDanhSachNguoiDung
            // 
            btn_XemDanhSachNguoiDung.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XemDanhSachNguoiDung.Location = new Point(140, 11);
            btn_XemDanhSachNguoiDung.Margin = new Padding(2);
            btn_XemDanhSachNguoiDung.Name = "btn_XemDanhSachNguoiDung";
            btn_XemDanhSachNguoiDung.Size = new Size(162, 60);
            btn_XemDanhSachNguoiDung.TabIndex = 3;
            btn_XemDanhSachNguoiDung.Text = "Xem danh sách nhân viên được quản lí";
            btn_XemDanhSachNguoiDung.UseVisualStyleBackColor = true;
            btn_XemDanhSachNguoiDung.Click += btn_XemDanhSachNguoiDung_Click;
            // 
            // btn_XemPhanCong
            // 
            btn_XemPhanCong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XemPhanCong.Location = new Point(470, 11);
            btn_XemPhanCong.Margin = new Padding(2);
            btn_XemPhanCong.Name = "btn_XemPhanCong";
            btn_XemPhanCong.Size = new Size(142, 60);
            btn_XemPhanCong.TabIndex = 8;
            btn_XemPhanCong.Text = "Xem danh sách phân công";
            btn_XemPhanCong.UseVisualStyleBackColor = true;
            btn_XemPhanCong.Click += btn_XemPhanCong_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(2, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 361);
            panel1.TabIndex = 9;
            // 
            // Form_QuanLyTrucTiep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btn_XemPhanCong);
            Controls.Add(btn_XemDanhSachNguoiDung);
            Name = "Form_QuanLyTrucTiep";
            Text = "Form_QuanLyTrucTiep";
            Load += Form_QuanLyTrucTiep_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btn_XemDanhSachNguoiDung;
        private Button btn_XemPhanCong;
        private Panel panel1;
    }
}