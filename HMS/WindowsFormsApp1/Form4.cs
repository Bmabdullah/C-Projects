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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = ("select * from [Prescription] where [Patient Phone] = '" + textBox.Text + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool recordfound = dr.Read();
            if (recordfound)
            {

                //label1.Text = "Record Found";
                //label1.ForeColor = System.Drawing.Color.Green;
                label1.Text = dr["Age"].ToString();
                /*label12.Text = dr["Id"].ToString();
                label13.Text = dr["Class"].ToString();
                label14.Text = dr["Tfee"].ToString();
                label15.Text = dr["Fpaid"].ToString();*/


            }
        }
    }
}
