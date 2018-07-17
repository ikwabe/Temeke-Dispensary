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

namespace Temeke_Dispensary
{
    public partial class patientTreatmentTab : UserControl
    {
        public static patientTreatmentTab _instance;
        public static patientTreatmentTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new patientTreatmentTab();
                return _instance;
            }
        }
        public patientTreatmentTab()
        {
            InitializeComponent();
        }

        public static string patientname;
        public static string pID;
        public static bool diagonisis = false;
        public static string addres;
        public static string file;
        public static string pymntType;
        public static string schme;
        //a function to load assigned patient info
        private void loadPatInfo()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string getDetails = "select patientName,clinicVisit,paymentType,scheme,fileNo,Gender,Age,address from patient_assign where pID = '" + doctCheckInTab.patientId + "'";
            string updateD = "update patient_assign set status = 'On-Treatment' where pID = '" + doctCheckInTab.patientId + "'";
            MySqlCommand getD = new MySqlCommand(getDetails, con);
            MySqlCommand update = new MySqlCommand(updateD, con);

            MySqlDataReader rd;
            DataTable table = new DataTable();

            try
            {
                con.Open();
                rd = getD.ExecuteReader();
                table.Load(rd);
                rd.Close();
                if(table.Rows.Count > 0)
                {
                    //change the status of the patient
                    rd = update.ExecuteReader();
                    rd.Close();

                    patientName.Text = table.Rows[0][0].ToString();
                    patientname = table.Rows[0][0].ToString();
                    clinicvisit.Text = table.Rows[0][1].ToString();
                    paymentType.Text = table.Rows[0][2].ToString();
                    pymntType = table.Rows[0][2].ToString();
                    scheme.Text = table.Rows[0][3].ToString();
                    schme = table.Rows[0][3].ToString();
                    fileNumber.Text = table.Rows[0][4].ToString();
                    file = table.Rows[0][4].ToString();
                    gender.Text = table.Rows[0][5].ToString();
                    year.Text = table.Rows[0][6].ToString();
                    address.Text = table.Rows[0][7].ToString();
                    addres = table.Rows[0][7].ToString();

                    doctCheckInTab.chechStatus = true;

                }

               

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //a function to abort user from tratment
        private void Abort()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            
            string updateD = "update patient_assign set status = 'Assigned' where pID = '" + doctCheckInTab.patientId + "'";
           
            MySqlCommand update = new MySqlCommand(updateD, con);

            MySqlDataReader rd;
           

            try
            {
                con.Open();
               
               
                    //change the status of the patient
                    rd = update.ExecuteReader();
                    rd.Close();
                    patientName.Text = "";
                    clinicvisit.Text = "";
                    paymentType.Text = "";
                    scheme.Text = "";
                    fileNumber.Text = "";
                    gender.Text = "";
                    year.Text = "";
                    address.Text = "";
                doctCheckInTab.patientId = "";
                doctCheckInTab.chechStatus = true;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void sympAssBtn_Click(object sender, EventArgs e)
        {
            line.Width = sympAssBtn.Width;
            line.Left = sympAssBtn.Left;
            panel3.Controls.Add(sympAssTab.Instance);
            sympAssTab.Instance.Dock = DockStyle.Fill;
            sympAssTab.Instance.BringToFront();
            sympAssTab.Instance.Visible = true;
            docLabTab.Instance.Visible = false;
            diagnosisTab.Instance.Visible = false;
            doctVitalTab.Instance.Visible = false;
            treatmentTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;
        }

        private void labBtn_Click(object sender, EventArgs e)
        {
            line.Width = labBtn.Width;
            line.Left = labBtn.Left;
            panel3.Controls.Add(docLabTab.Instance);
            docLabTab.Instance.Dock = DockStyle.Fill;
            docLabTab.Instance.BringToFront();
            docLabTab.Instance.Visible = true;
            sympAssTab.Instance.Visible = false;
            diagnosisTab.Instance.Visible = false;
            doctVitalTab.Instance.Visible = false;
            treatmentTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;

        }

        private void diagnosisBtn_Click(object sender, EventArgs e)
        {
            line.Width = diagnosisBtn.Width;
            line.Left = diagnosisBtn.Left;
            panel3.Controls.Add(diagnosisTab.Instance);
            diagnosisTab.Instance.Dock = DockStyle.Fill;
            diagnosisTab.Instance.BringToFront();
            diagnosisTab.Instance.Visible = true;
            docLabTab.Instance.Visible = false;
            sympAssTab.Instance.Visible = false;
            doctVitalTab.Instance.Visible = false;
            treatmentTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if(doctCheckInTab.patientId == "")
            {
                MessageBox.Show("No Patient to Examine.");
            }
            else
            {
                StartTreatments();
                panel2.Visible = true;
            }
            

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            docLabTab.Instance.Visible = false;
            sympAssTab.Instance.Visible = false;
            diagnosisTab.Instance.Visible = false;
            doctVitalTab.Instance.Visible = false;
            treatmentTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;
        }

        private void vitalBtn_Click(object sender, EventArgs e)
        {
            line.Width = vitalBtn.Width;
            line.Left = vitalBtn.Left;
            panel3.Controls.Add(doctVitalTab.Instance);
            doctVitalTab.Instance.Dock = DockStyle.Fill;
            doctVitalTab.Instance.BringToFront();
            doctVitalTab.Instance.Visible = true;
            diagnosisTab.Instance.Visible = false;
            docLabTab.Instance.Visible = false;
            sympAssTab.Instance.Visible = false;
            treatmentTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;
        }

        private void treatmentBtn_Click(object sender, EventArgs e)
        {
            line.Width = treatmentBtn.Width;
            line.Left = treatmentBtn.Left;
            panel3.Controls.Add(treatmentTab.Instance);
            treatmentTab.Instance.Dock = DockStyle.Fill;
            treatmentTab.Instance.BringToFront();
            treatmentTab.Instance.Visible = true;
            doctVitalTab.Instance.Visible = false;
            diagnosisTab.Instance.Visible = false;
            docLabTab.Instance.Visible = false;
            sympAssTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            line.Width = finishBtn.Width;
            line.Left = finishBtn.Left;
            panel3.Controls.Add(docFinishTab.Instance);
            docFinishTab.Instance.Dock = DockStyle.Fill;
            docFinishTab.Instance.BringToFront();
            docFinishTab.Instance.Visible = true;
            treatmentTab.Instance.Visible = false;
            doctVitalTab.Instance.Visible = false;
            diagnosisTab.Instance.Visible = false;
            docLabTab.Instance.Visible = false;
            sympAssTab.Instance.Visible = false;
        }
        public static bool checkAbort = false;
        private void patientTreatmentTab_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            diagbosisTimer.Start();
            checkAbort = true;

        }

        private void abortBtn_Click(object sender, EventArgs e)
        {
            Abort();
            panel2.Visible = false;
            docLabTab.Instance.Visible = false;
            sympAssTab.Instance.Visible = false;
            diagnosisTab.Instance.Visible = false;
            doctVitalTab.Instance.Visible = false;
            treatmentTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkAbort == true)
            {
                loadPatInfo();
                checkAbort = false;
            }
        }

        //a function to request a patient
        private void RequestPatient()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            string req = "insert into patients_requests(patient,requestor,location,status) value('" + patientName.Text + "','" + login.uname + "','Room " + room.TheroomNumber + "','New')";

            string checkName = "select * from patients_requests where patient = '" + patientName.Text + "' and requestor = '" + login.uname + "' and location = 'Room " + room.TheroomNumber + "' and status = 'oncall'";
            MySqlCommand request = new MySqlCommand(req, con);
            MySqlCommand requestCheck = new MySqlCommand(checkName, con);
            DataTable table = new DataTable();
            MySqlDataReader rd;
            try
            {
                con.Open();
                //check if patient alread called
                rd = requestCheck.ExecuteReader();
                table.Load(rd);
                rd.Close();

                if(table.Rows.Count > 0)
                {
                    if (MessageBox.Show("The Name is Already On Call. Do you want to Call it Again?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        rd = request.ExecuteReader();
                        rd.Close();
                    }
                    else
                    {

                    }
                   
                }
                else
                {
                    //call the patient
                    rd = request.ExecuteReader();
                    rd.Close();
                }

                
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //a function to start the treatments
        private void StartTreatments()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            string req = "update patients_requests set status = 'inprogress' where location = 'Room "+room.TheroomNumber+"' and patient = '"+patientName.Text+"'";

            MySqlCommand request = new MySqlCommand(req, con);
            MySqlDataReader rd;
            try
            {
                con.Open();
                rd = request.ExecuteReader();
                rd.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
            RequestPatient();
        }

        private void diagbosisTimer_Tick(object sender, EventArgs e)
        {
            if(diagonisis == true)
            {
                panel2.Visible = true;
                line.Width = diagnosisBtn.Width;
                line.Left = diagnosisBtn.Left;
                panel3.Controls.Add(diagnosisTab.Instance);
                diagnosisTab.Instance.Dock = DockStyle.Fill;
                diagnosisTab.Instance.BringToFront();
                diagnosisTab.Instance.Visible = true;
                docLabTab.Instance.Visible = false;
                sympAssTab.Instance.Visible = false;
                doctVitalTab.Instance.Visible = false;
                treatmentTab.Instance.Visible = false;
                docFinishTab.Instance.Visible = false;
                diagonisis = false;
            }
        }
    }
}
