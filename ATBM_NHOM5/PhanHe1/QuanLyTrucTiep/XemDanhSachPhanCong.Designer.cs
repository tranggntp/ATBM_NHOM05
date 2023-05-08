namespace PhanHe1.QuanLyTrucTiep
{
    partial class XemDanhSachPhanCong
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
            dgv_PhanCong = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_PhanCong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(299, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 2;
            label1.Text = "Danh sách phân công";
            // 
            // dgv_PhanCong
            // 
            dgv_PhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_PhanCong.Dock = DockStyle.Fill;
            dgv_PhanCong.Location = new Point(0, 0);
            dgv_PhanCong.Name = "dgv_PhanCong";
            dgv_PhanCong.RowTemplate.Height = 25;
            dgv_PhanCong.Size = new Size(800, 450);
            dgv_PhanCong.TabIndex = 3;
            // 
            // XemDanhSachPhanCong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_PhanCong);
            Controls.Add(label1);
            Name = "XemDanhSachPhanCong";
            Text = "XemDanhSachPhanCong";
            Load += XemDanhSachPhanCong_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_PhanCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_PhanCong;
    }
}