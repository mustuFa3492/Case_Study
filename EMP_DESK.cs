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
    public partial class EMP_DESK : Form
    {
        public EMP_DESK()
        {
            InitializeComponent();
        }
        public string EMPID;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private void iconButton8_Click(object sender, EventArgs e)
        {

        }

        private void exit(object sender, EventArgs e)
        {

        }

        private void help(object sender, EventArgs e)
        {

        }

        private void report(object sender, EventArgs e)
        {

        }

        private void remove_stock(object sender, EventArgs e)
        {

        }

        private void update(object sender, EventArgs e)
        {

        }

        private void add_stock(object sender, EventArgs e)
        {

        }

        private void home_click(object sender, EventArgs e)
        {

        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select emp_pass from emp_reg where emp_Id = @id", con);
            cmd.Parameters.AddWithValue("@id", label22.Text);
            string pass = (string)cmd.ExecuteScalar();
            if (textBox2.Text==pass)
            {
              
                panel1.Enabled = true;
                panel2.Enabled = true;
                // uc_update2.Show();
                emP_ATTEND2.Show();
                panel4.Hide();
                uc_update2.Show();
                label2.Show();
            }
        }

        private void EMP_DESK_Load(object sender, EventArgs e)
        {
            label23.Text=label12.Text;
            label22.Text=scanID.ID2;
            

         
            empinfo();

            hide();
           
        }

        private void hide()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label15.Hide();
            label6.Hide();
            label7.Hide();

            uc_update2.Hide();
            emP_ATTEND2.Hide();
            setting1.Hide();
            uc_help1.Hide();
            apply_leave1.Hide();
        }



        private void empinfo()
        {
           SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
           SqlCommand cmd = new SqlCommand("Select * from emp_reg where emp_id=@empID", con);
            cmd.Parameters.AddWithValue("@empID", label22.Text);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                MemoryStream stream = new MemoryStream();
                byte[] image = (byte[])dr[10];
                stream.Write(image, 0, image.Length);
                Bitmap bitmap = new Bitmap(stream);
                guna2CirclePictureBox1.Image = bitmap;
                label12.Text = dr[1].ToString().ToUpper();
                label23.Text = dr[1].ToString().ToUpper();
            }
        }

        private void uc_update2_Load(object sender, EventArgs e)
        {
            getdata();
        }
        private void getdata()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from product", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                uc_update2.uc_up_inventory1.comboBox1.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            label1.Show();
            Billing bl = new Billing();
            bl.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            hide();
            label2.Show();
            uc_update2.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            hide();
            label3.Show();
            emP_ATTEND2.Show();
        } 

        private void iconButton4_Click(object sender, EventArgs e)
        {
            hide();
            label4.Show();
            apply_leave1.Show();
        }

        private void iconButton8_Click_1(object sender, EventArgs e)
        {
            hide();
            label15.Show();
            setting1.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            hide();
            label6.Show();
            uc_help1.Show();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void emP_ATTEND2_Load(object sender, EventArgs e)
        {
            load_m_y();
        }
        private void load_m_y()
        {
            List<string> items = new List<string>();
            int j = System.DateTime.Now.Year;
            int k = j - 25, i;
            for (i = k; i <= j; i++)
            {
                items.Add(i.ToString());
            }
            Object[] itemsobj = items.Cast<object>().ToArray();
            emP_ATTEND2.combo_year.Items.AddRange(itemsobj);
            emP_ATTEND2.combo_year.SelectedItem = j.ToString();
            var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            emP_ATTEND2.combo_month.DataSource = months;
            int sMonth = DateTime.Now.Month;


            switch (sMonth)
            {
                case 1:
                    emP_ATTEND2.combo_month.SelectedIndex = 0;
                    break;
                case 2:
                    emP_ATTEND2.combo_month.SelectedIndex = 1;
                    break;
                case 3:
                    emP_ATTEND2.combo_month.SelectedIndex = 2;
                    break;
                case 4:
                    emP_ATTEND2.combo_month.SelectedIndex = 3;
                    break;
                case 5:
                    emP_ATTEND2.combo_month.SelectedIndex = 4;
                    break;
                case 6:
                    emP_ATTEND2.combo_month.SelectedIndex = 5;
                    break;
                case 7:
                    emP_ATTEND2.combo_month.SelectedIndex = 6;
                    break;
                case 8:
                    emP_ATTEND2.combo_month.SelectedIndex = 7;
                    break;
                case 9:
                    emP_ATTEND2.combo_month.SelectedIndex = 8;
                    break;
                case 10:
                    emP_ATTEND2.combo_month.SelectedIndex = 9;
                    break;
                case 11:
                    emP_ATTEND2.combo_month.SelectedIndex = 10;
                    break;
                case 12:
                    emP_ATTEND2.combo_month.SelectedIndex = 11;
                    break;
            }
        }
    }
}
