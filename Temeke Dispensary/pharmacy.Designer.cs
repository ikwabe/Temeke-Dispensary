namespace Temeke_Dispensary
{
    partial class pharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pharmacy));
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.headerPannel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.repotBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.closeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.dispNameLb = new System.Windows.Forms.Label();
            this.medicineBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.checkBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.minimizeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.headerPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 602);
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
            this.bunifuDragControl1.TargetControl = this.headerPannel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // headerPannel
            // 
            this.headerPannel.BackColor = System.Drawing.Color.Transparent;
            this.headerPannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerPannel.BackgroundImage")));
            this.headerPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerPannel.Controls.Add(this.logout);
            this.headerPannel.Controls.Add(this.logo2);
            this.headerPannel.Controls.Add(this.repotBtn);
            this.headerPannel.Controls.Add(this.line);
            this.headerPannel.Controls.Add(this.closeWindow);
            this.headerPannel.Controls.Add(this.dispNameLb);
            this.headerPannel.Controls.Add(this.medicineBtn);
            this.headerPannel.Controls.Add(this.checkBtn);
            this.headerPannel.Controls.Add(this.minimizeWindow);
            this.headerPannel.Controls.Add(this.logo);
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
            this.headerPannel.TabIndex = 7;
            // 
            // logo2
            // 
            this.logoAnimator.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.logo2.Image = ((System.Drawing.Image)(resources.GetObject("logo2.Image")));
            this.logo2.Location = new System.Drawing.Point(445, 3);
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
            this.repotBtn.Location = new System.Drawing.Point(620, 118);
            this.repotBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.repotBtn.Name = "repotBtn";
            this.repotBtn.Size = new System.Drawing.Size(92, 42);
            this.repotBtn.TabIndex = 12;
            this.repotBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.repotBtn.Click += new System.EventHandler(this.repotBtn_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.line, BunifuAnimatorNS.DecorationType.None);
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.line.LineThickness = 5;
            this.line.Location = new System.Drawing.Point(306, 162);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(126, 5);
            this.line.TabIndex = 1;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.Color.Transparent;
            this.closeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.closeWindow, BunifuAnimatorNS.DecorationType.None);
            this.closeWindow.Image = ((System.Drawing.Image)(resources.GetObject("closeWindow.Image")));
            this.closeWindow.ImageActive = null;
            this.closeWindow.Location = new System.Drawing.Point(1318, 12);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(30, 30);
            this.closeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeWindow.TabIndex = 0;
            this.closeWindow.TabStop = false;
            this.closeWindow.Zoom = 10;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // dispNameLb
            // 
            this.dispNameLb.AutoSize = true;
            this.dispNameLb.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.dispNameLb, BunifuAnimatorNS.DecorationType.None);
            this.dispNameLb.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispNameLb.ForeColor = System.Drawing.Color.Silver;
            this.dispNameLb.Location = new System.Drawing.Point(455, 77);
            this.dispNameLb.Name = "dispNameLb";
            this.dispNameLb.Size = new System.Drawing.Size(347, 39);
            this.dispNameLb.TabIndex = 3;
            this.dispNameLb.Text = "TEMEKE DISPENSARY";
            // 
            // medicineBtn
            // 
            this.medicineBtn.ActiveBorderThickness = 1;
            this.medicineBtn.ActiveCornerRadius = 20;
            this.medicineBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.medicineBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.medicineBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.medicineBtn.BackColor = System.Drawing.Color.Transparent;
            this.medicineBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("medicineBtn.BackgroundImage")));
            this.medicineBtn.ButtonText = "Medicines";
            this.medicineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.medicineBtn, BunifuAnimatorNS.DecorationType.None);
            this.medicineBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.medicineBtn.IdleBorderThickness = 1;
            this.medicineBtn.IdleCornerRadius = 20;
            this.medicineBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.medicineBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.medicineBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.medicineBtn.Location = new System.Drawing.Point(446, 118);
            this.medicineBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.medicineBtn.Name = "medicineBtn";
            this.medicineBtn.Size = new System.Drawing.Size(160, 42);
            this.medicineBtn.TabIndex = 11;
            this.medicineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.medicineBtn.Click += new System.EventHandler(this.medicineBtn_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.ActiveBorderThickness = 1;
            this.checkBtn.ActiveCornerRadius = 20;
            this.checkBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.checkBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.checkBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.checkBtn.BackColor = System.Drawing.Color.Transparent;
            this.checkBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBtn.BackgroundImage")));
            this.checkBtn.ButtonText = "Check In";
            this.checkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.checkBtn, BunifuAnimatorNS.DecorationType.None);
            this.checkBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBtn.IdleBorderThickness = 1;
            this.checkBtn.IdleCornerRadius = 20;
            this.checkBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.checkBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.checkBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.checkBtn.Location = new System.Drawing.Point(306, 118);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(126, 42);
            this.checkBtn.TabIndex = 9;
            this.checkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // minimizeWindow
            // 
            this.minimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.minimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.minimizeWindow, BunifuAnimatorNS.DecorationType.None);
            this.minimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("minimizeWindow.Image")));
            this.minimizeWindow.ImageActive = null;
            this.minimizeWindow.Location = new System.Drawing.Point(1290, 12);
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
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(101, 91);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.Visible = false;
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
            this.logout.Location = new System.Drawing.Point(1281, 53);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(76, 24);
            this.logout.TabIndex = 15;
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.headerPannel);
            this.Controls.Add(this.panel2);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pharmacy";
            this.Text = "pharmacy";
            this.Load += new System.EventHandler(this.pharmacy_Load);
            this.headerPannel.ResumeLayout(false);
            this.headerPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
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
        private Bunifu.Framework.UI.BunifuThinButton2 checkBtn;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private System.Windows.Forms.Label dispNameLb;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton minimizeWindow;
        private Bunifu.Framework.UI.BunifuImageButton closeWindow;
        private Bunifu.Framework.UI.BunifuThinButton2 medicineBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel headerPannel;
        private Bunifu.Framework.UI.BunifuThinButton2 logout;
    }
}