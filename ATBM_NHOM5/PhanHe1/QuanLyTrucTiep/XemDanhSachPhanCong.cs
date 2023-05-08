using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1.QuanLyTrucTiep
{
    public partial class XemDanhSachPhanCong : Form
    {
        DataTable dtTableName = new DataTable();

        public XemDanhSachPhanCong()
        {
            InitializeComponent();
        }

        private void XemDanhSachPhanCong_Load(object sender, EventArgs e)
        {
            string sql = "SELECT MANV, MADA, THOIGIAN FROM AD_N5.QLTT_CS2_PHAN2";
            dtTableName = Functions.GetDataToTable(sql);
            dgv_PhanCong.DataSource = dtTableName;

            dgv_PhanCong.Font = new Font("Segoe UI", 13);
            dgv_PhanCong.Columns[0].HeaderText = "Mã nhân viên";
            dgv_PhanCong.Columns[1].HeaderText = "Mã đề án";
            dgv_PhanCong.Columns[2].HeaderText = "Thời gian phân công";
            dgv_PhanCong.EnableHeadersVisualStyles = false;
            dgv_PhanCong.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

            dgv_PhanCong.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv_PhanCong.Columns[0].Width = 250;
            dgv_PhanCong.Columns[1].Width = 250;
            dgv_PhanCong.Columns[2].Width = 270;


            dgv_PhanCong.AllowUserToAddRows = false;
            dgv_PhanCong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
