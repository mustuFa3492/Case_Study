using System;
using AForge.Video;
using AForge.Video.DirectShow;
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
using ZXing;

namespace Case_Study
{
    public partial class Billing : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public object Barcode { get; private set; }
        public VideoCaptureDevice CaptureDevice { get; private set; }
        public Billing()
        {
            InitializeComponent();
        }

        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void Billing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Tamp' table. You can move, or remove it, as needed.
            this.tampTableAdapter.Fill(this.database1DataSet.Tamp);
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                guna2ComboBox1.Items.Add(filterInfo.Name);
            guna2ComboBox1.SelectedIndex = 0;
            label18.Text = "0.00";
            label19.Text = "0.00";
            label20.Text = "0.00";
            label14.Text = "";
            bill();
            getdata();
        }

        private void CaptureDevice_Newframe(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void getdata()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from Tamp", con);
            DataTable dt = new DataTable();
            con.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            dataGridView1.DataSource = dt;
            //dataGridView1.Columns[6].Width = 150;
            cmd = new SqlCommand("select * from product", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            con.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cmd = new SqlCommand("select * from product", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (comboBox1.Text == dr[0].ToString())
                {
                    //textBox11.Text = dr[4].ToString();
                    textBox1.Text = dr[2].ToString();
                    textBox3.Text = dr[1].ToString();
                    textBox2.Text = (Convert.ToInt32(dr[1]) * Convert.ToInt32(dr[2])).ToString();
                }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning == true)
            { captureDevice.Stop(); }
            double ntv = tamp_value();
            double v3 = 0;
            double v6 = 0;
            
            int v2 = 0;
            if (textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Field is empty");
            }
            else
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

                con.Open();
                cmd = new SqlCommand("select count (*) from Tamp", con);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                if (count <= 0)
                {
                    insert_temp();
                }
                else
                {
                    int j = 0;
                    con.Open();
                    cmd = new SqlCommand("select * from Tamp", con);
                    dr = cmd.ExecuteReader();
                    for (int i = 0; i <= count; i++)
                    {
                        while (dr.Read())
                        {
                            if (dr[1].ToString() == comboBox1.Text)
                            {
                                v2 = Convert.ToInt32(dr[2]);
                                v3 = Convert.ToDouble(dr[3]);
                                v6 = Convert.ToDouble(dr[6]);
                                update_tamp(v2, v3, v6, ntv);
                                j = 1;
                            }

                        }
                    }
                    if (j == 0)
                    {
                        insert_temp();
                    }

                }
                con.Close();
            }
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();

            comboBox1.Items.Clear();
            Billing_Load(e,e);
        }
        private void insert_temp()
        {
            double cgst = 0;
            double sgst = 0;
            
            double total = 0;
            double tv = 0;
            string hgst = "0%";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select * from product", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == comboBox1.Text)
                {
                    tv = Convert.ToDouble(dr[3]);
                }
            }
            con.Close();

            if (guna2ToggleSwitch1.Checked == true)
            {

                double htv = tv / 2;
                hgst = Convert.ToString(htv) + "%";

                cgst = ((tv / 2) * Convert.ToDouble(textBox5.Text)) / 100;
                sgst = cgst;
            }
            
            total = Convert.ToDouble(textBox5.Text) + cgst + sgst;
            con.Open();
            cmd = new SqlCommand("insert into Tamp values(@pn,@pq,@pc,@ps,@pt,@pp,@hsg,@hcg)", con);
            // cmd.Parameters.AddWithValue("@id", "");
            cmd.Parameters.AddWithValue("@pn", comboBox1.Text);
            cmd.Parameters.AddWithValue("@pq", textBox4.Text);
            cmd.Parameters.AddWithValue("@pc", cgst);
            cmd.Parameters.AddWithValue("@ps", sgst);
            cmd.Parameters.AddWithValue("@pt", Convert.ToDouble(textBox5.Text));
            cmd.Parameters.AddWithValue("@pp", total);
            cmd.Parameters.AddWithValue("@hsg", hgst);
            cmd.Parameters.AddWithValue("@hcg", hgst);
            

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("inserted :) ");
            }
            else
            {
                MessageBox.Show("not inserted :( ");
            }
            con.Close();
        }
        private double tamp_value()
        {
            double ntv = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();

            cmd = new SqlCommand("select * from product", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == comboBox1.Text)
                {
                    ntv = Convert.ToDouble(dr[3]);
                }
            }
            con.Close();
            return ntv;
        }
        private void update_tamp(int v2, double v3, double v6, double ntv)
        {
            double ncgst = 0.00d;
            double nsgst = 0.00d;
            double ntotal = 0.00d;
            double nprice = 0;

            int t = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);


            if (guna2ToggleSwitch1.Checked == true)
            {

                ncgst = (((ntv / 2) * Convert.ToDouble(textBox5.Text)) / 100) + v3;
                nsgst = ncgst;
            }
            
            ntotal = v6 + ncgst + nsgst + (Convert.ToDouble(textBox5.Text) - (v3 * 2));
            nprice = v6 + Convert.ToDouble(textBox5.Text) - (v3 * 2);
            t = v2 + Convert.ToInt32(textBox4.Text);

            con.Open();


            //q = Convert.ToDouble(dr[3]) + Convert.ToDouble(textBox5.Text);
            cmd = new SqlCommand("update Tamp set Quantity = @quan , cgst = @cgst , sgst = @sgst , Price = @price , Total = @total where Product_name = @pname", con);
            cmd.Parameters.AddWithValue("@pname", comboBox1.Text);
            cmd.Parameters.AddWithValue("@quan", t);
            cmd.Parameters.AddWithValue("@cgst", ncgst);
            cmd.Parameters.AddWithValue("@sgst", nsgst);
            cmd.Parameters.AddWithValue("@price", nprice);
            cmd.Parameters.AddWithValue("@total", ntotal);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("inserted :) ");
            }
            else
            {
                MessageBox.Show("not inserted :( ");
            }
            con.Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            string pn="";
            double pr=0;
            double pg=0;
            int f=0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();

            cmd = new SqlCommand("select * from product", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[4].ToString() == textBox11.Text)
                {
                    pn = dr[0].ToString();
                    label14.Text = pn;
                    pr = Convert.ToDouble(dr[1]);
                    pg = Convert.ToDouble(dr[3]);

                    f = 1;
                }
            }
            con.Close();
            if(f==1)
            { 
                tamp_insert_scan(pn, pr, pg);
                comboBox1.Items.Clear();
                guna2ComboBox1.Items.Clear();
                texttimer();
                Billing_Load(e, e);
            }
            totalatq();
        }

        private void totalatq()
        {
            double sum = 0, sum1 = 0, sum2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                sum2 += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            sum1 = sum1 * 2;
            label18.Text = sum.ToString();
            label19.Text = sum1.ToString();
            label20.Text = sum2.ToString();
        }

        private void tamp_insert_scan(string pn, double pr, double pg)
        {
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select count (*) from Tamp", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (count <= 0)
            {

                ins_tamp(pn,pr,pg);
            }
            else
            {
                {
                    int j = 0;
                    int qua = 0;
                    con.Open();
                    cmd = new SqlCommand("select * from Tamp", con);
                    dr = cmd.ExecuteReader();
                    for (int i = 0; i <= count; i++)
                    {
                        while (dr.Read())
                        {
                            if (dr[1].ToString() == label14.Text)
                            {
                                qua = Convert.ToInt32(dr[2]);
                                qua++;
                                upd_tamp(qua,pr,pg);
                                j = 1;
                            }

                        }
                    }
                    if (j == 0)
                    {
                        ins_tamp(pn,pr,pg);
                    }

                }
            }
            con.Close();
        }
        private void upd_tamp(int qua,double pr,double pg)
        {
            double price = qua*pr;
            double pgst = pg / 2;
            double fgst = (pg * price) / 100;
            double hgst = fgst / 2;
            double ntotal = price + fgst;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();


            //q = Convert.ToDouble(dr[3]) + Convert.ToDouble(textBox5.Text);
            cmd = new SqlCommand("update Tamp set Quantity = @quan , cgst = @cgst , sgst = @sgst , Price = @price , Total = @total where Product_name = @pname", con);
            cmd.Parameters.AddWithValue("@pname", label14.Text);
            cmd.Parameters.AddWithValue("@quan", qua);
            cmd.Parameters.AddWithValue("@cgst", hgst);
            cmd.Parameters.AddWithValue("@sgst", hgst);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@total", ntotal);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void ins_tamp(string pn,double pr,double pg)
        {
            
            double prgst = 0;
            prgst = pg / 2;
            double fgst = (pg * pr) / 100;
            double hgst = fgst / 2;
            double total = fgst + pr;
            string pgst = prgst.ToString() + "%";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("insert into Tamp values(@pn,@pq,@cg,@sg,@pp,@pt,@psg,@pcg)", con);
            cmd.Parameters.AddWithValue("@pn", pn);
            cmd.Parameters.AddWithValue("@pq", 1);
            cmd.Parameters.AddWithValue("@cg", hgst);
            cmd.Parameters.AddWithValue("@sg", hgst);
            cmd.Parameters.AddWithValue("@pp", pr);
            cmd.Parameters.AddWithValue("@pt", total);
            cmd.Parameters.AddWithValue("@psg", pgst);
            cmd.Parameters.AddWithValue("@pcg", pgst);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                delete_tamp();
            }
            else
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();
                cmd = new SqlCommand("delete from Tamp where id=@id", con);
                cmd.Parameters.AddWithValue("@id", textBox9.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("deleted :) ");
                }
                else
                {
                    MessageBox.Show("not deleted :( ");
                }
                con.Close();
            }

            comboBox1.Items.Clear();

            Billing_Load(e, e);
            totalatq();
        }
        private void delete_tamp()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("truncate table Tamp", con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            
        }

        private int bill()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select count (*) from bill", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (count > 0)
            {
                count++;
                textBox6.Text = count.ToString();
            }
            else
            {
                count = 1;
                textBox6.Text = "1";
            }
            return count;
        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image.Clone());
                if (result != null)
                {
                    textBox11.Text = result.ToString();

                }
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[guna2ComboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_Newframe;
            captureDevice.Start();
            timer1.Start();
        }

        private void guna2ComboBox1_Click(object sender, EventArgs e)
        {
            if(captureDevice.IsRunning==true)
            captureDevice.Stop();
        }

        Timer tmr;
        private void texttimer()
        {
            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 500;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            textBox11.Clear();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
        
        private void Billing_FormClosing(object sender, FormClosingEventArgs e)
        {

            if(captureDevice.IsRunning == true)
            captureDevice.Stop();
        }
        private void sendtoreport()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                cmd = new SqlCommand("insert into Report values(@bn,@pn,@pq,@pp,@dc)", con);
                cmd.Parameters.AddWithValue("@bn", DateTime.Now);
                cmd.Parameters.AddWithValue("@pn", dataGridView1.Rows[i].Cells["Product_name"].Value);
                cmd.Parameters.AddWithValue("@pq", dataGridView1.Rows[i].Cells["Quantity"].Value);
                cmd.Parameters.AddWithValue("@pp", dataGridView1.Rows[i].Cells["Total"].Value);
                cmd.Parameters.AddWithValue("@dc", "sale");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void sendtobill()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells["Total"].Value);
            }

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();


            cmd = new SqlCommand("insert into bill values (@bn,@custn,@date,@total,@GST,@cont)", con);
            cmd.Parameters.AddWithValue("@bn", textBox6.Text);
            cmd.Parameters.AddWithValue("@custn", textBox8.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@total", sum);
            cmd.Parameters.AddWithValue("@GST", textBox7.Text);
            cmd.Parameters.AddWithValue("@cont", textBox10.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Inserted :) ");
            }
            else
            {
                MessageBox.Show("not submitted :( ");
            }
            con.Close();
        }

        private void send_bill_prod()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select count (*) from bill", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                cmd = new SqlCommand("insert into bill_prod values(@bn,@pn,@pq,@pp,@ps,@pc,@pps,@ppc,@ppt)", con);
                cmd.Parameters.AddWithValue("@bn", count.ToString());
                cmd.Parameters.AddWithValue("@pn", dataGridView1.Rows[i].Cells["Product_name"].Value);
                cmd.Parameters.AddWithValue("@pq", dataGridView1.Rows[i].Cells["Quantity"].Value);
                cmd.Parameters.AddWithValue("@pp", dataGridView1.Rows[i].Cells["Price"].Value);
                cmd.Parameters.AddWithValue("@ps", dataGridView1.Rows[i].Cells["sgst"].Value);
                cmd.Parameters.AddWithValue("@pc", dataGridView1.Rows[i].Cells["cgst"].Value);
                
                cmd.Parameters.AddWithValue("@pps", dataGridView1.Rows[i].Cells["psgst"].Value);
                cmd.Parameters.AddWithValue("@ppc", dataGridView1.Rows[i].Cells["pcgst"].Value);
                
                cmd.Parameters.AddWithValue("@ppt", dataGridView1.Rows[i].Cells["Total"].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        private void update_quantity(int i, int q)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("update product set Product_quantity = @quan where Product_name = @pname", con);
            cmd.Parameters.AddWithValue("@pname", dataGridView1.Rows[i].Cells["Product_name"].Value);
            cmd.Parameters.AddWithValue("@quan", q);

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void manage_product()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select count (*) from product", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            con.Open();
            cmd = new SqlCommand("select * from product", con);
            dr = cmd.ExecuteReader();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                while (dr.Read())
                {

                    if (dr[0].ToString() == dataGridView1.Rows[i].Cells[1].Value.ToString())
                    {
                        int q = 0;
                        q = Convert.ToInt32(dr[2]) - Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                        update_quantity(i, q);
                    }
                }
            }
            con.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int c;
            if (textBox7.Text == "" || textBox8.Text == "" || textBox10.Text == "" || textBox10.Text.Length != 10 || textBox10.Text.StartsWith("0"))
            {
                MessageBox.Show("something went wrong");
            }
            else
            {
                delete_tamp();
                manage_product();
                c = bill();
                sendtobill();
                send_bill_prod();
                sendtoreport();
                comboBox1.Items.Clear();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox9.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox10.Clear();
                getdata();
                textBox6.Clear();
                print p = new print();
                p.Form1_Load(e, e);
                this.Billing_Load(e,e);
                billprint bp = new billprint(c);
                bp.Show();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
