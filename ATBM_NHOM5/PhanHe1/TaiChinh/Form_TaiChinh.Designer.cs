namespace PhanHe1
{
    partial class Form_TaiChinh
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
            btn_xemToanBoNV = new Button();
            btn_xemToanBoPC = new Button();
            btn_capNhatLuongPhuCap = new Button();
            btn_thoat = new Button();
            btn_xemTTCN = new Button();
            oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btn_xemToanBoNV
            // 
            btn_xemToanBoNV.Location = new Point(12, 12);
            btn_xemToanBoNV.Name = "btn_xemToanBoNV";
            btn_xemToanBoNV.Size = new Size(130, 50);
            btn_xemToanBoNV.TabIndex = 0;
            btn_xemToanBoNV.Text = "Xem toàn bộ nhân viên";
            btn_xemToanBoNV.UseVisualStyleBackColor = true;
            btn_xemToanBoNV.Click += btn_xemToanBoNhanVien_Click;
            // 
            // btn_xemToanBoPC
            // 
            btn_xemToanBoPC.Location = new Point(165, 12);
            btn_xemToanBoPC.Name = "btn_xemToanBoPC";
            btn_xemToanBoPC.Size = new Size(130, 50);
            btn_xemToanBoPC.TabIndex = 1;
            btn_xemToanBoPC.Text = "Xem toàn bộ phân công";
            btn_xemToanBoPC.UseVisualStyleBackColor = true;
            btn_xemToanBoPC.Click += btn_xemToanBoPhanCong_Click;
            // 
            // btn_capNhatLuongPhuCap
            // 
            btn_capNhatLuongPhuCap.Location = new Point(317, 12);
            btn_capNhatLuongPhuCap.Name = "btn_capNhatLuongPhuCap";
            btn_capNhatLuongPhuCap.Size = new Size(130, 50);
            btn_capNhatLuongPhuCap.TabIndex = 2;
            btn_capNhatLuongPhuCap.Text = "Cập nhật lương/ phụ cấp";
            btn_capNhatLuongPhuCap.UseVisualStyleBackColor = true;
            btn_capNhatLuongPhuCap.Click += btn_capNhatLuongPhuCap_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(670, 39);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(75, 23);
            btn_thoat.TabIndex = 4;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_xemTTCN
            // 
            btn_xemTTCN.Location = new Point(473, 12);
            btn_xemTTCN.Name = "btn_xemTTCN";
            btn_xemTTCN.Size = new Size(130, 50);
            btn_xemTTCN.TabIndex = 5;
            btn_xemTTCN.Text = "Xem với tư cách nhân viên";
            btn_xemTTCN.UseVisualStyleBackColor = true;
            btn_xemTTCN.Click += btn_xemTTCN_Click;
            // 
            // oracleCommand1
            // 
            oracleCommand1.Transaction = null;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 354);
            panel1.TabIndex = 6;
            // 
            // Form_TaiChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btn_xemTTCN);
            Controls.Add(btn_thoat);
            Controls.Add(btn_capNhatLuongPhuCap);
            Controls.Add(btn_xemToanBoPC);
            Controls.Add(btn_xemToanBoNV);
            Name = "Form_TaiChinh";
            Text = "Form_TaiChinh";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_xemToanBoNV;
        private Button btn_xemToanBoPC;
        private Button btn_capNhatLuongPhuCap;
        private Button btn_thoat;
        private Button btn_xemTTCN;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private Panel panel1;
    }
}