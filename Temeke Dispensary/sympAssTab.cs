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
    public partial class sympAssTab : UserControl
    {
        public static sympAssTab _instance;
        public static sympAssTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new sympAssTab();
                return _instance;
            }
        }
        public sympAssTab()
        {
            InitializeComponent();
        }
    }
}
