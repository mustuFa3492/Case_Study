using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Case_Study
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design",typeof(IDesigner))]
    public partial class uc_remove : System.Windows.Forms.UserControl
    {
        SqlDataReader dr;
        SqlCommand cmd;
        public uc_remove()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("delete from product where Product_name = @pname", con);
            con.Open();
            cmd.Parameters.AddWithValue("@pname", comboBox1.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Deleted :) ");

            }
            else
            {
                MessageBox.Show("Not Deleted:( ");
            }
            con.Close();
            comboBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           // uc_remove_Load(e,e);
        }
        private void delete_stocks()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("truncate table product", con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("deleted :) ");
            }
            else
            {
                MessageBox.Show("not deleted :( ");
            }
            con.Close();
        }

        private void uc_remove_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from product", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (comboBox1.Text == dr[0].ToString())
                {
                    textBox1.Text = dr[1].ToString();
                    textBox2.Text = dr[3].ToString();
                    textBox3.Text = dr[2].ToString();

                }
            }
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        public void getdata()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from product", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                comboBox1.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("delete from product where Product_name = @pname", con);
            con.Open();
            cmd.Parameters.AddWithValue("@pname", comboBox1.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Deleted :) ");

            }
            else
            {
                MessageBox.Show("Not Deleted:( ");
            }
            con.Close();
            comboBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            getdata();
        }
    }
}
