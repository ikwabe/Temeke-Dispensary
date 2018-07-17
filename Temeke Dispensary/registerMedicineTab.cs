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
    public partial class registerMedicineTab : UserControl
    {
        public static registerMedicineTab _instance;
        public static registerMedicineTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new registerMedicineTab();
                return _instance;
            }
        }
        public registerMedicineTab()
        {
            InitializeComponent();
        }

        private void registerMedicineTab_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string unit = " select category from drugs_categories ";

            MySqlCommand com = new MySqlCommand(unit, con);
            DataTable table = new DataTable();

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(unit, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Select");
                com.ExecuteNonQuery();
                TypeCombo.DisplayMember = "category";
                TypeCombo.DataSource = ds.Tables["Select"];
                da.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }
    }
}
