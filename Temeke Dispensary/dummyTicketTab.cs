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
    }
}
