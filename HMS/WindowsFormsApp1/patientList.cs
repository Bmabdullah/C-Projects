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
    public partial class patientList : Form
    {
        SqlConnection lCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public patientList()
        {
            InitializeComponent();
            showdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
        public void showdata()
        {
            sda = new SqlDataAdapter("select * from [patientData]", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            patientListGridView.DataSource = dt;

        }

        private void showPatient_Click(object sender, EventArgs e)
        {
            
        }

        private void bloodListButton_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void deleteBlood_Click(object sender, EventArgs e)
        {
            lCon.Open();
            SqlCommand cmd = lCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [patientData] where Phone='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            lCon.Close();
            passBox.Text = "";
            MessageBox.Show("deleted successfully! ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lCon.Open();
            SqlCommand cmd = lCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [patientData] set Phone='" + textBox2.Text + "' , Password='" + passBox.Text + "' , Name='" + nameBox.Text + "', Age='" + ageBox.Text + "', Address='" + addressTextBox.Text + "', Gender='" + comboBox1.Text + "' where Phone='" + textBox2.Text + "'"; ;
            cmd.ExecuteNonQuery();
            lCon.Close();
            passBox.Text = "";
            MessageBox.Show("updated successfully! ");
        }

        private void patientList_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select * from [patientData] where Phone='"+ textBox2.Text + "' ", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            patientListGridView.DataSource = dt;
        }
    }
}
