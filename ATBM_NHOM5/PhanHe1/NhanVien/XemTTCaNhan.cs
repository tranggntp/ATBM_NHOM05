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

namespace PhanHe1
{
    public partial class XemTTCaNhan : Form
    {
        DataTable dtTableName = new DataTable();

        public XemTTCaNhan()
        {
            InitializeComponent();
        }

        private void XemTTCaNhan_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ad_n5.NV_XEMNHANVIEN";
            dtTableName = Functions.GetDataToTable(sql);
            textBox1.Text = dtTableName.Rows[0][0].ToString();
            textBox2.Text = dtTableName.Rows[0][1].ToString();
            textBox3.Text = dtTableName.Rows[0][2].ToString();
            dateTimePicker1.Text = dtTableName.Rows[0][3].ToString();
            textBox5.Text = dtTableName.Rows[0][4].ToString();
            textBox6.Text = dtTableName.Rows[0][5].ToString();
            textBox7.Text = dtTableName.Rows[0][6].ToString();
            textBox8.Text = dtTableName.Rows[0][7].ToString();
            textBox9.Text = dtTableName.Rows[0][8].ToString();
            textBox10.Text = dtTableName.Rows[0][9].ToString();
            textBox11.Text = dtTableName.Rows[0][10].ToString();
        }

        private void RunSP_UpdateThongTin()
        {
            OracleCommand command = new OracleCommand("AD_N5.usp_NhanVien_UpdateThongTin", Functions.Con);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("updated_DiaChi", OracleDbType.Varchar2);
            OracleParameter param2 = new OracleParameter("updated_SDT", OracleDbType.Varchar2);
            OracleParameter param3 = new OracleParameter("updated_NgaySinh", OracleDbType.Varchar2);

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);

            ////set giá trị
            param1.Value = textBox5.Text.Trim().ToString();
            param2.Value = textBox6.Text.Trim().ToString();
            param3.Value = dateTimePicker1.Value.ToShortDateString();

            command.ExecuteNonQuery();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                RunSP_UpdateThongTin();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại, mã lỗi: " + ex.Message);
            }
        }
    }
}
