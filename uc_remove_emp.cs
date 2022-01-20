using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case_Study
{
    public partial class uc_remove_emp : UserControl
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public uc_remove_emp()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            empdata();
        }

        private void empdata()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("Select * from emp_reg where emp_id=@empID", con);
            cmd.Parameters.AddWithValue("@empID", comboBox2.Text);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[1].ToString() != "cancel")
                {
                    label4.Text = dr[14].ToString();
                    label3.Text = dr[4].ToString();
                    label1.Text = dr[1].ToString();
                    MemoryStream stream = new MemoryStream();
                    byte[] image = (byte[])dr[10];
                    stream.Write(image, 0, image.Length);
                    Bitmap bitmap = new Bitmap(stream);
                    pictureBox1.Image = bitmap;
                }
            }
        }

        private void reqleave()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("update emp_reg set emp_name=@pass where emp_Id =@id", con);
            cmd.Parameters.AddWithValue("@id", comboBox2.Text);
            cmd.Parameters.AddWithValue("@pass", "cancel");
            if (0 < cmd.ExecuteNonQuery())
            {
                MessageBox.Show("EMPLOYEE REMOVED...");
            }
            else
                MessageBox.Show("TRY AGAIN...!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reqleave();
            comboBox2.Items.Clear();
            label3.Text = "";
            label4.Text = "";
            pictureBox1.Image = null;
            fillcom2();
        }

        public void fillcom2()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("Select * from emp_reg", con);
            // cmd.Parameters.AddWithValue("@empID", comboBox2.Text);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[1].ToString() != "cancel")
                   comboBox2.Items.Add(dr[0]);
            }
        }

        private void uc_remove_emp_Load(object sender, EventArgs e)
        {

        }
    }
}
