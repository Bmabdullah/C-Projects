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
    public partial class stuffList : Form
    {
        SqlConnection lCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public stuffList()
        {
            InitializeComponent();
            showdata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void showStuff_Click(object sender, EventArgs e)
        {
           // showdata();

        }
        public void showdata()
        {
            sda = new SqlDataAdapter("select * from stuffList", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            stuffListGridView.DataSource = dt;

        }
        public void showdataMedicine()
        {
            sda = new SqlDataAdapter("select * from medicine", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            stuffListGridView.DataSource = dt;

        }
        private void stuffList_Load(object sender, EventArgs e)
        {

        }

        private void availableBlood_Click(object sender, EventArgs e)
        {
            showdataMedicine();
        }

        private void button1_Click(object sender, EventArgs e)//update button
        {
            lCon.Open();
            SqlCommand cmd = lCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [stuffList] set [Stuff Name]='" + nameTextBox.Text + "' , Designation='" + designationTextBox.Text + "' , Salary='" + salaryTextBox.Text + "', Gender='" + genderComboBox.Text + "', Address='" + addressTextBox.Text + "', Phone='" + phoneTextBox.Text + "', [Join Date]='" + DateTimePicker.Text + "', [User Name]='" + userNameTextBox.Text + "', Password='" + passwordTextBox.Text + "' where [Stuff ID]='" + IdTextBox.Text + "'";
            cmd.ExecuteNonQuery();
            lCon.Close();
            IdTextBox.Text = "";
            MessageBox.Show("Updated successfully! ");
        }

        private void deleteBlood_Click(object sender, EventArgs e)
        {
            lCon.Open();
            SqlCommand cmd = lCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [stuffList] where [Stuff ID]='" + IdTextBox.Text + "'";
            cmd.ExecuteNonQuery();
            lCon.Close();
            IdTextBox.Text = "";
            MessageBox.Show("deleted successfully! ");
        }

        private void stuffListGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                IdTextBox.Text = stuffListGridView.SelectedRows[0].Cells[0].Value.ToString();
                nameTextBox.Text = stuffListGridView.SelectedRows[0].Cells[1].Value.ToString();
                designationTextBox.Text = stuffListGridView.SelectedRows[0].Cells[2].Value.ToString();
                salaryTextBox.Text = stuffListGridView.SelectedRows[0].Cells[3].Value.ToString();
                genderComboBox.Text = stuffListGridView.SelectedRows[0].Cells[4].Value.ToString();
                addressTextBox.Text = stuffListGridView.SelectedRows[0].Cells[5].Value.ToString();
                phoneTextBox.Text = stuffListGridView.SelectedRows[0].Cells[6].Value.ToString();
                DateTimePicker.Text = stuffListGridView.SelectedRows[0].Cells[7].Value.ToString();
                userNameTextBox.Text = stuffListGridView.SelectedRows[0].Cells[8].Value.ToString();
                passwordTextBox.Text = stuffListGridView.SelectedRows[0].Cells[9].Value.ToString();
           
        }

        private void bloodListButton_Click(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
