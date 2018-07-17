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
    public partial class chekIn : UserControl
    {
        public static chekIn _instance;
        public static chekIn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new chekIn();
                return _instance;
            }
        }
        public chekIn()
        {
            InitializeComponent();
        }

        private void nameSearchBtn_Click(object sender, EventArgs e)
        {
            patientNames patient = new patientNames();
            patient.ShowDialog();
        }

        //function to populate the names of clinics
        private void ClinicsPop()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string unit = " select Clinicname from Clinics_master ";

            MySqlCommand com = new MySqlCommand(unit, con);

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(unit, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Select");
                com.ExecuteNonQuery();
                Cliniccombo.DisplayMember = "Clinicname";
                Cliniccombo.DataSource = ds.Tables["Select"];
                da.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void chekIn_Load(object sender, EventArgs e)
        {
            
        }

        private void fullNameTxt_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string name = " select * from patients where Fullname =  '" + fullNameTxt.Text + "'";
            
            MySqlCommand com = new MySqlCommand(name, con);
            MySqlDataAdapter ad;
           
            try
            {
                con.Open();
                ad = new MySqlDataAdapter(com);
                //taking email to the table for searchimg its corresponding messages in sentmail table
                DataTable table = new DataTable();
               
                ad.Fill(table);
                if (table.Rows.Count > 0)
                {
                    
                    addressTxt.Text = table.Rows[0][8].ToString();
                    fileNumberTxt.Text = table.Rows[0][1].ToString();
                    fullNameTxt.Text = table.Rows[0][2].ToString();
                    genderTxt.Text = table.Rows[0][3].ToString();
                    birthdayTxt.Text = table.Rows[0][4].ToString();
                    yearText.Text = (int.Parse(DateTime.Now.ToShortDateString().Substring(6)) - int.Parse(table.Rows[0][4].ToString().Substring(6))).ToString();
                    ad.Dispose();

                }
                else
                {
                    formNumerTxt.Text = "";
                    genderTxt.Text = "";
                    birthdayTxt.Text = "";
                    yearText.Text = "";
                    addressTxt.Text = "";
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Schemecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Schemecombo.Text == "Insurance")
            {
                MembershipIdTxt.Visible = true;
            }
            else
            {
                MembershipIdTxt.Visible = false;
            }
        }
       
        private void submitBtn_Click(object sender, EventArgs e)
        {

            if (fileNumberTxt.Text == ""
                || genderTxt.Text == ""
                || Doctorcombo.Text == ""
                || birthdayTxt.Text == "" 
                || yearText.Text == ""
                || Cliniccombo.Text==""
                || Cliniccombo.Text == "---Select---"
                || Schemecombo.Text == ""
                || Schemecombo.Text == "---Select---"
                || Paymentcombo.Text == ""
                || Paymentcombo.Text == "---Select---")
            {
                MessageBox.Show("Please fill the necessary fields");
            }
            else if(MembershipIdTxt.Text == "" && MembershipIdTxt.Visible== true)
            {
                MessageBox.Show("Please fill the MEMBERSHIP ID field");
            }
            else
            {
                sendThePatientToDoctor();
            }
        }

        // a petient has insurance
        private void sendThePatientToDoctor()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            if (Paymentcombo.Text == "Insurance" && Schemecombo.Text == "Insurance")
            {
                string values = "values('" + fullNameTxt.Text +
               "','" + Cliniccombo.Text +
               "','" + Paymentcombo.Text +
               "','" + Schemecombo.Text +
               "','" + fileNumberTxt.Text +
               "','" + genderTxt.Text +
               "','" + yearText.Text +
               "','" + addressTxt.Text +
               "','" + Doctorcombo.Text +
               "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") +
               "','Assigned'" +
               ",'" + tempTxt.Text +
               "','" + pulseTxt.Text +
               "','" + ResporationTxt.Text +
               "','" + oxygenTxt.Text +
               "','" + BPSystolicTxt.Text +
               "','" + BPDiastolicTxt.Text +
               "','" + WeightTxt.Text +
               "','" + HeightTxt.Text +
               "','" + BMITxt.Text + "')";
                string insert = "insert into patient_assign(patientName " +
                    ",clinicVisit" +
                    ",paymentType" +
                    ",scheme" +
                    ",fileNo" +
                    ",Gender" +
                    ",Age" +
                    ",address" +
                    ",doctorAssigned" +
                    ",TimeAssigned" +
                    ",Status" +
                    ",temperature" +
                    ",pulse" +
                    ",respiration" +
                    ",oxygen" +
                    ",BPsystolic" +
                    ",BPDiastolic" +
                    ",weight" +
                    ",height" +
                    ",BMI) " + values;

                MySqlCommand com = new MySqlCommand(insert, con);
                MySqlDataReader rd;
                try
                {
                    con.Open();
                    rd = com.ExecuteReader();
                    rd.Close();
                    fullNameTxt.Text = "";
                    Cliniccombo.Text = "";
                    Paymentcombo.Text = "";
                    Schemecombo.Text = "";
                    fileNumberTxt.Text = "";
                    genderTxt.Text = "";
                    yearText.Text = "";
                    addressTxt.Text = "";
                    Doctorcombo.Text = "";
                    tempTxt.Text = "";
                    pulseTxt.Text = "";
                    ResporationTxt.Text = "";
                    oxygenTxt.Text = "";
                    BPSystolicTxt.Text = "";
                    BPDiastolicTxt.Text = "";
                    WeightTxt.Text = "";
                    HeightTxt.Text = "";
                    BMITxt.Text = "";

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //if the patient has no insurance
           else if (Paymentcombo.Text == "Normal" && Schemecombo.Text == "Normal")
            {
                string values = "values('" + fullNameTxt.Text +
               "','" + Cliniccombo.Text +
               "','" + Paymentcombo.Text +
               "','" + Schemecombo.Text +
               "','" + fileNumberTxt.Text +
               "','" + genderTxt.Text +
               "','" + yearText.Text +
               "','" + addressTxt.Text +
               "','" + Doctorcombo.Text +
               "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") +
               "','Cashier' " +
               ",'" + tempTxt.Text +
               "','" + pulseTxt.Text +
               "','" + ResporationTxt.Text +
               "','" + oxygenTxt.Text +
               "','" + BPSystolicTxt.Text +
               "','" + BPDiastolicTxt.Text +
               "','" + WeightTxt.Text +
               "','" + HeightTxt.Text +
               "','" + BMITxt.Text + "')";
                string insert = "insert into patient_assign(patientName " +
                    ",clinicVisit" +
                    ",paymentType" +
                    ",scheme" +
                    ",fileNo" +
                    ",Gender" +
                    ",Age" +
                    ",address" +
                    ",doctorAssigned" +
                    ",TimeAssigned" +
                    ",Status" +
                    ",temperature" +
                    ",pulse" +
                    ",respiration" +
                    ",oxygen" +
                    ",BPsystolic" +
                    ",BPDiastolic" +
                    ",weight" +
                    ",height" +
                    ",BMI) " + values;

                MySqlCommand com = new MySqlCommand(insert, con);
                MySqlDataReader rd;
                try
                {
                    con.Open();
                    rd = com.ExecuteReader();
                    rd.Close();
                    fullNameTxt.Text = "";
                    Cliniccombo.Text = "";
                    Paymentcombo.Text = "";
                    Schemecombo.Text = "";
                    fileNumberTxt.Text = "";
                    genderTxt.Text = "";
                    yearText.Text = "";
                    addressTxt.Text = "";
                    Doctorcombo.Text = "";
                    tempTxt.Text = "";
                    pulseTxt.Text = "";
                    ResporationTxt.Text = "";
                    oxygenTxt.Text = "";
                    BPSystolicTxt.Text = "";
                    BPDiastolicTxt.Text = "";
                    WeightTxt.Text = "";
                    HeightTxt.Text = "";
                    BMITxt.Text = "";

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select the appropriet payment type and scheme");
            }
        }
    }
}
