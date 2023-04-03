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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1
{
    public partial class PhanQuyenHeThong : Form
    {
        string[] privilegesList = new string[] { "SELECT", "Grant Select",
                                                "INSERT", "Grant Insert",
                                                "UPDATE", "Grant Update",
                                                "DELETE", "Grant Delete"};
        DataTable userTable = new DataTable();

        public string user_role = string.Empty;
        public string privilege = string.Empty;
        public string table = string.Empty;


        public PhanQuyenHeThong()
        {
            InitializeComponent();
        }

        private void PhanQuyenHeThong_Load(object sender, EventArgs e)
        {
            loadFrom(sender, e);
        }

        private void Quyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            privilege = Quyen.SelectedItem.ToString();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            user_role = Username.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loadFrom(object sender, EventArgs e)
        {
            string query = "SELECT table_name FROM user_tables";
            Functions.FillComboBox(query, comboBox1);

            for (int i = 0; i < privilegesList.Length; i++)
            {
                Quyen.Items.Add(privilegesList[i]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            table = comboBox1.SelectedItem.ToString();
        }

        private void Grant_Click(object sender, EventArgs e)
        {
            string query = "GRANT " + privilege + " ON " + table + " TO " + user_role;
            MessageBox.Show(query);
            Functions.RunSQL(query);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}