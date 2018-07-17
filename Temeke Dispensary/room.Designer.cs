namespace Temeke_Dispensary
{
    partial class room
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lable1 = new System.Windows.Forms.Label();
            this.roomNumber = new System.Windows.Forms.ComboBox();
            this.finishBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.Silver;
            this.lable1.Location = new System.Drawing.Point(72, 35);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(104, 19);
            this.lable1.TabIndex = 17;
            this.lable1.Text = "Select Room";
            // 
            // roomNumber
            // 
            this.roomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.roomNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomNumber.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumber.ForeColor = System.Drawing.Color.White;
            this.roomNumber.FormattingEnabled = true;
            this.roomNumber.Location = new System.Drawing.Point(50, 67);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(151, 30);
            this.roomNumber.TabIndex = 19;
            this.roomNumber.SelectedIndexChanged += new System.EventHandler(this.roomNumber_SelectedIndexChanged);
            // 
            // finishBtn
            // 
            this.finishBtn.Activecolor = System.Drawing.Color.Green;
            this.finishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(126)))));
            this.finishBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finishBtn.BorderRadius = 5;
            this.finishBtn.ButtonText = "Cancel";
            this.finishBtn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.finishBtn.Location = new System.Drawing.Point(50, 125);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(126)))));
            this.finishBtn.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.finishBtn.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.finishBtn.selected = false;
            this.finishBtn.Size = new System.Drawing.Size(151, 32);
            this.finishBtn.TabIndex = 56;
            this.finishBtn.Text = "Cancel";
            this.finishBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finishBtn.Textcolor = System.Drawing.Color.White;
            this.finishBtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(254, 169);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.lable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "room";
            this.Load += new System.EventHandler(this.room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.ComboBox roomNumber;
        private Bunifu.Framework.UI.BunifuFlatButton finishBtn;
    }
}