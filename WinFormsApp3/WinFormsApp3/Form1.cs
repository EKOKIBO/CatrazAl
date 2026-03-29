using Microsoft.Data.SqlClient;
using System.Data;

namespace Cells
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            HideAll();
        }
        public void HideAll()
        {
            pictureBox1.Visible = false;
            userControl11.Visible = false;
            userControl21.Visible = false;
            guardsdb1.Visible = false;
            medicalRecords1.Visible = false;
            prisonBlock1.Visible = false;
            prisoners1.Visible = false;
            punishment1.Visible = false;
            shift1.Visible = false;
            visits1.Visible = false;

        }





        private void button1_Click(object sender, EventArgs e)
        {
            HideAll();
            userControl11.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAll();
            userControl21.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideAll();
            guardsdb1.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            HideAll();
            medicalRecords1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HideAll();
            prisonBlock1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HideAll();
            prisoners1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideAll();
            punishment1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HideAll();
            shift1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            HideAll();
            visits1.Visible = true;
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }







        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guardsdb1_Load(object sender, EventArgs e)
        {

        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            CELLS.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
        }

        private void Home_MouseLeave(object sender, EventArgs e)
        {
            CELLS.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
        }

        private void CELLS_MouseMove(object sender, MouseEventArgs e)
        {
            CELLS.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void shift1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
