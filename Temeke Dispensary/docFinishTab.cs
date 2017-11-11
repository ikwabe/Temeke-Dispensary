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
    public partial class docFinishTab : UserControl
    {
        public static docFinishTab _instance;
        public static docFinishTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new docFinishTab();
                return _instance;
            }
        }
        public docFinishTab()
        {
            InitializeComponent();
        }

        private void finalCommentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(finalCommentcomboBox.SelectedItem.ToString()== "Transfer")
            {
                panel2.Visible = true;
                confirmBtn.Visible = false;    
            }
            else
            {
                panel2.Visible = false;
                confirmBtn.Visible = true;
            }
        }
    }
}
