using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case_Study
{
    public partial class uc_dashboard : UserControl
    {
        
        
        public uc_dashboard()
        {
            InitializeComponent();
     
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Billing bl = new Billing();
            bl.Hide();
            uc_update1.Show();
            uc_add1.Hide();
            uc_remove1.Hide();
           
            panel1.BringToFront();
            iconButton2.ForeColor = Color.White;
            iconButton3.ForeColor = Color.White;
            iconButton4.ForeColor = Color.White;
            iconButton1.ForeColor = Color.DarkViolet;
            iconButton1.IconColor = Color.DarkViolet;
            iconButton2.IconColor = Color.White;
            iconButton3.IconColor = Color.White;
            iconButton4.IconColor = Color.White;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            uc_update1.Hide();
            uc_add1.Show();
            uc_remove1.Hide();
            iconButton1.ForeColor = Color.White;
            iconButton3.ForeColor = Color.White;
            iconButton2.ForeColor = Color.White;
            iconButton4.ForeColor = Color.DarkViolet;
            iconButton4.IconColor = Color.DarkViolet;
            iconButton1.IconColor = Color.White;
            iconButton3.IconColor = Color.White;
            iconButton2.IconColor = Color.White;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            uc_update1.Hide();
            uc_add1.Hide();
            uc_remove1.Show();
            iconButton1.ForeColor = Color.White;
            iconButton2.ForeColor = Color.White;
            iconButton4.ForeColor = Color.White;
            iconButton3.ForeColor = Color.DarkViolet;
            iconButton3.IconColor = Color.DarkViolet;
            iconButton1.IconColor = Color.White;
            iconButton2.IconColor = Color.White;
            iconButton4.IconColor = Color.White;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            
            iconButton2.ForeColor = Color.DarkViolet;
            iconButton2.IconColor = Color.DarkViolet;
           
            panel1.BringToFront();
            Billing bl = new Billing();
            bl.Show();
        }

        private void uc_dashboard_Load(object sender, EventArgs e)
        {
           /* uc_update.Hide();
            uc_add1.Hide();
            uc_remove1.Hide();*/
        }
    }
}
