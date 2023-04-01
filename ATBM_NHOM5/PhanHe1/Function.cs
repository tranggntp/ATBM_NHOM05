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

        private static string host_name = @"LAPTOP-LR15QBT2"; // Minh Host

        public static void InitConnection(String username, String password)
        {
            String connectionString = @"Data Source=" + host_name + ";User ID=" + username + ";Password=" + password + "";

            Con = new OracleConnection();
            Con.ConnectionString = connectionString;

            try
            {
                //Mở kết nối
                Con.Open();

                ////Kiểm tra kết nối
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
    }
}