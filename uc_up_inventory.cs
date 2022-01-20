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
    public partial class uc_up_inventory : UserControl
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public uc_up_inventory()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                //comboBox1.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            double v1 = 0;
            int v2 = 0;
            double v3 = 0;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select * from product", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == comboBox1.Text)
                {
                    v1 = Convert.ToDouble(dr[1]);
                    v2 = Convert.ToInt32(dr[2]);
                    v3 = Convert.ToDouble(dr[3]);

                }

            }
            if (textBox3.Text != "")
            {
                v2 = v2 + Convert.ToInt32(textBox3.Text);
            }
            if (textBox1.Text != "")
            {
                v1 = Convert.ToDouble(textBox1.Text);
            }
            if (textBox4.Text != "")
            {
                v3 = Convert.ToDouble(textBox4.Text);
            }
            con.Close();
            update(v1, v2, v3);
            sendtoreport();
            textBox3.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
            comboBox1.Items.Clear();
            getdata();

        }
        private void sendtoreport()
        {
            int q = 0;
            double p = 0;
            double r = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select * from product", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == comboBox1.Text)
                {
                    q = Convert.ToInt32(dr[2]);
                    r = Convert.ToInt32(dr[1]);

                }

            }
            if (textBox3.Text != "")
            {
                q = Convert.ToInt32(textBox3.Text);
                p = q * r;
            }
            if (textBox1.Text != "")
            {
                p = q * Convert.ToDouble(textBox1.Text);

            }
            if (textBox3.Text != "" && textBox1.Text != "")
            {
                q = Convert.ToInt32(textBox3.Text);
                p = q * Convert.ToDouble(textBox1.Text);
            }
            con.Close();
            inserttoreport(q, p);

        }
        private void update(double v1, int v2, double v3)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("update product set Product_rate = @v1, Product_quantity = @v2, GST = @v3 where Product_name = @pname", con);
            cmd.Parameters.AddWithValue("@pname", comboBox1.Text);
            cmd.Parameters.AddWithValue("@v1", v1);
            cmd.Parameters.AddWithValue("@v2", v2);
            cmd.Parameters.AddWithValue("@v3", v3);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void inserttoreport(int q, double p)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("insert into Report values(@date,@pn,@pq,@pp,@dc)", con);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@pn", comboBox1.Text);
            cmd.Parameters.AddWithValue("@pq", q);
            cmd.Parameters.AddWithValue("@pp", p);
            cmd.Parameters.AddWithValue("@dc", "purchase");
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Updated :) ");

            }
            else
            {
                MessageBox.Show("Not Updated :( ");

            }
            con.Close();
        }

        private void uc_up_inventory_Load_1(object sender, EventArgs e)
        {
           
        }
        
    }
}
