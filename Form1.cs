using AForge.Video.DirectShow;
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
using System.Xml;

namespace Case_Study
{
    public partial class print : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public print()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            leavedata();
            lowstock();
            iconButton1.IconColor = Color.LightSeaGreen;
            label1.Show();
            label2.Hide();
            //label3.Hide();
            //label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label15.Hide();
            iconButton11.Hide();
            iconButton12.Hide();
            iconButton13.Hide();
            iconButton14.Hide();
            iconButton16.Hide();
            iconButton18.Hide();


                uc_add1.Hide();
            emP_REG1.Hide();
                uc_update1.Hide();
                uc_remove1.Hide();
                uc_report1.Hide();
                uc_help1.Hide();
                uc_setting1.Hide();
            aprove_leave1.Hide();
            uc_remove_emp1.Hide();
            if(iconButton1.IconColor!=Color.White)
            {
                uc_update1.Show();
            }

        }

        private void lowstock()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from product where Product_quantity<=200", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from product", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (comboBox1.Text == dr[0].ToString())
                {
                    textBox1.Text = dr[2].ToString();
                }
            }
            con.Close();
           
           
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       


        private void add_stock(object sender, EventArgs e)
        {
            iconButton11.Hide();
            iconButton12.Hide();
            iconButton13.Hide();
            iconButton14.Hide();


            iconButton16.Show();
            iconButton18.Show();

            iconButton1.IconColor = Color.White;
            iconButton2.IconColor = Color.LightSeaGreen;
            
            //iconButton3.IconColor = Color.White;
            //iconButton4.IconColor = Color.White;
            iconButton5.IconColor = Color.White;
            iconButton6.IconColor = Color.White;
            iconButton8.IconColor = Color.White;

            label1.Hide();
            label2.Show();
           // label3.Hide();
            //label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label15.Hide();


            //uc_home1.Hide();
          /*  uc_add1.Show();
            uc_update1.Hide();
             uc_remove1.Hide();
             uc_report1.Hide();
             uc_help1.Hide();
             uc_add1.BringToFront();
            uc_setting1.Hide();*/
        }

        private void update(object sender, EventArgs e)
        {
           

            iconButton1.IconColor = Color.White;
            iconButton2.IconColor = Color.White;
            //iconButton3.IconColor = Color.LightSeaGreen;
           // iconButton4.IconColor = Color.White;
            iconButton5.IconColor = Color.White;
            iconButton6.IconColor = Color.White;
            iconButton8.IconColor = Color.White;

            label1.Hide();
            label2.Hide();
            //label3.Show();
           // label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label15.Hide();

           
        
             //uc_home1.Hide();
          /*   uc_add1.Hide();
             uc_update1.Show();
             uc_remove1.Hide();
             uc_report1.Hide();
             uc_help1.Hide();
             uc_update1.BringToFront();
            uc_setting1.Hide();*/
        }

        private void remove_stock(object sender, EventArgs e)
        {
         
            iconButton1.IconColor = Color.White;
            iconButton2.IconColor = Color.White;
            //iconButton3.IconColor = Color.White;
            //iconButton4.IconColor = Color.LightSeaGreen;
            iconButton5.IconColor = Color.White;
            iconButton6.IconColor = Color.White;
            iconButton8.IconColor = Color.White;

            label1.Hide();
            label2.Hide();
           // label3.Hide();
            //label4.Show();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label15.Hide();

            
             //uc_home1.Hide();
           /*  uc_add1.Hide();
             uc_update1.Hide();
             uc_remove1.Show();
             uc_report1.Hide();
             uc_help1.Hide();
             uc_remove1.BringToFront();
            uc_setting1.Hide();*/

        }

        private void report(object sender, EventArgs e)
        {
            uc_remove_emp1.Hide();
            emP_REG1.Hide();
            iconButton1.IconColor = Color.White;
            iconButton2.IconColor = Color.White;
           // iconButton3.IconColor = Color.White;
            //iconButton4.IconColor = Color.White;
            iconButton5.IconColor = Color.LightSeaGreen;
            iconButton6.IconColor = Color.White;
            iconButton8.IconColor = Color.White;

            label1.Hide();
            label2.Hide();
          //  label3.Hide();
          //  label4.Hide();
            label5.Show();
            label6.Hide();
            label7.Hide();
            label15.Hide();

           
              uc_add1.Hide();
              uc_update1.Hide();
              uc_remove1.Hide();
              uc_report1.Show();
              uc_help1.Hide();
            uc_setting1.Hide();
        }

        private void help(object sender, EventArgs e)
        {
            uc_remove_emp1.Hide();
            emP_REG1.Hide();
            iconButton1.IconColor = Color.White;
            iconButton2.IconColor = Color.White;
            //iconButton3.IconColor = Color.White;
            //iconButton4.IconColor = Color.White;
            iconButton5.IconColor = Color.White;
            iconButton6.IconColor = Color.LightSeaGreen;
            iconButton8.IconColor = Color.White;

            label1.Hide();
            label2.Hide();
            //label3.Hide();
            //label4.Hide();
            label5.Hide();
            label6.Show();
            label7.Hide();
            label15.Hide();

            
            
            uc_add1.Hide();
             uc_update1.Hide();
             uc_remove1.Hide();
             uc_report1.Hide();
             uc_help1.Show();
            uc_setting1.Hide();
        }

        private void exit(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.White;
            iconButton2.IconColor = Color.White;
            //iconButton3.IconColor = Color.White;
            //iconButton4.IconColor = Color.White;
            iconButton5.IconColor = Color.White;
            iconButton6.IconColor = Color.White;
            iconButton8.IconColor = Color.White;



            this.Close();
            login ln = new login();
            ln.Show();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        public void clrc()
        {
            comboBox1.Items.Clear();

        }
       

        private void home_click(object sender, EventArgs e)
        {
            iconButton11.Show();
            iconButton12.Show();
            iconButton13.Show();
            iconButton14.Show();


            iconButton16.Hide();
            iconButton18.Hide();

            iconButton1.BackColor = Color.Black;

            iconButton1.IconColor = Color.LightSeaGreen;
            
            iconButton2.IconColor = Color.White;
            //iconButton3.IconColor = Color.White;
            //iconButton4.IconColor = Color.White;
            iconButton5.IconColor = Color.White;
            iconButton6.IconColor = Color.White;
            iconButton8.IconColor = Color.White;

         

            label1.Show();
            label2.Hide();
            //label3.Hide();
            //label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label15.Hide();

            
            //uc_home1.Show();
               /* uc_add1.Hide();
                uc_update1.Hide();
                uc_remove1.Hide();
                uc_report1.Hide();
                uc_help1.Hide();
            uc_setting1.Hide();*/
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "EXIT", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {

                e.Cancel = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void uc_add1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void uc_login1_Load(object sender, EventArgs e)
        {
            
        }

        private void login_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uc_report1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            uc_remove_emp1.Hide();
            emP_REG1.Hide();
            uc_setting1.Show();
            
            uc_add1.Hide();
            uc_update1.Hide();
            uc_remove1.Hide();
            uc_report1.Hide();
            uc_help1.Hide();

            iconButton8.IconColor = Color.LightSeaGreen;
            iconButton2.IconColor = Color.White;
            //iconButton3.IconColor = Color.White;
            //iconButton4.IconColor = Color.White;
            iconButton5.IconColor = Color.White;
            iconButton6.IconColor = Color.White;
            iconButton1.IconColor = Color.White;

            label15.Show();
            label2.Hide();
            //label3.Hide();
            //label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label1.Hide();

           
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void iconButton9_MouseHover(object sender, EventArgs e)
        {
            iconButton9.BackColor = Color.Red;
        }

        private void uc_remove1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton9_MouseLeave(object sender, EventArgs e)
        {
            iconButton9.BackColor = Color.Transparent;
        }

        private void iconButton9_MouseEnter(object sender, EventArgs e)
        {
            iconButton9.BackColor = Color.Red;
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.Black;
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_update1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            lowstock();
        }

        private void iconButton9_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton10_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Enter(object sender, EventArgs e)
        {
           
        }

        private void iconButton1_Leave(object sender, EventArgs e)
        {
           
        }

  
        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
       
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
        
        }

        private void iconButton11_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {

           
            
        }

        private void iconButton2_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void print_MouseHover(object sender, EventArgs e)
        {
            iconButton11.Hide();
            iconButton12.Hide();
            iconButton13.Hide();
            iconButton14.Hide();
            iconButton16.Hide();
            iconButton18.Hide();
        }

        private void iconButton11_Click_1(object sender, EventArgs e)
        {
            Billing bl = new Billing();
            bl.Show();
            iconButton11.Hide();
            iconButton12.Hide();
            iconButton13.Hide();
            iconButton14.Hide();
            iconButton16.Hide();
            iconButton18.Hide();
        }

        private void iconButton5_MouseEnter(object sender, EventArgs e)
        {
            iconButton11.Hide();
            iconButton12.Hide();
            iconButton13.Hide();
            iconButton14.Hide();
            iconButton16.Hide();
            iconButton18.Hide();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            uc_update1.Show();
            uc_add1.Hide();
            uc_remove1.Hide();
            uc_report1.Hide();
            uc_setting1.Hide();
            uc_help1.Hide();
            uc_remove_emp1.Hide();
            emP_REG1.Hide();
            iconButton11.Hide();
            iconButton12.Hide();
            iconButton13.Hide();
            iconButton14.Hide();
            iconButton16.Hide();
            iconButton18.Hide();
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            uc_update1.Hide();
            uc_add1.Show();
            uc_remove1.Hide();
            uc_report1.Hide();
            uc_setting1.Hide();
            uc_help1.Hide();
            uc_remove_emp1.Hide();
            emP_REG1.Hide();
            iconButton11.Hide();
            iconButton12.Hide();
            iconButton13.Hide();
            iconButton14.Hide();
            iconButton16.Hide();
            iconButton18.Hide();
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            uc_remove_emp1.Hide();
            emP_REG1.Hide();
            uc_update1.Hide();
            uc_add1.Hide();
            uc_remove1.Show();
            uc_report1.Hide();
            uc_setting1.Hide();
            uc_help1.Hide();
            iconButton11.Hide();
            iconButton12.Hide();
            iconButton13.Hide();
            iconButton14.Hide();
            iconButton16.Hide();
            iconButton18.Hide();
        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            uc_remove_emp1.Hide();
            emP_REG1.Show();
            uc_update1.Hide();
            uc_add1.Hide();
            uc_remove1.Hide();
            uc_report1.Hide();
            uc_setting1.Hide();
            uc_help1.Hide();
            iconButton11.Hide();
            iconButton12.Hide();
            iconButton13.Hide();
            iconButton14.Hide();
            iconButton16.Hide();
            iconButton18.Hide();
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            uc_remove_emp1.Show();
            emP_REG1.Hide();
            uc_update1.Hide();
            uc_add1.Hide();
            uc_remove1.Hide();
            uc_report1.Hide();
            uc_setting1.Hide();
            uc_help1.Hide();
            iconButton11.Hide();
            iconButton12.Hide();
            iconButton13.Hide();
            iconButton14.Hide();
            iconButton16.Hide();
            iconButton18.Hide();
        }
        
        private void emP_REG1_Load(object sender, EventArgs e)
        {
            //divs();
            //emp_idj();
            emP_REG1.divs();
           emP_REG1.emp_idj();
        }
        

        private void uc_update1_Load_1(object sender, EventArgs e)
        {
           
            uc_update1.uc_up_inventory1.getdata();
        }

        private void uc_remove1_Load_1(object sender, EventArgs e)
        {
            uc_remove1.getdata();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if(iconPictureBox1.IconColor==Color.Red)
            {
                iconPictureBox1.IconColor = Color.Transparent;
                aprove_leave1.Show();
                
            }
          
        }
        
        private int leavedata()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select count (*) from EMP_LEAVE_DATA", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (count > 0)
            {
                iconPictureBox1.IconColor = Color.Red;
            }
            else
            {
                iconPictureBox1.IconColor = Color.Transparent;
                
            }
            return count;
        }
       
        private void aprove_leave1_Load(object sender, EventArgs e)
        {
           
            aprove_leave1.fillcom();
        }
        

        private void aprove_leave1_Click(object sender, EventArgs e)
        {
           
        }

        private void aprove_leave1_ControlRemoved(object sender, ControlEventArgs e)
        {
           
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            Form1_Load(e, e);
            MessageBox.Show("hh");
        }

        private void uc_remove_emp1_Load(object sender, EventArgs e)
        {
            uc_remove_emp1.fillcom2();
        }
       

        private void uc_remove_emp1_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void emP_REG1_MouseHover(object sender, EventArgs e)
        {

        }

        private void emP_REG1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void uc_remove1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void uc_update1_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
