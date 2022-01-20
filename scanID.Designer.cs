
namespace Case_Study
{
    partial class scanID
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.IDchanged = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.wlcm_id = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.wlcm_msg = new System.Windows.Forms.Label();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.combo_devices = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.IDchanged);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.combo_devices);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(98, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 476);
            this.panel1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(0, 349);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(95, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "CANCEL";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // IDchanged
            // 
            this.IDchanged.Location = new System.Drawing.Point(132, 432);
            this.IDchanged.Name = "IDchanged";
            this.IDchanged.Size = new System.Drawing.Size(220, 34);
            this.IDchanged.TabIndex = 9;
            this.IDchanged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IDchanged.TextChanged += new System.EventHandler(this.IDchanged_TextChanged);
            this.IDchanged.Click += new System.EventHandler(this.IDchanged_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.wlcm_id);
            this.panel2.Controls.Add(this.circularProgressBar1);
            this.panel2.Controls.Add(this.wlcm_msg);
            this.panel2.Location = new System.Drawing.Point(198, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 98);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Logging You in...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wlcm_id
            // 
            this.wlcm_id.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlcm_id.Location = new System.Drawing.Point(69, 5);
            this.wlcm_id.Name = "wlcm_id";
            this.wlcm_id.Size = new System.Drawing.Size(175, 30);
            this.wlcm_id.TabIndex = 5;
            this.wlcm_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wlcm_id.Click += new System.EventHandler(this.wlcm_id_Click);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.QuadraticEaseInOut;
            this.circularProgressBar1.AnimationSpeed = 5;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(33, 54);
            this.circularProgressBar1.MarqueeAnimationSpeed = 1000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.White;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.circularProgressBar1.ProgressWidth = 3;
            this.circularProgressBar1.RightToLeftLayout = true;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(35, 35);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.White;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 4;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 75;
            // 
            // wlcm_msg
            // 
            this.wlcm_msg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlcm_msg.Location = new System.Drawing.Point(1, 5);
            this.wlcm_msg.Name = "wlcm_msg";
            this.wlcm_msg.Size = new System.Drawing.Size(71, 30);
            this.wlcm_msg.TabIndex = 0;
            this.wlcm_msg.Text = "Welcome";
            this.wlcm_msg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_cancel
            // 
            this.btn_cancel.CheckedState.Parent = this.btn_cancel;
            this.btn_cancel.CustomImages.Parent = this.btn_cancel;
            this.btn_cancel.FillColor = System.Drawing.SystemColors.Highlight;
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.HoverState.Parent = this.btn_cancel;
            this.btn_cancel.Location = new System.Drawing.Point(390, 428);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ShadowDecoration.Parent = this.btn_cancel;
            this.btn_cancel.Size = new System.Drawing.Size(138, 45);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // combo_devices
            // 
            this.combo_devices.BackColor = System.Drawing.Color.Transparent;
            this.combo_devices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_devices.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_devices.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_devices.FocusedState.Parent = this.combo_devices;
            this.combo_devices.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_devices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_devices.HoverState.Parent = this.combo_devices;
            this.combo_devices.ItemHeight = 30;
            this.combo_devices.ItemsAppearance.Parent = this.combo_devices;
            this.combo_devices.Location = new System.Drawing.Point(190, 3);
            this.combo_devices.Name = "combo_devices";
            this.combo_devices.ShadowDecoration.Parent = this.combo_devices;
            this.combo_devices.Size = new System.Drawing.Size(255, 36);
            this.combo_devices.TabIndex = 5;
            this.combo_devices.SelectedIndexChanged += new System.EventHandler(this.combo_devices_SelectedIndexChanged);
            this.combo_devices.Click += new System.EventHandler(this.combo_devices_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBox1.Location = new System.Drawing.Point(101, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 374);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // scanID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "scanID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "scanID";
            this.Load += new System.EventHandler(this.scanID_Load);
            this.Shown += new System.EventHandler(this.scanID_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2ComboBox combo_devices;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label wlcm_msg;
        private System.Windows.Forms.Label IDchanged;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label wlcm_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
    }
}