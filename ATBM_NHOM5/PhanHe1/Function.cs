﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Net;

namespace PhanHe1
{
    public class Functions
    {
        protected static string GetHostName()
        {
            return System.Net.Dns.GetHostName();
        }

        public static OracleConnection Con;

        private static string host_name = GetHostName();

        public static void InitConnection(String username, String password)
        {
            // 
            String connectionString = @"Data Source=" + host_name + ";User ID=" + username + ";Password=" + password + "";

            Con = new OracleConnection();
            Con.ConnectionString = connectionString;

            try
            {
                Con.Open();
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
        public static void RunSQL(string sql) // chạy câu lệnh sql
        {
            OracleCommand cmd = new OracleCommand();

            //Gán kết nối
            cmd.Connection = Con;

            //Gán lệnh SQL
            cmd.CommandText = sql;

            //Thực hiện câu lệnh SQL
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Giải phóng bộ nhớ
            cmd.Dispose();
            cmd = null;
        }

        public static int RunSQLwithResult(string sql) // chạy câu lệnh sql
        {
            OracleCommand cmd = new OracleCommand();

            //Gán kết nối
            cmd.Connection = Con;

            //Gán lệnh SQL
            cmd.CommandText = sql;

            //Thực hiện câu lệnh SQL
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }

            //Giải phóng bộ nhớ
            cmd.Dispose();
            cmd = null;
            return 1;
        }
        public static DataTable GetDataToTable(string sql) //Lấy dữ liệu đổ vào bảng
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = sql;
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }

        // Hàm đổ dữ liệu vào combobox
        public static void FillComboBox(string sql, ComboBox comboBox)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = sql;
            command.Connection = Con;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    comboBox.Items.Add(reader.GetString(i));
                }
            }
            command.Dispose();
            command = null;
        }

        public static void FillTextBox(string sql, TextBox txtbox1)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = sql;
            command.Connection = Con;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    txtbox1.Text=reader.GetString(0);
                }
            }
            command.Dispose();
            command = null;
        }


        public static bool CheckUserExisted(string username) // Hàm kiểm tra User có tồn tại hay không
        {
            OracleCommand cmd = new OracleCommand();

            //Gán kết nối
            cmd.Connection = Con;

            //Gán lệnh SQL
            string sql = "SELECT * FROM ALL_USERS WHERE USERNAME = " + "'" + username + "'";
            cmd.CommandText = sql;

            //Kiểm tra
            OracleDataReader reader = cmd.ExecuteReader();
            bool existed = reader.Read();
            cmd.Dispose();
            cmd = null;
            return existed;
        }
        public static bool CheckRoleExisted(string rolename) // Hàm kiểm tra Role có tồn tại hay không
        {
            OracleCommand cmd = new OracleCommand();

            //Gán kết nối
            cmd.Connection = Con;

            //Gán lệnh SQL
            string sql = "SELECT * FROM DBA_ROLES WHERE ROLE LIKE " + "'" + rolename + "'";
            cmd.CommandText = sql;

            //Kiểm tra
            OracleDataReader reader = cmd.ExecuteReader();
            bool existed = reader.Read();
            cmd.Dispose();
            cmd = null;
            return existed;
        }
        public static string GetFieldValues(string sql)
        {
            string fieldValue = "";
            using (OracleCommand command = new OracleCommand(sql, Con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fieldValue = reader[0].ToString();
                    }
                }
            }
            return fieldValue;
        }

    }
}