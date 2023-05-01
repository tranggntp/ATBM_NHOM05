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
    public partial class XemDeAn : Form
    {
        DataTable dtTableName = new DataTable();

        public XemDeAn()
        {
            InitializeComponent();
        }

        private void XemDeAn_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ad_n5.DEAN";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = dtTableName;

            dataGridView1.Font = new Font("Segoe UI", 13);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;


            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 200;


            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
