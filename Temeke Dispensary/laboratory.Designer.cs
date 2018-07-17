namespace Temeke_Dispensary
{
    partial class laboratory
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laboratory));
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dispNameLb = new System.Windows.Forms.Label();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkPatientTimer = new System.Windows.Forms.Timer(this.components);
            this.mute = new System.Windows.Forms.Label();
            this.muteSoundButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.minimizeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.closeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.viewBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.measureBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.repotBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AlertTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muteSoundButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(0, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 603);
            this.panel2.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dispNameLb
            // 
            this.dispNameLb.AutoSize = true;
            this.dispNameLb.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.dispNameLb, BunifuAnimatorNS.DecorationType.None);
            this.dispNameLb.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispNameLb.ForeColor = System.Drawing.Color.Silver;
            this.dispNameLb.Location = new System.Drawing.Point(464, 77);
            this.dispNameLb.Name = "dispNameLb";
            this.dispNameLb.Size = new System.Drawing.Size(347, 39);
            this.dispNameLb.TabIndex = 3;
            this.dispNameLb.Text = "TEMEKE DISPENSARY";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.line, BunifuAnimatorNS.DecorationType.None);
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.line.LineThickness = 5;
            this.line.Location = new System.Drawing.Point(287, 158);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(146, 5);
            this.line.TabIndex = 1;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.logoAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation3;
            this.logoAnimator.TimeStep = 0.05F;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(98)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.mute);
            this.panel1.Controls.Add(this.muteSoundButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.minimizeWindow);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.logo2);
            this.panel1.Controls.Add(this.closeWindow);
            this.panel1.Controls.Add(this.viewBtn);
            this.panel1.Controls.Add(this.measureBtn);
            this.panel1.Controls.Add(this.repotBtn);
            this.panel1.Controls.Add(this.dispNameLb);
            this.logoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 171);
            this.panel1.TabIndex = 6;
            // 
            // checkPatientTimer
            // 
            this.checkPatientTimer.Interval = 1;
            this.checkPatientTimer.Tick += new System.EventHandler(this.checkPatientTimer_Tick);
            // 
            // mute
            // 
            this.mute.AutoSize = true;
            this.mute.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.mute, BunifuAnimatorNS.DecorationType.None);
            this.mute.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mute.ForeColor = System.Drawing.Color.Orange;
            this.mute.Location = new System.Drawing.Point(9, 146);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(34, 14);
            this.mute.TabIndex = 21;
            this.mute.Text = "Mute";
            // 
            // muteSoundButton
            // 
            this.muteSoundButton.BackColor = System.Drawing.Color.Transparent;
            this.muteSoundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.muteSoundButton, BunifuAnimatorNS.DecorationType.None);
            this.muteSoundButton.Image = ((System.Drawing.Image)(resources.GetObject("muteSoundButton.Image")));
            this.muteSoundButton.ImageActive = null;
            this.muteSoundButton.Location = new System.Drawing.Point(12, 117);
            this.muteSoundButton.Name = "muteSoundButton";
            this.muteSoundButton.Size = new System.Drawing.Size(30, 26);
            this.muteSoundButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.muteSoundButton.TabIndex = 20;
            this.muteSoundButton.TabStop = false;
            this.muteSoundButton.Zoom = 10;
            this.muteSoundButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.muteSoundButton_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(1190, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // logout
            // 
            this.logout.ActiveBorderThickness = 1;
            this.logout.ActiveCornerRadius = 20;
            this.logout.ActiveFillColor = System.Drawing.Color.Transparent;
            this.logout.ActiveForecolor = System.Drawing.Color.Silver;
            this.logout.ActiveLineColor = System.Drawing.Color.Transparent;
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(98)))), ((int)(((byte)(73)))));
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.ButtonText = "LogOut";
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.logout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.DarkGray;
            this.logout.IdleBorderThickness = 1;
            this.logout.IdleCornerRadius = 20;
            this.logout.IdleFillColor = System.Drawing.Color.Transparent;
            this.logout.IdleForecolor = System.Drawing.Color.DarkGray;
            this.logout.IdleLineColor = System.Drawing.Color.Transparent;
            this.logout.Location = new System.Drawing.Point(1290, 49);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(76, 24);
            this.logout.TabIndex = 15;
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // minimizeWindow
            // 
            this.minimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.minimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.minimizeWindow, BunifuAnimatorNS.DecorationType.None);
            this.minimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("minimizeWindow.Image")));
            this.minimizeWindow.ImageActive = null;
            this.minimizeWindow.Location = new System.Drawing.Point(1299, 12);
            this.minimizeWindow.Name = "minimizeWindow";
            this.minimizeWindow.Size = new System.Drawing.Size(32, 30);
            this.minimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeWindow.TabIndex = 1;
            this.minimizeWindow.TabStop = false;
            this.minimizeWindow.Zoom = 10;
            this.minimizeWindow.Click += new System.EventHandler(this.minimizeWindow_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(101, 91);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.Visible = false;
            // 
            // logo2
            // 
            this.logoAnimator.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.logo2.Image = ((System.Drawing.Image)(resources.GetObject("logo2.Image")));
            this.logo2.Location = new System.Drawing.Point(454, 3);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(357, 74);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 13;
            this.logo2.TabStop = false;
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.Color.Transparent;
            this.closeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.closeWindow, BunifuAnimatorNS.DecorationType.None);
            this.closeWindow.Image = ((System.Drawing.Image)(resources.GetObject("closeWindow.Image")));
            this.closeWindow.ImageActive = null;
            this.closeWindow.Location = new System.Drawing.Point(1327, 12);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(30, 30);
            this.closeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeWindow.TabIndex = 0;
            this.closeWindow.TabStop = false;
            this.closeWindow.Zoom = 10;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.ActiveBorderThickness = 1;
            this.viewBtn.ActiveCornerRadius = 20;
            this.viewBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.viewBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.viewBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.viewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(98)))), ((int)(((byte)(73)))));
            this.viewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewBtn.BackgroundImage")));
            this.viewBtn.ButtonText = "Request(s)";
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.viewBtn, BunifuAnimatorNS.DecorationType.None);
            this.viewBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.viewBtn.IdleBorderThickness = 1;
            this.viewBtn.IdleCornerRadius = 20;
            this.viewBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.viewBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.viewBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.viewBtn.Location = new System.Drawing.Point(287, 117);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(145, 42);
            this.viewBtn.TabIndex = 10;
            this.viewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // measureBtn
            // 
            this.measureBtn.ActiveBorderThickness = 1;
            this.measureBtn.ActiveCornerRadius = 20;
            this.measureBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.measureBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.measureBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.measureBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(98)))), ((int)(((byte)(73)))));
            this.measureBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("measureBtn.BackgroundImage")));
            this.measureBtn.ButtonText = "Measurements";
            this.measureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.measureBtn, BunifuAnimatorNS.DecorationType.None);
            this.measureBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measureBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.measureBtn.IdleBorderThickness = 1;
            this.measureBtn.IdleCornerRadius = 20;
            this.measureBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.measureBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.measureBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.measureBtn.Location = new System.Drawing.Point(446, 117);
            this.measureBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.measureBtn.Name = "measureBtn";
            this.measureBtn.Size = new System.Drawing.Size(200, 42);
            this.measureBtn.TabIndex = 11;
            this.measureBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.measureBtn.Click += new System.EventHandler(this.measureBtn_Click);
            // 
            // repotBtn
            // 
            this.repotBtn.ActiveBorderThickness = 1;
            this.repotBtn.ActiveCornerRadius = 20;
            this.repotBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.repotBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.repotBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.repotBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(98)))), ((int)(((byte)(73)))));
            this.repotBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("repotBtn.BackgroundImage")));
            this.repotBtn.ButtonText = "Report";
            this.repotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.repotBtn, BunifuAnimatorNS.DecorationType.None);
            this.repotBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repotBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.repotBtn.IdleBorderThickness = 1;
            this.repotBtn.IdleCornerRadius = 20;
            this.repotBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.repotBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.repotBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.repotBtn.Location = new System.Drawing.Point(660, 117);
            this.repotBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.repotBtn.Name = "repotBtn";
            this.repotBtn.Size = new System.Drawing.Size(92, 42);
            this.repotBtn.TabIndex = 12;
            this.repotBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.repotBtn.Click += new System.EventHandler(this.repotBtn_Click);
            // 
            // AlertTimer
            // 
            this.AlertTimer.Interval = 2000;
            this.AlertTimer.Tick += new System.EventHandler(this.AlertTimer_Tick);
            // 
            // laboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "laboratory";
            this.Text = "laboratory";
            this.Load += new System.EventHandler(this.laboratory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muteSoundButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox logo2;
        private Bunifu.Framework.UI.BunifuThinButton2 repotBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 measureBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 viewBtn;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private System.Windows.Forms.Label dispNameLb;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton minimizeWindow;
        private Bunifu.Framework.UI.BunifuImageButton closeWindow;
        private Bunifu.Framework.UI.BunifuThinButton2 logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer checkPatientTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mute;
        private Bunifu.Framework.UI.BunifuImageButton muteSoundButton;
        private System.Windows.Forms.Timer AlertTimer;
    }
}