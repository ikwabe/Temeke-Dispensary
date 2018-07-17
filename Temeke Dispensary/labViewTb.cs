using System;
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
    public partial class labViewTb : UserControl
    {
       
            public static labViewTb _instance;
            public static labViewTb Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new labViewTb();
                    return _instance;
                }
            }

            public labViewTb()
            {
                InitializeComponent();
            }

        BunifuFlatButton[] bt;
        public static string doctorName = "";
        private void LoadAssignedPatient()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string loadInf = "select pID,patientName from patient_assign where status = 'ToLab'";

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
                        bt[j].Click += new EventHandler(LoadPatientInfo);

                        string update = "update patient_assign set status = 'InLab' where pID = '" + tab.Rows[i][0].ToString() + "'";
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

        public static string patientId = "";
        private void LoadPatientInfo(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            patientId = button.Name;
            button.Visible = false;
            laboratory.checkPatient = true;
            measurementTab.checkInfo = true;
        }

        private void labViewTb_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //loading the requested Patient Details
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadAssignedPatient();
        }
    }
    }

