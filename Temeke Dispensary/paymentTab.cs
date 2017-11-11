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
    public partial class paymentTab : UserControl
    {
        public static paymentTab _instance;
        public static paymentTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new paymentTab();
                return _instance;
            }
        }

        public paymentTab()
        {
            InitializeComponent();
        }

        private void labEditBtn_Click(object sender, EventArgs e)
        {
            labPayTxt.Visible = true;
            labPayTxt.Text = "";
            labEditBtn.Visible = false;
            labCost.Visible = false;
        }

        private void labPaidBtn_Click(object sender, EventArgs e)
        {
            labPayTxt.Visible = false;
            labEditBtn.Visible = true;
            labCost.Visible = true;
        }
    }
}
