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

namespace Case_Study
{
    public partial class uc_report : UserControl
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public uc_report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printpage pp = new printpage();
            pp.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from bill", con);
            con.Open();
            dr = cmd.ExecuteReader();
            int flag = 0;
            while (dr.Read())
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                   flag= 1;
                   
                }
              
             
            }
            if(flag==0)
            {
                MessageBox.Show("Bill Not Exist");
            }
            else 
            {
                billprint bp = new billprint(Convert.ToInt32(textBox1.Text));
                bp.Show();

            }
           
            con.Close();
                   }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uc_report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            printpage pp = new printpage();
            pp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            billingtotal bt = new billingtotal();
            bt.Show();
        }
    }
}
