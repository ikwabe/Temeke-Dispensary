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
    public partial class registerMedicineTab : UserControl
    {
        public static registerMedicineTab _instance;
        public static registerMedicineTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new registerMedicineTab();
                return _instance;
            }
        }
        public registerMedicineTab()
        {
            InitializeComponent();
        }
    }
}
