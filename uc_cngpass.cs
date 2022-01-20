using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Case_Study
{

    public partial class uc_cngpass : UserControl
    {
        SqlDataReader dr;
        SqlCommand cmd;
        public uc_cngpass()
        {
            InitializeComponent();
        }

        private void uc_cngpass_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            up_pass();
            textBox1.Text = "";
            bunifuMaterialTextbox1.Text = "";
        }
        private void up_pass()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select * from register", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (textBox1.Text == dr[7].ToString())
                {
                    update();
                }
                else
                {
                    MessageBox.Show("Old password does not match.");
                }
            }

            con.Close();
        }

        private void update()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("update register set password = @pass", con);
            cmd.Parameters.AddWithValue("@pass", bunifuMaterialTextbox1.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Updated");

            }
            else
            {
                MessageBox.Show("Not updated");
            }

        }
    }
}
