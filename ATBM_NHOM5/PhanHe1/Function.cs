using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace PhanHe1
{
    public class Functions
    {
        public static OracleConnection Con;

        // sửa lại host name theo máy
        private static string host_name = @"DESKTOP-J4KC12Q";

        public static void InitConnection(String username, String password)
        {
            // 
            String connectionString = @"Data Source=" + host_name + ";User ID=" + username + ";Password=" + password + "";

            Con = new OracleConnection();
            Con.ConnectionString = connectionString;

            try
            {
                Con.Open();

                if (Con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Kết nối DB thành công");
                }

            }
            catch (OracleException ex)
            {
                Con = null;
                throw new Exception(ex.Message);
                MessageBox.Show("Không thể kết nối với DB");
            }
        }

        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                //Đóng kết nối
                Con.Close();

                //Giải phóng tài nguyên
                Con.Dispose();
                Con = null;

                MessageBox.Show("Đóng kết nối với DB");
            }
        }
    }
}