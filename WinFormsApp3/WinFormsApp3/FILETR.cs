using Microsoft.Data.SqlClient;
using Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cells
{
    public partial class FILETR : Form
    {
        public FILETR()
        {
            InitializeComponent();
        }

        public void checkedListBox1_LoadData()
        {
            String constring = "Server=localhost\\SQLEXPRESS; Database=PROJECT; Integrated Security=true; TrustServerCertificate=True;";
            SqlConnection conDataBase = new SqlConnection(constring);
            conDataBase.Open();
            string query = "SELECT * FROM Table_1";
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader reader = cmdDataBase.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void FILETR_Load(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).Enabled = false;
        }
        private void FILETR_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).Enabled = true;
        }

        private void CONFIRM_Click(object sender, EventArgs e)
        {
            string fillter = "";
            // Loop through every checked item
            foreach (var item in checkedListBox1.CheckedItems)
            {
                fillter += item.ToString() + ",";
            }
            fillter = fillter.TrimEnd(','); // Remove the last comma
            Cells kon = new Cells();
            kon.Update(fillter);
          
        }


    }
}
