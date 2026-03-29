using Cells;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatrazAl_Form
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static string id = null;
        public static string first = null;
        public static string second = null;
        public static string last = null;


        private void UserControl1_Load(object sender, EventArgs e)
        {
            String constring = "Server=DESKTOP-7G89GA4\\SQLEXPRESS; Database=prison_db; Integrated Security=true; TrustServerCertificate=True;";
            SqlConnection conDataBase = new SqlConnection(constring);
            conDataBase.Open();
            string query = "SELECT * FROM cells";
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader reader = cmdDataBase.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
    }
}
