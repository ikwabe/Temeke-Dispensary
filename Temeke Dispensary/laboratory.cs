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
    public partial class laboratory : Form
    {
        public laboratory()
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

        private void viewBtn_Click(object sender, EventArgs e)
        {
            line.Width = viewBtn.Width;
            line.Left = viewBtn.Left;
            panel2.Controls.Add(labViewTb.Instance);
            labViewTb.Instance.Dock = DockStyle.Fill;
            labViewTb.Instance.BringToFront();
            labViewTb.Instance.Visible = true;
            labreportTab.Instance.Visible = false;
            measurementTab.Instance.Visible = false;
           
        }

        private void measureBtn_Click(object sender, EventArgs e)
        {
            line.Width = measureBtn.Width;
            line.Left = measureBtn.Left;
            panel2.Controls.Add(measurementTab.Instance);
            measurementTab.Instance.Dock = DockStyle.Fill;
            measurementTab.Instance.BringToFront();
            measurementTab.Instance.Visible = true;
            labViewTb.Instance.Visible = false;
            labreportTab.Instance.Visible = false;
           
        }

        private void repotBtn_Click(object sender, EventArgs e)
        {
            line.Width = repotBtn.Width;
            line.Left = repotBtn.Left;
            panel2.Controls.Add(labreportTab.Instance);
            labreportTab.Instance.Dock = DockStyle.Fill;
            labreportTab.Instance.BringToFront();
            labreportTab.Instance.Visible = true;
            measurementTab.Instance.Visible = false;
            labViewTb.Instance.Visible = false;
           
        }

        bool check = false;
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
               
                con.Open();
                //counting the menu in the table
                rd = com.ExecuteReader();
                tab.Load(rd);
                rd.Close();
                if (tab.Rows.Count > 0)
                {
                    mute.Visible = true;
                    muteSoundButton.Visible = true;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.labTone);
                    player.Play();

                    if (check == true)
                    {
                        for (int i = 0; i < tab.Rows.Count; i++)
                        {

                            string update = "update patient_assign set status = 'LabMute' where pID = '" + tab.Rows[i][0].ToString() + "'";
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

        public static bool checkPatient = false;
        private void laboratory_Load(object sender, EventArgs e)
        {
            profile();
            timer1.Start();
            AlertTimer.Start();
            checkPatientTimer.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            logoAnimator.ShowSync(logo);
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            login.logoutSt();
            login.logoutRecord();
            Application.Exit();
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login.logoutSt();
            login.logoutRecord();
            Application.Restart();
        }

        private void checkPatientTimer_Tick(object sender, EventArgs e)
        {
            if(checkPatient == true)
            {
                line.Width = measureBtn.Width;
                line.Left = measureBtn.Left;
                panel2.Controls.Add(measurementTab.Instance);
                measurementTab.Instance.Dock = DockStyle.Fill;
                measurementTab.Instance.BringToFront();
                measurementTab.Instance.Visible = true;
                labViewTb.Instance.Visible = false;
                labreportTab.Instance.Visible = false;
                checkPatient = false;
            }
        }

        
        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            LoadAssignedPatient();
            
        }

        private void muteSoundButton_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                muteSoundButton.Visible = false;
                mute.Visible = false;
                check = true;
            }
        }
    }
}
