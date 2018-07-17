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
    public partial class measurementTab : UserControl
    {
        public static measurementTab _instance;
        public static measurementTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new measurementTab();
                return _instance;
            }
        }
        public measurementTab()
        {
            InitializeComponent();
        }

        public static string patientname;
        public static bool checkInfo = false;
        string doctorName;
        //function to load the info

        private void RequestPatient()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            string req = "insert into patients_requests(patient,requestor,location,status) value('" + patientName.Text + "','" + login.uname + "','Laboratory','New')";

            string checkName = "select * from patients_requests where patient = '" + patientName.Text + "' and requestor = '" + login.uname + "' and location = 'Laboratory' and status = 'oncall'";
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

                if (table.Rows.Count > 0)
                {
                    if (MessageBox.Show("The Name is Already On Call. Do you want to Call it Again?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        rd = request.ExecuteReader();
                        rd.Close();
                        panel2.Visible = true;
                        
                    }
                    else
                    {
                        panel2.Visible = true;
                       
                    }

                }
                else
                {
                    //call the patient
                    rd = request.ExecuteReader();
                    rd.Close();
                    panel2.Visible = true;
                    
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadPatInfo()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string getDetails = "select patientName,clinicVisit,paymentType,scheme,fileNo,Gender,Age,address,doctorAssigned from patient_assign where pID = '" + labViewTb.patientId + "'";
            string updateD = "update patient_assign set status = 'InTest' where pID = '" + labViewTb.patientId + "'";
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
                if (table.Rows.Count > 0)
                {
                    //change the status of the patient
                    rd = update.ExecuteReader();
                    rd.Close();

                    patientName.Text = table.Rows[0][0].ToString();
                    patientname = table.Rows[0][0].ToString();
                    doctorName = table.Rows[0][8].ToString();
                    clinicvisit.Text = table.Rows[0][1].ToString();
                    paymentType.Text = table.Rows[0][2].ToString();
                    scheme.Text = table.Rows[0][3].ToString();
                    fileNumber.Text = table.Rows[0][4].ToString();
                    gender.Text = table.Rows[0][5].ToString();
                    year.Text = table.Rows[0][6].ToString();
                    address.Text = table.Rows[0][7].ToString();

                }



            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        FlowLayoutPanel flpanel1;
        FlowLayoutPanel flpanel2;
        FlowLayoutPanel flpanel3;
        FlowLayoutPanel flpanel4;
        FlowLayoutPanel flpanel5;
        FlowLayoutPanel flpanel6;
        Label lb1;
        Label lb2;
        Label lb3;
        Label lb4;
        Label lb5;
        BunifuImageButton bt;


        private void InsertTests()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            string insert = "insert into laboratorytestrecords(" +
                "date," +
                "LabTest," +
                "LabResult," +
                "comment," +
                "sample," +
                "pID," +
                "doctorName," +
                "status)" +

                "values('" +
                DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" +
                LabTestCategory.Text + "','" +
                resultTxt.Text + "','" +
               commentTxt.Text + "','" +
               unitComb.Text + "','" +
              labViewTb.patientId + "','" +
              doctorName + "','New')";

            MySqlDataReader rd;
            MySqlCommand com = new MySqlCommand(insert, con);
            try
            {
                con.Open();
                rd = com.ExecuteReader();
                LabTestCategory.Text = "";
                resultTxt.Text = "";
                commentTxt.Text = "";
                unitComb.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        private void addMeasurements()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string select = "select Id,date,LabTest,LabResult,comment,sample from laboratorytestrecords where status = 'New' ";

            MySqlDataReader rd;
            DataTable table = new DataTable();
            MySqlCommand com = new MySqlCommand(select, con);
            try
            {
                con.Open();

                rd = com.ExecuteReader();
                table.Load(rd);
                rd.Close();

                if(table.Rows.Count > 0)
                {
                    for(int i = 0; i< table.Rows.Count; i++)
                    {

                        //date panel
                        flpanel1 = new FlowLayoutPanel();
                        flpanel1.FlowDirection = FlowDirection.TopDown;
                        flpanel1.Height = 25;
                        flpanel1.BorderStyle = BorderStyle.FixedSingle;

                        flpanel1.WrapContents = false;

                        lb1 = new Label();
                        lb1.ForeColor = Color.White;
                        lb1.Font = new Font("Cambria", 10, FontStyle.Bold);
                        lb1.AutoSize = true;
                        lb1.Text = table.Rows[i][1].ToString();
                        flpanel1.Controls.Add(lb1);
                        flowLayoutPanel1.Controls.Add(flpanel1);

                        //Lab test panel
                        flpanel2 = new FlowLayoutPanel();
                        flpanel2.FlowDirection = FlowDirection.TopDown;
                        flpanel2.Height = 25;
                        flpanel2.Width = 400;

                        flpanel2.BorderStyle = BorderStyle.FixedSingle;

                        flpanel2.WrapContents = false;

                        lb2 = new Label();
                        lb2.ForeColor = Color.White;
                        lb2.Font = new Font("Cambria", 10, FontStyle.Bold);
                        lb2.AutoSize = true;
                        lb2.Text = table.Rows[i][2].ToString();
                        flpanel2.Controls.Add(lb2);
                        flowLayoutPanel2.Controls.Add(flpanel2);

                        //Lab result panel
                        flpanel3 = new FlowLayoutPanel();
                        flpanel3.FlowDirection = FlowDirection.TopDown;
                        flpanel3.Height = 25;
                        flpanel3.Width = 400;
                        flpanel3.BorderStyle = BorderStyle.FixedSingle;

                        flpanel3.WrapContents = false;

                        lb3 = new Label();
                        lb3.ForeColor = Color.White;
                        lb3.Font = new Font("Cambria", 10, FontStyle.Bold);
                        lb3.AutoSize = true;
                        lb3.Text = table.Rows[i][3].ToString();
                        flpanel3.Controls.Add(lb3);
                        flowLayoutPanel3.Controls.Add(flpanel3);

                        //Lab Comment panel
                        flpanel4 = new FlowLayoutPanel();
                        flpanel4.FlowDirection = FlowDirection.TopDown;
                        flpanel4.Height = 25;
                        flpanel4.Width = 400;
                        flpanel4.BorderStyle = BorderStyle.FixedSingle;

                        flpanel4.WrapContents = false;

                        lb4 = new Label();
                        lb4.ForeColor = Color.White;
                        lb4.Font = new Font("Cambria", 10, FontStyle.Bold);
                        lb4.AutoSize = true;
                        lb4.Text = table.Rows[i][4].ToString();
                        flpanel4.Controls.Add(lb4);
                        flowLayoutPanel4.Controls.Add(flpanel4);

                        //Lab Sample panel
                        flpanel5 = new FlowLayoutPanel();
                        flpanel5.FlowDirection = FlowDirection.TopDown;
                        flpanel5.Height = 25;
                        flpanel5.Width = 400;
                        flpanel5.BorderStyle = BorderStyle.FixedSingle;

                        flpanel5.WrapContents = false;

                        lb5 = new Label();
                        lb5.ForeColor = Color.White;
                        lb5.Font = new Font("Cambria", 10, FontStyle.Bold);
                        lb5.AutoSize = true;
                        lb5.Text = table.Rows[i][5].ToString();
                        flpanel5.Controls.Add(lb5);
                        flowLayoutPanel5.Controls.Add(flpanel5);

                        //Lab Cancel panel
                        flpanel6 = new FlowLayoutPanel();
                        flpanel6.FlowDirection = FlowDirection.TopDown;
                        flpanel6.Height = 25;
                        flpanel6.Width = 400;
                        flpanel6.BorderStyle = BorderStyle.FixedSingle;

                        flpanel6.WrapContents = false;

                        //the button to remove the test
                        bt = new BunifuImageButton();
                        bt.Height = 20;
                        bt.Name = table.Rows[i][0].ToString();
                        bt.Width = 20;
                        bt.Cursor = Cursors.Hand;
                        bt.BackColor = Color.Transparent;
                        bt.Image = Properties.Resources.delete;
                        bt.Click += new EventHandler(RemoveTest);
                        flpanel6.Controls.Add(bt);
                        flowLayoutPanel6.Controls.Add(flpanel6);
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void measurementTab_Load(object sender, EventArgs e)
        {
            timer1.Start();
            checkInfo = true;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string unit = " select unit from laboratory_units ";

            MySqlCommand com = new MySqlCommand(unit, con);
            DataTable table = new DataTable();

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(unit, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Select");
                com.ExecuteNonQuery();
                unitComb.DisplayMember = "unit";
                unitComb.DataSource = ds.Tables["Select"];
                da.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //a function to populate the test required for a user
        private void getTest()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string test = " select test from lab_test where pID = '" + labViewTb.patientId + "' and status = 'Approved'";

            MySqlCommand com = new MySqlCommand(test, con);
            DataTable table = new DataTable();

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds, "Select");
                com.ExecuteNonQuery();
                LabTestCategory.DisplayMember = "Test";
                LabTestCategory.DataSource = ds.Tables["Select"];
                da.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkInfo == true)
            {
                loadPatInfo();
                getTest();
                checkInfo = false;
            }
        }

        private void ClearThePanels()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            flowLayoutPanel4.Controls.Clear();
            flowLayoutPanel5.Controls.Clear();
            flowLayoutPanel6.Controls.Clear();
        }
        private void labAddBtn_Click(object sender, EventArgs e)
        {
            InsertTests();
            LabTestTimer.Start();
        }

        private void RemoveTest(object sender, EventArgs e)
        {
            var button = sender as BunifuImageButton;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            string delete = "delete from laboratorytestrecords where Id = '" + button.Name.ToString() + "'";
            MySqlDataReader rd;
            MySqlCommand com = new MySqlCommand(delete, con);
            try
            {
                con.Open();
                rd = com.ExecuteReader();
                LabTestTimer.Start();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }

        private void LabTestTimer_Tick(object sender, EventArgs e)
        {
            LabTestTimer.Stop();
            ClearThePanels();
            addMeasurements();
        }

        //function for requesting the patients
        private void requestBtn_Click(object sender, EventArgs e)
        {
            
            if(patientName.Text == "")
            {
                MessageBox.Show("No Patient for request, please select patient from Request(s).");
            }
            else
            {

                RequestPatient();
            }
            
        }

        //a funtion to send the details to doctor
        private void SendLabTestToDoctor()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string select = "select Id,date,LabTest,LabResult,comment,sample from laboratorytestrecords where status = 'New' ";

            MySqlDataReader rd;
            DataTable table = new DataTable();
            MySqlCommand com = new MySqlCommand(select, con);
            try
            {
                con.Open();

                rd = com.ExecuteReader();
                table.Load(rd);
                rd.Close();

                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        string update = "update laboratorytestrecords set status = 'Tested' where Id = '" + table.Rows[i][0].ToString() + "'";
                        MySqlCommand com1 = new MySqlCommand(update, con);

                        rd = com1.ExecuteReader();
                        rd.Close();   
                    }

                    string updat = "update patient_assign set status = 'FromLab' where pID = '" + labViewTb.patientId + "'";
                    MySqlCommand Update = new MySqlCommand(updat, con);
                    rd = Update.ExecuteReader();
                    rd.Close();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void finishBtn_Click(object sender, EventArgs e)
        {
            SendLabTestToDoctor();
            LabTestTimer.Start();
            panel2.Visible = false;
            patientName.Text = "";
            clinicvisit.Text = "";
            paymentType.Text = "";
            scheme.Text = "";
            fileNumber.Text = "";
            gender.Text = "";
            year.Text = "";
            address.Text = "";


        } 
    }
}
