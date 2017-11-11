namespace Temeke_Dispensary
{
    partial class cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashier));
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.repotBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.paymentBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.dispNameLb = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.minimizeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerPannel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.logout = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).BeginInit();
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
            // repotBtn
            // 
            this.repotBtn.ActiveBorderThickness = 1;
            this.repotBtn.ActiveCornerRadius = 20;
            this.repotBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.repotBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.repotBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.repotBtn.BackColor = System.Drawing.Color.Transparent;
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
            this.repotBtn.Location = new System.Drawing.Point(492, 114);
            this.repotBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.repotBtn.Name = "repotBtn";
            this.repotBtn.Size = new System.Drawing.Size(92, 42);
            this.repotBtn.TabIndex = 12;
            this.repotBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.repotBtn.Click += new System.EventHandler(this.repotBtn_Click);
            // 
            // paymentBtn
            // 
            this.paymentBtn.ActiveBorderThickness = 1;
            this.paymentBtn.ActiveCornerRadius = 20;
            this.paymentBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.paymentBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.paymentBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.paymentBtn.BackColor = System.Drawing.Color.Transparent;
            this.paymentBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paymentBtn.BackgroundImage")));
            this.paymentBtn.ButtonText = "Payments";
            this.paymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.paymentBtn, BunifuAnimatorNS.DecorationType.None);
            this.paymentBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.paymentBtn.IdleBorderThickness = 1;
            this.paymentBtn.IdleCornerRadius = 20;
            this.paymentBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.paymentBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.paymentBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.paymentBtn.Location = new System.Drawing.Point(326, 114);
            this.paymentBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(152, 42);
            this.paymentBtn.TabIndex = 10;
            this.paymentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
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
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.logoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 606);
            this.panel2.TabIndex = 7;
            // 
            // headerPannel
            // 
            this.headerPannel.BackColor = System.Drawing.Color.Transparent;
            this.headerPannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerPannel.BackgroundImage")));
            this.headerPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerPannel.Controls.Add(this.logout);
            this.headerPannel.Controls.Add(this.paymentBtn);
            this.headerPannel.Controls.Add(this.repotBtn);
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
            this.headerPannel.TabIndex = 0;
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
            this.logout.TabIndex = 14;
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.headerPannel);
            this.Controls.Add(this.panel2);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cashier";
            this.Text = "cashier";
            this.Load += new System.EventHandler(this.cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).EndInit();
            this.headerPannel.ResumeLayout(false);
            this.headerPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private System.Windows.Forms.PictureBox logo2;
        private Bunifu.Framework.UI.BunifuThinButton2 repotBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 paymentBtn;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private System.Windows.Forms.Label dispNameLb;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton minimizeWindow;
        private Bunifu.Framework.UI.BunifuImageButton closeWindow;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuGradientPanel headerPannel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 logout;
    }
}