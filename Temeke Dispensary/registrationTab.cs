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

       
        int fileNum;

        // a function to capture the id and the file number
        private void ChechId()
        {
            
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
     
            string recoId = "select recordID,FilenumberCode from patients order by recordID DESC LIMIT 1 ";
            MySqlCommand com1 = new MySqlCommand(recoId, con);
            DataTable table = new DataTable();
            MySqlDataReader rd;

            try
            {
                con.Open();
                //taking the record Id and The File code number
                rd = com1.ExecuteReader();
                table.Load(rd);
                rd.Close();
                if (table.Rows.Count > 0)
                {
                    
                        string rcId = table.Rows[0][0].ToString();
                        string flCode = table.Rows[0][1].ToString();

                        //taking the record id and file code number and increment them
                       
                        fileNum = int.Parse(flCode.Substring(1)) + 1;
                   
                    fileNumberCodeTxt.Text = "F" + fileNum;
                    recordId.Text = (int.Parse(table.Rows[0][0].ToString()) + 1).ToString();
                }
                else
                {
                    fileNumberCodeTxt.Text = "F"+1;
                    recordId.Text = 1.ToString();
                }
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void LoadOccupation()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string unit = " select occupationname from occupation_master ";

            MySqlCommand com = new MySqlCommand(unit, con);

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(unit, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Select");
                com.ExecuteNonQuery();
                occupationCombo.DisplayMember = "occupationname";
                occupationCombo.DataSource = ds.Tables["Select"];
                da.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void LoadTribe()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string unit = " select Tribename from tribes_master ";

            MySqlCommand com = new MySqlCommand(unit, con);

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
        private void registrationTab_Load(object sender, EventArgs e)
        {
           //fill the file number and recordId
            ChechId();

            //fill the tribes
            LoadTribe();
            //fill the occupations
            LoadOccupation();

            
        }

        string tribeCode;

        private void tribeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string unit = " select Tribecode from tribes_master where Tribename = '"+tribeCombo.Text+"' ";
            MySqlCommand com = new MySqlCommand(unit, con);
            MySqlDataReader rd;
            DataTable table = new DataTable();

            try
            {
                con.Open();
                rd = com.ExecuteReader();
                table.Load(rd);

                tribeCode = table.Rows[0][0].ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }

       

        private void phoneTxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void fullNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                
            }
        }

        private void InsertMalePatient()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string insert = "insert into patients(FilenumberCode,Fullname,Gender,Birthdate,Religion,Tribecode,District,Street,Occupationcode,status,registrationdate,contacts,nextOfKin) values('" + fileNumberCodeTxt.Text + "','" + fullNameTxt.Text.ToUpper() + "','" + maleRadio.Text.Substring(0, 1) + "','" + BDate.Text + "','" + religionCombo.Text + "','" + tribeCode + "','"+districtCombo.Text+"','"+streetTxt.Text.ToUpper()+"','" + occupationCombo.Text.ToUpper() + "','ACTIVE','" + DateTime.Now.ToShortDateString() + "','" + phoneTxt.Text + "','"+NextOfKinTxt.Text.ToUpper()+"')";
            MySqlCommand com = new MySqlCommand(insert, con);
            MySqlDataReader rd;
            try
            {
                con.Open();
                //insert The Details
                rd = com.ExecuteReader();
                rd.Close();
                fullNameTxt.Text = "";
                maleRadio.Checked = false;
                femailRadio.Checked = false;
                tribeCombo.Text = "";
                streetTxt.Text = "";
                NextOfKinTxt.Text = "";
                religionCombo.Text = "";
                regionCombo.Text = "";
                occupationCombo.Text = "";
                phoneTxt.Text = "";
                districtCombo.Text = "";
                ChechId();

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //the function to insert the male patient
        private void InsertFemalePatient()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string insert = "insert into patients(FilenumberCode,Fullname,Gender,Birthdate,Religion,Tribecode,District,Street,Occupationcode,status,registrationdate,contacts,nextOfKin) values('" + fileNumberCodeTxt.Text + "','" + fullNameTxt.Text.ToUpper() + "','" + femailRadio.Text.Substring(0, 1) + "','" + BDate.Text + "','" + religionCombo.Text + "','" + tribeCode + "','" + districtCombo.Text + "','" + streetTxt.Text.ToUpper() + "','" + occupationCombo.Text.ToUpper() + "','ACTIVE','" + DateTime.Now.ToShortDateString() + "','" + phoneTxt.Text + "','" + NextOfKinTxt.Text.ToUpper() + "')";
            MySqlCommand com = new MySqlCommand(insert, con);
            MySqlDataReader rd;
            try
            {
                con.Open();
                //insert The Details
                rd = com.ExecuteReader();
                rd.Close();

                fullNameTxt.Text = "";
                fullNameTxt.Text = "";
                maleRadio.Checked = false;
                femailRadio.Checked = false;
                tribeCombo.Text = "";
                streetTxt.Text = "";
                NextOfKinTxt.Text = "";
                religionCombo.Text = "";
                regionCombo.Text = "";
                occupationCombo.Text = "";
                phoneTxt.Text = "";
                districtCombo.Text = "";
                ChechId();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void regBtn_Click(object sender, EventArgs e)
        {
            if(fullNameTxt.Text =="" || BDate.Text == "" || regionCombo.Text == "" || religionCombo.Text =="" || districtCombo.Text == "" || streetTxt.Text == "" || occupationCombo.Text == "" ||  phoneTxt.Text == "" || NextOfKinTxt.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields");
            }
            else
            {
                if(maleRadio.Checked == true)
                {
                    InsertMalePatient();
                }
               else if(femailRadio.Checked == true)
                {
                    InsertFemalePatient();
                }
                else
                {
                    MessageBox.Show("Please select gender for the Patient");
                }
            }
        }
    }
    }

