using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class adminWindow : Form
    {
        SqlConnection lCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public adminWindow()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stuffView_Click(object sender, EventArgs e)
        {
            dataGridView.Show();
            showdatastuff();
        }
       


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss1 = new Form1();
            ss1.Show();
        }

        private void stuffEdit_Click(object sender, EventArgs e)
        {
            stuffList ss1 = new stuffList();
            ss1.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView.Show();
            showdatadoctor();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView.Show();
            showdatapatient();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bloodList ss1 = new bloodList();
            ss1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView.Show();
            showdatablood();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            medicineStore ss1 = new medicineStore();
            ss1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /* stuffList ss1 = new stuffList();
            ss1.Show(); */
            dataGridView.Show();
            showdatamedicine();
            
        }

        private void adminWindow_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString(); */
        }
        

        private void button11_Click(object sender, EventArgs e)
        {
            bloodList ss1 = new bloodList();
            ss1.Show();
        }

        private void dataGridViewMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showdatamedicine()
        {
            sda = new SqlDataAdapter("select * from medicine", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;

        }
        public void showdatastuff()
        {
            sda = new SqlDataAdapter("select * from stuffList", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;

        }
        public void showdatablood()
        {
            sda = new SqlDataAdapter("select * from bloodData", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;

        }
        public void showdatadoctor()
        {
            sda = new SqlDataAdapter("select * from doctorList", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;

        }
        public void showdatapatient()
        {
            sda = new SqlDataAdapter("select * from patientData", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            patientSignUp ss1 = new patientSignUp();
            ss1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            patientList ss1 = new patientList();
            ss1.Show();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            bloodEntry ss1 = new bloodEntry();
            ss1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stuffRegistration ss1 = new stuffRegistration();
            ss1.Show();
        }

        private void stuffDelete_Click(object sender, EventArgs e)
        {
            stuffList ss1 = new stuffList();
            ss1.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            prescription ss1 = new prescription();
            ss1.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form4 ss1 = new Form4();
            ss1.Show();
        }
    }
}
