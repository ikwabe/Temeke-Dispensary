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

    public partial class editMedTab : UserControl
    {
        public static editMedTab _instance;
        public static editMedTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new editMedTab();
                return _instance;
            }
        }
        public editMedTab()
        {
            InitializeComponent();
        }
    }
}
