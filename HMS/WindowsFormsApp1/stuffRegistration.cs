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
    public partial class stuffRegistration : Form
    {
        SqlConnection nlogin_Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");

        public stuffRegistration()
        {
            InitializeComponent();
        }

        private void commentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void stuffRegisterButton_Click(object sender, EventArgs e)
        {
            nlogin_Con.Open();
            SqlCommand cmd = nlogin_Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [stuffList] values('" + IdTextBox.Text + "' , '" + nameTextBox.Text + "' , '" + designationTextBox.Text + "', '" + salaryTextBox.Text + "', '" + genderComboBox.Text + "', '" + addressTextBox.Text + "', '" + phoneTextBox.Text + "', '" + DateTimePicker.Text + "', '" + userNameTextBox.Text + "', '" + passwordTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            nlogin_Con.Close();
            phoneTextBox.Text = "";
            nameTextBox.Text = "";
            IdTextBox.Text = "";
            designationTextBox.Text = "";
            salaryTextBox.Text = "";
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
            addressTextBox.Text = "";
            MessageBox.Show("inserted successfully! ");
        }
    }
}
