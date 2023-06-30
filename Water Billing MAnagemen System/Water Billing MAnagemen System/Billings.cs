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
    public partial class Billings : Form
    {
        public Billings()
        {
            InitializeComponent();
            ShowBills();
            GetCons();
            AgentLbl.Text = Login.User;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\Water Billing MAnagemen System\Water Billing MAnagemen System\WBMS_Db.mdf;Integrated Security=True;Connect Timeout=30");

        private void ShowBills()
        {
            Con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillGDV.DataSource = ds.Tables[0];
            Con.Close();
        }

       private void GetCons()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CId from ConsumersTbl", Con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CId", typeof(int));
            dt.Load(dr);
            CIdCb.ValueMember = "Cid";
            CIdCb.DataSource = dt;

            Con.Close();
        }

       private void GetConsRate() 
       {
           Con.Open();
           string query = "select * from ConsumersTbl where CId= "+ CIdCb.SelectedValue.ToString()+ "";
           SqlCommand cmd = new SqlCommand(query,Con);
           DataTable dt = new DataTable();
           SqlDataAdapter sda = new SqlDataAdapter(cmd);
           sda.Fill(dt);
           foreach (DataRow dr in dt.Rows)
           {
               RateTb.Text = dr["CRate"].ToString();

           }
           Con.Close();
       }

       private void Reset()
       {
           CIdCb.SelectedIndex = -1;
           RateTb.Text = "";
           TaxTb.Text = "";
           ConsTb.Text = "";

       }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (RateTb.Text == "" || TaxTb.Text == "" || ConsTb.Text == "")
            {
                MessageBox.Show("missing some information in the entry spaces");
            }
            else 
            {
                try
                {
                    int R = Convert.ToInt32(RateTb.Text);
                    int Consumption = Convert.ToInt32(ConsTb.Text);
                    double Tax = (R * Consumption) * (Convert.ToInt32(TaxTb.Text)/100);
                    double Total = (R * Consumption)  - Tax;
                    string Period = BPeriod.Value.Month + " / " + BPeriod.Value.Year;

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BillTbl(CId,Agent,BPeriod,Consumption,Rate,Tax,Total)  values(@CI,@Ag,@BP,@Cons,@Rate,@Tax,@Tot)", Con);
                    cmd.Parameters.AddWithValue("@CI", CIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Ag", AgentLbl.Text);
                    cmd.Parameters.AddWithValue("@BP", Period);
                    cmd.Parameters.AddWithValue("@Cons", ConsTb.Text);
                    cmd.Parameters.AddWithValue("@Rate", RateTb.Text);
                    cmd.Parameters.AddWithValue("@Tax", TaxTb.Text);
                    cmd.Parameters.AddWithValue("@Tot", Total);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("a New Agent Added Successfully");
                    Con.Close();
                    ShowBills();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetConsRate();
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            Billings Obj = new Billings();
            Obj.Show();
            
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            Consumers Obj = new Consumers();
            Obj.Show();
            this.Hide();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }
    }
}
