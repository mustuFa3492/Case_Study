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
    public partial class EMP_ATTEND : UserControl
    {
        //SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public EMP_ATTEND()
        {
            InitializeComponent();
        }

        private void EMP_ATTEND_Load(object sender, EventArgs e)
        {
            EMP_DESK ed = new EMP_DESK();
            Emp_ID.Text = ed.EMPID;
           
            Emp_ID.Text = scanID.ID2;
        }

       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            present_days();
            absent_days();
            leave_days();
            total_days();
        }

        private void present_days()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("Select count(P_A_L) from EMP_ATTEND where DATE in (select DATE where month(DATE) = @month_combo AND year(DATE) =@year_combo AND EMP_ID=@empID) AND P_A_L='P'", con);
           // cmd = new SqlCommand("select count(P_A_L) from EMP_ATTEND where EMP_ID=@empID",con);
            cmd.Parameters.AddWithValue("@month_combo",(combo_month.SelectedIndex)+1);
            cmd.Parameters.AddWithValue("@year_combo",combo_year.Text);
            cmd.Parameters.AddWithValue("@empID", Emp_ID.Text);
            
           
                int count = (int)cmd.ExecuteScalar();
                label10.Text = count.ToString();
               
        }
        private void absent_days()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("Select count(P_A_L) from EMP_ATTEND where DATE in (select DATE where month(DATE) = @month_combo AND year(DATE) =@year_combo AND EMP_ID=@empID) AND P_A_L='A'", con);
           // cmd = new SqlCommand("select count(P_A_L) from EMP_ATTEND where EMP_ID=@empID",con);
            cmd.Parameters.AddWithValue("@month_combo",(combo_month.SelectedIndex)+1);
            cmd.Parameters.AddWithValue("@year_combo",combo_year.Text);
            cmd.Parameters.AddWithValue("@empID", Emp_ID.Text);
           
           
                int count = (int)cmd.ExecuteScalar();
                label9.Text = count.ToString();
               
        }
        private void leave_days()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("Select count(P_A_L) from EMP_ATTEND where DATE in (select DATE where month(DATE) = @month_combo AND year(DATE) =@year_combo AND EMP_ID=@empID) AND P_A_L='L'", con);
           // cmd = new SqlCommand("select count(P_A_L) from EMP_ATTEND where EMP_ID=@empID",con);
            cmd.Parameters.AddWithValue("@month_combo",(combo_month.SelectedIndex)+1);
            cmd.Parameters.AddWithValue("@year_combo",combo_year.Text);
            cmd.Parameters.AddWithValue("@empID", Emp_ID.Text);
            
           
                int count = (int)cmd.ExecuteScalar();
                label8.Text = count.ToString();
               
        }
        private void total_days()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
           // cmd = new SqlCommand("Select count(P_A_L) from EMP_ATTEND where DATE in (select DATE where month(DATE) = @month_combo AND year(DATE) =@year_combo AND EMP_ID=@empID) AND P_A_L='L'", con);
            cmd = new SqlCommand("select count(P_A_L) from EMP_ATTEND where EMP_ID=@empID",con);
            cmd.Parameters.AddWithValue("@month_combo",(combo_month.SelectedIndex)+1);
            cmd.Parameters.AddWithValue("@year_combo",combo_year.Text);
            cmd.Parameters.AddWithValue("@empID", Emp_ID.Text);
            
           
                int count = (int)cmd.ExecuteScalar();
                label11.Text = count.ToString();
               
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
