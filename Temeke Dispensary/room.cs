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

namespace Temeke_Dispensary
{
    public partial class room : Form
    {
        public room()
        {
            InitializeComponent();
        }

        private void LoadRoom()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string room = " select name from doctors_rooms where status <> 'RESERVED'";

            MySqlCommand com = new MySqlCommand(room, con);

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(room, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "none");
                com.ExecuteNonQuery();
                roomNumber.DisplayMember = "name";
                roomNumber.DataSource = ds.Tables["none"];
                da.Dispose();

               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void room_Load(object sender, EventArgs e)
        {
            i = 0;
            LoadRoom();
        }

        public static string TheroomNumber;
        int i;
        private void roomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(i == 0)
            {
                i++;
            }
            else
            {
                if (MessageBox.Show("Room " + roomNumber.Text, "Chosen", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = login.DBconnection;
                    string updateD = " update login_logs set location = '" + roomNumber.Text + "' where loginname = '" + login.uname + "' and status ='login'";
                    string updateR = "update doctors_rooms set status = 'RESERVED' where name = '" + roomNumber.Text + "'";
                    MySqlCommand Update = new MySqlCommand(updateD, con);
                    MySqlCommand UpdateRoom = new MySqlCommand(updateR, con);

                    MySqlDataReader rd;

                    try
                    {
                        con.Open();

                        //inserting the room number
                        rd = Update.ExecuteReader();
                        rd.Close();

                        //change the status of the room.
                        rd = UpdateRoom.ExecuteReader();
                        rd.Close();


                        TheroomNumber = roomNumber.Text;

                        doctor doc = new doctor();
                        doc.Show();
                        this.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
           
           
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            login.logoutSt();
            login.logoutRecord();
            Application.Restart();

        }
    }
}
