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
    public partial class uc_setting : UserControl
    {
        public uc_setting()
        {
            InitializeComponent();
        }

        private void uc_login_Load(object sender, EventArgs e)
        {
            uc_cnguser1.Show();
            uc_cngpass1.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uc_cnguser1.Hide();
            uc_cngpass1.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uc_cnguser1.Show();
            uc_cngpass1.Hide();
        }

        private void uc_cngpass1_Load(object sender, EventArgs e)
        {

        }
    }
}
