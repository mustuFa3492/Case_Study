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
    public partial class login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public login()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            iconPictureBox2.Show();
            iconPictureBox1.Hide();
            label1.Hide();
            label2.Hide();
            guna2TextBox2.UseSystemPasswordChar = true;
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            scanID scan = new scanID();
            scan.Show();
            this.Hide();

        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            label1.Show();
            guna2TextBox1.PlaceholderText = "";
        }

        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            label2.Show();
            guna2TextBox2.PlaceholderText = "";

        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "")
            {
                label2.Hide();
                guna2TextBox2.PlaceholderText = "Password";
            }
            else
            {
                label2.Show();
                guna2TextBox2.PlaceholderText = "";
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                label1.Hide();
                guna2TextBox1.PlaceholderText = "UserName";
            }
            else
            {
                label1.Show();
                guna2TextBox1.PlaceholderText = "";
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            iconPictureBox1.Show();
            iconPictureBox2.Hide();
            guna2TextBox2.UseSystemPasswordChar=false;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            iconPictureBox2.Show();
            iconPictureBox1.Hide();
            guna2TextBox2.UseSystemPasswordChar = true;
        }

        public void guna2Button1_Click(object sender, EventArgs e)
        {
            logdone();
           

        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                //logdone();
                guna2Button1.PerformClick();
            }
        }
        private void logdone()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select * from register", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (guna2TextBox1.Text == dr[6].ToString() && guna2TextBox2.Text == dr[7].ToString())
                {
                    print f1 = new print();
                    f1.Show();
                    splash sh = new splash();
                    sh.Hide();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid userid or password");
                }
            }

            con.Close();
        }
        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logdone();
            }
        }

        private void iconButton9_MouseEnter(object sender, EventArgs e)
        {
            iconButton9.IconColor = Color.Red;
        }

        private void iconButton9_MouseLeave(object sender, EventArgs e)
        {
            iconButton9.IconColor = Color.White;
        }
    }
}
