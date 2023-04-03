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
        string[] privilegesList = new string[] { "Select", "Grant Select",
                                                "Insert", "Grant Insert",
                                                "Update", "Grant Update",
                                                "Delete", "Grant Delete"};
        DataTable userTable = new DataTable();


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

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            string user_role = string.Empty;

            user_role = Username.Text;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loadFrom(object sender, EventArgs e)
        {
            string query = "SELECT table_name FROM user_tables";
            Functions.FillComboBox(query, comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
