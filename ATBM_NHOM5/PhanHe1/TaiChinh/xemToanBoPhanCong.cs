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
    public partial class xemToanBoPhanCong : Form
    {
        DataTable dtTableName = new DataTable();
        public xemToanBoPhanCong()
        {
            InitializeComponent();
        }


        private void XemToanBoPhanCong_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ad_n5.PHANCONG";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = dtTableName;

            dataGridView1.Font = new Font("Segoe UI", 13);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;


            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 250;


            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
