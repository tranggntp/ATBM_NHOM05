using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1
{
    public partial class xemToanBoNhanVien : Form
    {
        Thread t;
        DataTable dtTableName = new DataTable();
        public xemToanBoNhanVien()
        {
            InitializeComponent();
        }

        private void XemToanBoNhanVien_Load(object sender, EventArgs e)
        {
            string sql = "select * from AD_N5.view_decrypt_LUONGPHUCAP";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = dtTableName;

            dataGridView1.Font = new Font("Segoe UI", 13);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;


            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Width = 150;
            dataGridView1.Columns[8].Width = 150;
            dataGridView1.Columns[9].Width = 150;
            dataGridView1.Columns[10].Width = 150;


            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }





    }
}
