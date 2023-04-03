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
            Button Grant;
            Username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Quyen = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            Grant = new Button();
            SuspendLayout();
            // 
            // Grant
            // 
            Grant.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Grant.Location = new Point(330, 274);
            Grant.Margin = new Padding(3, 2, 3, 2);
            Grant.Name = "Grant";
            Grant.Size = new Size(147, 41);
            Grant.TabIndex = 12;
            Grant.Text = "Grant";
            Grant.UseVisualStyleBackColor = true;
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(342, 98);
            Username.Margin = new Padding(3, 2, 3, 2);
            Username.Name = "Username";
            Username.Size = new Size(277, 32);
            Username.TabIndex = 9;
            Username.TextChanged += Username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(161, 101);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 8;
            label2.Text = "Nhập User/Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(161, 149);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(67, 25);
            label1.TabIndex = 10;
            label1.Text = "Quyền";
            // 
            // Quyen
            // 
            Quyen.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Quyen.FormattingEnabled = true;
            Quyen.Location = new Point(342, 146);
            Quyen.Margin = new Padding(2);
            Quyen.Name = "Quyen";
            Quyen.Size = new Size(277, 33);
            Quyen.TabIndex = 11;
            Quyen.SelectedIndexChanged += Quyen_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 37);
            label3.Name = "label3";
            label3.Size = new Size(648, 45);
            label3.TabIndex = 13;
            label3.Text = "GRANT QUYỀN HỆ THỐNG CHO ROLE/USER";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(342, 196);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 33);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(161, 199);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(89, 25);
            label4.TabIndex = 15;
            label4.Text = "Tên bảng";
            label4.Click += label4_Click;
            // 
            // PhanQuyenHeThong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 326);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(Grant);
            Controls.Add(Quyen);
            Controls.Add(label1);
            Controls.Add(Username);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "PhanQuyenHeThong";
            Text = "PhanQuyenHeThong";
            Load += PhanQuyenHeThong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private Label label2;
        private Label label1;
        private ComboBox Quyen;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
    }
}