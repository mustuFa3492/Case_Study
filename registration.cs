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
    public partial class registration : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public registration()
        {
            InitializeComponent();
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            iconPictureBox2.Show();
            iconPictureBox1.Hide();
            textBox9.UseSystemPasswordChar = true;
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            iconPictureBox1.Show();
            iconPictureBox2.Hide();
            textBox9.UseSystemPasswordChar = false;
        }
        private void delete_tamp()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("truncate table register", con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            delete_tamp();
            int i = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from register", con);
            con.Open();
            dr = cmd.ExecuteReader();
            
            while(dr.Read())
            {
                if(dr[6].ToString()==textBox8.Text)
                {
                    i = 1;
                }
            }
            con.Close();
            if (i==1)
            {
                MessageBox.Show("username already exist..!!");
            }
            else
            {
                cmd = new SqlCommand("insert into register values(@cop,@add1,@add2,@state,@city,@pin,@use,@pass,@cont)", con);
                cmd.Parameters.AddWithValue("@cop", textBox1.Text);
                cmd.Parameters.AddWithValue("@add1", textBox2.Text);
                cmd.Parameters.AddWithValue("@add2", textBox3.Text);
                cmd.Parameters.AddWithValue("@state", textBox5.Text);
                cmd.Parameters.AddWithValue("@city", textBox4.Text);
                cmd.Parameters.AddWithValue("@pin", textBox6.Text);
                cmd.Parameters.AddWithValue("@use", textBox8.Text);
                cmd.Parameters.AddWithValue("@pass", textBox9.Text);
                cmd.Parameters.AddWithValue("@cont", textBox7.Text);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Registration Successfull");
                }

                con.Close();
                login ln = new login();
                ln.Show();
                this.Hide();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
