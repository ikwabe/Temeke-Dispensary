namespace Temeke_Dispensary
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.closeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.dispNameLb = new System.Windows.Forms.Label();
            this.headerPannel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.finishBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
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
            this.headerPannel.Controls.Add(this.logo2);
            this.headerPannel.Controls.Add(this.closeWindow);
            this.headerPannel.Controls.Add(this.minimizeWindow);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(568, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(467, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(467, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // passwd
            // 
            this.passwd.BorderColorFocused = System.Drawing.Color.Blue;
            this.passwd.BorderColorIdle = System.Drawing.Color.RoyalBlue;
            this.passwd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.passwd.BorderThickness = 3;
            this.passwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logoAnimator.SetDecoration(this.passwd, BunifuAnimatorNS.DecorationType.None);
            this.passwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwd.ForeColor = System.Drawing.Color.Black;
            this.passwd.isPassword = true;
            this.passwd.Location = new System.Drawing.Point(471, 430);
            this.passwd.Margin = new System.Windows.Forms.Padding(4);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(370, 44);
            this.passwd.TabIndex = 13;
            this.passwd.Text = "shauri";
            this.passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // finishBtn
            // 
            this.finishBtn.Activecolor = System.Drawing.Color.Green;
            this.finishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(126)))));
            this.finishBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finishBtn.BorderRadius = 5;
            this.finishBtn.ButtonText = "Finish";
            this.finishBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.finishBtn, BunifuAnimatorNS.DecorationType.None);
            this.finishBtn.DisabledColor = System.Drawing.Color.Gray;
            this.finishBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.finishBtn.Iconimage = null;
            this.finishBtn.Iconimage_right = null;
            this.finishBtn.Iconimage_right_Selected = null;
            this.finishBtn.Iconimage_Selected = null;
            this.finishBtn.IconMarginLeft = 0;
            this.finishBtn.IconMarginRight = 0;
            this.finishBtn.IconRightVisible = false;
            this.finishBtn.IconRightZoom = 0D;
            this.finishBtn.IconVisible = false;
            this.finishBtn.IconZoom = 90D;
            this.finishBtn.IsTab = false;
            this.finishBtn.Location = new System.Drawing.Point(471, 525);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(126)))));
            this.finishBtn.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.finishBtn.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.finishBtn.selected = false;
            this.finishBtn.Size = new System.Drawing.Size(370, 52);
            this.finishBtn.TabIndex = 55;
            this.finishBtn.Text = "Finish";
            this.finishBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finishBtn.Textcolor = System.Drawing.Color.Green;
            this.finishBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
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
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerPannel);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.headerPannel.ResumeLayout(false);
            this.headerPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private System.Windows.Forms.PictureBox logo2;
        private Bunifu.Framework.UI.BunifuImageButton closeWindow;
        private Bunifu.Framework.UI.BunifuImageButton minimizeWindow;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label dispNameLb;
        private Bunifu.Framework.UI.BunifuGradientPanel headerPannel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwd;
        private Bunifu.Framework.UI.BunifuFlatButton finishBtn;
    }
}