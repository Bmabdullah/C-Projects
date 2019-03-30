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
    public partial class doctorWindow : Form
    {
        SqlConnection lCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public doctorWindow()
        {
            InitializeComponent();
        }

        private void doctorWindow_Load(object sender, EventArgs e)
        {

        }

        private void doctorEdit_Click(object sender, EventArgs e)
        {
            prescription ss1 = new prescription();
            ss1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showdataprescription();
        }
        public void showdata()
        {
            sda = new SqlDataAdapter("select * from PatientData", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }public void showdataprescription()
        {
            sda = new SqlDataAdapter("select * from Prescription", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patientSignUp ss1 = new patientSignUp();
            ss1.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss1 = new Form1();
            ss1.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ss1 = new Form2();
            ss1.Show();
        }
    }
}
