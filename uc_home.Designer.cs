namespace Case_Study
{
    partial class uc_home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ToggleSwitch2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(139, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 232);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(368, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 35);
            this.label6.TabIndex = 19;
            this.label6.Text = "Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(222, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 35);
            this.label4.TabIndex = 18;
            this.label4.Text = "MRP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(70, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 35);
            this.label5.TabIndex = 17;
            this.label5.Text = "Product Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DropDownHeight = 150;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(70, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(410, 30);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(70, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Qauntity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(222, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(112, 31);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(368, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(112, 31);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(112, 31);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(368, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(222, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 31);
            this.textBox5.TabIndex = 21;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(222, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 35);
            this.label3.TabIndex = 20;
            this.label3.Text = "Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(70, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 31);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(70, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Qauntity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.guna2ToggleSwitch2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.guna2ToggleSwitch1);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(139, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 138);
            this.panel2.TabIndex = 23;
            // 
            // guna2ToggleSwitch2
            // 
            this.guna2ToggleSwitch2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedState.Parent = this.guna2ToggleSwitch2;
            this.guna2ToggleSwitch2.Location = new System.Drawing.Point(317, 17);
            this.guna2ToggleSwitch2.Name = "guna2ToggleSwitch2";
            this.guna2ToggleSwitch2.ShadowDecoration.Parent = this.guna2ToggleSwitch2;
            this.guna2ToggleSwitch2.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch2.TabIndex = 28;
            this.guna2ToggleSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.UncheckedState.Parent = this.guna2ToggleSwitch2;
            this.guna2ToggleSwitch2.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(237, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "out state : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "with gst in state : ";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.AutoRoundedCorners = true;
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(194, 17);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 25;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(368, 87);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(45, 34);
            this.textBox9.TabIndex = 24;
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(413, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(139, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 132);
            this.panel3.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 130);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(139, 267);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(533, 35);
            this.bunifuCustomLabel1.TabIndex = 24;
            this.bunifuCustomLabel1.Text = "Bill...";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(131, 17);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(60, 35);
            this.textBox6.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox10);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.textBox8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(139, 585);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(533, 306);
            this.panel4.TabIndex = 26;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(66, 189);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(414, 31);
            this.textBox10.TabIndex = 26;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            this.textBox10.Validating += new System.ComponentModel.CancelEventHandler(this.textBox10_Validating);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(66, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(414, 35);
            this.label10.TabIndex = 25;
            this.label10.Text = "Contact No.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(397, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 34);
            this.button3.TabIndex = 24;
            this.button3.Text = "SUBMIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.generate_bill_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(66, 106);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(414, 31);
            this.textBox8.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(66, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(414, 35);
            this.label9.TabIndex = 21;
            this.label9.Text = "Customer Name.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(297, 17);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(183, 35);
            this.textBox7.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(222, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 35);
            this.label7.TabIndex = 19;
            this.label7.Text = "GST No.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(66, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 35);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bill No.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uc_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel4);
            this.Name = "uc_home";
            this.Size = new System.Drawing.Size(731, 402);
            this.Load += new System.EventHandler(this.uc_home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
