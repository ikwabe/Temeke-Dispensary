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
    public partial class doctCheckInTab : UserControl
    {
       
            public static doctCheckInTab _instance;
            public static doctCheckInTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new doctCheckInTab();
                return _instance;
            }
        }
       
            public doctCheckInTab()
        {
            InitializeComponent();
        }
    }
}
