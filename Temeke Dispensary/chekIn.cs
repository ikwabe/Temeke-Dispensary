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
    public partial class chekIn : UserControl
    {
        public static chekIn _instance;
        public static chekIn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new chekIn();
                return _instance;
            }
        }
        public chekIn()
        {
            InitializeComponent();
        }

        private void nameSearchBtn_Click(object sender, EventArgs e)
        {
            patientNames patient = new patientNames();
            patient.Show();
        }
    }
}
