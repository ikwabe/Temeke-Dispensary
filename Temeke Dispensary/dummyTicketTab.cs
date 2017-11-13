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
    public partial class dummyTicketTab : UserControl
    {
        public static dummyTicketTab _instance;
        public static dummyTicketTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new dummyTicketTab();
                return _instance;
            }
        }
        public dummyTicketTab()
        {
            InitializeComponent();
           
        }

        private void dummyTicketTab_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ; database = explora_10 ";
            string clinic = " select Clinicname Dummy from clinics_master";
            MySqlCommand com = new MySqlCommand(clinic, con);
            MySqlDataAdapter ad;
            try
            {
                con.Open();
                ad = new MySqlDataAdapter(com);
                //taking email to the table for searchimg its corresponding messages in sentmail table
                DataTable table = new DataTable();
                ad.Fill(table);
                if (table.Rows.Count > 0)
                {
                   dummyDataGrid.DataSource = table; 
                   ad.Dispose();
                  
                }
                else
                {

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void searchNameTxt_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ; database = explora_10 ";
            string names = " select Fullname from patients where Fullname like '" + searchNameTxt.Text + "%'";
            MySqlCommand com = new MySqlCommand(names, con);
            DataTable table = new DataTable();
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();
                table.Load(reader);
                reader.Close();
                namesDataGrid.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public static string patientName;
        private void namesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            try
            {
                DataGridViewRow selectedIndex = namesDataGrid.Rows[index];
                patientName = selectedIndex.Cells[0].Value.ToString();
            }
            catch
            {

            }


            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ; database = explora_10 ";
            string name = " select * from patients where Fullname =  '" + patientName + "'";
            MySqlCommand com = new MySqlCommand(name, con);
            MySqlDataAdapter ad;
            try
            {
                con.Open();
                ad = new MySqlDataAdapter(com);
                //taking email to the table for searchimg its corresponding messages in sentmail table
                DataTable table = new DataTable();
                ad.Fill(table);
                if (table.Rows.Count > 0)
                {
                    fullNameLable.Text = table.Rows[0][3].ToString();
                    fileNumberLable.Text = table.Rows[0][1].ToString();

                    ad.Dispose();
                 
                }
                else
                {

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
