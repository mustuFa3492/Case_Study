using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Case_Study
{
    public partial class uc_cnguser : UserControl
    {
        //SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public uc_cnguser()
        {
            InitializeComponent();
        }

        private void textBox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void uc_cnguser_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            up_usr();
            textBox1.Text = "";
            bunifuMaterialTextbox1.Text = "";
        }
        private void up_usr()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select * from register", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (textBox1.Text == dr[6].ToString())
                {
                    update();
                }
                else
                {
                    MessageBox.Show("Old username does not match.");
                }
            }

            con.Close();
        }

        private void update()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("update register set username = @usr", con);
            cmd.Parameters.AddWithValue("@usr", bunifuMaterialTextbox1.Text);
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
