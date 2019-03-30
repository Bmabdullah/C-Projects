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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           // Form1 ss1 = new Form1();
            //ss1.Show();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bloodListButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = ("select * from [Prescription] where [Patient Phone] = '" + phone.Text + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool recordfound = dr.Read();
            if (recordfound)
            {

                doctorLabel.Text = dr["Doctor"].ToString(); ;
                depertmentLabel.Text = dr["Doctor Dept"].ToString();
                namelabel.Text = dr["Patient Name"].ToString();
                datekabel.Text = dr["Date"].ToString();
                agelabel.Text = dr["Age"].ToString();
                weightlabel.Text = dr["Waight"].ToString();
                bplabel.Text = dr["BP"].ToString();
                bslabel.Text = dr["B Sugar"].ToString();
                symptomlabel.Text = dr["Symptom"].ToString();
                advicelabel.Text = dr["Advice"].ToString();
                rxlabel.Text = dr["Rx"].ToString();
                meetlabel.Text = dr["Meet"].ToString();


            }con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
