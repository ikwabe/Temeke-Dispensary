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
    public partial class AllDiagnosis : Form
    {
        public AllDiagnosis()
        {
            InitializeComponent();
        }

        private void AllDiagnosis_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04 ; database = explora_10 ";
            string diag = " select diseasename Diagnosis from diseases_master";
            MySqlCommand com = new MySqlCommand(diag, con);
            DataTable table = new DataTable();
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();
                table.Load(reader);
                reader.Close();
                diagDataGrid.DataSource = table;
                diagDataGrid.Sort(diagDataGrid.Columns[0], ListSortDirection.Ascending);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            logoAnimator.ShowSync(logo2);
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = explora_10 ";
            string diag = " select diseasename Diagnosis from diseases_master where diseasename like '"+ searchTxt.Text +"%' ";
            MySqlCommand com = new MySqlCommand(diag, con);
            DataTable table = new DataTable();
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();
                table.Load(reader);
                reader.Close();
                diagDataGrid.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
