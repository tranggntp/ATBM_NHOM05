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

namespace PhanHe1.NHANSU
{
    public partial class QuanLiNV : Form
    {
        DataTable DTTABLENAME = new DataTable();
        public QuanLiNV()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void QuanLiNV_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ad_n5.NHANVIEN_NHANSU";
            DTTABLENAME = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = DTTABLENAME;

            dataGridView1.Font = new Font("Segoe UI", 13);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.InactiveCaption;


            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[numrow].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[numrow].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[numrow].Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.Rows[numrow].Cells[8].Value.ToString();
        }
        private void RunSP_INSERT_NHANVIEN()
        {
            OracleCommand command = new OracleCommand("AD_N5.INSERT_NHANVIEN", Functions.Con);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("MANV_IN", OracleDbType.Varchar2);
            OracleParameter param2 = new OracleParameter("TENNV_IN", OracleDbType.Varchar2);
            OracleParameter param3 = new OracleParameter("PHAI_IN", OracleDbType.Varchar2);
            OracleParameter param4 = new OracleParameter("NGAYSINH_IN", OracleDbType.Date);
            OracleParameter param5 = new OracleParameter("DIACHI_IN", OracleDbType.Varchar2);
            OracleParameter param6 = new OracleParameter("SODT_IN", OracleDbType.Varchar2);
            OracleParameter param7 = new OracleParameter("VAITRO_IN", OracleDbType.Varchar2);
            OracleParameter param8 = new OracleParameter("MANQL_IN", OracleDbType.Varchar2);
            OracleParameter param9 = new OracleParameter("PHG_IN", OracleDbType.Varchar2);

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);
            command.Parameters.Add(param6);
            command.Parameters.Add(param7);
            command.Parameters.Add(param8);
            command.Parameters.Add(param9);
            ////set giá trị
            param1.Value = textBox1.Text.Trim().ToString();
            param2.Value = textBox2.Text.Trim().ToString();
            param3.Value = textBox3.Text.Trim().ToString();
            param4.Value = dateTimePicker1.Value.ToShortDateString();
            param5.Value = textBox4.Text.Trim().ToString();
            param6.Value = textBox5.Text.Trim().ToString();
            param7.Value = textBox7.Text.Trim().ToString();
            param8.Value = textBox8.Text.Trim().ToString();
            param9.Value = textBox6.Text.Trim().ToString();
            


            command.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string s = "SELECT COUNT(*) FROM AD_N5.NHANVIEN_NHANSU WHERE MANV = '" + textBox1.Text.Trim().ToString() + "'";
            string countStr1 = Functions.GetFieldValues(s);
            int count1 = int.Parse(countStr1); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count1 >=1)
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string q = "SELECT COUNT(*) FROM AD_N5.NHANVIEN_NHANSU WHERE MANV = '" + textBox8.Text.Trim().ToString() + "'";
            string countStr2 = Functions.GetFieldValues(q);
            int count2 = int.Parse(countStr2); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count2 <= 0)
            {
                MessageBox.Show("Mã người quản lí này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string k = "SELECT COUNT(*) FROM AD_N5.PHONGBAN WHERE MAPB = '" + textBox6.Text.Trim().ToString() + "'";
            string countStr3 = Functions.GetFieldValues(k);
            int count3 = int.Parse(countStr3); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count3 < 1)
            {
                MessageBox.Show("Mã phòng ban này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    RunSP_INSERT_NHANVIEN();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại!!" + ex.Message);
                }
            }
            QuanLiNV_Load(sender, e);
        }
        private void RunSP_UPDATE_NHANVIEN()
        {
            OracleCommand command = new OracleCommand("AD_N5.UPDATE_NHANVIEN", Functions.Con);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("MANV_IN", OracleDbType.Varchar2);
            OracleParameter param2 = new OracleParameter("TENNV_IN", OracleDbType.Varchar2);
            OracleParameter param3 = new OracleParameter("PHAI_IN", OracleDbType.Varchar2);
            OracleParameter param4 = new OracleParameter("NGAYSINH_IN", OracleDbType.Date);
            OracleParameter param5 = new OracleParameter("DIACHI_IN", OracleDbType.Varchar2);
            OracleParameter param6 = new OracleParameter("SODT_IN", OracleDbType.Varchar2);
            OracleParameter param7 = new OracleParameter("VAITRO_IN", OracleDbType.Varchar2);
            OracleParameter param8 = new OracleParameter("MANQL_IN", OracleDbType.Varchar2);
            OracleParameter param9 = new OracleParameter("PHG_IN", OracleDbType.Varchar2);

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);
            command.Parameters.Add(param6);
            command.Parameters.Add(param7);
            command.Parameters.Add(param8);
            command.Parameters.Add(param9);
            ////set giá trị
            param1.Value = textBox1.Text.Trim().ToString();
            param2.Value = textBox2.Text.Trim().ToString();
            param3.Value = textBox3.Text.Trim().ToString();
            param4.Value = dateTimePicker1.Value.ToShortDateString();
            param5.Value = textBox4.Text.Trim().ToString();
            param6.Value = textBox5.Text.Trim().ToString();
            param7.Value = textBox7.Text.Trim().ToString();
            param8.Value = textBox8.Text.Trim().ToString();
            param9.Value = textBox6.Text.Trim().ToString();



            command.ExecuteNonQuery();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string s = "SELECT COUNT(*) FROM AD_N5.NHANVIEN_NHANSU WHERE MANV = '" + textBox1.Text.Trim().ToString() + "'";
            string countStr1 = Functions.GetFieldValues(s);
            int count1 = int.Parse(countStr1); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count1 <= 0)
            {
                MessageBox.Show("Mã nhân viên này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string q = "SELECT COUNT(*) FROM AD_N5.NHANVIEN_NHANSU WHERE MANV = '" + textBox8.Text.Trim().ToString() + "'";
            string countStr2 = Functions.GetFieldValues(q);
            int count2 = int.Parse(countStr2); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count2 <= 0)
            {
                MessageBox.Show("Mã người quản lí này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string k = "SELECT COUNT(*) FROM AD_N5.PHONGBAN WHERE MAPB = '" + textBox6.Text.Trim().ToString() + "'";
            string countStr3 = Functions.GetFieldValues(k);
            int count3 = int.Parse(countStr3); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count3 <= 0)
            {
                MessageBox.Show("Mã phòng ban này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    RunSP_UPDATE_NHANVIEN();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại!!" + ex.Message);
                }
            }
            QuanLiNV_Load(sender, e);
        }
    }
}
