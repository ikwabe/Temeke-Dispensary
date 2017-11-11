namespace Temeke_Dispensary
{
    partial class medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicine));
            this.panel1 = new System.Windows.Forms.Panel();
            this.editMedBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.viewBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.regMedBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dispNameLb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.editMedBtn);
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.viewBtn);
            this.panel1.Controls.Add(this.regMedBtn);
            this.panel1.Controls.Add(this.dispNameLb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 100);
            this.panel1.TabIndex = 0;
            // 
            // editMedBtn
            // 
            this.editMedBtn.ActiveBorderThickness = 1;
            this.editMedBtn.ActiveCornerRadius = 20;
            this.editMedBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.editMedBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.editMedBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.editMedBtn.BackColor = System.Drawing.Color.Transparent;
            this.editMedBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editMedBtn.BackgroundImage")));
            this.editMedBtn.ButtonText = "Edit Drug Details";
            this.editMedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editMedBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMedBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.editMedBtn.IdleBorderThickness = 1;
            this.editMedBtn.IdleCornerRadius = 20;
            this.editMedBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.editMedBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.editMedBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.editMedBtn.Location = new System.Drawing.Point(506, 48);
            this.editMedBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.editMedBtn.Name = "editMedBtn";
            this.editMedBtn.Size = new System.Drawing.Size(230, 42);
            this.editMedBtn.TabIndex = 14;
            this.editMedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editMedBtn.Click += new System.EventHandler(this.editMedBtn_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.line.LineThickness = 5;
            this.line.Location = new System.Drawing.Point(238, 90);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(258, 10);
            this.line.TabIndex = 13;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // viewBtn
            // 
            this.viewBtn.ActiveBorderThickness = 1;
            this.viewBtn.ActiveCornerRadius = 20;
            this.viewBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.viewBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.viewBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.viewBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewBtn.BackgroundImage")));
            this.viewBtn.ButtonText = "View All Medicine";
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.viewBtn.IdleBorderThickness = 1;
            this.viewBtn.IdleCornerRadius = 20;
            this.viewBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.viewBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.viewBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.viewBtn.Location = new System.Drawing.Point(750, 48);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(230, 42);
            this.viewBtn.TabIndex = 12;
            this.viewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // regMedBtn
            // 
            this.regMedBtn.ActiveBorderThickness = 1;
            this.regMedBtn.ActiveCornerRadius = 20;
            this.regMedBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.regMedBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.regMedBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.regMedBtn.BackColor = System.Drawing.Color.Transparent;
            this.regMedBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regMedBtn.BackgroundImage")));
            this.regMedBtn.ButtonText = "Register Medicine(s)";
            this.regMedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regMedBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regMedBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.regMedBtn.IdleBorderThickness = 1;
            this.regMedBtn.IdleCornerRadius = 20;
            this.regMedBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.regMedBtn.IdleForecolor = System.Drawing.Color.DarkGray;
            this.regMedBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.regMedBtn.Location = new System.Drawing.Point(238, 48);
            this.regMedBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.regMedBtn.Name = "regMedBtn";
            this.regMedBtn.Size = new System.Drawing.Size(258, 42);
            this.regMedBtn.TabIndex = 11;
            this.regMedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regMedBtn.Click += new System.EventHandler(this.regMedBtn_Click);
            // 
            // dispNameLb
            // 
            this.dispNameLb.AutoSize = true;
            this.dispNameLb.BackColor = System.Drawing.Color.Transparent;
            this.dispNameLb.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispNameLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.dispNameLb.Location = new System.Drawing.Point(631, 0);
            this.dispNameLb.Name = "dispNameLb";
            this.dispNameLb.Size = new System.Drawing.Size(199, 39);
            this.dispNameLb.TabIndex = 5;
            this.dispNameLb.Text = "MEDICINES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 503);
            this.panel2.TabIndex = 1;
            // 
            // medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "medicine";
            this.Size = new System.Drawing.Size(1370, 603);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dispNameLb;
        private Bunifu.Framework.UI.BunifuThinButton2 viewBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 regMedBtn;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 editMedBtn;
    }
}
