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
    public partial class patientSignUp : Form
    {
        SqlConnection plogin_Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");


        public patientSignUp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           // if (patientPass.Text == rePatientPass.Text)
          //  {
                plogin_Con.Open();
                SqlCommand cmd = plogin_Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [patientData] values('" + phoneTextBox.Text + "' , '" + patientPass.Text + "' , '" + nameTextBox.Text + "', '" + patientAge.Text + "', '" + patientAddress.Text + "', '" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();
                plogin_Con.Close();
                MessageBox.Show("inserted successfully! ");
           // }
          //  else
          //  {
           //     MessageBox.Show("Password doesn't match ! ");
           // }



        }

        private void singleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void marriedButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void divorcedButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            patientLogin pl = new patientLogin();
            pl.Show();
        }
    }
}
