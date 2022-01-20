using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZXing;

namespace Case_Study
{
    public partial class EMP_REG : UserControl
    {
        private VideoCaptureDevice captureDevice;
        FilterInfoCollection FilterInfoCollection;

        string imgpath = "";
        public EMP_REG()
        {
            InitializeComponent();
        }
        private void CaptureDevice_Newframe(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public void divs()
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                guna2ComboBox1.Items.Add(filterInfo.Name);
            guna2ComboBox1.SelectedIndex = 0;
        }

        
        
        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text=="TAKE PHOTO"|| button2.Text == "RETAKE")
            {
                captureDevice = new VideoCaptureDevice(FilterInfoCollection[guna2ComboBox1.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_Newframe;
                captureDevice.Start();
                button2.Text = "CLICK";
            } 
            else if(button2.Text=="CLICK")
            {
                captureDevice.Stop();
                button2.Text = "RETAKE";
            }
          

        }

        public void emp_idj()
        {
            char eid1='0',eid;
            string comname="";
            string year="";
            int empno=0;
            string sempno="";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            
            cmd = new SqlCommand("select company from register ", con);
            con.Open();
            comname = (string)cmd.ExecuteScalar();
            con.Close();
           
            
            eid = char.ToUpper(comname[0]);
            
            for (int i=0;i<comname.Length-1;i++)
            {
            
                if (comname[i]==' ')
                {
                     eid1 = char.ToUpper(comname[i + 1]);
                    break;
            
                }
            }
            empno = empid();
            if(empno.ToString().Length==1)
            {
                sempno = "00" + empno.ToString();
            }else if(empno.ToString().Length==2)
            {
                sempno = "0" + empno.ToString();
            }
            year = DateTime.Now.ToString("yy");
            comname = eid.ToString() + eid1.ToString() + year + sempno;
            textBox8.Text = comname;
            
            
        }
        private int empid()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select count (*) from emp_reg", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (count > 0)
            {
                count++;
                
            }
            else
            {
                count = 1;
                
            }
            return count;
        }

        private void EMP_REG_Load(object sender, EventArgs e)
        {
            iconPictureBox2.Hide();
            panel2.Hide();
            label26.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
           
        }
        SqlCommand cmd;
        private void button3_Click(object sender, EventArgs e)
        {
            qrcodeimg();
            byte[] content = ImageToStream();
            byte[] content2 = ImageToStream2();
            string gen="";
            if(guna2RadioButton1.Checked==true)
            {
                gen = guna2RadioButton1.Text;
            }else if(guna2RadioButton2.Checked==true)
            {
                gen = guna2RadioButton2.Text;
            }
            else if (guna2RadioButton3.Checked == true)
            {
                gen = guna2RadioButton3.Text;
            }
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("insert into emp_reg values(@ei,@en,@eg,@ed,@ej,@ea1,@ea2,@ec,@ep,@eco,@epho,@ee,@epass,@qpho,@esa)", con);
            // cmd.Parameters.AddWithValue("@id", "");
            cmd.Parameters.AddWithValue("@ei", textBox8.Text);
            cmd.Parameters.AddWithValue("@en", textBox1.Text);
            cmd.Parameters.AddWithValue("@eg", gen);
            cmd.Parameters.AddWithValue("@ed", DOB.Value);
            cmd.Parameters.AddWithValue("@ej", label26.Text);
            cmd.Parameters.AddWithValue("@ea1", textBox2.Text);
            cmd.Parameters.AddWithValue("@ea2", textBox3.Text);
            cmd.Parameters.AddWithValue("@ec", textBox4.Text);
            cmd.Parameters.AddWithValue("@ep", textBox5.Text);
            cmd.Parameters.AddWithValue("@eco", textBox6.Text);
            cmd.Parameters.AddWithValue("@epho", content);
            cmd.Parameters.AddWithValue("@ee", textBox5.Text);
            cmd.Parameters.AddWithValue("@epass", textBox9.Text);
            cmd.Parameters.AddWithValue("@qpho", content2);
            cmd.Parameters.AddWithValue("@esa", textBox10.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("inserted :) ");
                panel2.Show();
                QRCoder.QRCodeGenerator qg = new QRCoder.QRCodeGenerator();
                var data = qg.CreateQrCode(textBox8.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(data);
                pictureBox4.Image = code.GetGraphic(50);
                pictureBox3.Image = pictureBox1.Image;
                idinfo();
            }
            else
            {
                MessageBox.Show("not inserted :( ");
            }
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            pictureBox1.Image = null;
            divs();
            emp_idj();
        }

        private byte[] ImageToStream()
        {
            MemoryStream stream = new MemoryStream();
        tryagain:
            try
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                goto tryagain;
            }
            return stream.ToArray();
            //throw new NotImplementedException();
        }
        private byte[] ImageToStream2()
        {
            MemoryStream stream = new MemoryStream();
        tryagain:
            try
            {
                Bitmap image = new Bitmap(pictureBox4.Image);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                goto tryagain;
            }
            return stream.ToArray();
            //throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                imgpath = open.FileName;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void qrcodeimg()
        {
            QRCoder.QRCodeGenerator qg = new QRCoder.QRCodeGenerator();
            var data = qg.CreateQrCode(textBox8.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(data);
            pictureBox4.Image = code.GetGraphic(50);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Show();
            
            
        }
        private void idinfo()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            cmd = new SqlCommand("select company from register ", con);
            con.Open();
            string comname = (string)cmd.ExecuteScalar();
            con.Close();
            com_name.Text = comname;
            if(textBox1.Text.Length>=20)
            {
                emp_name.Text = textBox1.Text.Substring(0, 20).ToUpper();
            }else
            {
                emp_name.Text = textBox1.Text.ToUpper();
            }
            
            emp_cont.Text = textBox7.Text;
            emp_id.Text = textBox8.Text;
        }
        
       

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            doc.Print();

        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // Panel grd = new Panel();
            Bitmap bmp = new Bitmap(emp_id_panal.Width, emp_id_panal.Height, emp_id_panal.CreateGraphics());
            emp_id_panal.DrawToBitmap(bmp, new Rectangle(0, 0, emp_id_panal.Width, emp_id_panal.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            textBox9.UseSystemPasswordChar = true;
            iconPictureBox1.Show();
            iconPictureBox2.Hide();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            textBox9.UseSystemPasswordChar = false;
            iconPictureBox2.Show();
            iconPictureBox1.Hide();
        }
    }
}
