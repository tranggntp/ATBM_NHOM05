using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhanHe1
{
    public partial class QuanLyDeAn : Form
    {
        DataTable dtTableName = new DataTable();
        //string inUserName;
        public QuanLyDeAn()
        {
            InitializeComponent();
            //inUserName= username;   
        }
        private void LoadData()
        {
            string sql = "SELECT * FROM ad_n5.DEAN";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = dtTableName;

            dataGridView1.Font = new Font("Segoe UI", 13);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;

            dataGridView1.Columns[0].HeaderText = "Mã đề án";
            dataGridView1.Columns[1].HeaderText = "Tên đề án";
            dataGridView1.Columns[2].HeaderText = "Ngày bắt đầu";
            dataGridView1.Columns[3].HeaderText = "Phòng ban phụ trách";

            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 276;
            dataGridView1.Columns[2].Width = 260;
            dataGridView1.Columns[3].Width= 300;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void QuanLyDeAn_Load(object sender, EventArgs e)
        {
            LoadData();
            string sql2 = "SELECT MAPB FROM AD_N5.PHONGBAN";
            Functions.FillComboBox(sql2, comboBox1);
        }

    
        private void btn_ThemDeAn_Click(object sender, EventArgs e)
        {
           
            string sql = "INSERT INTO AD_N5.DEAN VALUES( " +
            "'" + textBox1.Text.Trim().ToString() + "', " +
            "'" + textBox2.Text.Trim().ToString() + "', " +
            "TO_DATE('" + dateTimePicker1.Value.ToShortDateString() + "','mm//dd/yyyy'), " +
            "'" + comboBox1.Text.Trim().ToString() + "')";
            Functions.RunSQL(sql);
            MessageBox.Show("Thêm đề án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btn_UpdateDeAn_Click(object sender, EventArgs e)
        {
          //  textBox3.Enabled = false;
            string sql = "UPDATE AD_N5.DEAN SET " +
            "TENDA = '" + textBox2.Text.Trim().ToString() + "', " +
            "PHONG = '" + comboBox1.Text.Trim().ToString() + "', " +
            "NGAYBD = TO_DATE('" + dateTimePicker1.Value.ToShortDateString() + "','mm//dd/yyyy') " +
            "WHERE MADA  = '" + textBox1.Text.Trim().ToString() + "' ";
            Functions.RunSQL(sql);
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btn_XoaDeAn_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM AD_N5.DEAN " +
            "WHERE MADA  = '" + textBox1.Text.Trim().ToString() + "' ";
            Functions.RunSQL(sql);
            MessageBox.Show("Xóa đề án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["MADA"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["TENDA"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["PHONG"].Value.ToString();
            dateTimePicker1.Text= dataGridView1.CurrentRow.Cells["NGAYBD"].Value.ToString();
        }
    }
}
