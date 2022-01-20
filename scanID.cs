using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Data.SqlClient;
using System.Configuration;

namespace Case_Study
{
    public partial class scanID : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private VideoCaptureDevice captureDevice;
        public scanID()
        {
            InitializeComponent();
        }

        public FilterInfoCollection FilterInfoCollection { get; private set; }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(captureDevice.IsRunning==true)
                captureDevice.Stop();
            this.Hide();
            login ln = new login();
            ln.Show();
            
        }

        private void scanID_Load(object sender, EventArgs e)
        {
            panel2.Hide();


            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                combo_devices.Items.Add(filterInfo.Name);
            combo_devices.SelectedIndex = 0;
             
            //check_leave();
           /* con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("truncate table EMP_ATTEND", con);
            cmd.ExecuteNonQuery();

            con.Close();*/
        }

        private void combo_devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[combo_devices.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_Newframe;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_Newframe(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    IDchanged.Text = result.ToString();

                }
            }
        }

        private void combo_devices_Click(object sender, EventArgs e)
        {
            captureDevice.Stop();
        }
        public string athuid1 = "";
        public static string ID2 = "";
        
        private void IDchanged_TextChanged(object sender, EventArgs e)
        {
            athuid1 = IDchanged.Text;
            if(IDchanged.Text!="")
            reg_emp_check(athuid1);
            
        }

        private void emp_present(string athuid)
        {
            
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("insert into EMP_ATTEND values(@empID,@date,@pal)", con);


            cmd.Parameters.AddWithValue("@empID", athuid);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@pal", 'P');

            if (cmd.ExecuteNonQuery() > 0)
            {
                captureDevice.Stop();
                panel2.Show();
                panel2.BringToFront();
                texttimer();
                //  wlcm_id.Text = IDchanged.Text;
            }
            else
            {
                MessageBox.Show("Error...Try Again");
            }
            con.Close();
          
        }

        private void emp_absent(DateTime dt, string athuid)
        {
            //MessageBox.Show(dt.ToString());
            
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("insert into EMP_ATTEND values(@empID,@date,@pal)", con);


            cmd.Parameters.AddWithValue("@empID", athuid);
            cmd.Parameters.AddWithValue("@date", dt);
            cmd.Parameters.AddWithValue("@pal", 'A');

            if (cmd.ExecuteNonQuery() > 0)
            {
                captureDevice.Stop();
                
                //  wlcm_id.Text = IDchanged.Text;
            }
            else
            {
                MessageBox.Show("Error...Try Again");
            }
            con.Close();


        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
             IDchanged.Text = "BL21004";
            /*con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("truncate table EMP_ATTEND", con);
            cmd.ExecuteNonQuery();

            con.Close();*/
        }
        private void reg_emp_check(string athuid)
        {
            string eid1="";
            int i = 0;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select * from emp_reg", con);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                if (dr[0].ToString() == athuid && dr[1].ToString() != "cancel")
                {
                    i = 0;
                    eid1 = dr[1].ToString();
                    break;
                }
                else
                {
                    i = 1;
                }
                 
            }
            con.Close();
            if(i==1)
            {
                if (IDchanged.Text != "")
                    MessageBox.Show("EMPLOYEE NOT REGISTERED");
                IDchanged.Text = "";
            }
            else
            {
                if(eid1.Length>20)
                wlcm_id.Text = eid1.Substring(0, 20) + "..";
                else
                    wlcm_id.Text = eid1;
                emp_att_check(athuid);
            }
        }
        private void emp_att_check(string athuid)
        {
            int f = 0;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            SqlCommand cmdc = new SqlCommand("select count (*) from EMP_ATTEND", con);
            Int32 count = Convert.ToInt32(cmdc.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmd1 = new SqlCommand("select * from EMP_ATTEND", con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    if (dr1[1].ToString() == athuid)
                    {
                        f = 1;
                    }
                    
                }
                con.Close();
                if (f == 1)
                {
                    emp_check(athuid);
                }
                else
                   emp_present(athuid);
            }
            else
            {
               
                emp_present(athuid);
            }
        }
        private void emp_check(string athuid)
        {
            DateTime dt_tommorow= DateTime.Now.AddDays(-1);
           
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select TOP 1 * from EMP_ATTEND WHERE EMP_ID=@id order by sr_no DESC", con);
            cmd.Parameters.AddWithValue("@id", athuid);


            SqlCommand cmd1 = new SqlCommand("select TOP 1 DATE from EMP_ATTEND WHERE EMP_ID=@id and P_A_L=@p order by sr_no DESC", con);
            cmd1.Parameters.AddWithValue("@id", athuid);
            cmd1.Parameters.AddWithValue("@p", "P");
            DateTime dt_last = (DateTime) cmd1.ExecuteScalar();
            DateTime i = dt_last.AddDays(1);
            
           SqlDataReader dr3 = cmd.ExecuteReader();
            
            
            while (dr3.Read())
            {
                
                if ((dr3[2].ToString()).Substring(0, 10) != DateTime.Now.ToString("dd/MM/yyyy")/* && dr[1].ToString()==IDchanged.Text*/)
                {
                    
                     if ((dr3[2].ToString()).Substring(0, 10) == dt_tommorow.ToString("dd/MM/yyyy"))
                     {
                         emp_present(athuid);
                      // MessageBox.Show("today");
                     }
                     else
                     {

                         foreach(DateTime x in EachDay(i,dt_tommorow))
                         {

                            // emp_absent(x);

                            empap(x,athuid);
                        }
                         emp_present(athuid);
                        //MessageBox.Show("today11");
                    }

                }
                else
                {
                    if (captureDevice.IsRunning == true)
                        captureDevice.Stop();
                    panel2.Show();
                    panel2.BringToFront();
                    texttimer();
                
                }
            }
            con.Close();
          
        }

       
        private void empap(DateTime datep, string athuid)
        {
            int f = 0;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("select * from EMP_ATTEND where EMP_ID=@id1", con);
            cmd1.Parameters.AddWithValue("@id1", athuid);
            con.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                if ((dr1[2].ToString()).Substring(0, 10) == datep.ToString("dd/MM/yyyy"))
                {
                    f = 1;
                }
              
            }
            if(f==0)
            {
                 emp_absent(datep,athuid);
               // MessageBox.Show(datep.ToString());
            }
            con.Close();
        }
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
        Timer tmr;
        private void texttimer()
        {
            athuid1 = IDchanged.Text;
            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 3000;

            //starts the timer
            tmr.Start();

            tmr.Tick += tmr_Tick;
        }
        private void IDchanged_Click(object sender, EventArgs e)
        {

        }

        private void wlcm_id_Click(object sender, EventArgs e)
        {
            
        }
        int i = 0;
        private void tmr_Tick(object sender, EventArgs e)
        {
           
            i++;
            tmr.Stop();
            if(i==1)
            {
                ID2 = IDchanged.Text;
                EMP_DESK ED = new EMP_DESK();
                ED.Show();
                this.Hide();

            }


        }

        private void scanID_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
