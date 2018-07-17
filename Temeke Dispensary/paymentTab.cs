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
    public partial class paymentTab : UserControl
    {
        public static paymentTab _instance;
        public static paymentTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new paymentTab();
                return _instance;
            }
        }

        BunifuFlatButton[] bt;
        public static string patientId;
        public paymentTab()
        {
            InitializeComponent();
        }

        private void labEditBtn_Click(object sender, EventArgs e)
        {
            labPayTxt.Visible = true;
            labPayTxt.Text = "";
            labEditBtn.Visible = false;
            labCost.Visible = false;
        }

        // a function to approve the lab payments
        private void ApproveLabPayments()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            string update = "update patient_assign set status = 'ToLab' where pID = '" + patientId + "'";
            
            MySqlCommand Update = new MySqlCommand(update, con);

            MySqlDataReader rd;


            try
            {
                con.Open();
                //send the patient to Lab
                rd = Update.ExecuteReader();
                rd.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void labPaidBtn_Click(object sender, EventArgs e)
        {
            labPayTxt.Visible = false;
            labEditBtn.Visible = false;
            labCost.Visible = true;
            paid2.Visible = true;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string test = " select Id from lab_test where pID = '" + patientId + "' and status = 'New'";

            MySqlCommand com = new MySqlCommand(test, con);
            DataTable table = new DataTable();
            MySqlDataReader rd;
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
                        string update = "update lab_test set status = 'Approved' where Id = '" + table.Rows[i][0].ToString() + "'";
                        string updateReceptor = "update lab_test set receptor = '"+login.uname+"' where Id = '" + table.Rows[i][0].ToString() + "'";
                        MySqlCommand com1 = new MySqlCommand(update, con);
                        MySqlCommand com2 = new MySqlCommand(updateReceptor, con);

                        //update the status for approval
                        rd = com1.ExecuteReader();
                        rd.Close();

                        //update the receptor for the payments
                        rd = com2.ExecuteReader();
                        rd.Close();
                    }

                    ApproveLabPayments();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }


        FlowLayoutPanel flpanel1;
        FlowLayoutPanel flpanel2;
        //FlowLayoutPanel flpanel3;
        //FlowLayoutPanel flpanel4;
        //FlowLayoutPanel flpanel5;
        FlowLayoutPanel flpanel6;
        Label lb1;
        Label lb2;
        //Label lb3;
        //Label lb4;
        //Label lb5;
        BunifuImageButton bt1;

        int totalLabCost = 0; 
        //a function to load lab test costs
        private void LoadLabCost()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string test = " select Id,test,cost from lab_test where pID = '" + patientId + "' and status = 'New'";

            MySqlCommand com = new MySqlCommand(test, con);
            DataTable table = new DataTable();
            MySqlDataReader rd;
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

                        //Lab Test panel
                        flpanel1 = new FlowLayoutPanel();
                        flpanel1.FlowDirection = FlowDirection.TopDown;
                        flpanel1.Height = 25;
                        flpanel1.Width = 500;
                        flpanel1.BorderStyle = BorderStyle.FixedSingle;

                        flpanel1.WrapContents = false;

                        lb1 = new Label();
                        lb1.ForeColor = Color.White;
                        lb1.Font = new Font("Cambria", 10, FontStyle.Bold);
                        lb1.AutoSize = true;
                        lb1.Text = table.Rows[i][1].ToString();
                        flpanel1.Controls.Add(lb1);
                        flowLayoutPanel2.Controls.Add(flpanel1);

                        //Test cost panel
                        flpanel2 = new FlowLayoutPanel();
                        flpanel2.FlowDirection = FlowDirection.TopDown;
                        flpanel2.Height = 25;
                        flpanel2.Width = 150;

                        flpanel2.BorderStyle = BorderStyle.FixedSingle;

                        flpanel2.WrapContents = false;

                        lb2 = new Label();
                        lb2.ForeColor = Color.White;
                        lb2.Font = new Font("Cambria", 10, FontStyle.Bold);
                        lb2.AutoSize = true;
                        lb2.Text = table.Rows[i][2].ToString();
                        totalLabCost += int.Parse(table.Rows[i][2].ToString());
                        flpanel2.Controls.Add(lb2);
                        flowLayoutPanel3.Controls.Add(flpanel2);


                        //Test cost panel
                        flpanel6 = new FlowLayoutPanel();
                        flpanel6.FlowDirection = FlowDirection.TopDown;
                        flpanel6.Height = 25;
                        flpanel6.Width = 150;

                        flpanel6.BorderStyle = BorderStyle.FixedSingle;

                        flpanel6.WrapContents = false;

                        //the button to remove the test
                        bt1 = new BunifuImageButton();
                        bt1.Height = 20;
                        bt1.Name = table.Rows[i][0].ToString();
                        bt1.Width = 20;
                        bt1.Cursor = Cursors.Hand;
                        bt1.BackColor = Color.Transparent;
                        bt1.Image = Properties.Resources.delete;
                        bt1.Click += new EventHandler(RemoveTest);
                        flpanel6.Controls.Add(bt1);
                        flowLayoutPanel4.Controls.Add(flpanel6);

                        //string update = "update lab_test set status = 'Approved' where Id = '" + table.Rows[i][0].ToString() + "'";
                        //MySqlCommand com1 = new MySqlCommand(update, con);
                        //rd = com1.ExecuteReader();
                        //rd.Close();

                    }
                    labCost.Text = totalLabCost.ToString();
                    labCostLable.Text = labCost.Text + "/=";
                }
                else
                {
                    labCost.Text = totalLabCost.ToString();
                    labCostLable.Text = labCost.Text + "/=";
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        //clearing the lab test panels
        private void clearLabPanels()
        {
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            flowLayoutPanel4.Controls.Clear();
        }

        //deleting the lab test
        private void RemoveTest(object sender, EventArgs e)
        {
            var button = sender as BunifuImageButton;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            totalLabCost = 0;
            string delete = "delete from lab_test where Id = '" + button.Name.ToString() + "'";
            MySqlDataReader rd;
            MySqlCommand com = new MySqlCommand(delete, con);
            try
            {
                con.Open();
                rd = com.ExecuteReader();
                rd.Close();
                clearLabPanels();
                LoadLabCost();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }
        private void LoadAssignedPatient()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string loadInf = "select pID,patientName from patient_assign where status = 'Cashier'";

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

                        string update = "update patient_assign set status = 'ConsPay' where pID = '" + tab.Rows[i][0].ToString() + "'";
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

        //function to load patient from reception
        private void LoadPatientInfo(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;
            patientId = button.Name;
            button.Visible = false;

            //check if the patient alread pay the consultation fee
            checkConsFee();

            //check if the patient pay labcost
            checkLabCost();

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string getDetails = "select patientName from patient_assign where pID = '" + button.Name + "'";

            MySqlCommand getD = new MySqlCommand(getDetails, con);


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
                    PatientName.Text = table.Rows[0][0].ToString();
                    consultationFeeLable.Text = "2000";
                    initialLable.Text = "2,000/=";
                    description.Text = table.Rows[0][0].ToString() + "`S PAYMENTS DESCRIPTIONS.";

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
        private void paymentTab_Load(object sender, EventArgs e)
        {
            LoadPatientTimer.Start();
        }

        private void LoadPatientTimer_Tick(object sender, EventArgs e)
        {
            LoadAssignedPatient();
        }

        //private void initEditBtn_Click(object sender, EventArgs e)
        //{
        //    consultationFeeLable.Visible = false;
        //    consultationFeeText.Visible = true;
        //    initialLable.Text = "";
        //}

        private void consultationFeeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                
            }
        }

        private void consultationFeeText_TextChanged(object sender, EventArgs e)
        {
            initialLable.Text = consultationFeeText.Text + "/=";
        }

        //function to chech if the patient already pay the lab cost

            private void checkLabCost()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string test = " select Id,cost from lab_test where pID = '" + patientId + "' and status = 'Approved' and state = 'Today'";

            MySqlCommand com = new MySqlCommand(test, con);
            DataTable table = new DataTable();
            MySqlDataReader rd;
            try
            {
                con.Open();

                rd = com.ExecuteReader();
                table.Load(rd);
                rd.Close();

                if (table.Rows.Count > 0)
                {
                    for(int i =0; i< table.Rows.Count; i++)
                    {
                        totalLabCost += int.Parse(table.Rows[i][1].ToString());
                    }

                    labCost.Text = totalLabCost.ToString();
                    labCostLable.Text = labCost.Text + "/=";
                    paid2.Visible = true;
                    labEditBtn.Visible = false;
                    labPaidBtn.Visible = false;

                }
                else
                {
                    paid2.Visible = false;
                    labEditBtn.Visible = true;
                    labPaidBtn.Visible = true;
                   
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }



        //function to check if the patient alread pay the consultation fee
        private void checkConsFee()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string checkConsFee = "select pID from consultationfeepaid where state = 'Today' ";
            MySqlCommand com1 = new MySqlCommand(checkConsFee, con);
 
            MySqlDataReader rd;

            DataTable table = new DataTable();

            try
            {
                con.Open();


                //approve consultation payments
                rd = com1.ExecuteReader();
                table.Load(rd);
                rd.Close();

                if(table.Rows.Count > 0)
                {
                    initEditBtn.Visible = false;
                    initPaidBtn.Visible = false;
                    paid.Visible = true;

                    //if the patient has already pay the consultation fee.
                    LoadLabCost();
                }
                else
                {
                    initEditBtn.Visible = true;
                    initPaidBtn.Visible = true;

                    paid.Visible = false;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function to approve the consultation fee
        private void ApproveConsFee()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
           
            string update = "update patient_assign set status = 'Assigned' where pID = '" + patientId + "'";
            string insert = "insert into consultationfeepaid(pID,cashamount,date,receptor,status,state) values("+patientId+",'"+
                consultationFeeLable.Text+"','"+DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+"','"+
                login.uname+"','Received','Today')";

            MySqlCommand Update = new MySqlCommand(update, con);

            MySqlCommand com = new MySqlCommand(insert, con);

          

            MySqlDataReader rd;

           
            try
            {
                con.Open();


                //approve consultation payments
                rd = com.ExecuteReader();
                rd.Close();

                //send the patient to doctor
                rd = Update.ExecuteReader();
                rd.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void initPaidBtn_Click(object sender, EventArgs e)
        {
            initEditBtn.Visible = false;
            initPaidBtn.Visible = false;
            paid.Visible = true;

            ApproveConsFee();

        }
    }
}
