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
    public partial class pharmCheckIn : UserControl
    {
        public static pharmCheckIn _instance;
        public static pharmCheckIn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new pharmCheckIn();
                return _instance;
            }
        }
        public pharmCheckIn()
        {
            InitializeComponent();
        }
    }
}
