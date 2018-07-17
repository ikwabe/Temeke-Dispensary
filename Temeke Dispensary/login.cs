using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;

namespace Temeke_Dispensary
{
    public partial class login : Form
    {
        public static BunifuMaterialTextbox txt = new BunifuMaterialTextbox();
        public static BunifuMetroTextbox pwd = new BunifuMetroTextbox();
        public login()
        {
            InitializeComponent();
        }

        public static string DBconnection = "server = localhost; user = root; password = '' ; database = explora_10 ";
        private void login_Load(object sender, EventArgs e)
        {
           
             txt.Size = new Size(370, 44);
             txt.Location = new Point(471, 337);
             txt.Visible = true;
            txt.Text = "admin";
            txt.LineFocusedColor = Color.Blue;
            txt.LineIdleColor = Color.RoyalBlue;
             txt.Font = new Font("Century Gothic",10, FontStyle.Regular);
             txt.Margin = new Padding(4, 4, 4, 4);
             txt.ForeColor = Color.Black;
             txt.BackColor = Color.FromArgb(0, 60, 101);
            Controls.Add(txt);
            timer1.Start();
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            logoAnimator.ShowSync(logo);
        }
        
        public static string UTid;
        public static string uname;
        public static string password;
        public static string status;

        private void finishBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = DBconnection;
            string titleId = "select TitleCode,loginname,password,status from users where loginname = '" + txt.Text +"' and password = '"+ passwd.Text +"'";
            MySqlCommand UT = new MySqlCommand(titleId, con);
            MySqlDataReader rd;
            DataTable table = new DataTable();
            try
            {
                    con.Open();
                //retrieving UT ID from the database
                rd = UT.ExecuteReader();
                table.Load(rd);
                rd.Close();   
                    
                try
                {
                    uname = table.Rows[0][1].ToString();
                    password = table.Rows[0][2].ToString();
                    status = table.Rows[0][3].ToString();
                    UTid = table.Rows[0][0].ToString();
                    
                   
                    if (txt.Text == uname && passwd.Text == password && UTid == "UT01" && status == "logout")
                    {
                        loginSt();
                        loginRecord();
                        room room = new room();
                        room.Show();
                        this.Hide();
                    }
                    //Administator
                    else if (txt.Text == uname && passwd.Text == password && UTid == "UT02" && status == "logout")
                    {
                        loginSt();
                        loginRecord();
                        staffRegistration st = new staffRegistration();
                        st.Show();
                        this.Hide();
                    }
                    //Receptionist
                    else if (txt.Text == uname && passwd.Text == password && UTid == "UT04" && status == "logout")
                    {
                        loginSt();
                        loginRecord();
                        reception rs = new reception();
                        rs.Show();
                        this.Hide();
                    }
                    //Pharmersist
                    else if (txt.Text == uname && passwd.Text == password && UTid == "UT05" && status == "logout")
                    {
                        loginSt();
                        loginRecord();
                        pharmacy ph = new pharmacy();
                        ph.Show();
                        this.Hide();
                    }
                    //Cashier
                    else if (txt.Text == uname && passwd.Text == password && UTid == "UT06" && status == "logout")
                    {
                        loginSt();
                        loginRecord();
                        cashier cs = new cashier();
                        cs.Show();
                        this.Hide();
                    }
                    //Laboratorian
                    else if (txt.Text == uname && passwd.Text == password && UTid == "UT08" && status == "logout")
                    {
                        loginSt();
                        loginRecord();
                        laboratory lb = new laboratory();
                        lb.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User is Already Online");
                        txt.Text = "";
                        passwd.Text = "";
                    }

                }
                catch
                {
                    MessageBox.Show("Wrong Password Or Username");
                }
                   
                //Doctor
               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
           
        }

        //function to record  logouts
        public static void logoutRecord()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = DBconnection;
            string updateD = " update login_logs set logouttime = '"+DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+"', status = 'logout' where loginname = '" + uname + "'";

            MySqlCommand Update = new MySqlCommand(updateD, con);

            MySqlDataReader rd;

            try
            {
                con.Open();

                rd = Update.ExecuteReader();
                rd.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //function to record  login
        public static void loginRecord()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = DBconnection;
            string updateD = "insert into login_logs(logintime,status,loginname) values('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','login','" + uname + "')";

            MySqlCommand Update = new MySqlCommand(updateD, con);

            MySqlDataReader rd;

            try
            {
                con.Open();

                rd = Update.ExecuteReader();
                rd.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //function to change the status of the login user
        public static void loginSt()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = DBconnection;
           string updateD = " update users set Status = 'login' where loginname = '" + uname + "'";

            MySqlCommand Update =  new MySqlCommand(updateD, con);
           
            MySqlDataReader rd;

            try
            {
                con.Open();

                rd = Update.ExecuteReader();
                rd.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //the function to change the status of the logout user
        public static void logoutSt()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = DBconnection;
            string updateD = "update  users set status = 'logout' where loginname = '" + uname + "'";

            MySqlCommand Update = new MySqlCommand(updateD, con);

            MySqlDataReader rd;

            try
            {
                con.Open();

                rd = Update.ExecuteReader();
                rd.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
      
    }
}
