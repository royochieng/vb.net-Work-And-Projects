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
    public partial class Consumers : Form
    {
        public Consumers()
        {
            InitializeComponent();
            ShowConsumers();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\Water Billing MAnagemen System\Water Billing MAnagemen System\WBMS_Db.mdf;Integrated Security=True;Connect Timeout=30");

        private void ShowConsumers()
        {
            Con.Open();
            string query = "select CId as Number,Consumer_Name as Name,Consumer_Address as Address,Consumer_Phone as Telephone,Consumer_Category as Category,CJDate as Join_Date,CRate as Rate from ConsumersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ConsumersGDV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Consumers_Load(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            CNameTb.Text = "";
            CAddTb.Text = "";
            CPhoneTb.Text = "";
            CCatCb.SelectedIndex = -1;
            CJDate.Text = "";
            CRateTb.Text = "";
            //Key = 0;
        }
        int Key = 0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAddTb.Text == "" || CPhoneTb.Text == "" || CCatCb.SelectedIndex == -1 )
            {
                MessageBox.Show("Fill in the blank Entries Spaces");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ConsumersTbl(Consumer_Name,Consumer_Address,Consumer_Phone,Consumer_Category,CJDate,CRate)  values(@CN,@CA,@CP,@CCa,@CJD,@CR)", Con);
                    cmd.Parameters.AddWithValue("@CN", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CAddTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CCa", CCatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CJD", CJDate.Value.Date);
                    cmd.Parameters.AddWithValue("@CR", CRateTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consumer Added");
                    Con.Close();
                    ShowConsumers();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAddTb.Text == "" || CPhoneTb.Text == "" || CCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in the blank Entries Spaces");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ConsumersTbl set Consumer_Name=@CN,Consumer_Address=@CA,Consumer_Phone=@CP,Consumer_Category=@CCa,CJDate=@CJD,CRate=@CR where CId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CAddTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CCa", CCatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CJD", CJDate.Value.Date);
                    cmd.Parameters.AddWithValue("@CR", CRateTb.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consumer Updated");
                    Con.Close();
                    ShowConsumers();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select Consumer from the list ");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ConsumersTbl where CId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consumer Deleted");
                    Con.Close();
                    ShowConsumers();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void GetRate()
        {
            if (CCatCb.SelectedIndex == 0)
            {
                CRateTb.Text = "70";
            }
            else if (CCatCb.SelectedIndex == 1)
            {
                CRateTb.Text = "95";
            }
            else
            {
                CRateTb.Text = "120";
            }
        }
        private void CCatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetRate();
        }

        private void ConsumersGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTb.Text = ConsumersGDV.SelectedRows[0].Cells[1].Value.ToString();
            CPhoneTb.Text = ConsumersGDV.SelectedRows[0].Cells[2].Value.ToString();
            CAddTb.Text = ConsumersGDV.SelectedRows[0].Cells[3].Value.ToString();
            CCatCb.SelectedItem = ConsumersGDV.SelectedRows[0].Cells[4].Value.ToString();
            CJDate.Text = ConsumersGDV.SelectedRows[0].Cells[5].Value.ToString();
            CRateTb.Text = ConsumersGDV.SelectedRows[0].Cells[6].Value.ToString();

            if (CNameTb.Text == "")
            {
                Key = 0;

            }
            else
            {
                Key = Convert.ToInt32(ConsumersGDV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            Consumers Obj = new Consumers();
            Obj.Show();
            
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

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }
    }
}
