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
    public partial class registrationTab : UserControl
    {
        public static registrationTab _instance;
        public static registrationTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new registrationTab();
                return _instance;
            }
        }
        public registrationTab()
        {
            InitializeComponent();
        }

        private void registrationTab_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04 ; database = explora_10 ";
            string unit = " select Tribename from tribes_master ";
            MySqlCommand com = new MySqlCommand(unit, con);
            DataTable table = new DataTable();

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(unit, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Select");
                com.ExecuteNonQuery();
                tribeCombo.DisplayMember = "Tribename";
                tribeCombo.DataSource = ds.Tables["Select"];
                da.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
    }

