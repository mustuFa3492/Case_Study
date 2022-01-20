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
    public partial class aprove_leave : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        public aprove_leave()
        {
            InitializeComponent();
        }

        private void aprove_leave_Load(object sender, EventArgs e)
        {

           
        }

        public void fillcom()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("Select * from EMP_LEAVE_DATA", con);
           // cmd.Parameters.AddWithValue("@empID", comboBox2.Text);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void empdata()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("Select * from emp_reg where emp_id=@empID", con);
            cmd.Parameters.AddWithValue("@empID", comboBox2.Text);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                label1.Text = dr[1].ToString();
                MemoryStream stream = new MemoryStream();
                byte[] image = (byte[])dr[10];
                stream.Write(image, 0, image.Length);
                Bitmap bitmap = new Bitmap(stream);
                pictureBox1.Image = bitmap;
            }
        }

        private void reqleave()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("Select * from EMP_LEAVE_DATA where emp_id=@empID", con);
            cmd.Parameters.AddWithValue("@empID", comboBox2.Text);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dateTimePicker1.Text = dr[1].ToString();
                dateTimePicker2.Text = dr[2].ToString();
                label9.Text = dr[3].ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            empdata();
            reqleave();
            string dtm = DateTime.Now.ToString("MM");
            string dty = DateTime.Now.ToString("yyyy");
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("Select count(P_A_L) from EMP_ATTEND where DATE in (select DATE where month(DATE) = @dtm AND year(DATE) =@dty AND EMP_ID=@empID) AND P_A_L='L'", con);
            cmd.Parameters.AddWithValue("@dtm", dtm);
            cmd.Parameters.AddWithValue("@dty", dty);
            cmd.Parameters.AddWithValue("@empID", comboBox2.Text);
            int count = (int)cmd.ExecuteScalar();
            SqlCommand cmd1 = new SqlCommand("Select count(P_A_L) from EMP_ATTEND where DATE in (select DATE where month(DATE) = @dtm1 AND year(DATE) =@dty1 AND EMP_ID=@empID1) AND P_A_L='A'", con);
            cmd1.Parameters.AddWithValue("@dtm1", dtm);
            cmd1.Parameters.AddWithValue("@dty1", dty);
            cmd1.Parameters.AddWithValue("@empID1", comboBox2.Text);
            int count1 = (int)cmd1.ExecuteScalar();
            con.Close();
            label4.Text = count.ToString();
            label6.Text = count1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insleave();
            comboBox2.Items.Clear();
            pictureBox1.Image = null;
            label9.Text = "";
            label1.Text = "NAME";
            label4.Text = "";
            label6.Text = "";
            fillcom();
        }

        private void insleave()
        {
            int i = 0;
            DateTime dt = new DateTime();
           /// dt = dateTimePicker1.Value.AddDays(5);
            for (i=1;i>0 ;i++)
            {
                dt = dateTimePicker1.Value.AddDays(i-1);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();
                cmd = new SqlCommand("insert into EMP_ATTEND values (@ei,@date,@pal)", con);
                cmd.Parameters.AddWithValue("@ei", comboBox2.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.AddDays(i-1));
                cmd.Parameters.AddWithValue("@pal", "L");
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Inserted :) ");
                }
                else
                {
                    MessageBox.Show("not submitted :( ");
                }
                con.Close();
                if (dateTimePicker2.Value.ToString("dd/MM/yyyy")==dt.ToString("dd/MM/yyyy"))
                {
                    break;
                }
            }
            //MessageBox.Show(i.ToString());
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete_leave_data();
            comboBox2.Items.Clear();
            pictureBox1.Image = null;
            label9.Text = "";
            label1.Text = "NAME";
            label4.Text = "";
            label6.Text = "";
            fillcom();
        }
        private void delete_leave_data()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("DELETE FROM EMP_LEAVE_DATA WHERE emp_id=@id", con);
            cmd.Parameters.AddWithValue("@id",comboBox2.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
