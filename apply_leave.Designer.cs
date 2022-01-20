
namespace Case_Study
{
    partial class apply_leave
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_to = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dt_from = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textbox_reason = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.textbox_reason);
            this.panel1.Controls.Add(this.dt_to);
            this.panel1.Controls.Add(this.dt_from);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(135, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 445);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dt_to
            // 
            this.dt_to.CheckedState.Parent = this.dt_to;
            this.dt_to.FillColor = System.Drawing.Color.White;
            this.dt_to.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_to.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_to.HoverState.Parent = this.dt_to;
            this.dt_to.Location = new System.Drawing.Point(188, 131);
            this.dt_to.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_to.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_to.Name = "dt_to";
            this.dt_to.ShadowDecoration.Parent = this.dt_to;
            this.dt_to.Size = new System.Drawing.Size(200, 36);
            this.dt_to.TabIndex = 30;
            this.dt_to.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            // 
            // dt_from
            // 
            this.dt_from.CheckedState.Parent = this.dt_from;
            this.dt_from.FillColor = System.Drawing.Color.White;
            this.dt_from.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_from.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_from.HoverState.Parent = this.dt_from;
            this.dt_from.Location = new System.Drawing.Point(188, 80);
            this.dt_from.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_from.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_from.Name = "dt_from";
            this.dt_from.ShadowDecoration.Parent = this.dt_from;
            this.dt_from.Size = new System.Drawing.Size(200, 36);
            this.dt_from.TabIndex = 29;
            this.dt_from.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Peru;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(411, 370);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(123, 38);
            this.guna2Button1.TabIndex = 28;
            this.guna2Button1.Text = "APPLY";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 36);
            this.label4.TabIndex = 27;
            this.label4.Text = "REASON";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "LEAVE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(109, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "TO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(109, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "FROM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Peru;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(545, 33);
            this.label12.TabIndex = 19;
            this.label12.Text = "APPLY FOR LEAVE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textbox_reason
            // 
            this.textbox_reason.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_reason.Location = new System.Drawing.Point(108, 188);
            this.textbox_reason.Multiline = true;
            this.textbox_reason.Name = "textbox_reason";
            this.textbox_reason.Size = new System.Drawing.Size(425, 175);
            this.textbox_reason.TabIndex = 31;
            // 
            // apply_leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Name = "apply_leave";
            this.Size = new System.Drawing.Size(810, 539);
            this.Load += new System.EventHandler(this.apply_leave_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_to;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_from;
        private System.Windows.Forms.TextBox textbox_reason;
    }
}
