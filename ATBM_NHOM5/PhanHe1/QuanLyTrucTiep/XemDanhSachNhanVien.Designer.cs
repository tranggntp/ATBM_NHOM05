namespace PhanHe1.QuanLyTrucTiep
{
    partial class XemDanhSachNhanVien
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
            dgv_XemDanhSachNhanVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_XemDanhSachNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 1;
            label1.Text = "Danh sách nhân viên";
            // 
            // dgv_XemDanhSachNhanVien
            // 
            dgv_XemDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_XemDanhSachNhanVien.Dock = DockStyle.Fill;
            dgv_XemDanhSachNhanVien.Location = new Point(0, 0);
            dgv_XemDanhSachNhanVien.Name = "dgv_XemDanhSachNhanVien";
            dgv_XemDanhSachNhanVien.RowTemplate.Height = 25;
            dgv_XemDanhSachNhanVien.Size = new Size(800, 450);
            dgv_XemDanhSachNhanVien.TabIndex = 2;
            // 
            // XemDanhSachNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_XemDanhSachNhanVien);
            Controls.Add(label1);
            Name = "XemDanhSachNhanVien";
            Text = "XemDanhSachNhanVien";
            Load += XemDanhSachNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_XemDanhSachNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_XemDanhSachNhanVien;
    }
}