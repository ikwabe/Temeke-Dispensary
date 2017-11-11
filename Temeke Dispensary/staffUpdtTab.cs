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
    public partial class staffUpdtTab : UserControl
    {
        public static staffUpdtTab _instance;
        public static staffUpdtTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new staffUpdtTab();
                return _instance;
            }
        }
        public staffUpdtTab()
        {
            InitializeComponent();
        }

        private void uploadPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();

            dg.Filter = "(*.JPG; *.PNG)|*.JPG; *.PNG";
            if (dg.ShowDialog() == DialogResult.OK)
            {
                prflPhoto.Image = Image.FromFile(dg.FileName);
            }
        }
    }
}
