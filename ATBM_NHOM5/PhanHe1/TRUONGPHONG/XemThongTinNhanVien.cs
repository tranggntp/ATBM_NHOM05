using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1.TRUONGPHONG
{
    public partial class XemThongTinNhanVien : Form
    {
        DataTable DTTABLENAME = new DataTable();
        public XemThongTinNhanVien()
        {
            InitializeComponent();
        }
        private void LoadData_NHANVIEN_TRUONGPHONG()
        {
            string sql = "SELECT * FROM ad_n5.TRUONGPHONG_NHANVIEN";
            DTTABLENAME = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = DTTABLENAME;

            dataGridView1.Font = new Font("Segoe UI", 13);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;


            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void XemThongTinNhanVien_Load(object sender, EventArgs e)
        {
            LoadData_NHANVIEN_TRUONGPHONG();
        }
    }
}
