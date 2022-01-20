using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace Case_Study
{
    public partial class printpage : Form
    {
        SqlDataAdapter da;
        string date1=null;
        SqlCommand cmd;
        string date2=null;
        public printpage()
        {
            InitializeComponent();
            
        }

        private void printpage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            date1 = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd"); //fromdate.Value.ToString("yyyy-MM-dd");
            date2 = DateTime.Now.ToString("yyyy-MM-dd");
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select * from Report where Date between '" + date1 + "' and '" + date2 + "'", con);
            //cmd = new SqlCommand("select * from Report", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CrystalReport cr = new CrystalReport();

            cr.Database.Tables["Report"].SetDataSource(dt);
            
            this.crystalReportViewer1.ReportSource = cr;
            this.crystalReportViewer1.Refresh();
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            date1 = fromdate.Value.ToString("yyyy-MM-dd");
            date2 = todate.Value.ToString("yyyy-MM-dd");
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select * from Report where Date between '" + date1 + "' and '" + date2 + "'", con);
           // cmd = new SqlCommand("select * from Report", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CrystalReport cr = new CrystalReport();
            
            cr.Database.Tables["Report"].SetDataSource(dt);
            
            this.crystalReportViewer1.ReportSource = cr;
            this.crystalReportViewer1.Refresh();
            con.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
