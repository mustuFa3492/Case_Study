using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Case_Study
{

    public partial class apply_leave : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        
        public apply_leave()
        {
            InitializeComponent();
        }

        private void apply()
        {
            // EMP_DESK ed = new EMP_DESK();
            //string ID= ed.EMPID;
           
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("insert into EMP_LEAVE_DATA values(@id,@fdate,@tdate,@reason)", con);
            cmd.Parameters.AddWithValue("@id",scanID.ID2);
            cmd.Parameters.AddWithValue("@fdate",dt_from.Value);
            cmd.Parameters.AddWithValue("@tdate",dt_to.Value);
            cmd.Parameters.AddWithValue("@reason",textbox_reason.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Apllied successfully..");
            }
            else
            {
                MessageBox.Show("Error...Try Again");
            }
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void apply_leave_Load(object sender, EventArgs e)
        {
            dt_from.Value = DateTime.Now;
            dt_to.Value = DateTime.Now;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            apply();
        }
    }
}
