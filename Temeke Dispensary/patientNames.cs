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
    public partial class patientNames : Form
    {
        public patientNames()
        {
            InitializeComponent();
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadnames()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string names = " select Fullname from patients";
            MySqlCommand com = new MySqlCommand(names, con);
            DataTable table = new DataTable();
            MySqlDataAdapter ad;
            try
            {
                con.Open();
                ad = new MySqlDataAdapter(com);
                ad.Fill(table);
                diagDataGrid.DataSource = table;
                diagDataGrid.Sort(diagDataGrid.Columns[0], ListSortDirection.Ascending);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void patientNames_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            logoAnimator.ShowSync(logo2);
        }

        
        public static string patientName;
        private void diagDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            try
            {
                DataGridViewRow selectedIndex = diagDataGrid.Rows[index];
                patientName = selectedIndex.Cells[0].Value.ToString();
            }
            catch
            {

            }


                MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
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
                if(table.Rows.Count > 0)
                {
                    chekIn.Instance.formNumerTxt.Text = table.Rows[0][1].ToString();
                    chekIn.Instance.fullNameTxt.Text = table.Rows[0][3].ToString();
                    chekIn.Instance.genderTxt.Text = table.Rows[0][4].ToString();
                    chekIn.Instance.birthdayTxt.Text = table.Rows[0][5].ToString();
                    chekIn.Instance.yearText.Text = (int.Parse(DateTime.Now.ToShortDateString().Substring(6)) - int.Parse(table.Rows[0][5].ToString().Substring(6))).ToString();


                    ad.Dispose();
                    this.Close();
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

       

        private void searchNameTxt_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
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
