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
    public partial class doctVitalTab : UserControl
    {
        public static doctVitalTab _instance;
        public static doctVitalTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new doctVitalTab();
                return _instance;
            }
        }
        public doctVitalTab()
        {
            InitializeComponent();
        }

        private void editVitalBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //panel1.Width = 407;
        }

        private void addVitalBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            //panel1.Width = 0;
        }
    }
}
