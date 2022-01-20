using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Case_Study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Show();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();

            uc_home1.Show();
            uc_add1.Hide();
            uc_update1.Hide();
            uc_remove1.Hide();
            uc_report1.Hide();
            uc_help1.Hide();
            uc_home1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       


        private void add_stock(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Show();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();

            uc_home1.Hide();
            uc_add1.Show();
            uc_update1.Hide();
            uc_remove1.Hide();
            uc_report1.Hide();
            uc_help1.Hide();
            uc_add1.BringToFront();
        }

        private void update(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Show();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();

            uc_home1.Hide();
            uc_add1.Hide();
            uc_update1.Show();
            uc_remove1.Hide();
            uc_report1.Hide();
            uc_help1.Hide();
            uc_update1.BringToFront();
        }

        private void remove_stock(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Show();
            label5.Hide();
            label6.Hide();
            label7.Hide();

            uc_home1.Hide();
            uc_add1.Hide();
            uc_update1.Hide();
            uc_remove1.Show();
            uc_report1.Hide();
            uc_help1.Hide();
            uc_remove1.BringToFront();

        }

        private void report(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Show();
            label6.Hide();
            label7.Hide();

            uc_home1.Hide();
            uc_add1.Hide();
            uc_update1.Hide();
            uc_remove1.Hide();
            uc_report1.Show();
            uc_help1.Hide();
            uc_report1.BringToFront();
        }

        private void help(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Show();
            label7.Hide();

            uc_home1.Hide();
            uc_add1.Hide();
            uc_update1.Hide();
            uc_remove1.Hide();
            uc_report1.Hide();
            uc_help1.Show();
        }

        private void exit(object sender, EventArgs e)
        {

            this.Close();

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

       

        private void home_click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();

            uc_home1.Show();
            uc_add1.Hide();
            uc_update1.Hide();
            uc_remove1.Hide();
            uc_report1.Hide();
            uc_help1.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult dialog = MessageBox.Show("Do you really want to exit?", "EXIT", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }*/
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void uc_add1_Load(object sender, EventArgs e)
        {

        }
    }
}
