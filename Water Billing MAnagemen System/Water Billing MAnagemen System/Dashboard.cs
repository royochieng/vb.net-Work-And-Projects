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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountAgents();
            CountConsumers();
            SumBills();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\Water Billing MAnagemen System\Water Billing MAnagemen System\WBMS_Db.mdf;Integrated Security=True;Connect Timeout=30");
        private void CountAgents()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AgentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AgentLbl.Text = dt.Rows[0][0].ToString() + " Agents";
            Con.Close();
        }

        private void CountConsumers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ConsumersTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ConsLbl.Text = dt.Rows[0][0].ToString() + " Consumers";
            Con.Close();
        }

        private void SumBills()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Total) from BillTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BillLbl.Text = " Kshs. " +dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void ConsLbl_Click(object sender, EventArgs e)
        {

        }

        private void BPeriod_ValueChanged(object sender, EventArgs e)
        {
            string BPer = BPeriod.Value.Month + " / " + BPeriod.Value.Year;

            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Total) from BillTbl where BPeriod = '"+BPer+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BillMonthLbl.Text = " Kshs. " + dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            Billings Obj = new Billings();
            Obj.Show();
            this.Hide();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            Consumers Obj = new Consumers();
            Obj.Show();
            this.Hide();
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
            Billings Obj = new Billings();
            Obj.Show();
            
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }
    }
}
