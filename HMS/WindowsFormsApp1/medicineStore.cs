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
    public partial class medicineStore : Form
    {
        SqlConnection nlogin_Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");

        public medicineStore()
        {
            InitializeComponent();
        }

        private void medicineStore_Load(object sender, EventArgs e)
        {

        }

        private void medicineDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void medicineRegisterButton_Click(object sender, EventArgs e)
        {
            nlogin_Con.Open();
            SqlCommand cmd = nlogin_Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [medicine] values('" + medicineIdTextBox.Text + "' , '" + madicineNameTextBox.Text + "' , '" + groupTextBox.Text + "', '" + companyTextBox.Text + "', '" + madicineDateTimePicker.Text + "', '" + commentTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            nlogin_Con.Close();
            MessageBox.Show("inserted successfully! ");
        }
    }
}
