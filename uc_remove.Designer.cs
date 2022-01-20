namespace Case_Study
{
    partial class uc_remove
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.delete = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(26, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "Product Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DropDownHeight = 150;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(26, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(410, 30);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(350, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 20);
            this.textBox3.TabIndex = 22;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.delete.IconColor = System.Drawing.Color.Red;
            this.delete.IconSize = 32;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(30, 230);
            this.delete.Name = "delete";
            this.delete.Rotation = 0D;
            this.delete.Size = new System.Drawing.Size(157, 37);
            this.delete.TabIndex = 38;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(170, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 313);
            this.panel1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(350, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Quntity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(188, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "GST";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(29, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Rate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uc_remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Name = "uc_remove";
            this.Size = new System.Drawing.Size(811, 538);
            this.Load += new System.EventHandler(this.uc_remove_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private FontAwesome.Sharp.IconButton delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}
