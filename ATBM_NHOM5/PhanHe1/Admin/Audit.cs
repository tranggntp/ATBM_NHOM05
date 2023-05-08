using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
            Audit_Standard();
            Audit_1();
            Audit_2();
            Audit_3();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_audit_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Audit_Standard()
        {
            string sql = "SELECT USERNAME, EXTENDED_TIMESTAMP, OBJ_NAME, ACTION_NAME, SQL_TEXT FROM DBA_AUDIT_TRAIL";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = dtTableName;

            dataGridView1.Font = new Font("Segoe UI", 13);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Audit_1()
        {
            string sql = "SELECT AUDIT_TYPE,FGA_POLICY_NAME, DBUSERNAME, ACTION_NAME, SQL_TEXT, EVENT_TIMESTAMP FROM UNIFIED_AUDIT_TRAIL WHERE AUDIT_TYPE = 'FineGrainedAudit' AND FGA_POLICY_NAME = 'AUDIT_UPDATE_THOIGIAN_PC'";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView2.DataSource = dtTableName;

            dataGridView2.Font = new Font("Segoe UI", 13);
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

            dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Audit_2()
        {
            string sql = "SELECT AUDIT_TYPE,FGA_POLICY_NAME, DBUSERNAME, ACTION_NAME, SQL_TEXT, EVENT_TIMESTAMP FROM UNIFIED_AUDIT_TRAIL WHERE AUDIT_TYPE = 'FineGrainedAudit' AND OBJECT_NAME = 'NHANVIEN'";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView3.DataSource = dtTableName;

            dataGridView3.Font = new Font("Segoe UI", 13);
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

            dataGridView3.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Audit_3()
        {
            string sql = "SELECT AUDIT_TYPE,FGA_POLICY_NAME, DBUSERNAME, ACTION_NAME, SQL_TEXT, EVENT_TIMESTAMP FROM UNIFIED_AUDIT_TRAIL WHERE AUDIT_TYPE = 'FineGrainedAudit' AND FGA_POLICY_NAME = 'AUDIT_XEM_LUONG_PHUCAP_VAI_TRO_KHONG_LA_TC'";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView4.DataSource = dtTableName;

            dataGridView4.Font = new Font("Segoe UI", 13);
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

            dataGridView4.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
