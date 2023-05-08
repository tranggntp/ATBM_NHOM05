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
    public partial class XemDanhSachNhanVien : Form
    {
        DataTable dtTableName = new DataTable();


        public XemDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void XemDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            string sql = "SELECT MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, VAITRO, MANQL, PHG FROM AD_N5.QLTT_CS2_PHAN1";
            dtTableName = Functions.GetDataToTable(sql);
            dgv_XemDanhSachNhanVien.DataSource = dtTableName;

            dgv_XemDanhSachNhanVien.Font = new Font("Segoe UI", 13);
            dgv_XemDanhSachNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgv_XemDanhSachNhanVien.Columns[1].HeaderText = "Họ tên";
            dgv_XemDanhSachNhanVien.Columns[2].HeaderText = "Giới tính";
            dgv_XemDanhSachNhanVien.Columns[3].HeaderText = "Ngày sinh";
            dgv_XemDanhSachNhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgv_XemDanhSachNhanVien.Columns[5].HeaderText = "Số điện thoại";
            dgv_XemDanhSachNhanVien.Columns[6].HeaderText = "Vai trò";
            dgv_XemDanhSachNhanVien.Columns[7].HeaderText = "Mã nhà quản lý";
            dgv_XemDanhSachNhanVien.Columns[8].HeaderText = "Phòng ban";
            dgv_XemDanhSachNhanVien.EnableHeadersVisualStyles = false;
            dgv_XemDanhSachNhanVien.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

            dgv_XemDanhSachNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv_XemDanhSachNhanVien.Columns[0].Width = 150;
            dgv_XemDanhSachNhanVien.Columns[1].Width = 150;
            dgv_XemDanhSachNhanVien.Columns[2].Width = 150;
            dgv_XemDanhSachNhanVien.Columns[3].Width = 150;
            dgv_XemDanhSachNhanVien.Columns[4].Width = 150;
            dgv_XemDanhSachNhanVien.Columns[5].Width = 150;
            dgv_XemDanhSachNhanVien.Columns[6].Width = 150;
            dgv_XemDanhSachNhanVien.Columns[7].Width = 150;
            dgv_XemDanhSachNhanVien.Columns[8].Width = 150;


            dgv_XemDanhSachNhanVien.AllowUserToAddRows = false;
            dgv_XemDanhSachNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
