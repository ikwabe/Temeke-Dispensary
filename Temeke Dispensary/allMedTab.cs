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
    public partial class allMedTab : UserControl
    {
        public static allMedTab _instance;
        public static allMedTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new allMedTab();
                return _instance;
            }
        }
        public allMedTab()
        {
            InitializeComponent();
        }
    }
}
