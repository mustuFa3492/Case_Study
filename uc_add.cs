using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Case_Study
{
    public partial class uc_add : UserControl
    {
        //SqlConnection con;
        SqlCommand cmd;
        //SqlDataReader dr;
        public uc_add()
        {
            InitializeComponent();
           // con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gmans\Desktop\Case_Study\Case_Study\Case_Study\Database1.mdf;Integrated Security=True");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("Insert into product values(@pn,@pr,@pq,@pg,@prn)", con);
            cmd.Parameters.AddWithValue("@pn", textBox1.Text);
            cmd.Parameters.AddWithValue("@pr", textBox2.Text);//convert to double
            cmd.Parameters.AddWithValue("@pq", textBox3.Text);//covert to int
            cmd.Parameters.AddWithValue("@pg", textBox4.Text);//covert to int
            cmd.Parameters.AddWithValue("@prn", prntext.Text);
            int i = cmd.ExecuteNonQuery();
            if (i < 0)
                MessageBox.Show("Data NOT Saved..!!");
            else
                MessageBox.Show("Data Saved..!!");
            con.Close();
            sendtoreport();
            prntext.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text="";
            textBox4.Text = "";
            


        }
        private void sendtoreport()
        {
            double price = 0;
            price = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            cmd = new SqlCommand("insert into Report values(@bn,@pn,@pq,@pp,@dc)", con);
            cmd.Parameters.AddWithValue("@bn", DateTime.Now);
            cmd.Parameters.AddWithValue("@pn", textBox1.Text);
            cmd.Parameters.AddWithValue("@pq", textBox3.Text);
            cmd.Parameters.AddWithValue("@pp", price);
            cmd.Parameters.AddWithValue("@dc", "purchase");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void uc_add_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
