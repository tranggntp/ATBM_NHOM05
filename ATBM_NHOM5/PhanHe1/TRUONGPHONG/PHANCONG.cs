using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhanHe1.TRUONGPHONG
{
    public partial class PHANCONG : Form
    {
        DataTable DTTABLENAME = new DataTable();
        public PHANCONG()
        {
            InitializeComponent();
        }

        private void PHANCONG_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ad_n5.TP_PC";
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
            dateTimePicker1.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
        }
        private void RunSP_INSERT_PHANCONG_TP()
        {
            OracleCommand command = new OracleCommand("AD_N5.INSERT_PHANCONG_TP", Functions.Con);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("MANV_IN", OracleDbType.Varchar2);
            OracleParameter param2 = new OracleParameter("MADA_IN", OracleDbType.Varchar2);
            OracleParameter param3 = new OracleParameter("THOIGIAN_IN", OracleDbType.Date);

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);

            ////set giá trị
            param1.Value = textBox1.Text.Trim().ToString();
            param2.Value = textBox2.Text.Trim().ToString();
            param3.Value = dateTimePicker1.Value.ToShortDateString();

            command.ExecuteNonQuery();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu vừa nhập!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string s = "SELECT COUNT(*) FROM AD_N5.TRUONGPHONG_NHANVIEN WHERE MANV = '" + textBox1.Text.Trim().ToString() + "'";
            string countStr1 = Functions.GetFieldValues(s);
            int count1 = int.Parse(countStr1); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count1 <= 0)
            {
                MessageBox.Show("Mã nhân viên này không thuộc quyền quản lí của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else {
                try
                {
                    RunSP_INSERT_PHANCONG_TP();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại!!" + ex.Message);
                }
            }
            PHANCONG_Load(sender, e);
        }
        private void RunSP_DELETE_PHANCONG_TP()
        {
            OracleCommand command = new OracleCommand("AD_N5.DELETE_PHANCONG_TP", Functions.Con);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("MANV_IN", OracleDbType.Varchar2);
            OracleParameter param2 = new OracleParameter("MADA_IN", OracleDbType.Varchar2);
            OracleParameter param3 = new OracleParameter("THOIGIAN_IN", OracleDbType.Date);

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);

            ////set giá trị
            param1.Value = textBox1.Text.Trim().ToString();
            param2.Value = textBox2.Text.Trim().ToString();
            param3.Value = dateTimePicker1.Value.ToShortDateString();

            command.ExecuteNonQuery();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu vừa nhập!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string s = "SELECT COUNT(*) FROM AD_N5.TRUONGPHONG_NHANVIEN WHERE MANV = '" + textBox1.Text.Trim().ToString() + "'";
            string countStr1 = Functions.GetFieldValues(s);
            int count1 = int.Parse(countStr1); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count1 <= 0)
            {
                MessageBox.Show("Mã nhân viên này không thuộc quyền quản lí của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    RunSP_DELETE_PHANCONG_TP();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại!!");
                }
            }
            PHANCONG_Load(sender, e);
        }
        private void RunSP_UPDATE_PHANCONG_TP()
        {
            OracleCommand command = new OracleCommand("AD_N5.UPDATE_PHANCONG_TP", Functions.Con);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("MANV_IN", OracleDbType.Varchar2);
            OracleParameter param2 = new OracleParameter("MADA_IN", OracleDbType.Varchar2);
            OracleParameter param3 = new OracleParameter("THOIGIAN_IN", OracleDbType.Date);

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);

            ////set giá trị
            param1.Value = textBox1.Text.Trim().ToString();
            param2.Value = textBox2.Text.Trim().ToString();
            param3.Value = dateTimePicker1.Value.ToShortDateString();

            command.ExecuteNonQuery();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu vừa nhập!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string s = "SELECT COUNT(*) FROM AD_N5.TRUONGPHONG_NHANVIEN WHERE MANV = '" + textBox1.Text.Trim().ToString() + "'";
            string countStr1 = Functions.GetFieldValues(s);
            int count1 = int.Parse(countStr1); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count1 <= 0)
            {
                MessageBox.Show("Mã nhân viên này không thuộc quyền quản lí của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    RunSP_UPDATE_PHANCONG_TP();
                    MessageBox.Show("Cập Nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập Nhật thất bại!!");
                }
            }
            PHANCONG_Load(sender, e);
        }
    }
}
