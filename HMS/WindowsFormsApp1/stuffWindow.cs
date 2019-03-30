using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class stuffWindow : Form
    {
        public stuffWindow()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            //adminWindow ss1 = new adminWindow();
            //ss1.Show();
        }

        private void stuffWindow_Load(object sender, EventArgs e)
        {

        }

        private void adminLogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss1 = new Form1();
            ss1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
