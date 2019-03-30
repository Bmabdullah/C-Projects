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
    public partial class bloodEntry : Form
    {
        SqlConnection nlogin_Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");

        public bloodEntry()
        {
            InitializeComponent();
        }

        private void bloodEntry_Load(object sender, EventArgs e)
        {

        }

        private void BloodRegistereButton_Click(object sender, EventArgs e)
        {
            nlogin_Con.Open();
            SqlCommand cmd = nlogin_Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [bloodData] values('" + phoneTextBox.Text + "' , '" + nameTextBox.Text + "' , '" + ageTextBox.Text + "', '" + weightTextBox.Text + "', '" + genderComboBox.Text + "', '" + groupComboBox.Text + "', '" + dateTimePicker.Text + "', '" + addressTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            nlogin_Con.Close();
                phoneTextBox.Text="";
                nameTextBox.Text="";
                ageTextBox.Text="";
                weightTextBox.Text="";
                addressTextBox.Text = "";

            MessageBox.Show("inserted successfully! ");
        }
    }
}
