using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Case_Study
{
    public partial class uc_home : UserControl
    {
        //SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public uc_home()
        {
            InitializeComponent();
        }

        public void uc_home_Load(object sender, EventArgs e)
        {

            getdata();
            //delete_tamp();
            bill();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void insert_temp()
        {
            double cgst = 0;
            double sgst = 0;
            double igst = 0;
            double total = 0;
            double tv = 0;
            string hgst="0%";
            string fgst="0%";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select * from product", con);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                if(dr[0].ToString()==comboBox1.Text)
                {
                     tv = Convert.ToDouble(dr[3]);
                }
            }
            con.Close();
            
            if(guna2ToggleSwitch1.Checked==true)
            {
                
                double htv = tv/2;
                hgst = Convert.ToString(htv) + "%";
               
                cgst = ((tv/2)*Convert.ToDouble(textBox5.Text))/100;
                sgst = cgst;
            }
            if(guna2ToggleSwitch2.Checked==true)
            {
                fgst = Convert.ToString(tv) + "%";
                igst = (tv * Convert.ToDouble(textBox5.Text)) / 100;
            }
            total = Convert.ToDouble(textBox5.Text) + cgst + sgst + igst;
            con.Open();
            cmd = new SqlCommand("insert into Tamp values(@pn,@pq,@pc,@ps,@pi,@pt,@pp,@hsg,@hcg,@fig)", con);
            // cmd.Parameters.AddWithValue("@id", "");
            cmd.Parameters.AddWithValue("@pn", comboBox1.Text);
            cmd.Parameters.AddWithValue("@pq", textBox4.Text);
            cmd.Parameters.AddWithValue("@pc", cgst);
            cmd.Parameters.AddWithValue("@ps", sgst);
            cmd.Parameters.AddWithValue("@pi", igst);
            cmd.Parameters.AddWithValue("@pt", Convert.ToDouble(textBox5.Text));
            cmd.Parameters.AddWithValue("@pp", total);
            cmd.Parameters.AddWithValue("@hsg", hgst);
            cmd.Parameters.AddWithValue("@hcg", hgst);
            cmd.Parameters.AddWithValue("@fig", fgst);

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
        private void update_tamp(int v2,double v3,double v6, double ntv, double v5)
        {
            double ncgst = 0.00d;
            double nsgst = 0.00d;
            double nigst = 0.00d;
            double ntotal = 0.00d;
            double nprice = 0;
             
            int t=0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            
            
                if (guna2ToggleSwitch1.Checked == true)
                {
                
                ncgst = (((ntv / 2) * Convert.ToDouble(textBox5.Text)) / 100) + v3;
                    nsgst = ncgst;
                }
                if(guna2ToggleSwitch2.Checked==true)
            {
                nigst = ((ntv * Convert.ToDouble(textBox5.Text)) / 100) + v5;
            }
                ntotal = v6 + ncgst + nsgst + nigst + (Convert.ToDouble(textBox5.Text) - (v3 * 2)) - v5;
            nprice = v6 + Convert.ToDouble(textBox5.Text) - (v3 * 2) - v5;
                t = v2 + Convert.ToInt32(textBox4.Text);
            
            con.Open();
            
            
            //q = Convert.ToDouble(dr[3]) + Convert.ToDouble(textBox5.Text);
            cmd = new SqlCommand("update Tamp set Quantity = @quan , cgst = @cgst , sgst = @sgst , igst = @igst , Price = @price , Total = @total where Product_name = @pname", con);
            cmd.Parameters.AddWithValue("@pname", comboBox1.Text);
            cmd.Parameters.AddWithValue("@quan", t);
            cmd.Parameters.AddWithValue("@cgst", ncgst);
            cmd.Parameters.AddWithValue("@sgst", nsgst);
            cmd.Parameters.AddWithValue("@igst", nigst);
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
        private void button1_Click(object sender, EventArgs e)
        {
            double ntv = tamp_value();
            double v3 = 0;
            double v6 = 0;
            double v5 = 0;
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
                                v6 = Convert.ToDouble(dr[7]);
                                v5 = Convert.ToDouble(dr[5]);
                                update_tamp(v2, v3, v6, ntv, v5);
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

            uc_home_Load(e, e);
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

            uc_home_Load(e, e);
        }
        private void delete_tamp()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("truncate table Tamp", con);
            cmd.ExecuteNonQuery();
            
            con.Close();
        }
        private void update_quantity(int i,int q)
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
                while(dr.Read())
                {
                    
                    if(dr[0].ToString()==dataGridView1.Rows[i].Cells[1].Value.ToString())
                    {
                        int q = 0;
                        q = Convert.ToInt32(dr[2]) - Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                        update_quantity(i,q);
                    }
                }
            }
                con.Close();
        }
        private void generate_bill_Click(object sender, EventArgs e)
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
                p.Form1_Load(e,e);
                uc_home_Load(e, e);
                billprint bp = new billprint(c);
                bp.Show();
            }
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
                cmd.Parameters.AddWithValue("@dc", "dr");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void send_bill_prod()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            cmd = new SqlCommand("select count (*) from bill", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {

                cmd = new SqlCommand("insert into bill_prod values(@bn,@pn,@pq,@pp,@ps,@pc,@pi,@pps,@ppc,@ppi,@ppt)", con);
                    cmd.Parameters.AddWithValue("@bn", count.ToString());
                    cmd.Parameters.AddWithValue("@pn", dataGridView1.Rows[i].Cells["Product_name"].Value);
                    cmd.Parameters.AddWithValue("@pq", dataGridView1.Rows[i].Cells["Quantity"].Value);
                    cmd.Parameters.AddWithValue("@pp", dataGridView1.Rows[i].Cells["Price"].Value);
                    cmd.Parameters.AddWithValue("@ps", dataGridView1.Rows[i].Cells["sgst"].Value);
                cmd.Parameters.AddWithValue("@pc", dataGridView1.Rows[i].Cells["cgst"].Value);
                cmd.Parameters.AddWithValue("@pi", dataGridView1.Rows[i].Cells["igst"].Value);
                cmd.Parameters.AddWithValue("@pps", dataGridView1.Rows[i].Cells["psgst"].Value);
                cmd.Parameters.AddWithValue("@ppc", dataGridView1.Rows[i].Cells["pcgst"].Value);
                cmd.Parameters.AddWithValue("@ppi", dataGridView1.Rows[i].Cells["pigst"].Value);
                cmd.Parameters.AddWithValue("@ppt", dataGridView1.Rows[i].Cells["Total"].Value);
                con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
           
        }
        private void label4_Click(object sender, EventArgs e)
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
                
                if( comboBox1.Text == dr[0].ToString() )
                {
                    textBox1.Text = dr[2].ToString();
                    textBox3.Text = dr[1].ToString();
                    textBox2.Text = (Convert.ToInt32(dr[1]) * Convert.ToInt32(dr[2])).ToString();
                }
            }
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void sendtobill()
        {
            double sum = 0;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells["Total"].Value);
            }
         
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            con.Open();
            
            
            cmd = new SqlCommand("insert into bill values (@bn,@custn,@date,@total,@GST,@cont)", con);
            cmd.Parameters.AddWithValue("@bn",textBox6.Text);
            cmd.Parameters.AddWithValue("@custn", textBox8.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd/MM/yyyy"));
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           // if()
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true) 
            { guna2ToggleSwitch2.Checked = false; }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            uc_home_Load(e, e);
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch2.Checked == true)
            { guna2ToggleSwitch1.Checked = false; }
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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            if(textBox10.Text.Length!=10||textBox10.Text.StartsWith("0"))
            {
                textBox10.Focus();
                errorProvider1.SetError(textBox10,"please enter valid mobile no.");
            }
            else
            {
                errorProvider1.SetError(textBox10,null);
            }
        }
    }
}
