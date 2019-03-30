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
    public partial class Form1 : Form
    {
        SqlConnection login_Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From [Login] where Username='" + getEmployeUserName.Text + "' and Password='" + getEmployeePass.Text + "'", login_Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            String s = roleBox.SelectedItem.ToString();
            if (s == null)
            {
                MessageBox.Show("Please choose an option");
            }
            else if (s == "Admin")
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Loged in Successfully. ");
                    this.Hide();
                    adminWindow ss = new adminWindow(); //admin page  link
                    ss.Show();
                }
                else
                {
                    MessageBox.Show(@"Please check right Username and Password Given By Admin ! ");
                }
            }
            else if (s == "Doctor")
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Loged in Successfully. ");
                    this.Hide();
                    doctorWindow ss = new doctorWindow(); //patientSignUp form link
                    ss.Show();
                }
                else
                {
                    MessageBox.Show(@"Please check right Username and Password Given By Admin ! ");
                }
            }
            else if (s == "Stuff")
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Loged in Successfully. ");
                    this.Hide();
                    patientLogin ss = new patientLogin(); //patientSignUp form link
                    ss.Show();
                }
                else
                {
                    MessageBox.Show(@"Please check right Username and Password Given By Admin ! ");
                }
            }
        }   

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
