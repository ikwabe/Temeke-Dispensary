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
    public partial class docLabTab : UserControl
    {
        public static docLabTab _instance;
        public static docLabTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new docLabTab();
                return _instance;
            }
        }
        public docLabTab()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            testPanel.Visible = true;
            btnTestPanel.Visible = true;
            cancelBtn.Visible = true;
            notePanel.Visible = true;
            confiLabTxt.AppendText(instrctnTxt.Text);

            instrctnTxt.Text = "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            testPanel.Visible = false;
            btnTestPanel.Visible = false;
            cancelBtn.Visible = false;
            notePanel.Visible = false;
            confiLabTxt.Text = "";


        }

        public void checkBx()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04 ; database = explora_10 ";
            string check1 = " insert into lab_temp(Test) values('" + checkBox1.Text + "') ";
            string check2 = " insert into lab_temp(Test) values('" + checkBox2.Text + "') ";
            string check3 = " insert into lab_temp(Test) values('" + checkBox3.Text + "') ";
            string check4 = " insert into lab_temp(Test) values('" + checkBox4.Text + "') ";
            string check5 = " insert into lab_temp(Test) values('" + checkBox5.Text + "') ";

            string addToGrid = "select * from lab_temp ";
            MySqlDataReader rd;
            MySqlCommand com1 = new MySqlCommand(check1, con);
            MySqlCommand com2 = new MySqlCommand(check2, con);
            MySqlCommand com3 = new MySqlCommand(check3, con);
            MySqlCommand com4 = new MySqlCommand(check4, con);
            MySqlCommand com5 = new MySqlCommand(check5, con);


            MySqlCommand com0 = new MySqlCommand(addToGrid, con);
            try
            {
                con.Open();

                if (checkBox1.CheckState == CheckState.Checked)
                {
                    rd = com1.ExecuteReader();
                    rd.Close();
                }

                if (checkBox2.CheckState == CheckState.Checked)
                {
                    rd = com2.ExecuteReader();
                    rd.Close();
                }

                if (checkBox3.CheckState == CheckState.Checked)
                {
                    rd = com3.ExecuteReader();
                    rd.Close();

                }

                if (checkBox4.CheckState == CheckState.Checked)
                {
                    rd = com4.ExecuteReader();
                    rd.Close();
                }

                if (checkBox5.CheckState == CheckState.Checked)
                {
                    rd = com5.ExecuteReader();
                    rd.Close();
                }

                //add data to grid
                rd = com0.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(rd);
                confiTestGrid.DataSource = table;
                rd.Close();

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        private void lab_tem()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04 ; database = explora_10 ";
            string test = " insert into lab_temp(Test) values('" + labTestList.Text + "') ";
            string addToGrid = "select * from lab_temp ";
            MySqlDataReader rd;
            MySqlCommand com = new MySqlCommand(test, con);
            MySqlCommand com0 = new MySqlCommand(addToGrid, con);
           try {
                con.Open();

                //saving data to database
                rd = com.ExecuteReader();
                rd.Close();


                //add data to grid
                rd = com0.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(rd);
                confiTestGrid.DataSource = table;
                rd.Close();

                labTestList.Text = "----Select---";

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            checkBx();
        }

        private void docLabTab_Load(object sender, EventArgs e)
        {
            labTestList.Text = "----Select---";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04 ; database = explora_10 ";
            string test = " select name from laboratory_tests_master ";
            string trunc = "truncate lab_temp";
            MySqlCommand com = new MySqlCommand(test, con);
            DataTable table = new DataTable();
        
            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(test, con);
                DataSet ds = new DataSet();
                da.Fill(ds,"Select");
                com.ExecuteNonQuery();
                labTestList.DisplayMember = "name";
                labTestList.DataSource = ds.Tables["Select"];
                da.Dispose();

                MySqlCommand com1 = new MySqlCommand(trunc, con);
                MySqlDataReader rd;
                rd = com1.ExecuteReader();
                rd.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

           
         
        }

        private void labTestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lab_tem();
        }


        public static string selectedWord;
        private void confiTestGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            try
            {
                DataGridViewRow selectedIndex = confiTestGrid.Rows[index];
                selectedWord = selectedIndex.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04 ; database = explora_10 ";
            string delete = "delete from lab_temp where Test = '" + selectedWord + "' ";
            MySqlCommand com1 = new MySqlCommand(delete, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = com1.ExecuteReader();
                reader.Close();

                string addToGrid = "select * from lab_temp ";
                MySqlCommand com0 = new MySqlCommand(addToGrid, con);
                reader = com0.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                confiTestGrid.DataSource = table;
                reader.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
    }
}
