namespace PhanHe1
{
    partial class XemQuyen
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
            View = new Button();
            Username = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // View
            // 
            View.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            View.ImageAlign = ContentAlignment.TopCenter;
            View.Location = new Point(761, 42);
            View.Margin = new Padding(3, 2, 3, 2);
            View.Name = "View";
            View.Size = new Size(144, 39);
            View.TabIndex = 8;
            View.Text = "Xem quyền";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(447, 49);
            Username.Margin = new Padding(3, 2, 3, 2);
            Username.Name = "Username";
            Username.Size = new Size(277, 32);
            Username.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(230, 49);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 6;
            label2.Text = "Nhập tên User/ Role";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 101);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1161, 359);
            dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(427, 9);
            label3.Name = "label3";
            label3.Size = new Size(328, 37);
            label3.TabIndex = 14;
            label3.Text = "Xem quyền của User/ Role";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // XemQuyen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 471);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(View);
            Controls.Add(Username);
            Controls.Add(label2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "XemQuyen";
            Text = "XemQuyenUser";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button View;
        private TextBox Username;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
    }
}