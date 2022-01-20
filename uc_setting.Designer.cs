namespace Case_Study
{
    partial class uc_setting
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.uc_cngpass1 = new Case_Study.uc_cngpass();
            this.uc_cnguser1 = new Case_Study.uc_cnguser();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(104, 49);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(305, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Change UserName";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(410, 49);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(305, 45);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Change Password";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // uc_cngpass1
            // 
            this.uc_cngpass1.BackColor = System.Drawing.Color.DarkGray;
            this.uc_cngpass1.Location = new System.Drawing.Point(104, 96);
            this.uc_cngpass1.Name = "uc_cngpass1";
            this.uc_cngpass1.Size = new System.Drawing.Size(611, 362);
            this.uc_cngpass1.TabIndex = 3;
            this.uc_cngpass1.Load += new System.EventHandler(this.uc_cngpass1_Load);
            // 
            // uc_cnguser1
            // 
            this.uc_cnguser1.BackColor = System.Drawing.Color.DarkGray;
            this.uc_cnguser1.Location = new System.Drawing.Point(104, 95);
            this.uc_cnguser1.Name = "uc_cnguser1";
            this.uc_cnguser1.Size = new System.Drawing.Size(611, 362);
            this.uc_cnguser1.TabIndex = 2;
            // 
            // uc_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.uc_cngpass1);
            this.Controls.Add(this.uc_cnguser1);
            this.Name = "uc_setting";
            this.Size = new System.Drawing.Size(810, 539);
            this.Load += new System.EventHandler(this.uc_login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private uc_cnguser uc_cnguser1;
        private uc_cngpass uc_cngpass1;
    }
}
