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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            login l1 = new login();
            l1.Show();
            
            circularProgressBar1.AnimationSpeed = 0;
        }
       
        private void splash_Load(object sender, EventArgs e)
        {

        }
        Timer tmr;
        private void splash_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 3000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            login mf = new login();

            mf.Show();

            //hide this form

            this.Hide();

        }

        private void splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
