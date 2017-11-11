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
    public partial class medicine : UserControl
    {
        public static medicine _instance;
        public static medicine Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new medicine();
                return _instance;
            }
        }
        public medicine()
        {
            InitializeComponent();
        }

        private void regMedBtn_Click(object sender, EventArgs e)
        {
            line.Width = regMedBtn.Width;
            line.Left = regMedBtn.Left;
            panel2.Controls.Add(registerMedicineTab.Instance);
            registerMedicineTab.Instance.Dock = DockStyle.Fill;
            registerMedicineTab.Instance.BringToFront();
            registerMedicineTab.Instance.Visible = true;
            allMedTab.Instance.Visible = false;
            editMedTab.Instance.Visible = false;


        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            line.Width = viewBtn.Width;
            line.Left = viewBtn.Left;
            panel2.Controls.Add(allMedTab.Instance);
            allMedTab.Instance.Dock = DockStyle.Fill;
            allMedTab.Instance.BringToFront();
            registerMedicineTab.Instance.Visible = false;
            editMedTab.Instance.Visible = false;
            allMedTab.Instance.Visible = true;
            

        }

        private void editMedBtn_Click(object sender, EventArgs e)
        {
            line.Width = editMedBtn.Width;
            line.Left = editMedBtn.Left;
            panel2.Controls.Add(editMedTab.Instance);
            editMedTab.Instance.Dock = DockStyle.Fill;
            editMedTab.Instance.BringToFront();
            registerMedicineTab.Instance.Visible = false;
            allMedTab.Instance.Visible = false;
            editMedTab.Instance.Visible = true;

        }
    }
}
