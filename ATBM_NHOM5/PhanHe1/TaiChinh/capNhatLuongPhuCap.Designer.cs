namespace PhanHe1
{
    partial class capNhatLuongPhuCap
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbx_luongphucap = new ComboBox();
            txtBox_tien = new TextBox();
            txtBox_maNV = new TextBox();
            btn_capNhat = new Button();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(243, 50);
            label1.Name = "label1";
            label1.Size = new Size(253, 25);
            label1.TabIndex = 0;
            label1.Text = "CẬP NHẬT LƯƠNG/PHỤ CẤP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 122);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 1;
            label2.Text = "Chọn lương/ phụ cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 164);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Nhập vào số tiền ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 202);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 3;
            label4.Text = "Nhập mã nhân viên ";
            // 
            // cbx_luongphucap
            // 
            cbx_luongphucap.FormattingEnabled = true;
            cbx_luongphucap.Location = new Point(243, 114);
            cbx_luongphucap.Name = "cbx_luongphucap";
            cbx_luongphucap.Size = new Size(121, 23);
            cbx_luongphucap.TabIndex = 4;
            // 
            // txtBox_tien
            // 
            txtBox_tien.Location = new Point(243, 156);
            txtBox_tien.Name = "txtBox_tien";
            txtBox_tien.Size = new Size(121, 23);
            txtBox_tien.TabIndex = 5;
            // 
            // txtBox_maNV
            // 
            txtBox_maNV.Location = new Point(243, 194);
            txtBox_maNV.Name = "txtBox_maNV";
            txtBox_maNV.Size = new Size(121, 23);
            txtBox_maNV.TabIndex = 6;
            // 
            // btn_capNhat
            // 
            btn_capNhat.Location = new Point(567, 156);
            btn_capNhat.Name = "btn_capNhat";
            btn_capNhat.Size = new Size(75, 23);
            btn_capNhat.TabIndex = 7;
            btn_capNhat.Text = "cập nhật";
            btn_capNhat.UseVisualStyleBackColor = true;
            btn_capNhat.Click += btn_capNhat_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(12, 12);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(91, 34);
            btn_thoat.TabIndex = 8;
            btn_thoat.Text = "thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            // 
            // capNhatLuongPhuCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_thoat);
            Controls.Add(btn_capNhat);
            Controls.Add(txtBox_maNV);
            Controls.Add(txtBox_tien);
            Controls.Add(cbx_luongphucap);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "capNhatLuongPhuCap";
            Text = "capNhatLuongPhuCap";
            Load += capNhatLuongPhuCap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbx_luongphucap;
        private TextBox txtBox_tien;
        private TextBox txtBox_maNV;
        private Button btn_capNhat;
        private Button btn_thoat;
    }
}