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
using Bunifu.Framework.UI;

namespace Temeke_Dispensary
{
    public partial class doctCheckInTab : UserControl
    {
       
            public static doctCheckInTab _instance;
            public static doctCheckInTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new doctCheckInTab();
                return _instance;
            }
        }
       
            public doctCheckInTab()
        {
            InitializeComponent();
        }
        BunifuFlatButton[] bt;
        public static bool check = false;
        

        private void LoadAssignedPatient()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string loadInf = "select pID,patientName from patient_assign where status = 'Assigned' and doctorAssigned = '" + login.uname+"'";

            MySqlCommand com = new MySqlCommand(loadInf, con);
            MySqlDataReader rd;

            DataTable tab = new DataTable();
            try
            {
                int j = 0;
                con.Open();
                //counting the menu in the table
                rd = com.ExecuteReader();
                tab.Load(rd);
                rd.Close();
                if(tab.Rows.Count > 0)
                {
                   
                    bt = new BunifuFlatButton[tab.Rows.Count];

                    for(int i =0; i<tab.Rows.Count; i++)
                    {
                        //Button

                        bt[j] = new BunifuFlatButton();
                        bt[j].Text = tab.Rows[i][1].ToString();
                        bt[j].Name = tab.Rows[i][0].ToString();
                        bt[j].Height = 41;
                        bt[j].Width = 351;
                        bt[j].Normalcolor = Color.FromArgb(0, 122, 204);
                        bt[j].OnHovercolor = Color.FromArgb(134, 49, 199);
                        bt[j].Activecolor = Color.DarkGreen;
                        bt[j].Iconimage = null;
                        bt[j].TextAlign = ContentAlignment.MiddleCenter;
                        bt[j].Textcolor = Color.White;
                        bt[j].BorderRadius = 5;
                        bt[j].Click += new EventHandler(LoadPatientInfo);

                        string update = "update patient_assign set status = 'ToDoctor' where pID = '" + tab.Rows[i][0].ToString() + "'";
                        MySqlCommand Update = new MySqlCommand(update, con);
                        rd = Update.ExecuteReader();
                        rd.Close();


                        //adding button to the panel
                        flowLayoutPanel1.Controls.Add(bt[j]);

                        j++;
                    }
                         
                    }
                    rd.Close();

              
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //load from laboratory
        private void LoadPatientFromLab()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string loadInf = "select pID,patientName from patient_assign where status = 'FromLab' and doctorAssigned = '" + login.uname + "'";

            MySqlCommand com = new MySqlCommand(loadInf, con);
            MySqlDataReader rd;

            DataTable tab = new DataTable();
            try
            {
                int j = 0;
                con.Open();
                //counting the menu in the table
                rd = com.ExecuteReader();
                tab.Load(rd);
                rd.Close();
                if (tab.Rows.Count > 0)
                {

                    bt = new BunifuFlatButton[tab.Rows.Count];

                    for (int i = 0; i < tab.Rows.Count; i++)
                    {
                        //Button

                        bt[j] = new BunifuFlatButton();
                        bt[j].Text = tab.Rows[i][1].ToString();
                        bt[j].Name = tab.Rows[i][0].ToString();
                        bt[j].Height = 41;
                        bt[j].Width = 351;
                        bt[j].Normalcolor = Color.FromArgb(0, 122, 204);
                        bt[j].OnHovercolor = Color.FromArgb(134, 49, 199);
                        bt[j].Activecolor = Color.DarkGreen;
                        bt[j].Iconimage = null;
                        bt[j].TextAlign = ContentAlignment.MiddleCenter;
                        bt[j].Textcolor = Color.White;
                        bt[j].BorderRadius = 5;
                        bt[j].Click += new EventHandler(LoadPatientIFromLab);

                        string update = "update patient_assign set status = 'Diagnosis' where pID = '" + tab.Rows[i][0].ToString() + "'";
                        MySqlCommand Update = new MySqlCommand(update, con);
                        rd = Update.ExecuteReader();
                        rd.Close();


                        //adding button to the panel
                        flowLayoutPanel2.Controls.Add(bt[j]);

                        j++;

                    }

                }
                rd.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void doctCheckInTab_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public static string patientId = "";
        public static bool chechStatus =  false;

        //function to load patient from reception
        private void LoadPatientInfo(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            patientId = button.Name;
            button.Visible = false;
            //switch to the tab patientTreatmentTab
            doctor.checkPatient = true;
            //showing the patient info
            patientTreatmentTab.checkAbort = true;
        }

        //function to load patient from reception
        private void LoadPatientIFromLab(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            patientId = button.Name;
            button.Visible = false;
            //switch to the tab patientTreatmentTab
            doctor.checkPatient = true;
            //showing the patient info change status to On-Treatment
            patientTreatmentTab.checkAbort = true;
            //showing the diagnosis page
            patientTreatmentTab.diagonisis = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadAssignedPatient();
            LoadPatientFromLab();
        }
    }
}
