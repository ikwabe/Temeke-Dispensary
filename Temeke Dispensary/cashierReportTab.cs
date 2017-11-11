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
    public partial class cashierReportTab : UserControl
    {
        public static cashierReportTab _instance;
        public static cashierReportTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new cashierReportTab();
                return _instance;
            }
        }


        public cashierReportTab()
        {
            InitializeComponent();
        }
    }
}
