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
    public partial class uc_up_bill : UserControl
    {
        SqlDataReader dr;
        //SqlConnection con;
        SqlCommand cmd;
        public uc_up_bill()
        {
            InitializeComponent();
        }

        private void uc_up_bill_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from bill", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(textBox6.Text == dr[0].ToString())
                {
                    if (dr[1].ToString() == "cancel")
                    {
                       
                      
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        textBox8.Text = dr[1].ToString();
                        textBox1.Text = dr[2].ToString();
                        textBox7.Text = dr[4].ToString();
                    }
                }
            }
            con.Close();
            bind_bill_product();
            if(textBox6.Text=="")
            {
                comboBox1.Items.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
            }
        }
        private void bind_bill_product()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from bill_prod", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (textBox6.Text == dr[0].ToString())
                {
                    comboBox1.Items.Add(dr[1]);
                }
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from bill_prod", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                if (comboBox1.Text == dr[1].ToString()&&textBox6.Text==dr[0].ToString())
                {
                    textBox4.Text = dr[2].ToString();
                    textBox2.Text = dr[3].ToString();
                    
                }
            }
            con.Close();
        }
        private void upb()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("update bill set customer_name='cancel',total='0',GST='-',contact='0' where bill_no=@bl", con);
            cmd.Parameters.AddWithValue("@bl",textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("delete from bill_prod where bill_no=@id", con);
            cmd.Parameters.AddWithValue("@id", textBox6.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("deleted :) ");
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("not deleted :( ");
            }
            con.Close();
            upb();
        }
    }
}
