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
using System.Drawing.Imaging;
using System.IO;

namespace Temeke_Dispensary
{
    public partial class staffRegTab : UserControl
    {
        public static staffRegTab _instance;
        public static staffRegTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new staffRegTab();
                return _instance;
            }
        }

        public staffRegTab()
        {
            InitializeComponent();
        }

        string deptCode;
        string tribeCode;
        string titleCode;
        private void LoadTitle()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string unit = " select title from userstitles_master";

            MySqlCommand com = new MySqlCommand(unit, con);
            DataTable table = new DataTable();

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(unit, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Select");
                com.ExecuteNonQuery();
                TitleCombo.DisplayMember = "title";
                TitleCombo.DataSource = ds.Tables["Select"];
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

        private void LoadDepartments()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string unit = " select departmentname from departments ";

            MySqlCommand com = new MySqlCommand(unit, con);

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(unit, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Select");
                com.ExecuteNonQuery();
                deptCombo.DisplayMember = "departmentname";
                deptCombo.DataSource = ds.Tables["Select"];
                da.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        string location;
        bool photoUpload = false;
        private void uploadPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();

            dg.Filter = "(*.JPG; *.PNG)|*.JPG; *.PNG";
            if(dg.ShowDialog() == DialogResult.OK)
            {
                prflPhoto.Image = Image.FromFile(dg.FileName);
                location = dg.FileName;
                CompressImage();
                photoUpload = true;
            }
        }

        private void UploadPhoto()
        {

        }
        private void phoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void staffRegTab_Load(object sender, EventArgs e)
        {
            //customize the date format

            Birthdate.Format = DateTimePickerFormat.Custom;
            Birthdate.CustomFormat = "yyyy-MM-dd";

            //load the Tittle for the User
            LoadTitle();
            //load tribes 
            LoadTribe();
            //load the departiments
            LoadDepartments();

        }

        //taking the tribe code 
        private void tribeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string unit = " select Tribecode from tribes_master where Tribename = '" + tribeCombo.Text + "' ";
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
        //taking the dept code
        private void deptCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string unit = " select departmentid from departments where departmentname = '" + deptCombo.Text + "' ";
            MySqlCommand com = new MySqlCommand(unit, con);
            MySqlDataReader rd;
            DataTable table = new DataTable();

            try
            {
                con.Open();
                rd = com.ExecuteReader();
                table.Load(rd);

                deptCode = table.Rows[0][0].ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        //taking the title id for users
        private void TitleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;
            string unit = " select titleid from userstitles_master where title = '" + TitleCombo.Text + "' ";
            MySqlCommand com = new MySqlCommand(unit, con);
            MySqlDataReader rd;
            DataTable table = new DataTable();

            try
            {
                con.Open();
                rd = com.ExecuteReader();
                table.Load(rd);

                titleCode = table.Rows[0][0].ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Maleregistration()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            //without the photo
            string register = "insert into users(Fullname,gender,Birthdate,Religion,TribeCode,Nationality,Region,District,Street,TitleCode,Phone,DeptCode,loginname,password,status)" +
                "values('" + FirstNameTxt.Text.ToUpper() + " " + Surnametxt.Text.ToUpper() + "','" + male.Text.Substring(0, 1) + "','" + Birthdate.Text + "','" + religion.Text + "','" + tribeCode + "','" + nationality.Text + "','" + regionListCombobox.Text + "','" +
                districtCombo.Text + "','" + street.Text + "','" + titleCode + "','" + phoneTxt.Text + "','" + deptCode + "','" + Surnametxt.Text.ToLower() + "','default','logout')";

            //if the photo is present
            string registerwithPhoto = "insert into users(Fullname,gender,Birthdate,Religion,TribeCode,Nationality,Region,District,Street,TitleCode,Phone,DeptCode,loginname,password,status,photo)" +
               "values('" + FirstNameTxt.Text.ToUpper() + " " + Surnametxt.Text.ToUpper() + "','" + male.Text.Substring(0, 1) + "','" + Birthdate.Text + "','" + religion.Text + "','" + tribeCode + "','" + nationality.Text + "','" + regionListCombobox.Text + "','" +
               districtCombo.Text + "','" + street.Text + "','" + titleCode + "','" + phoneTxt.Text + "','" + deptCode + "','" + Surnametxt.Text.ToLower() + "','default','logout',@photo)";
            
           

            MySqlDataReader rd;
            try
            {
                con.Open();
                if (FirstNameTxt.Text == ""
                    || Surnametxt.Text == "" 
                    || religion.Text == ""
                    || nationality.Text == "" 
                    || districtCombo.Text == ""
                    || street.Text == "" 
                    || phoneTxt.Text == ""
                    || regionListCombobox.Text == ""
                    || religion.Text == ""
                    || TitleCombo.Text == ""
                    || tribeCombo.Text == ""
                    || districtCombo.Text == ""
                    || deptCombo.Text == ""
                    )
                {
                    MessageBox.Show("Some Fields are not filled, please fill all the field");
                }
                else
                {
                    //upload with profile photo
                    if(photoUpload == true)
                    {
                        MySqlCommand Register = new MySqlCommand(registerwithPhoto, con);
                        byte[] images = null;
                        FileStream stream = new FileStream(@"C:/Users/" + Environment.UserName + "/Pictures/image.jpeg", FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        images = brs.ReadBytes((int)stream.Length);

                        Register.Parameters.AddWithValue("@photo", images);
                        Register.ExecuteNonQuery();
                        

                        FirstNameTxt.Text = "";
                        Surnametxt.Text = "";
                        religion.Text = "";
                        nationality.Text = "";
                        districtCombo.Text = "";
                        street.Text = "";
                        phoneTxt.Text = "";
                        regionListCombobox.Text = "";
                        religion.Text = "";
                        TitleCombo.Text = "";
                        tribeCombo.Text = "";
                        districtCombo.Text = "";
                        deptCombo.Text = "";
                        prflPhoto.Image = null;
                        male.Checked = false;
                        photoUpload = false;
                       // 

                    }

                    //upload without profile photo
                    else
                    {
                        MySqlCommand Register = new MySqlCommand(register, con);
                        rd = Register.ExecuteReader();
                        rd.Close();
                        FirstNameTxt.Text = "";
                        Surnametxt.Text = "";
                        religion.Text = "";
                        nationality.Text = "";
                        districtCombo.Text = "";
                        street.Text = "";
                        phoneTxt.Text = "";
                        regionListCombobox.Text = "";
                        religion.Text = "";
                        TitleCombo.Text = "";
                        tribeCombo.Text = "";
                        districtCombo.Text = "";
                        deptCombo.Text = "";
                        male.Checked = false;
                    }
                      
                }
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
           
           
        }

        private void Femaleregistration()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = login.DBconnection;

            string register = "insert into users(Fullname,gender,Birthdate,Religion,TribeCode,Nationality,Region,District,Street,TitleCode,Phone,DeptCode,loginname,password,status)" +
                "values('" + FirstNameTxt.Text.ToUpper() + " " + Surnametxt.Text.ToUpper() + "','" + female.Text.Substring(0, 1) + "','" + Birthdate.Text + "','" + religion.Text + "','" + tribeCode + "','" + nationality.Text + "','" + regionListCombobox.Text + "','" +
                districtCombo.Text + "','" + street.Text + "','" + titleCode + "','" + phoneTxt.Text + "','" + deptCode + "','" + Surnametxt.Text.ToLower() + "','default','logout')";

            //if the photo is present
            string registerwithPhoto = "insert into users(Fullname,gender,Birthdate,Religion,TribeCode,Nationality,Region,District,Street,TitleCode,Phone,DeptCode,loginname,password,status,photo)" +
               "values('" + FirstNameTxt.Text.ToUpper() + " " + Surnametxt.Text.ToUpper() + "','" + female.Text.Substring(0, 1) + "','" + Birthdate.Text + "','" + religion.Text + "','" + tribeCode + "','" + nationality.Text + "','" + regionListCombobox.Text + "','" +
               districtCombo.Text + "','" + street.Text + "','" + titleCode + "','" + phoneTxt.Text + "','" + deptCode + "','" + Surnametxt.Text.ToLower() + "','default','logout',@photo)";

            MySqlDataReader rd;
            try
            {
                con.Open();
                if (FirstNameTxt.Text == ""
                    || Surnametxt.Text == ""
                    || religion.Text == ""
                    || nationality.Text == ""
                    || districtCombo.Text == ""
                    || street.Text == ""
                    || phoneTxt.Text == ""
                    ||regionListCombobox.Text == ""
                    ||religion.Text == ""
                    ||TitleCombo.Text == ""
                    ||tribeCombo.Text == ""
                    ||districtCombo.Text == ""
                    ||deptCombo.Text == ""
                    )
                {
                    MessageBox.Show("Some Fields are not filled, please fill all the field");
                }
                else
                {
                    //upload with profile photo
                    if (photoUpload == true)
                    {
                        MySqlCommand Register = new MySqlCommand(registerwithPhoto, con);
                        byte[] images = null;
                        FileStream stream = new FileStream(@"C:/Users/" + Environment.UserName + "/Pictures/image.jpeg", FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(stream);
                        images = brs.ReadBytes((int)stream.Length);

                        Register.Parameters.AddWithValue("@photo", images);
                        Register.ExecuteNonQuery();

                        FirstNameTxt.Text = "";
                        Surnametxt.Text = "";
                        religion.Text = "";
                        nationality.Text = "";
                        districtCombo.Text = "";
                        street.Text = "";
                        phoneTxt.Text = "";
                        regionListCombobox.Text = "";
                        religion.Text = "";
                        TitleCombo.Text = "";
                        tribeCombo.Text = "";
                        districtCombo.Text = "";
                        deptCombo.Text = "";
                        prflPhoto.Image = null;
                        female.Checked = false;
                        photoUpload = false;
                       // File.Delete(@"C:/Users/" + Environment.UserName + "/Pictures/image.jpeg");

                    }

                    //upload without profile photo
                    else
                    {
                        MySqlCommand Register = new MySqlCommand(register, con);
                        rd = Register.ExecuteReader();
                        rd.Close();
                        FirstNameTxt.Text = "";
                        Surnametxt.Text = "";
                        religion.Text = "";
                        nationality.Text = "";
                        districtCombo.Text = "";
                        street.Text = "";
                        phoneTxt.Text = "";
                        regionListCombobox.Text = "";
                        religion.Text = "";
                        TitleCombo.Text = "";
                        tribeCombo.Text = "";
                        districtCombo.Text = "";
                        deptCombo.Text = "";
                        female.Checked = false;
                    }

                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
            
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if(male.Checked == true)
            {
                Maleregistration();
            }
            else if(female.Checked == true)
            {
                Femaleregistration();
            }
            else
            {
                MessageBox.Show("Please Select Gender");
            }
        }

        //resize image 
        private void CompressImage()
        {
            // Get a bitmap. The using statement ensures objects  
            // are automatically disposed from memory after use.  
            using (Bitmap bmp1 = new Bitmap(@location))
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                // Create an Encoder object based on the GUID  
                // for the Quality parameter category.  
                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;

                // Create an EncoderParameters object.  
                // An EncoderParameters object has an array of EncoderParameter  
                // objects. In this case, there is only one  
                // EncoderParameter object in the array.  
                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 20L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                bmp1.Save(@"C:/Users/" + Environment.UserName + "/Pictures/image.jpeg", jpgEncoder, myEncoderParameters);
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
