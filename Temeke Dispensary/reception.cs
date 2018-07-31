using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using Bunifu.Framework.UI;
using System.IO;

namespace Temeke_Dispensary
{
    public partial class reception : Form
    {
        public reception()
        {
            InitializeComponent();
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

        

        private void reception_Load(object sender, EventArgs e)
        {
            profile();
            timer1.Start();
            requestCheckerTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
           logoAnimator.ShowSync(logo);
            
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
           
            
            line.Width = regBtn.Width;
            line.Left = regBtn.Left;
            panel2.Controls.Add(registrationTab.Instance);
            registrationTab.Instance.Dock = DockStyle.Fill;
            registrationTab.Instance.BringToFront();
            registrationTab.Instance.Visible = true;
            chekIn.Instance.Visible = false;
           
            dummyTicketTab.Instance.Visible = false;

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
           
           
            line.Width = checkBtn.Width;
            line.Left = checkBtn.Left;
            panel2.Controls.Add(chekIn.Instance);
            chekIn.Instance.Dock = DockStyle.Fill;
            chekIn.Instance.BringToFront();
          
            chekIn.Instance.Visible = true;
            dummyTicketTab.Instance.Visible = false;
            registrationTab.Instance.Visible = false;
        }

        private void dummyBtn_Click(object sender, EventArgs e)
        {
            line.Left = dummyBtn.Left;
            line.Width = dummyBtn.Width;
            panel2.Controls.Add(dummyTicketTab.Instance);
            dummyTicketTab.Instance.Dock = DockStyle.Fill;
            dummyTicketTab.Instance.BringToFront();
            dummyTicketTab.Instance.Visible = true;
            chekIn.Instance.Visible = false;
            registrationTab.Instance.Visible = false;
            

        }

        private void logout_Click(object sender, EventArgs e)
        {
            login.logoutSt();
            login.logoutRecord();
            Application.Restart();
        }
        Label lb;
        Label lb1;
        Label lb2;
        private void Requests()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            string req = "select * from patients_requests where status = 'New'";
            

            MySqlCommand request = new MySqlCommand(req, con);
           
            MySqlDataAdapter da;
            MySqlDataReader rd;
            DataTable table = new DataTable();
            try
            {
                con.Open();
                da = new MySqlDataAdapter(request);
                da.Fill(table);
                string lbName;
                if(table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        //names
                        lb = new Label();
                        lb.ForeColor = Color.White;
                        lb.Font = new Font("Arial Rounded MT", 12,FontStyle.Bold);
                        lb.AutoSize = true;
                        lb.Name = table.Rows[i][0].ToString();
                        lbName = table.Rows[i][0].ToString();

                        //Location
                  
                        lb1 = new Label();
                        lb1.ForeColor = Color.White;
                        lb1.Font = new Font("Arial Rounded MT", 12, FontStyle.Bold);
                        lb1.AutoSize = true;

                        //time
                        lb2 = new Label();
                        lb2.ForeColor = Color.White;
                        lb2.Font = new Font("Arial Rounded MT", 12, FontStyle.Bold);
                        lb2.AutoSize = true;

                        string update = "update patients_requests set status = 'oncall' where recid = '"+lb.Name+"'";
                        MySqlCommand Update = new MySqlCommand(update, con);
                        rd = Update.ExecuteReader();
                        rd.Close();


                        lb.Text = table.Rows[i][1].ToString().ToUpper();
                        lb1.Text = table.Rows[i][3].ToString().ToUpper();
                        lb2.Text = DateTime.Now.ToLongTimeString();

                        flowLayoutPanel1.Controls.Add(lb);
                        flowLayoutPanel2.Controls.Add(lb1);
                        flowLayoutPanel3.Controls.Add(lb2);
                    }

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.tone3);
                    player.Play();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //a function to load profile information for the user login
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
        private void requestCheckerTimer_Tick(object sender, EventArgs e)
        {
            Requests();
        }
    }
}
