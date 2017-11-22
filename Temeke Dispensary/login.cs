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

       
        private void login_Load(object sender, EventArgs e)
        {
           
             txt.Size = new Size(370, 44);
             txt.Location = new Point(471, 337);
             txt.Visible = true;
            txt.Text = "temba";
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

        private void finishBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04 ; database = explora_10 ";
            string titleId = "select * from users where loginname = '"+ txt.Text +"' and password = '"+ passwd.Text +"'";
            MySqlCommand UT = new MySqlCommand(titleId, con);
            MySqlDataAdapter ad;

            try
            {
                    con.Open();
                    //retrieving UT ID from the database
                    ad = new MySqlDataAdapter(UT);
                    DataTable table = new DataTable();
                    ad.Fill(table);
                try
                {
                    uname = table.Rows[0][2].ToString();
                    password = table.Rows[0][3].ToString();
                    UTid = table.Rows[0][9].ToString();
                    ad.Dispose();
                }
                catch
                {
                    MessageBox.Show("Wrong Password Or Username");
                }
                   

                if (txt.Text == uname && passwd.Text == password && UTid == "UT01" )
                {
                    doctor doc = new doctor();
                    doc.Show();
                    this.Hide();
                }
                else if (txt.Text == uname && passwd.Text == password && UTid == "UT04")
                {
                    laboratory lb = new laboratory();
                    lb.Show();
                    this.Hide();
                }
                else if (txt.Text == "pharm" && passwd.Text == "1234")
                {
                    pharmacy ph = new pharmacy();
                    ph.Show();
                    this.Hide();
                }
                else if (txt.Text == uname && passwd.Text == password && UTid == "UT02")
                {
                    staffRegistration st = new staffRegistration();
                    st.Show();
                    this.Hide();
                }
                else if (txt.Text == "cash" && passwd.Text == "1234")
                {
                    cashier cs = new cashier();
                    cs.Show();
                    this.Hide();
                }
                else if (txt.Text == "resp" && passwd.Text == "1234")
                {
                    reception rs = new reception();
                    rs.Show();
                    this.Hide();
                }
                else
                {
                    txt.Text = "";
                    passwd.Text = "";
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
