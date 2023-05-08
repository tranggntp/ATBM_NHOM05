using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1.Admin
{
    public partial class Audit : Form
    {
        DataTable dtTableName = new DataTable();
        public Audit()
        {
            InitializeComponent();
        }

        private void dgv_Cau1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Audit_Load(object sender, EventArgs e)
        {
            string sql = "SELECT USERNAME, EXTENDED_TIMESTAMP, OBJ_NAME, ACTION_NAME, SQL_TEXT FROM DBA_AUDIT_TRAIL";
            dtTableName = Functions.GetDataToTable(sql);
            dgv_Main.DataSource = dtTableName;

            dgv_Main.Font = new Font("Segoe UI", 13);
            dgv_Main.EnableHeadersVisualStyles = false;
            dgv_Main.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

            dgv_Main.Columns[0].Width = 280;
            dgv_Main.Columns[1].Width = 280;
            dgv_Main.Columns[2].Width = 280;
            dgv_Main.Columns[3].Width = 280;

            dgv_Main.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv_Main.AllowUserToAddRows = false;
            dgv_Main.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
