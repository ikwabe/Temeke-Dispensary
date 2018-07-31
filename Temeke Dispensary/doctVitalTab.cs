using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Temeke_Dispensary
{
    public partial class doctVitalTab : UserControl
    {
        public static doctVitalTab _instance;
        public static doctVitalTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new doctVitalTab();
                return _instance;
            }
        }
        public doctVitalTab()
        {
            InitializeComponent();
        }

        private void editVitalBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //panel1.Width = 407;
        }

        private void LoadVitals()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            MySqlDataAdapter da;
           
            string loadData = "select temperature,pulse,respiration,oxygen,BPsystolic,BPDiastolic,weight,height,BMI from patient_assign where doctorAssigned = '" + login.uname + "' and pID = '" + doctCheckInTab.patientId + "' and status = 'On-Treatment'";

            MySqlCommand com = new MySqlCommand(loadData, con);
            DataTable table = new DataTable();
            try
            {
                con.Open();

                da = new MySqlDataAdapter(com);
                da.Fill(table);
                da.Dispose();

                vitalDataGridView.DataSource = table;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void addVitalBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            MySqlDataReader rd;

            string updateAll = "update patient_assign set temperature = '" + temTxt.Text + 
                "', pulse = '"+pulseTxt+
                "', repiration = '"+respTxt.Text+
                "',oxygen = '"+oxygenTxt.Text+
                "',BPSystolic = '"+bpsTxt.Text+
                "',BPDiastolic = '"+bpdTxt.Text+
                "',weight = '"+weightTxt.Text+
                "', height= '"+heightTxt.Text+
                "',BMI = '"+bmiTxt.Text+"'";

            string updateTemp = "update  patient_assign set temperature = '" + temTxt.Text +
                "'";
            string updatePulse = "update  patient_assign set pulse = '" + pulseTxt +
                "'";
            string updateResp = "update patient_assign set repiration = '" + respTxt.Text +
                "'";
            string updateOxy = "update  patient_assign set oxygen = '" + oxygenTxt.Text +
                "'";
            string updateBps = "update  patient_assign set BPSystolic = '" + bpsTxt.Text +
                "'";
            string updateBpd = "update  patient_assign set BPDiastolic = '" + bpdTxt.Text +
                "'";
            string updateWeigh = "update patient_assign set weight = '" + weightTxt.Text +
                "'";
            string updateHeigh = "update patient_assign set height= '" + heightTxt.Text +
                "'"; 
            string updateBmi = "update patient_assign set BMI = '" + bmiTxt.Text + "'";

            MySqlCommand comAll = new MySqlCommand(updateAll, con);
            MySqlCommand comTemp = new MySqlCommand(updateTemp, con);
            MySqlCommand comPuls = new MySqlCommand(updatePulse, con);
            MySqlCommand comResp = new MySqlCommand(updateResp, con);
            MySqlCommand comOxy = new MySqlCommand(updateOxy, con);
            MySqlCommand comBps = new MySqlCommand(updateBps, con);
            MySqlCommand comBpd = new MySqlCommand(updateBpd, con);
            MySqlCommand comWeigh = new MySqlCommand(updateWeigh, con);
            MySqlCommand comHeight = new MySqlCommand(updateHeigh, con);
            MySqlCommand comBMI = new MySqlCommand(updateBmi, con);

            try
            {
                con.Open();
                //input temp update only
                if(temTxt.Text != "" 
                    && pulseTxt.Text == ""
                    && oxygenTxt.Text == "" 
                    && bpsTxt.Text == "" 
                    && bpdTxt.Text == ""
                    && weightTxt.Text == ""
                    && heightTxt.Text == ""
                    && bmiTxt.Text == ""
                    )
                {
                    rd = comTemp.ExecuteReader();
                    rd.Close();
                   
                    LoadVitals();

                }

                //input pulse update only
               else if (temTxt.Text == ""
                    && pulseTxt.Text != ""
                    && oxygenTxt.Text == ""
                    && bpsTxt.Text == ""
                    && bpdTxt.Text == ""
                    && weightTxt.Text == ""
                    && heightTxt.Text == ""
                    && bmiTxt.Text == ""
                    )
                {
                    rd = comPuls.ExecuteReader();
                    rd.Close();
                    
                    LoadVitals();
                }

                //input oxygen update only
                else if (temTxt.Text == ""
                    && pulseTxt.Text == ""
                    && oxygenTxt.Text != ""
                    && bpsTxt.Text == ""
                    && bpdTxt.Text == ""
                    && weightTxt.Text == ""
                    && heightTxt.Text == ""
                    && bmiTxt.Text == ""
                    )
                {
                    rd = comOxy.ExecuteReader();
                    rd.Close();
                   
                    LoadVitals();
                }

                //input bps update only
                else if (temTxt.Text == ""
                    && pulseTxt.Text == ""
                    && oxygenTxt.Text == ""
                    && bpsTxt.Text != ""
                    && bpdTxt.Text == ""
                    && weightTxt.Text == ""
                    && heightTxt.Text == ""
                    && bmiTxt.Text == ""
                    )
                {
                    rd = comBps.ExecuteReader();
                    rd.Close();
                    
                    LoadVitals();
                }

                //input bpd update only
               else if (temTxt.Text == ""
                    && pulseTxt.Text == ""
                    && oxygenTxt.Text == ""
                    && bpsTxt.Text == ""
                    && bpdTxt.Text != ""
                    && weightTxt.Text == ""
                    && heightTxt.Text == ""
                    && bmiTxt.Text == ""
                    )
                {
                    rd = comBpd.ExecuteReader();
                    rd.Close();
                   
                    LoadVitals();
                }

                //input weight update only
              else  if (temTxt.Text == ""
                    && pulseTxt.Text == ""
                    && oxygenTxt.Text == ""
                    && bpsTxt.Text == ""
                    && bpdTxt.Text == ""
                    && weightTxt.Text != ""
                    && heightTxt.Text == ""
                    && bmiTxt.Text == ""
                    )
                {
                    rd = comWeigh.ExecuteReader();
                    rd.Close();
                    
                    LoadVitals();
                }

                //input height update only
               else if (temTxt.Text == ""
                    && pulseTxt.Text == ""
                    && oxygenTxt.Text == ""
                    && bpsTxt.Text == ""
                    && bpdTxt.Text == ""
                    && weightTxt.Text == ""
                    && heightTxt.Text != ""
                    && bmiTxt.Text == ""
                    )
                {
                    rd = comHeight.ExecuteReader();
                    rd.Close();
                   
                    LoadVitals();
                }

                //input bmi update only
             else  if (temTxt.Text == ""
                    && pulseTxt.Text == ""
                    && oxygenTxt.Text == ""
                    && bpsTxt.Text == ""
                    && bpdTxt.Text == ""
                    && weightTxt.Text == ""
                    && heightTxt.Text == ""
                    && bmiTxt.Text != ""
                    )
                {
                    rd = comBMI.ExecuteReader();
                    rd.Close();
                    
                    LoadVitals();

                }
                else
                {
                    rd = comAll.ExecuteReader();
                    rd.Close();
                    
                    LoadVitals();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void doctVitalTab_Load(object sender, EventArgs e)
        {
            LoadVitals();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            //panel1.Width = 0;
        }
    }
}
