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
    public partial class QLPHONGBAN : Form
    {
        DataTable dtTableName = new DataTable();
        public QLPHONGBAN()
        {
            InitializeComponent();
        }

        private void QLPHONGBAN_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ad_n5.PHONGBAN";
            dtTableName = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = dtTableName;

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
        }
        private void RunSP_INSERT_PHONGBAN()
        {
            OracleCommand command = new OracleCommand("AD_N5.INSERT_PHONGBAN", Functions.Con);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("MAPB_IN", OracleDbType.Varchar2);
            OracleParameter param2 = new OracleParameter("TENPB_IN", OracleDbType.Varchar2);
            OracleParameter param3 = new OracleParameter("TRPHG_IN", OracleDbType.Varchar2);

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);

            ////set giá trị
            param1.Value = textBox1.Text.Trim().ToString();
            param2.Value = textBox2.Text.Trim().ToString();
            param3.Value = textBox3.Text.Trim().ToString();

            command.ExecuteNonQuery();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string s = "SELECT COUNT(*) FROM AD_N5.PHONGBAN WHERE MAPB = '" + textBox1.Text.Trim().ToString() + "'";
            string countStr1 = Functions.GetFieldValues(s);
            int count1 = int.Parse(countStr1); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count1 >0)
            {
                MessageBox.Show("Mã phòng ban này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string q = "SELECT COUNT(*) FROM AD_N5.NHANVIEN_NHANSU WHERE MANV = '" + textBox3.Text.Trim().ToString() + "'";
            string countStr2 = Functions.GetFieldValues(q);
            int count2 = int.Parse(countStr2); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count2 <= 0)
            {
                MessageBox.Show("Mã nhân viên này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    RunSP_INSERT_PHONGBAN();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại!!" + ex.Message);
                }
            }
            QLPHONGBAN_Load(sender, e);
        }
        private void RunSP_UPDATE_PHONGBAN()
        {
            OracleCommand command = new OracleCommand("AD_N5.UPDATE_PHONGBAN", Functions.Con);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("MAPB_IN", OracleDbType.Varchar2);
            OracleParameter param2 = new OracleParameter("TENPB_IN", OracleDbType.Varchar2);
            OracleParameter param3 = new OracleParameter("TRPHG_IN", OracleDbType.Varchar2);

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);

            ////set giá trị
            param1.Value = textBox1.Text.Trim().ToString();
            param2.Value = textBox2.Text.Trim().ToString();
            param3.Value = textBox3.Text.Trim().ToString();

            command.ExecuteNonQuery();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string s = "SELECT COUNT(*) FROM AD_N5.PHONGBAN WHERE MAPB = '" + textBox1.Text.Trim().ToString() + "'";
            string countStr1 = Functions.GetFieldValues(s);
            int count1 = int.Parse(countStr1); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count1 <= 0)
            {
                MessageBox.Show("Mã phòng ban này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string q = "SELECT COUNT(*) FROM AD_N5.NHANVIEN_NHANSU WHERE MANV = '" + textBox3.Text.Trim().ToString() + "'";
            string countStr2 = Functions.GetFieldValues(q);
            int count2 = int.Parse(countStr2); // Chuyển đổi kiểu dữ liệu từ string sang int
            if (count2 <= 0)
            {
                MessageBox.Show("Mã nhân viên này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    RunSP_UPDATE_PHONGBAN();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại!!" );
                }
            }
            QLPHONGBAN_Load(sender, e);
        }
    }
}
