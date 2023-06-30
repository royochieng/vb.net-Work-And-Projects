using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Billing_MAnagemen_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have just Log Out?");
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            Consumers Obj = new Consumers();
            Obj.Show();
            this.Hide();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            Billings Obj = new Billings();
            Obj.Show();
            this.Hide();
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel10_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel11_Click(object sender, EventArgs e)
        {

        }
    }
}
