using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void uploadPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();

            dg.Filter = "(*.JPG; *.PNG)|*.JPG; *.PNG";
            if(dg.ShowDialog() == DialogResult.OK)
            {
                prflPhoto.Image = Image.FromFile(dg.FileName);
            }
        }
    }
}
