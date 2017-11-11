namespace Temeke_Dispensary
{
    partial class staffRegistration
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffRegistration));
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.closeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.logo = new System.Windows.Forms.PictureBox();
            this.dispNameLb = new System.Windows.Forms.Label();
            this.headerPannel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.regBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.updBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.logout = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.headerPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.logoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation1;
            this.logoAnimator.TimeStep = 0.05F;
            // 
            // logo2
            // 
            this.logo2.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.logo2.Image = ((System.Drawing.Image)(resources.GetObject("logo2.Image")));
            this.logo2.Location = new System.Drawing.Point(443, 0);
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
            this.closeWindow.Location = new System.Drawing.Point(1316, 9);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(30, 30);
            this.closeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeWindow.TabIndex = 0;
            this.closeWindow.TabStop = false;
            this.closeWindow.Zoom = 10;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // minimizeWindow
            // 
            this.minimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.minimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.minimizeWindow, BunifuAnimatorNS.DecorationType.None);
            this.minimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("minimizeWindow.Image")));
            this.minimizeWindow.ImageActive = null;
            this.minimizeWindow.Location = new System.Drawing.Point(1288, 9);
            this.minimizeWindow.Name = "minimizeWindow";
            this.minimizeWindow.Size = new System.Drawing.Size(32, 30);
            this.minimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeWindow.TabIndex = 1;
            this.minimizeWindow.TabStop = false;
            this.minimizeWindow.Zoom = 10;
            this.minimizeWindow.Click += new System.EventHandler(this.minimizeWindow_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.line, BunifuAnimatorNS.DecorationType.None);
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.line.LineThickness = 5;
            this.line.Location = new System.Drawing.Point(326, 155);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(153, 5);
            this.line.TabIndex = 1;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(1, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(101, 91);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.Visible = false;
            // 
            // dispNameLb
            // 
            this.dispNameLb.AutoSize = true;
            this.dispNameLb.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.dispNameLb, BunifuAnimatorNS.DecorationType.None);
            this.dispNameLb.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispNameLb.ForeColor = System.Drawing.Color.Silver;
            this.dispNameLb.Location = new System.Drawing.Point(453, 74);
            this.dispNameLb.Name = "dispNameLb";
            this.dispNameLb.Size = new System.Drawing.Size(347, 39);
            this.dispNameLb.TabIndex = 3;
            this.dispNameLb.Text = "TEMEKE DISPENSARY";
            // 
            // headerPannel
            // 
            this.headerPannel.BackColor = System.Drawing.Color.Transparent;
            this.headerPannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerPannel.BackgroundImage")));
            this.headerPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerPannel.Controls.Add(this.logout);
            this.headerPannel.Controls.Add(this.regBtn);
            this.headerPannel.Controls.Add(this.updBtn);
            this.headerPannel.Controls.Add(this.logo2);
            this.headerPannel.Controls.Add(this.closeWindow);
            this.headerPannel.Controls.Add(this.minimizeWindow);
            this.headerPannel.Controls.Add(this.line);
            this.headerPannel.Controls.Add(this.logo);
            this.headerPannel.Controls.Add(this.dispNameLb);
            this.logoAnimator.SetDecoration(this.headerPannel, BunifuAnimatorNS.DecorationType.None);
            this.headerPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPannel.GradientBottomLeft = System.Drawing.Color.LimeGreen;
            this.headerPannel.GradientBottomRight = System.Drawing.Color.MediumSeaGreen;
            this.headerPannel.GradientTopLeft = System.Drawing.Color.Navy;
            this.headerPannel.GradientTopRight = System.Drawing.Color.Black;
            this.headerPannel.Location = new System.Drawing.Point(0, 0);
            this.headerPannel.Name = "headerPannel";
            this.headerPannel.Quality = 10;
            this.headerPannel.Size = new System.Drawing.Size(1370, 169);
            this.headerPannel.TabIndex = 8;
            // 
            // regBtn
            // 
            this.regBtn.ActiveBorderThickness = 1;
            this.regBtn.ActiveCornerRadius = 20;
            this.regBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.regBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.regBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.regBtn.BackColor = System.Drawing.Color.Transparent;
            this.regBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regBtn.BackgroundImage")));
            this.regBtn.ButtonText = "Registration";
            this.regBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.regBtn, BunifuAnimatorNS.DecorationType.None);
            this.regBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.regBtn.IdleBorderThickness = 1;
            this.regBtn.IdleCornerRadius = 20;
            this.regBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.regBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.regBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.regBtn.Location = new System.Drawing.Point(326, 114);
            this.regBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(152, 42);
            this.regBtn.TabIndex = 10;
            this.regBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.ActiveBorderThickness = 1;
            this.updBtn.ActiveCornerRadius = 20;
            this.updBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.updBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.updBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.updBtn.BackColor = System.Drawing.Color.Transparent;
            this.updBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updBtn.BackgroundImage")));
            this.updBtn.ButtonText = "Update Staff Info";
            this.updBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.updBtn, BunifuAnimatorNS.DecorationType.None);
            this.updBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.updBtn.IdleBorderThickness = 1;
            this.updBtn.IdleCornerRadius = 20;
            this.updBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.updBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.updBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.updBtn.Location = new System.Drawing.Point(492, 114);
            this.updBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(212, 42);
            this.updBtn.TabIndex = 12;
            this.updBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.logoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 606);
            this.panel2.TabIndex = 9;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerPannel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // logout
            // 
            this.logout.ActiveBorderThickness = 1;
            this.logout.ActiveCornerRadius = 20;
            this.logout.ActiveFillColor = System.Drawing.Color.Transparent;
            this.logout.ActiveForecolor = System.Drawing.Color.Silver;
            this.logout.ActiveLineColor = System.Drawing.Color.Transparent;
            this.logout.BackColor = System.Drawing.Color.Transparent;
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
            this.logout.Location = new System.Drawing.Point(1281, 46);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(76, 24);
            this.logout.TabIndex = 15;
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // staffRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.headerPannel);
            this.Controls.Add(this.panel2);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffRegistration";
            this.Text = "staffRegistration";
            this.Load += new System.EventHandler(this.staffRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.headerPannel.ResumeLayout(false);
            this.headerPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private System.Windows.Forms.PictureBox logo2;
        private Bunifu.Framework.UI.BunifuImageButton closeWindow;
        private Bunifu.Framework.UI.BunifuImageButton minimizeWindow;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label dispNameLb;
        private Bunifu.Framework.UI.BunifuGradientPanel headerPannel;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 regBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 updBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 logout;
    }
}