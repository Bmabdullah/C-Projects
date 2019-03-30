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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection login_Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From patientData where Phone='" + newtextBox1.Text + "' and Name='" + textBox1.Text + "'", login_Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //String s = newtextBox1.ToString();
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Yhe Password is 1234");
            }
        }
    }
}
