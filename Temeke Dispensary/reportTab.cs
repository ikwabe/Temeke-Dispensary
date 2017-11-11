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
    public partial class reportTab : UserControl
    {
        public static reportTab _instance;
        public static reportTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new reportTab();
                return _instance;
            }
        }
        public reportTab()
        {
            InitializeComponent();
        }

        private void pharmRepotBtn_Click(object sender, EventArgs e)
        {
            reportLabel.Text = "Pharmacy Report";
            searchPanel.Visible = true;
           
        }

        private void labRepotBtn_Click(object sender, EventArgs e)
        {
            reportLabel.Text = "Laboratory Report";
            searchPanel.Visible = true;
        }

        private void docAssRepotBtn_Click(object sender, EventArgs e)
        {
            reportLabel.Text = "Doctor Assessment Report";
            searchPanel.Visible = true;
        }

        private void personRepotBtn_Click(object sender, EventArgs e)
        {
            reportLabel.Text = "Personal Information Report";
            searchPanel.Visible = true;
        }
    }
}
