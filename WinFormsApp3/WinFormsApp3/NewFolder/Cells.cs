using CatrazAl.Business;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Cells
{
    public partial class Cells : UserControl
    {

        public Cells()
        {
            InitializeComponent();
        }

        public static string id = null;
        public static string first = null;
        public static string second = null;
        public static string last = null;

        public void Data() { }

        public void Update(string fillter)
        {
            String constring = "Server=localhost\\SQLEXPRESS; Database=PROJECT; Integrated Security=true; TrustServerCertificate=True;";
            SqlConnection conDataBase = new SqlConnection(constring);
            conDataBase.Open();
            string query = $"SELECT {fillter} FROM Table_1";
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader reader = cmdDataBase.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                first = row.Cells[1].Value.ToString();
                second = row.Cells[2].Value.ToString();
                last = row.Cells[3].Value.ToString();
            }
        }

        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FILETR().ShowDialog();
        }

        private void Cells_Load(object sender, EventArgs e)
        {

            String constring = "Server=localhost\\SQLEXPRESS; Database=PROJECT; Integrated Security=true; TrustServerCertificate=True;";
            SqlConnection conDataBase = new SqlConnection(constring);
            conDataBase.Open();
            string query = "SELECT * FROM Table_1";
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader reader = cmdDataBase.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        { 

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void incert_Click(object sender, EventArgs e)
        { 
        }
    }
}
