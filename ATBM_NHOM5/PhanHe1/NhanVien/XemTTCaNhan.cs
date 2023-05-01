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

        //private void RunSP_UpdateThongTin()
        //{
        //    OracleCommand command = new OracleCommand("ad_n5.usp_NhanVien_UpdateThongTin",Functions.Con);
        //    command.CommandType = CommandType.StoredProcedure;

        //    //command.Parameters.Add("@updated_NgaySinh", OracleDbType.Varchar2).Value= textBox4.Text.Trim().ToString();
        //    command.Parameters.Add("updated_DiaChi", OracleDbType.Varchar2).Value = textBox5.Text.Trim().ToString();
        //    command.Parameters.Add("updated_SDT", OracleDbType.Varchar2).Value = textBox6.Text.Trim().ToString();
        //    //var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
        //    //returnParameter.Direction = ParameterDirection.ReturnValue;

        //    ////set giá trị
        //    //command.Parameters["updated_NgaySinh"].Value= textBox4.Text.Trim().ToString();
        //    //command.Parameters["updated_DiaChi"].Value = textBox5.Text.Trim().ToString();
        //    //command.Parameters["updated_SDT"].Value = textBox6.Text.Trim().ToString();

        //    command.ExecuteNonQuery();

        //    //return Int32.Parse(returnParameter.Value.ToString());

        //}


        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE AD_N5.NHANVIEN SET " +
            "NGAYSINH = TO_DATE('" + dateTimePicker1.Value.ToShortDateString() + "','mm//dd/yyyy'), " +
            "DIACHI = '" + textBox5.Text.Trim().ToString() + "', " +
            "SODT = '" + textBox6.Text.Trim().ToString() + "' ";
            Functions.RunSQL(sql);
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
