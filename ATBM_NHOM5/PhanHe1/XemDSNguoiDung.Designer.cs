namespace PhanHe1
{
    partial class XemDsNguoiDung
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
            dGV_listUser = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dGV_listUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(252, 37);
            label1.Name = "label1";
            label1.Size = new Size(274, 32);
            label1.TabIndex = 0;
            label1.Text = " Danh Sách Người Dùng";
            label1.Click += label1_Click;
            // 
            // dGV_listUser
            // 
            dGV_listUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_listUser.Location = new Point(0, 118);
            dGV_listUser.Name = "dGV_listUser";
            dGV_listUser.RowTemplate.Height = 25;
            dGV_listUser.Size = new Size(821, 325);
            dGV_listUser.TabIndex = 1;
            // 
            // XemDsNguoiDung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 450);
            Controls.Add(dGV_listUser);
            Controls.Add(label1);
            Name = "XemDsNguoiDung";
            Text = "XemDsNguoiDung";
            ((System.ComponentModel.ISupportInitialize)dGV_listUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dGV_listUser;
    }
}