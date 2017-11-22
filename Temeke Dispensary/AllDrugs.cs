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
    public partial class AllDrugs : Form
    {
        public AllDrugs()
        {
            InitializeComponent();
        }
        public static string drugname;
        private void AllDrugs_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04 ; database = explora_10 ";
            string drug = " select drugname Drugs from drugs_master";
            MySqlCommand com = new MySqlCommand(drug, con);
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
            catch (MySqlException ex)
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

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04 ; database = explora_10 ";
            string drug = " select drugname Drugs from drugs_master where drugname like '" + searchTxt.Text + "%'";
            MySqlCommand com = new MySqlCommand(drug, con);
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

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void diagDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            try
            {
                DataGridViewRow selectedIndex = diagDataGrid.Rows[index];
                drugname = selectedIndex.Cells[0].Value.ToString();
                treatmentTab.Instance.drugnameLable.Text = drugname;


                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server = localhost; user = root; password = ikwabe04 ; database = explora_10 ";
                string drug = " select * from drugs_master where drugname =  '" + drugname + "'";
                MySqlCommand com = new MySqlCommand(drug, con);
                MySqlDataAdapter ad;
                try
                {
                    con.Open();
                    ad = new MySqlDataAdapter(com);
                    //taking email to the table for searchimg its corresponding messages in sentmail table
                    DataTable table = new DataTable();
                    ad.Fill(table);
                    treatmentTab.Instance.drugCodeTxt.Text = table.Rows[0][0].ToString();
                    ad.Dispose();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

                //close datagrid
                this.Close();
            }
            catch
            {

            }
        }
    }
}
