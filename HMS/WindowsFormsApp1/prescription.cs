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
    public partial class prescription : Form
    {
        SqlConnection nlogin_Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");

        public prescription()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string dn = nameTextBox.Text.ToString();
            string pn = pName.Text.ToString();
            string p = rx.Text.ToString();
            string p1 = symptom.Text.ToString();
            string p2 = advice.Text.ToString();
            nlogin_Con.Open();
            SqlCommand cmd = nlogin_Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Prescription] values('" + patientPhone.Text + "' , '" + pn + "' , '" + pAge.Text + "', '" + pWaight.Text + "', '" + dn + "', '" + doctorDept.Text + "', '" + dateTimePicker1.Text + "', '" + bp.Text + "', '" + bs.Text + "', '" + p1 + "', '" + p2 + "', '" + p + "', '" + meet.Text + "')";
            cmd.ExecuteNonQuery();
            nlogin_Con.Close();
            /*phoneTextBox.Text = "";
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            weightTextBox.Text = "";
            addressTextBox.Text = "";*/

            MessageBox.Show("inserted successfully! "); 
        }

        private void symptom_TextChanged(object sender, EventArgs e)
        {

        }

        private void prescription_Load(object sender, EventArgs e)
        {

        }
    }
}
