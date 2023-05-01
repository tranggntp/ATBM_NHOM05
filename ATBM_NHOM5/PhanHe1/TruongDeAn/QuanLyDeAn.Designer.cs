namespace PhanHe1
{
    partial class QuanLyDeAn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ThemDeAn = new System.Windows.Forms.Button();
            this.btn_UpdateDeAn = new System.Windows.Forms.Button();
            this.btn_XoaDeAn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_ThemDeAn
            // 
            this.btn_ThemDeAn.Location = new System.Drawing.Point(328, 185);
            this.btn_ThemDeAn.Name = "btn_ThemDeAn";
            this.btn_ThemDeAn.Size = new System.Drawing.Size(156, 34);
            this.btn_ThemDeAn.TabIndex = 1;
            this.btn_ThemDeAn.Text = "Thêm Đề Án";
            this.btn_ThemDeAn.UseVisualStyleBackColor = true;
            this.btn_ThemDeAn.Click += new System.EventHandler(this.btn_ThemDeAn_Click);
            // 
            // btn_UpdateDeAn
            // 
            this.btn_UpdateDeAn.Location = new System.Drawing.Point(521, 185);
            this.btn_UpdateDeAn.Name = "btn_UpdateDeAn";
            this.btn_UpdateDeAn.Size = new System.Drawing.Size(160, 34);
            this.btn_UpdateDeAn.TabIndex = 2;
            this.btn_UpdateDeAn.Text = "Cập Nhật Đề Án";
            this.btn_UpdateDeAn.UseVisualStyleBackColor = true;
            this.btn_UpdateDeAn.Click += new System.EventHandler(this.btn_UpdateDeAn_Click);
            // 
            // btn_XoaDeAn
            // 
            this.btn_XoaDeAn.Location = new System.Drawing.Point(709, 185);
            this.btn_XoaDeAn.Name = "btn_XoaDeAn";
            this.btn_XoaDeAn.Size = new System.Drawing.Size(156, 34);
            this.btn_XoaDeAn.TabIndex = 3;
            this.btn_XoaDeAn.Text = "Xóa Đề Án";
            this.btn_XoaDeAn.UseVisualStyleBackColor = true;
            this.btn_XoaDeAn.Click += new System.EventHandler(this.btn_XoaDeAn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Đề Án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Đề Án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phòng ban phụ trách";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 31);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 31);
            this.textBox2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(734, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(328, 31);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(790, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(444, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Danh Sách Các Đề Án Hiện Có";
            // 
            // QuanLyDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 625);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XoaDeAn);
            this.Controls.Add(this.btn_UpdateDeAn);
            this.Controls.Add(this.btn_ThemDeAn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLyDeAn";
            this.Text = "QuanLyDeAn";
            this.Load += new System.EventHandler(this.QuanLyDeAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_ThemDeAn;
        private Button btn_UpdateDeAn;
        private Button btn_XoaDeAn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label5;
    }
}