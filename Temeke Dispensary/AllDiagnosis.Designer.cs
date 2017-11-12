﻿namespace Temeke_Dispensary
{
    partial class AllDiagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllDiagnosis));
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.closeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.headerPannel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.diagDataGrid = new System.Windows.Forms.DataGridView();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).BeginInit();
            this.headerPannel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagDataGrid)).BeginInit();
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
            this.logo2.Location = new System.Drawing.Point(229, 3);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(175, 74);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 13;
            this.logo2.TabStop = false;
            this.logo2.Visible = false;
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.Color.Transparent;
            this.closeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.closeWindow, BunifuAnimatorNS.DecorationType.None);
            this.closeWindow.Image = ((System.Drawing.Image)(resources.GetObject("closeWindow.Image")));
            this.closeWindow.ImageActive = null;
            this.closeWindow.Location = new System.Drawing.Point(630, 3);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(30, 30);
            this.closeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeWindow.TabIndex = 0;
            this.closeWindow.TabStop = false;
            this.closeWindow.Zoom = 10;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // headerPannel
            // 
            this.headerPannel.BackColor = System.Drawing.Color.Transparent;
            this.headerPannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerPannel.BackgroundImage")));
            this.headerPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerPannel.Controls.Add(this.label1);
            this.headerPannel.Controls.Add(this.searchTxt);
            this.headerPannel.Controls.Add(this.logo2);
            this.headerPannel.Controls.Add(this.closeWindow);
            this.logoAnimator.SetDecoration(this.headerPannel, BunifuAnimatorNS.DecorationType.None);
            this.headerPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPannel.GradientBottomLeft = System.Drawing.Color.LimeGreen;
            this.headerPannel.GradientBottomRight = System.Drawing.Color.MediumSeaGreen;
            this.headerPannel.GradientTopLeft = System.Drawing.Color.Navy;
            this.headerPannel.GradientTopRight = System.Drawing.Color.Black;
            this.headerPannel.Location = new System.Drawing.Point(0, 0);
            this.headerPannel.Name = "headerPannel";
            this.headerPannel.Quality = 10;
            this.headerPannel.Size = new System.Drawing.Size(668, 140);
            this.headerPannel.TabIndex = 57;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.diagDataGrid);
            this.logoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 632);
            this.panel1.TabIndex = 58;
            // 
            // diagDataGrid
            // 
            this.diagDataGrid.AllowUserToAddRows = false;
            this.diagDataGrid.AllowUserToDeleteRows = false;
            this.diagDataGrid.AllowUserToResizeColumns = false;
            this.diagDataGrid.AllowUserToResizeRows = false;
            this.diagDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.diagDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.diagDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.diagDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logoAnimator.SetDecoration(this.diagDataGrid, BunifuAnimatorNS.DecorationType.None);
            this.diagDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagDataGrid.Location = new System.Drawing.Point(0, 0);
            this.diagDataGrid.Name = "diagDataGrid";
            this.diagDataGrid.ReadOnly = true;
            this.diagDataGrid.Size = new System.Drawing.Size(668, 632);
            this.diagDataGrid.TabIndex = 0;
            // 
            // searchTxt
            // 
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoAnimator.SetDecoration(this.searchTxt, BunifuAnimatorNS.DecorationType.None);
            this.searchTxt.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(12, 104);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(260, 30);
            this.searchTxt.TabIndex = 14;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search";
            // 
            // AllDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(668, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPannel);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllDiagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllDiagnosis";
            this.Load += new System.EventHandler(this.AllDiagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).EndInit();
            this.headerPannel.ResumeLayout(false);
            this.headerPannel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private System.Windows.Forms.PictureBox logo2;
        private Bunifu.Framework.UI.BunifuImageButton closeWindow;
        private Bunifu.Framework.UI.BunifuGradientPanel headerPannel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView diagDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTxt;
    }
}