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

namespace Water_Billing_MAnagemen_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\Water Billing MAnagemen System\Water Billing MAnagemen System\WBMS_Db.mdf;Integrated Security=True;Connect Timeout=30");

        public static string User;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
           if(UnameTb.Text == "" || PassTb.Text == "")
           {
               MessageBox.Show("Key in you username and password first");
           }
           else
           {
                Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AgentTbl where Agent_Name = '"+UnameTb.Text+"' and Agent_Password = '"+PassTb.Text+"' ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                User = UnameTb.Text;
                Home Obj = new Home();
                Obj.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Wrong username or password !");
            }
            Con.Close();
           }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminTbn_Click(object sender, EventArgs e)
        {
            AdminLogin Obj = new AdminLogin();
            Obj.Show();
            this.Hide();
        }
    }
}
