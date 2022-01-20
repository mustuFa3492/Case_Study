using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case_Study
{
    public partial class setting : UserControl
    {
        public setting()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            string eid = scanID.ID2;
            //MessageBox.Show(eid);
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select emp_pass from emp_reg where emp_Id = @id", con);
            cmd.Parameters.AddWithValue("@id", eid);
            string pass = (string)cmd.ExecuteScalar();
            if(pass == old_pass.Text)
            {
                if(new_pass.Text==confirm_pass.Text)
                {
                    update_pass(eid);

                }
                else
                {
                    MessageBox.Show("Confirm password does not match...");
                }
            }
            else
            {
                MessageBox.Show("Old password does not match...");

            }

            con.Close();
            old_pass.Text = "";
            new_pass.Text = "";
            confirm_pass.Text = "";
        }

        private void update_pass(string E_ID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update emp_reg set emp_pass=@pass where emp_Id =@id", con);
            cmd.Parameters.AddWithValue("@pass",confirm_pass.Text);
            cmd.Parameters.AddWithValue("@id",E_ID);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Password changed successfully..");
            }
            else
            {
                MessageBox.Show("Error...Try Again");
            }
            con.Close();
        }

        private void setting_Load(object sender, EventArgs e)
        {

        }
    }
}
