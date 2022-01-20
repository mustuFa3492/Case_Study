using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case_Study
{
    public partial class uc_update : UserControl
    {
        int j = 0;
        public uc_update()
        {
            
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //public int ID2;
        private void uc_update_Load(object sender, EventArgs e)
        {


         
        uc_up_bill1.Hide();
            uc_up_inventory1.Show();
           
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            uc_up_bill1.Show();
            uc_up_inventory1.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uc_up_bill1.Hide();
            uc_up_inventory1.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uc_up_bill1.Hide();
            uc_up_inventory1.Hide();
            
        }

        private void uc_up_inventory1_Load(object sender, EventArgs e)
        {

        }
    }
}
