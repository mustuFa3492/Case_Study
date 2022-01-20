namespace Case_Study
{
    partial class uc_update
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uc_up_inventory1 = new Case_Study.uc_up_inventory();
            this.uc_up_bill1 = new Case_Study.uc_up_bill();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(425, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = "INVENTORY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(104, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "BILL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uc_up_inventory1
            // 
            this.uc_up_inventory1.AutoScroll = true;
            this.uc_up_inventory1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uc_up_inventory1.Location = new System.Drawing.Point(104, 74);
            this.uc_up_inventory1.Name = "uc_up_inventory1";
            this.uc_up_inventory1.Size = new System.Drawing.Size(629, 405);
            this.uc_up_inventory1.TabIndex = 27;
            this.uc_up_inventory1.Load += new System.EventHandler(this.uc_up_inventory1_Load);
            // 
            // uc_up_bill1
            // 
            this.uc_up_bill1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uc_up_bill1.Location = new System.Drawing.Point(104, 74);
            this.uc_up_bill1.Name = "uc_up_bill1";
            this.uc_up_bill1.Size = new System.Drawing.Size(629, 405);
            this.uc_up_bill1.TabIndex = 26;
            // 
            // uc_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uc_up_inventory1);
            this.Controls.Add(this.uc_up_bill1);
            this.Name = "uc_update";
            this.Size = new System.Drawing.Size(811, 538);
            this.Load += new System.EventHandler(this.uc_update_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private uc_up_bill uc_up_bill1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public uc_up_inventory uc_up_inventory1;
        //private uc_up_report uc_up_report1;
    }
}
