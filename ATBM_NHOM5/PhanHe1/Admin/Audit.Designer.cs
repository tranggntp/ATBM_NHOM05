namespace PhanHe1.Admin
{
    partial class Audit
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
            dgv_Main = new DataGridView();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).BeginInit();
            SuspendLayout();
            // 
            // dgv_Main
            // 
            dgv_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Main.Location = new Point(2, 60);
            dgv_Main.Name = "dgv_Main";
            dgv_Main.RowTemplate.Height = 25;
            dgv_Main.Size = new Size(1160, 490);
            dgv_Main.TabIndex = 0;
            dgv_Main.CellContentClick += dgv_Cau1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(488, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 1;
            label1.Text = "Audit hệ thống";
            // 
            // Audit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 562);
            Controls.Add(label1);
            Controls.Add(dgv_Main);
            Name = "Audit";
            Text = "Audit";
            Load += Audit_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Main).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Main;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}