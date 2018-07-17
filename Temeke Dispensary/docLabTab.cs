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
    public partial class docLabTab : UserControl
    {
        public static docLabTab _instance;
        public static docLabTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new docLabTab();
                return _instance;
            }
        }
        public docLabTab()
        {
            InitializeComponent();
        }
        Label link;
        BunifuImageButton remBtn;
        FlowLayoutPanel flPanel;
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            testPanel.Visible = true;
            btnTestPanel.Visible = true;
            cancelBtn.Visible = true;
            notePanel.Visible = true;
            confiLabTxt.AppendText(instrctnTxt.Text);

            instrctnTxt.Text = "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            testPanel.Visible = false;
            btnTestPanel.Visible = false;
            cancelBtn.Visible = false;
            notePanel.Visible = false;
            confiLabTxt.Text = "";


        }

        //the function to display the added tests
        private void ViewAddedTest()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string addToGrid = "select * from lab_temp where doctorName = '" + login.uname + "'";
            MySqlDataAdapter rd;
            DataTable table = new DataTable();
            MySqlCommand com = new MySqlCommand(addToGrid, con);
            try
            {
                con.Open();

                //add data to the flowlayoutpanel
                rd = new MySqlDataAdapter(com);
                rd.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //a panel to add the link and the remove button
                    flPanel = new FlowLayoutPanel();
                    flPanel.FlowDirection = FlowDirection.LeftToRight;
                    flPanel.WrapContents = false;
                    flPanel.AutoSize = true;
                    flPanel.Height = 30;

                    //a link to hold the name of the test
                    link = new Label();
                    link.Font = new Font("Cambria", 12);
                    link.AutoSize = true;
                    link.ForeColor = Color.Silver;
                    link.Text = table.Rows[i][1].ToString();

                    //the button to remove the test
                    remBtn = new BunifuImageButton();
                    remBtn.Height = 25;
                    remBtn.Width = 25;
                    remBtn.Name = table.Rows[i][0].ToString();
                    remBtn.Cursor = Cursors.Hand;
                    remBtn.BackColor = Color.Transparent;
                    remBtn.Image = Properties.Resources.delete2;
                    remBtn.Click += new EventHandler(RemoveTest);



                    //adding the button and link to the flp panel
                    flPanel.Controls.Add(link);
                    flPanel.Controls.Add(remBtn);

                    //adding the flpanel to the main panel
                    flowLayoutPanel1.Controls.Add(flPanel);
                    
                }

                
                rd.Dispose();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private static int TestCost1;
        private static int TestCost2;
        private static int TestCost3;
        private static int TestCost4;
        private static int TestCost5;
        public void checkBx()
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            MySqlDataReader rd;
           
            try
            {
                con.Open();

                if (checkBox1.Checked == true)
                {
                   
                    string selectCost = "select proposedprice from laboratory_tests_master where name = '" + checkBox1.Text + "'";
                    //taking the price of the test
                    DataTable table1 = new DataTable();
                    MySqlCommand cost = new MySqlCommand(selectCost, con);
                    rd = cost.ExecuteReader();
                    table1.Load(rd);
                    rd.Close();

                    if (table1.Rows.Count > 0)
                    {
                        TestCost1 = int.Parse(table1.Rows[0][0].ToString());
                        string check1 = " insert into lab_temp(Test,doctorName,pID,date,cost,status) values('" + checkBox1.Text + "','" + login.uname + "','" + doctCheckInTab.patientId + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'," + TestCost1 + ",'New') ";
                        MySqlCommand com1 = new MySqlCommand(check1, con);
                        rd = com1.ExecuteReader();
                        rd.Close();
                    }
                }

                if (checkBox2.Checked == true)
                {
                    string selectCost = "select proposedprice from laboratory_tests_master where name = '" + checkBox2.Text + "'";
                    //taking the price of the test
                    DataTable table2 = new DataTable();
                    MySqlCommand cost = new MySqlCommand(selectCost, con);
                    rd = cost.ExecuteReader();
                    table2.Load(rd);
                    rd.Close();

                    if (table2.Rows.Count > 0)
                    {
                        TestCost2 = int.Parse(table2.Rows[0][0].ToString());
                        string check2 = " insert into lab_temp(Test,doctorName,pID,date,cost,status) values('" + checkBox2.Text + "','" + login.uname + "','" + doctCheckInTab.patientId + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'," + TestCost2 + ",'New') ";
                        MySqlCommand com2 = new MySqlCommand(check2, con);
                        rd = com2.ExecuteReader();
                        rd.Close();
                    }
                }

                if (checkBox3.Checked == true)
                {
                    string selectCost = "select proposedprice from laboratory_tests_master where name = '" + checkBox3.Text + "'";
                    //taking the price of the test
                    DataTable table3 = new DataTable();
                    MySqlCommand cost = new MySqlCommand(selectCost, con);
                    rd = cost.ExecuteReader();
                    table3.Load(rd);
                    rd.Close();

                    if (table3.Rows.Count > 0)
                    {
                        TestCost3 = int.Parse(table3.Rows[0][0].ToString());
                        string check3 = " insert into lab_temp(Test,doctorName,pID,date,cost,status) values('" + checkBox3.Text + "','" + login.uname + "','" + doctCheckInTab.patientId + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'," + TestCost3 + ",'New') ";
                        
                        MySqlCommand com3 = new MySqlCommand(check3, con);
                       
                        rd = com3.ExecuteReader();
                        rd.Close();
                    }

                }

                if (checkBox4.Checked == true)
                {
                    string selectCost = "select proposedprice from laboratory_tests_master where name = '" + checkBox4.Text + "'";
                    //taking the price of the test
                    DataTable table4 = new DataTable();
                    MySqlCommand cost = new MySqlCommand(selectCost, con);
                    rd = cost.ExecuteReader();
                    table4.Load(rd);
                    rd.Close();

                    if (table4.Rows.Count > 0)
                    {
                        TestCost4 = int.Parse(table4.Rows[0][0].ToString());
                        string check4 = " insert into lab_temp(Test,doctorName,pID,date,cost,status) values('" + checkBox4.Text + "','" + login.uname + "','" + doctCheckInTab.patientId + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'," + TestCost4 + ",'New') ";
                        
                        MySqlCommand com4 = new MySqlCommand(check4, con);
                       
                        rd = com4.ExecuteReader();
                        rd.Close();
                    }
                }

                if (checkBox5.Checked == true)
                {
                    string selectCost = "select proposedprice from laboratory_tests_master where name = '" + checkBox5.Text + "'";
                    //taking the price of the test
                    DataTable table5 = new DataTable();
                    MySqlCommand cost = new MySqlCommand(selectCost, con);
                    rd = cost.ExecuteReader();
                    table5.Load(rd);
                    rd.Close();
                    if(table5.Rows.Count > 0)
                    {
                        TestCost5 = int.Parse(table5.Rows[0][0].ToString());
                        string check5 = " insert into lab_temp(Test,doctorName,pID,date,cost,status) values('" + checkBox5.Text + "','" + login.uname + "','" + doctCheckInTab.patientId + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'," + TestCost5 + ",'New') ";
                        MySqlCommand com5 = new MySqlCommand(check5, con);
                        rd = com5.ExecuteReader();
                        rd.Close();
                    }
                    
                }

                LoadTestTimer.Start();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        bool empty;
        //a function to delete the details from lab_temp when sending the information to Lab
        private void ClearTests()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string test = "select * from lab_temp where doctorName = '" + login.uname + "'";
            string moveTable = "insert into lab_test(select * from lab_temp where doctorName = '" + login.uname + "' )";
            MySqlDataReader rd;

            MySqlDataAdapter ad;
            MySqlCommand com = new MySqlCommand(test, con);
            MySqlCommand move = new MySqlCommand(moveTable, con);
            DataTable table = new DataTable();
            try
            {
                con.Open();

                //taking the Ids for delection
                ad = new MySqlDataAdapter(com);
                ad.Fill(table);
                ad.Dispose();

                if(table.Rows.Count > 0)
                {
                    rd = move.ExecuteReader();
                    rd.Close();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        string delete = "delete from lab_temp where Id = '" + table.Rows[i][0].ToString() + "'";
                        MySqlCommand com1 = new MySqlCommand(delete, con);
                        rd = com1.ExecuteReader();
                        rd.Close();
                    }

                    flowLayoutPanel1.Controls.Clear();
                    testPanel.Visible = false;
                    btnTestPanel.Visible = false;
                    cancelBtn.Visible = false;
                    notePanel.Visible = false;
                    confiLabTxt.Text = "";
                    empty = false;
                }
                else
                {
                    empty = true;
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        int TestCost;
        private void lab_tem()
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
           
            MySqlDataReader rd;
           
           try {
                con.Open();

                string selectCost = "select proposedprice from laboratory_tests_master where name = '" + labTestList.Text + "'";
                //taking the price of the test
                DataTable table = new DataTable();
                MySqlCommand cost = new MySqlCommand(selectCost, con);
                rd = cost.ExecuteReader();
                table.Load(rd);
                rd.Close();

                if (table.Rows.Count > 0)
                {

                    TestCost = int.Parse(table.Rows[0][0].ToString());
                    string test = " insert into lab_temp(Test,doctorName,pID,date,cost,status) values('" + labTestList.Text + "','" + login.uname + "','" + doctCheckInTab.patientId + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'," + TestCost + ",'New') ";
                    MySqlCommand com = new MySqlCommand(test, con);
                   
                    //saving data to database
                    rd = com.ExecuteReader();
                    rd.Close();

                    LoadTestTimer.Start();
                    labTestList.Text = "----Select---";
                }
               

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //the function to add the tests
        private void addBtn_Click(object sender, EventArgs e)
        {
            checkBx();
        }

        //the function to remove the test
        private void RemoveTest(object sender, EventArgs e)
        {
            var button = sender as BunifuImageButton;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string delete = "delete from lab_temp where Id = '" + button.Name + "' ";
            MySqlCommand com1 = new MySqlCommand(delete, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                //deleting the deleted text
                reader = com1.ExecuteReader();
                reader.Close();
                LoadTestTimer.Start();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

       
        //form load function
        private void docLabTab_Load(object sender, EventArgs e)
        {
            labTestList.Text = "----Select---";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string test = " select name from laboratory_tests_master ";
            MySqlCommand com = new MySqlCommand(test, con);
            DataTable table = new DataTable();
            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(test, con);
                DataSet ds = new DataSet();
                da.Fill(ds,"Select");
                da.Dispose();

                
                
                com.ExecuteNonQuery();
                labTestList.DisplayMember = "name";
                labTestList.DataSource = ds.Tables["Select"];
                da.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

           
         
        }
        int select = 0;
        private void labTestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(select == 0)
            {
                select++;
            }
            else
            {
                lab_tem();
            }
            
        }

        //view the tests
        private void LoadTestTimer_Tick(object sender, EventArgs e)
        {
            LoadTestTimer.Stop();
            flowLayoutPanel1.Controls.Clear();
            ViewAddedTest();
        }

        //a function to change the status of the patient when sent to lab by the doctor
        private void UpdateToLab()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            string req = "update patient_assign set status = 'ToLab' where pID = '" + doctCheckInTab.patientId + "'";
            string Cashier = "update patient_assign set status = 'Cashier' where pID = '" + doctCheckInTab.patientId + "'";

            MySqlCommand request = new MySqlCommand(req, con);
            MySqlCommand CashierRequest = new MySqlCommand(Cashier, con);

            MySqlDataReader rd;
            try
            {
                con.Open();
                if(patientTreatmentTab.pymntType  == "Normal" && patientTreatmentTab.schme == "Normal")
                {
                    rd = CashierRequest.ExecuteReader();
                    rd.Close();
                }
                else
                {
                    rd = request.ExecuteReader();
                    rd.Close();
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            
                ClearTests();
            if(empty == false)
            {
                UpdateToLab();
            }
                 
        }
    }
}
