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
    public partial class bloodList : Form
    {
        SqlConnection lCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public bloodList()
        {
            InitializeComponent();
            showdatablood();
        }

        private void bloodList_Load(object sender, EventArgs e)
        {

        }

        public void showdatablood()
        {
            sda = new SqlDataAdapter("select * from bloodData", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            stuffListGridView.DataSource = dt;

        }

       

       

        private void deleteBlood_Click_1(object sender, EventArgs e)
        {
            lCon.Open();
            SqlCommand cmd = lCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [bloodData] where Phone='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            lCon.Close();
            textBox1.Text = "";
            MessageBox.Show("deleted successfully! ");
        }

        private void bloodListButton_Click_1(object sender, EventArgs e)
        {
            showdatablood();
        }

        /* Update Section */

        private void stuffListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void stuffListGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lCon.Open();
            SqlCommand cmd = lCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [bloodData] set Phone='" + textBox2.Text + "' , Name='" + textBox3.Text + "' , Age='" + textBox4.Text + "', Weight='" + textBox5.Text + "', Gender='" + comboBox1.Text + "', Date='" + dateTimePicker.Text + "', Address='" + addressTextBox.Text + "' where Phone='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            lCon.Close();
            textBox1.Text = "";
            MessageBox.Show("Updated successfully! ");
        }

        private void stuffListGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = stuffListGridView.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = stuffListGridView.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = stuffListGridView.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = stuffListGridView.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = stuffListGridView.SelectedRows[0].Cells[4].Value.ToString();
            //groupComboBox.Text = stuffListGridView.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePicker.Text = stuffListGridView.SelectedRows[0].Cells[6].Value.ToString();
            addressTextBox.Text = stuffListGridView.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select * from bloodData where Phone='"+ textBox1.Text + "' ", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            stuffListGridView.DataSource = dt;
        }
    }
}
