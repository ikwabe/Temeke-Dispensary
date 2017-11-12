﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Temeke_Dispensary
{
    public partial class treatmentTab : UserControl
    {
        public static treatmentTab _instance;
        public static treatmentTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new treatmentTab();
                return _instance;
            }
        }
        public treatmentTab()
        {
            InitializeComponent();
        }

        private void treatmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(treatmentComboBox.SelectedItem.ToString() == "Drug")
            {
                panel2.Visible = true;
                panel3.Visible = true;
            }
            else
            {
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }

        private void daycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (daycomboBox.SelectedItem.ToString() == "Other")
            {
                daycomboBox.Visible = false;
                otherTxtBox.Visible = true;
                otherTxtBox.Location = new Point(daycomboBox.Location.X, daycomboBox.Location.Y);
            }
            else
            {

            }
        }

        private void searchDrugBtn_Click(object sender, EventArgs e)
        {
            AllDrugs drug = new AllDrugs();
            drug.Show();
        }

        private void drugCodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server = localhost; user = root; password = ; database = explora_10 ";
                string drug = " select * from drugs_master where drugcode =  '" + drugCodeTxt.Text + "'";
                MySqlCommand com = new MySqlCommand(drug, con);
                MySqlDataAdapter ad;
                try
                {
                    con.Open();
                    ad = new MySqlDataAdapter(com);
                //taking email to the table for searchimg its corresponding messages in sentmail table
                DataTable table = new DataTable();
                ad.Fill(table);
                    if(table.Rows.Count > 0)
                    {
                        drugnameLable.Text = table.Rows[0][1].ToString();
                        ad.Dispose();
                    }
                    else
                    {
                        drugnameLable.Text = "No Drug Selected";
                    }
               
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }
    }
}
