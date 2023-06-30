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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (PassTb.Text == "")
            {
                MessageBox.Show("Key in Administrator password first.");
            }
            else if (PassTb.Text == "Password")
            {
                Agents Obj = new Agents();
                Obj.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("wrong Administator Password !!!");
            }
        }
    }
}
