using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Temeke_Dispensary
{
    public partial class doctor : Form
    {
        public doctor()
        {
            InitializeComponent();
        }

        private void profile()
        {
            MySqlDataReader rd;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string detail = "select photo from users where loginname = '" + login.uname + "'";
            MySqlCommand com = new MySqlCommand(detail, con);
            DataTable table = new DataTable();
            try
            {

                con.Open();
                rd = com.ExecuteReader();
                table.Load(rd);
                rd.Close();


                try
                {
                    byte[] img = (byte[])table.Rows[0][0];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);

                }
                catch
                {

                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        //a function for alerting the doctor for new patients
        bool check = false;
        private void LoadAssignedPatient()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string loadInf = "select pID,patientName from patient_assign where status = 'Assigned' and doctorAssigned = '" + login.uname + "' or status = 'DocMute'";

            MySqlCommand com = new MySqlCommand(loadInf, con);
            MySqlDataReader rd;

            DataTable tab = new DataTable();
            try
            {

                con.Open();
                //counting the menu in the table
                rd = com.ExecuteReader();
                tab.Load(rd);
                rd.Close();
                if (tab.Rows.Count > 0)
                {
                    mute.Visible = true;
                    muteSoundButton.Visible = true;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.docTone);
                    player.Play();

                    if (check == true)
                    {
                        for (int i = 0; i < tab.Rows.Count; i++)
                        {

                            string update = "update patient_assign set status = 'DocMute' where pID = '" + tab.Rows[i][0].ToString() + "'";
                            MySqlCommand Update = new MySqlCommand(update, con);
                            rd = Update.ExecuteReader();
                            rd.Close();
                        }

                        check = false;
                    }

                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //a function for the emergence loss of power for patient assigned to a doctor
        private void ReloadTheUnsolvePatient()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            string req = "select * from patient_assign where status = 'ToDoctor' or status = 'On-Treatment'";


            MySqlCommand request = new MySqlCommand(req, con);

            MySqlDataAdapter da;
            MySqlDataReader rd;
            DataTable table = new DataTable();
            try
            {
                con.Open();
                da = new MySqlDataAdapter(request);
                da.Fill(table);
                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        

                        string update = "update patient_assign set status = 'Assigned' where pID = '" + table.Rows[i][0].ToString() + "'";
                        MySqlCommand Update = new MySqlCommand(update, con);
                        rd = Update.ExecuteReader();
                        rd.Close();
                    }

                }
                da.Dispose();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //releas a room
        private void ReleaseRoom()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
           
            string updateR = "update doctors_rooms set status = 'ACTIVE' where name = '" + room.TheroomNumber + "'";
         
            MySqlCommand UpdateRoom = new MySqlCommand(updateR, con);

            MySqlDataReader rd;

            try
            {
                con.Open();
                //change the status of the room.
                rd = UpdateRoom.ExecuteReader();
                rd.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static bool checkPatient = false;
        private void closeWindow_Click(object sender, EventArgs e)
        {
            login.logoutSt();
            login.logoutRecord();
            ReleaseRoom();
            Application.Exit();
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            line.Width = checkBtn.Width;
            line.Left = checkBtn.Left;

            panel2.Controls.Add(doctCheckInTab.Instance);
            doctCheckInTab.Instance.Dock = DockStyle.Fill;
            doctCheckInTab.Instance.BringToFront();
            doctCheckInTab.Instance.Visible = true;
            patientTreatmentTab.Instance.Visible = false;
            docreportTab.Instance.Visible = false;
        }

        private void patientTrtmntBtn_Click(object sender, EventArgs e)
        {
            line.Width = patientTrtmntBtn.Width;
            line.Left = patientTrtmntBtn.Left;
            panel2.Controls.Add(patientTreatmentTab.Instance);
            patientTreatmentTab.Instance.Dock = DockStyle.Fill;
            patientTreatmentTab.Instance.BringToFront();
            patientTreatmentTab.Instance.Visible = true;
           doctCheckInTab.Instance.Visible = false;
            docreportTab.Instance.Visible = false;
        }

        private void doctor_Load(object sender, EventArgs e)
        {
            profile();
            timer1.Start();
            AlertTimer.Start();
            ReloadTheUnsolvePatient();
            openTreatmentTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            logoAnimator.ShowSync(logo);
        }

        private void repotBtn_Click(object sender, EventArgs e)
        {
            line.Width = repotBtn.Width;
            line.Left = repotBtn.Left;
            panel2.Controls.Add(docreportTab.Instance);
            docreportTab.Instance.Dock = DockStyle.Fill;
            docreportTab.Instance.BringToFront();
            docreportTab.Instance.Visible = true;
            patientTreatmentTab.Instance.Visible = false;
            doctCheckInTab.Instance.Visible = false;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login.logoutSt();
            login.logoutRecord();
            ReleaseRoom();
            Application.Restart();
        }

        private void openTreatmentTimer_Tick(object sender, EventArgs e)
        {
            if(checkPatient == true)
            {
                line.Width = patientTrtmntBtn.Width;
                line.Left = patientTrtmntBtn.Left;
                panel2.Controls.Add(patientTreatmentTab.Instance);
                patientTreatmentTab.Instance.Dock = DockStyle.Fill;
                patientTreatmentTab.Instance.BringToFront();
                patientTreatmentTab.Instance.Visible = true;
                doctCheckInTab.Instance.Visible = false;
                docreportTab.Instance.Visible = false;
                checkPatient = false;
            }
        }

        private void muteSoundButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                muteSoundButton.Visible = false;
                mute.Visible = false;
                check = true;
            }
        }

        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            LoadAssignedPatient();
        }
    }
}
