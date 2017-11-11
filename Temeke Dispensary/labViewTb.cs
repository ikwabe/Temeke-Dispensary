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
    public partial class labViewTb : UserControl
    {
       
            public static labViewTb _instance;
            public static labViewTb Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new labViewTb();
                    return _instance;
                }
            }

            public labViewTb()
            {
                InitializeComponent();
            }
        
        }
    }

