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
    public partial class dummyTicketTab : UserControl
    {
        public static dummyTicketTab _instance;
        public static dummyTicketTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new dummyTicketTab();
                return _instance;
            }
        }
        public dummyTicketTab()
        {
            InitializeComponent();
           
        }
    }
}
