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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            ShowAgents();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\Water Billing MAnagemen System\Water Billing MAnagemen System\WBMS_Db.mdf;Integrated Security=True;Connect Timeout=30");

        private void ShowAgents()
        {
            Con.Open();
            string query = "select Agent_Number as Code,Agent_Name as Name,Agent_Address as Address,Agent_Phone as Telephone,Agent_Password as Password from AgentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AgentsGDV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
                if (AgNameTb.Text == "" || AgAddressTb.Text == "" || AgPhoneTb.Text == "" || AgPassTb.Text == "")
                {
                    MessageBox.Show("Fill in the blank Entries Spaces");
                }
                else 
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("insert into AgentTbl(Agent_name,Agent_Address,Agent_Phone,Agent_Password)  values(@AN,@AA,@AP,@APa)", Con);
                        cmd.Parameters.AddWithValue("@AN",AgNameTb.Text);
                        cmd.Parameters.AddWithValue("@AA", AgAddressTb.Text);
                        cmd.Parameters.AddWithValue("@AP", AgPhoneTb.Text);
                        cmd.Parameters.AddWithValue("@APa", AgPassTb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("a New Agent Added Successfully"); 
                        Con.Close();
                        ShowAgents();
                        Reset();
                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show(Ex.Message);
                    }
                }
            
        }

        int Key = 0;
        private void AgentsGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AgNameTb.Text = AgentsGDV.SelectedRows[0].Cells[1].Value.ToString();
            AgPhoneTb.Text = AgentsGDV.SelectedRows[0].Cells[2].Value.ToString();
            AgAddressTb.Text = AgentsGDV.SelectedRows[0].Cells[3].Value.ToString();
            AgPassTb.Text = AgentsGDV.SelectedRows[0].Cells[4].Value.ToString();

            if (AgNameTb.Text == "")
            {
                Key = 0;
                
            }
            else
            {
                Key = Convert.ToInt32(AgentsGDV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
             if (AgNameTb.Text == "" || AgAddressTb.Text == "" || AgPhoneTb.Text == "" || AgPassTb.Text == "")
                {
                    MessageBox.Show("Please select the Agent detail to Update ");
                }
                else 
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("update AgentTbl set Agent_name=@AN,Agent_Address=@AA,Agent_Phone=@AP,Agent_Password=@APa where Agent_Number=@AKey", Con);
                        cmd.Parameters.AddWithValue("@AN",AgNameTb.Text);
                        cmd.Parameters.AddWithValue("@AA", AgAddressTb.Text);
                        cmd.Parameters.AddWithValue("@AP", AgPhoneTb.Text);
                        cmd.Parameters.AddWithValue("@APa", AgPassTb.Text);
                        cmd.Parameters.AddWithValue("@AKey", Key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Details Updated Successfully"); 
                        Con.Close();
                        ShowAgents();
                        Reset();
                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show(Ex.Message);
                    }
                }
            
        }

        private void Reset()
        {
            AgNameTb.Text = "";
            AgPhoneTb.Text = "";
            AgAddressTb.Text = "";
            AgPassTb.Text = "";
            Key = 0;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select the Agent detail to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AgentTbl where Agent_Number=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent User Deleted");
                    Con.Close();
                    ShowAgents();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            Agents Obj = new Agents();
            Obj.Show();
            
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have just Log Out?");
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
        }
    }

