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
    public partial class patientLogin : Form
    {
       

        public patientLogin()
        {
            InitializeComponent();
        }

        private void loginButtonPatient_Click(object sender, EventArgs e)
        {
            SqlConnection patientLogin_Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Badhon\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter nsda = new SqlDataAdapter("Select Count(*) From patientData where Phone='" + getPhoneLogin.Text + "' and Password='" + getPassLogin.Text + "'", patientLogin_Con);
            DataTable dtn = new DataTable();
            nsda.Fill(dtn);
            //String s = roleBox.SelectedItem.ToString();
            
                if (dtn.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Form2 ss = new Form2(); //new form link
                    ss.Show(); 
                }
                else
                {
                    MessageBox.Show(@"Please check right Username and Password Given By Admin ! ");
                }
            
        }

        private void forgetPassPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ss = new Form3(); //patientSignUp form link
            ss.Show();
        }
    }
}
