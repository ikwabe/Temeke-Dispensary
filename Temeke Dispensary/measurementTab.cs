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
    public partial class measurementTab : UserControl
    {
        public static measurementTab _instance;
        public static measurementTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new measurementTab();
                return _instance;
            }
        }
        public measurementTab()
        {
            InitializeComponent();
        }

        private void measurementTab_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04 ; database = explora_10 ";
            string unit = " select unit from laboratory_units ";
            MySqlCommand com = new MySqlCommand(unit, con);
            DataTable table = new DataTable();

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(unit, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Select");
                com.ExecuteNonQuery();
                unitComb.DisplayMember = "unit";
                unitComb.DataSource = ds.Tables["Select"];
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
