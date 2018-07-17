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
    public partial class diagnosisTab : UserControl
    {
        public static diagnosisTab _instance;
        public static diagnosisTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new diagnosisTab();
                return _instance;
            }
        }
        public diagnosisTab()
        {
            InitializeComponent();
        }

        private void LoadTestResult()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string select = "select date Date,LabTest 'Lab Test',LabResult 'Lab Result',comment Comment from laboratorytestrecords where status = 'Tested' and doctorName = '"+login.uname +"' and pID = '"+ doctCheckInTab.patientId +"' ";

            MySqlDataReader rd;

            DataTable table = new DataTable();
            MySqlCommand com = new MySqlCommand(select, con);
            try
            {
                con.Open();

                rd = com.ExecuteReader();
                table.Load(rd);
                rd.Close();

                labResultList.DataSource = table;

                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        string update = "update laboratorytestrecords set status = 'Diagnosis' where Id = '" + table.Rows[i][0].ToString() + "'";
                        MySqlCommand com1 = new MySqlCommand(update, con);

                        rd = com1.ExecuteReader();
                        rd.Close();
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public static bool diaLoad = false;
        private void diagnosisTab_Load(object sender, EventArgs e)
        {
            timer1.Start();
            diaLoad = true;
            LoadTestResult();
           
        }

        private void moreDiagnosBtn_Click(object sender, EventArgs e)
        {
            AllDiagnosis dia = new AllDiagnosis();
            dia.ShowDialog();
        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var checkText = sender as CheckBox;

            if(checkText.Checked == true)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = login.DBconnection;

                string insert = "insert into diagnosisrecords(date,pID,diagnosis,doctorName,status) values('"
                    + DateTime.Now.ToString("yyyy-MM-dd") + "','"
                    + doctCheckInTab.patientId + "','" + checkText.Text + "','" + login.uname + "','New')";

                MySqlDataReader rd;
                MySqlCommand com = new MySqlCommand(insert, con);
                try
                {
                    con.Open();

                    rd = com.ExecuteReader();
                    rd.Close();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }
            else if(checkText.Checked == false)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = login.DBconnection;

                string remove = "delete from diagnosisrecords  where pID = '" + doctCheckInTab.patientId + "' and  diagnosis = '" + checkText.Text+ "' and doctorName = '" + login.uname + "' and status = 'New' ";

                MySqlDataReader rd;
                MySqlCommand com = new MySqlCommand(remove, con);
                try
                {
                    con.Open();

                    rd = com.ExecuteReader();
                    rd.Close();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }
            else
            {
               
            }
        }
        public static bool newDia = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(diaLoad == true)
            {
                patientName.Text = patientTreatmentTab.patientname;
                fileNumber.Text = patientTreatmentTab.file;
                address.Text = patientTreatmentTab.addres;
                LoadLastDiagnosis();
                diaLoad = false;
            }

            if(newDia == true)
            {
                //add the diagnosis checkbox to the panel
                CheckBox checkB = new CheckBox();
                checkB.ForeColor = Color.Silver;
                checkB.Text = AllDiagnosis.diagnosis;
                checkB.Font = new Font("Cambria", 14);
                checkB.Checked = true;
                checkB.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
                flowLayoutPanel1.Controls.Add(checkB);
                newDia = false;
            }
        }
        
        //a function to load the diagnosis to the datagridvie
        private void LoadDiagnosis()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string checkDio = "select date Date,diagnosis 'Diagnosis with',doctorcomment 'Doctor Comment'  from diagnosisrecords where pID = '" + doctCheckInTab.patientId + "' and doctorName = '" + login.uname + "' and status = 'NewDia'";
            string takeId = "select Id  from diagnosisrecords where pID = '" + doctCheckInTab.patientId + "' and doctorName = '" + login.uname + "' and status = 'NewDia'";

            MySqlDataReader rd;
            DataTable table = new DataTable();
            MySqlCommand com = new MySqlCommand(checkDio, con);

            DataTable table1 = new DataTable();
            MySqlCommand com2 = new MySqlCommand(takeId, con);
            try
            {
                con.Open();
                //check if the diagnosis are present
                rd = com.ExecuteReader();
                table.Load(rd);
                rd.Close();

                //take the Ids
                rd = com2.ExecuteReader();
                table1.Load(rd);
                rd.Close();

                if (table.Rows.Count > 0)
                {
                    NewdiagDataGridview.DataSource = table;
                    //cahnge status to Last
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {
                        string update = "update diagnosisrecords set status = 'Last' where Id = '" + table1.Rows[i][0].ToString() + "'";
                        MySqlCommand com1 = new MySqlCommand(update, con);
                        rd = com1.ExecuteReader();
                        rd.Close();

                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();


        }

        //a function to load the Last diagnosis to the datagridview
        private void LoadLastDiagnosis()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string checkDio = "select date Date,diagnosis 'Diagnosis with',doctorcomment 'Doctor Comment'  from diagnosisrecords where pID = '" + doctCheckInTab.patientId + "' and status = 'Last'";
            string takeId = "select Id  from diagnosisrecords where pID = '" + doctCheckInTab.patientId + "' and status = 'Last'";

            MySqlDataReader rd;
            DataTable table = new DataTable();
            MySqlCommand com = new MySqlCommand(checkDio, con);

            DataTable table1 = new DataTable();
            MySqlCommand com2 = new MySqlCommand(takeId, con);
            try
            {
                con.Open();
                //check if the diagnosis are present
                rd = com.ExecuteReader();
                table.Load(rd);
                rd.Close();

                //take the Ids
                rd = com2.ExecuteReader();
                table1.Load(rd);
                rd.Close();

                if (table.Rows.Count > 0)
                {
                    PreviousdiagDataGridview.DataSource = table;
                    //cahnge status to Last
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {
                        string update = "update diagnosisrecords set status = 'Old' where Id = '" + table1.Rows[i][0].ToString() + "'";
                        MySqlCommand com1 = new MySqlCommand(update, con);
                        rd = com1.ExecuteReader();
                        rd.Close();

                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();


        }
        //upload the diagnosis to the database
        private void postDiagnssBtn_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            string checkDio = "select Id  from diagnosisrecords where pID = '"+doctCheckInTab.patientId+"' and doctorName = '"+login.uname+"' and status = 'New'";

            MySqlDataReader rd;
            DataTable table = new DataTable();
            MySqlCommand com = new MySqlCommand(checkDio, con);
            try
            {
                con.Open();
                //check if the diagnosis are present
                rd = com.ExecuteReader();
                table.Load(rd);
                rd.Close();

                if(table.Rows.Count > 0)
                {
                    
                    //cahnge status to Last
                    for(int i =0; i< table.Rows.Count; i++)
                    {
                        string update = "update diagnosisrecords set status = 'NewDia' where Id = '" + table.Rows[i][0].ToString() + "'";
                        MySqlCommand com1 = new MySqlCommand(update, con);
                        rd = com1.ExecuteReader();
                        rd.Close();

                    }

                    //uncheck the checkboxes
                    foreach (CheckBox c in flowLayoutPanel1.Controls)
                    {

                        c.Checked = false;
                    }
                    LoadDiagnosis();
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
