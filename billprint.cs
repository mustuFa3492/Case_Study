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
    public partial class billprint : Form
    {
        SqlDataAdapter da;
        
        SqlCommand cmd;

        int ab;
        public billprint(int b)
        {
            InitializeComponent();
            ab = b;
        }

       

        private void billprint_Load(object sender, EventArgs e)
        {
           // lbill();
            lpbill();
        }
        
        private void lpbill()
        {
           /* string na="";
            string cont="";
            string gst="";
            string cona = "";
            string add1 = "";
            string add2 = "";
            string st = "";
            string pi = "";
            string conta = "";*/

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            DataTable dt3 = new DataTable();
            cmd = new SqlCommand("select * from register", con);
            cmd.Parameters.AddWithValue("@ab", ab);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt3);
            /*dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cona = dr[0].ToString();
                add1 = dr[1].ToString();
                add2 = dr[2].ToString();
                st = dr[4].ToString();
                pi = dr[5].ToString();
                conta = dr[8].ToString();

            }*/
            con.Close();
            con.Open();
            DataTable dt2 = new DataTable();
            cmd = new SqlCommand("select * from bill where bill_no=@ab", con);
            cmd.Parameters.AddWithValue("@ab", ab);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt2);
           /* dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                na = dr[1].ToString();
                cont = dr[5].ToString();
                gst = dr[4].ToString();
            }*/
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            //DataSet dt = new DataSet();

            cmd = new SqlCommand("select * from bill_prod where bill_no=@ab", con);
            cmd.Parameters.AddWithValue("@ab", ab);
            //cmd.Parameters.AddWithValue("@nab", ab);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            printbill cr = new printbill();
            cr.Database.Tables["bill"].SetDataSource(dt2);
            cr.Database.Tables["bill_prod"].SetDataSource(dt);
            cr.Database.Tables["register"].SetDataSource(dt3);
            /*cr.SetParameterValue("phcompany",cona);
            cr.SetParameterValue("padd1", add1);
            cr.SetParameterValue("padd2", add2);
            cr.SetParameterValue("pcity", st);
            cr.SetParameterValue("ppin", pi);
            cr.SetParameterValue("pcont", conta);
            cr.SetParameterValue("pname", na);
            cr.SetParameterValue("pcon", cont);
            cr.SetParameterValue("pgst", gst);*/
            this.crystalReportViewer1.ReportSource = cr;
            this.crystalReportViewer1.Refresh();
            con.Close();
        }
    }
}
