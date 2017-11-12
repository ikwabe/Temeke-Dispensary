namespace Temeke_Dispensary
{
    partial class treatmentTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.treatmentComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.otherTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.submitTreatmentBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.symptomTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.daycomboBox = new System.Windows.Forms.ComboBox();
            this.drugnameLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchDrugBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.drugCodeTxt = new System.Windows.Forms.TextBox();
            this.bunifuCustomDataGrid3 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(86, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 19);
            this.label11.TabIndex = 38;
            this.label11.Text = "Treatments";
            // 
            // treatmentComboBox
            // 
            this.treatmentComboBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.treatmentComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treatmentComboBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentComboBox.FormattingEnabled = true;
            this.treatmentComboBox.Items.AddRange(new object[] {
            "Drug",
            "Procedual"});
            this.treatmentComboBox.Location = new System.Drawing.Point(185, 23);
            this.treatmentComboBox.Name = "treatmentComboBox";
            this.treatmentComboBox.Size = new System.Drawing.Size(247, 30);
            this.treatmentComboBox.TabIndex = 37;
            this.treatmentComboBox.Text = "---Select---";
            this.treatmentComboBox.SelectedIndexChanged += new System.EventHandler(this.treatmentComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.treatmentComboBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 64);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.otherTxtBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.submitTreatmentBtn);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.symptomTxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox6);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.daycomboBox);
            this.panel2.Controls.Add(this.drugnameLable);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.searchDrugBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.drugCodeTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 380);
            this.panel2.TabIndex = 40;
            this.panel2.Visible = false;
            // 
            // otherTxtBox
            // 
            this.otherTxtBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.otherTxtBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherTxtBox.Location = new System.Drawing.Point(20, 279);
            this.otherTxtBox.Mask = "00";
            this.otherTxtBox.Name = "otherTxtBox";
            this.otherTxtBox.Size = new System.Drawing.Size(75, 30);
            this.otherTxtBox.TabIndex = 118;
            this.otherTxtBox.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(17, 650);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 19);
            this.label12.TabIndex = 124;
            // 
            // submitTreatmentBtn
            // 
            this.submitTreatmentBtn.Activecolor = System.Drawing.Color.DodgerBlue;
            this.submitTreatmentBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitTreatmentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitTreatmentBtn.BorderRadius = 5;
            this.submitTreatmentBtn.ButtonText = "Submit";
            this.submitTreatmentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitTreatmentBtn.DisabledColor = System.Drawing.Color.Gray;
            this.submitTreatmentBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTreatmentBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.submitTreatmentBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.submitTreatmentBtn.Iconimage = null;
            this.submitTreatmentBtn.Iconimage_right = null;
            this.submitTreatmentBtn.Iconimage_right_Selected = null;
            this.submitTreatmentBtn.Iconimage_Selected = null;
            this.submitTreatmentBtn.IconMarginLeft = 0;
            this.submitTreatmentBtn.IconMarginRight = 0;
            this.submitTreatmentBtn.IconRightVisible = false;
            this.submitTreatmentBtn.IconRightZoom = 0D;
            this.submitTreatmentBtn.IconVisible = false;
            this.submitTreatmentBtn.IconZoom = 90D;
            this.submitTreatmentBtn.IsTab = false;
            this.submitTreatmentBtn.Location = new System.Drawing.Point(345, 584);
            this.submitTreatmentBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitTreatmentBtn.Name = "submitTreatmentBtn";
            this.submitTreatmentBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.submitTreatmentBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(126)))));
            this.submitTreatmentBtn.OnHoverTextColor = System.Drawing.Color.Lime;
            this.submitTreatmentBtn.selected = false;
            this.submitTreatmentBtn.Size = new System.Drawing.Size(187, 41);
            this.submitTreatmentBtn.TabIndex = 123;
            this.submitTreatmentBtn.Text = "Submit";
            this.submitTreatmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitTreatmentBtn.Textcolor = System.Drawing.Color.Lime;
            this.submitTreatmentBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(109, 498);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 60);
            this.textBox1.TabIndex = 122;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(16, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 19);
            this.label10.TabIndex = 121;
            this.label10.Text = "Comment";
            // 
            // symptomTxt
            // 
            this.symptomTxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.symptomTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomTxt.Location = new System.Drawing.Point(109, 366);
            this.symptomTxt.Multiline = true;
            this.symptomTxt.Name = "symptomTxt";
            this.symptomTxt.Size = new System.Drawing.Size(323, 60);
            this.symptomTxt.TabIndex = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(16, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 119;
            this.label9.Text = "Other Plan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(353, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 117;
            this.label8.Text = "Evening";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(245, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 116;
            this.label6.Text = "Afternoon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(129, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 115;
            this.label5.Text = "Morning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(21, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 114;
            this.label4.Text = "Day";
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox6.Location = new System.Drawing.Point(357, 279);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(75, 30);
            this.comboBox6.TabIndex = 113;
            this.comboBox6.Text = "0";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox4.Location = new System.Drawing.Point(245, 279);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(75, 30);
            this.comboBox4.TabIndex = 112;
            this.comboBox4.Text = "0";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(133, 279);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(75, 30);
            this.comboBox3.TabIndex = 111;
            this.comboBox3.Text = "0";
            // 
            // daycomboBox
            // 
            this.daycomboBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.daycomboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daycomboBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daycomboBox.FormattingEnabled = true;
            this.daycomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "Other"});
            this.daycomboBox.Location = new System.Drawing.Point(21, 279);
            this.daycomboBox.Name = "daycomboBox";
            this.daycomboBox.Size = new System.Drawing.Size(75, 30);
            this.daycomboBox.TabIndex = 110;
            this.daycomboBox.Text = "0";
            this.daycomboBox.SelectedIndexChanged += new System.EventHandler(this.daycomboBox_SelectedIndexChanged);
            // 
            // drugnameLable
            // 
            this.drugnameLable.AutoSize = true;
            this.drugnameLable.BackColor = System.Drawing.Color.Transparent;
            this.drugnameLable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugnameLable.ForeColor = System.Drawing.Color.LightCoral;
            this.drugnameLable.Location = new System.Drawing.Point(129, 137);
            this.drugnameLable.Name = "drugnameLable";
            this.drugnameLable.Size = new System.Drawing.Size(81, 19);
            this.drugnameLable.TabIndex = 109;
            this.drugnameLable.Text = "Loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(17, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 108;
            this.label2.Text = "Drug Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Drug",
            "Procedual"});
            this.comboBox1.Location = new System.Drawing.Point(133, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 30);
            this.comboBox1.TabIndex = 106;
            this.comboBox1.Text = "---Select---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(79, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 107;
            this.label1.Text = "For";
            // 
            // searchDrugBtn
            // 
            this.searchDrugBtn.Activecolor = System.Drawing.Color.DodgerBlue;
            this.searchDrugBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchDrugBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchDrugBtn.BorderRadius = 5;
            this.searchDrugBtn.ButtonText = "Choose Drug";
            this.searchDrugBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchDrugBtn.DisabledColor = System.Drawing.Color.Gray;
            this.searchDrugBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDrugBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.searchDrugBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.searchDrugBtn.Iconimage = null;
            this.searchDrugBtn.Iconimage_right = null;
            this.searchDrugBtn.Iconimage_right_Selected = null;
            this.searchDrugBtn.Iconimage_Selected = null;
            this.searchDrugBtn.IconMarginLeft = 0;
            this.searchDrugBtn.IconMarginRight = 0;
            this.searchDrugBtn.IconRightVisible = false;
            this.searchDrugBtn.IconRightZoom = 0D;
            this.searchDrugBtn.IconVisible = false;
            this.searchDrugBtn.IconZoom = 90D;
            this.searchDrugBtn.IsTab = false;
            this.searchDrugBtn.Location = new System.Drawing.Point(116, 78);
            this.searchDrugBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchDrugBtn.Name = "searchDrugBtn";
            this.searchDrugBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.searchDrugBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(126)))));
            this.searchDrugBtn.OnHoverTextColor = System.Drawing.Color.Lime;
            this.searchDrugBtn.selected = false;
            this.searchDrugBtn.Size = new System.Drawing.Size(187, 41);
            this.searchDrugBtn.TabIndex = 105;
            this.searchDrugBtn.Text = "Choose Drug";
            this.searchDrugBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchDrugBtn.Textcolor = System.Drawing.Color.Lime;
            this.searchDrugBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDrugBtn.Click += new System.EventHandler(this.searchDrugBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(31, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 82;
            this.label7.Text = "Drug Code";
            // 
            // drugCodeTxt
            // 
            this.drugCodeTxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.drugCodeTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugCodeTxt.Location = new System.Drawing.Point(133, 25);
            this.drugCodeTxt.Name = "drugCodeTxt";
            this.drugCodeTxt.Size = new System.Drawing.Size(148, 30);
            this.drugCodeTxt.TabIndex = 81;
            this.drugCodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.drugCodeTxt_KeyDown);
            // 
            // bunifuCustomDataGrid3
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.bunifuCustomDataGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.bunifuCustomDataGrid3.DoubleBuffered = true;
            this.bunifuCustomDataGrid3.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid3.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.bunifuCustomDataGrid3.HeaderForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomDataGrid3.Location = new System.Drawing.Point(40, 106);
            this.bunifuCustomDataGrid3.Name = "bunifuCustomDataGrid3";
            this.bunifuCustomDataGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid3.Size = new System.Drawing.Size(647, 75);
            this.bunifuCustomDataGrid3.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Plan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 600;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.bunifuCustomDataGrid3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(652, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 380);
            this.panel3.TabIndex = 41;
            this.panel3.Visible = false;
            // 
            // treatmentTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "treatmentTab";
            this.Size = new System.Drawing.Size(1365, 444);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox treatmentComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton searchDrugBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox daycomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox otherTxtBox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox symptomTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuFlatButton submitTreatmentBtn;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label drugnameLable;
        public System.Windows.Forms.TextBox drugCodeTxt;
    }
}
