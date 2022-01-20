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

namespace Case_Study
{
    public partial class billingtotal : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public billingtotal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
           string date1 = fromdate.Value.ToString("yyyy-MM-dd");
           string date2 = todate.Value.ToString("yyyy-MM-dd");
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select * from bill where Date between '" + date1 + "' and '" + date2 + "'", con);
            // cmd = new SqlCommand("select * from Report", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            
            BILLING_TOTAL cr = new BILLING_TOTAL();
            cr.Database.Tables["bill"].SetDataSource(dt);

            this.crystalReportViewer1.ReportSource = cr;
            this.crystalReportViewer1.Refresh();
            con.Close();
        }

        private void billingtotal_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            string date1 = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd");
            string date2 = DateTime.Now.ToString("yyyy-MM-dd");
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select * from bill where Date between '" + date1 + "' and '" + date2 + "'", con);
            // cmd = new SqlCommand("select * from Report", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            BILLING_TOTAL cr = new BILLING_TOTAL();
            cr.Database.Tables["bill"].SetDataSource(dt);

            this.crystalReportViewer1.ReportSource = cr;
            this.crystalReportViewer1.Refresh();
            con.Close();
        }
    }
}
