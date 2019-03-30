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
    public partial class doctorList : Form
    {

        SqlConnection lCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\source\repos\WindowsFormsApp1\WindowsFormsApp1\Data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public doctorList()
        {
            InitializeComponent();
            //showdata();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void doctorList_Load(object sender, EventArgs e)
        {

        }

        private void doctorListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showdata()
        {
            sda = new SqlDataAdapter("select * from doctorList", lCon);
            dt = new DataTable();
            sda.Fill(dt);
            doctorListGridView.DataSource = dt;

        }
        
    }
}
