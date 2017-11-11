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
    public partial class patientTreatmentTab : UserControl
    {
        public static patientTreatmentTab _instance;
        public static patientTreatmentTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new patientTreatmentTab();
                return _instance;
            }
        }
        public patientTreatmentTab()
        {
            InitializeComponent();
        }

        private void sympAssBtn_Click(object sender, EventArgs e)
        {
            line.Width = sympAssBtn.Width;
            line.Left = sympAssBtn.Left;
            panel3.Controls.Add(sympAssTab.Instance);
            sympAssTab.Instance.Dock = DockStyle.Fill;
            sympAssTab.Instance.BringToFront();
            sympAssTab.Instance.Visible = true;
            docLabTab.Instance.Visible = false;
            diagnosisTab.Instance.Visible = false;
            doctVitalTab.Instance.Visible = false;
            treatmentTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;
        }

        private void labBtn_Click(object sender, EventArgs e)
        {
            line.Width = labBtn.Width;
            line.Left = labBtn.Left;
            panel3.Controls.Add(docLabTab.Instance);
            docLabTab.Instance.Dock = DockStyle.Fill;
            docLabTab.Instance.BringToFront();
            docLabTab.Instance.Visible = true;
            sympAssTab.Instance.Visible = false;
            diagnosisTab.Instance.Visible = false;
            doctVitalTab.Instance.Visible = false;
            treatmentTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;

        }

        private void diagnosisBtn_Click(object sender, EventArgs e)
        {
            line.Width = diagnosisBtn.Width;
            line.Left = diagnosisBtn.Left;
            panel3.Controls.Add(diagnosisTab.Instance);
            diagnosisTab.Instance.Dock = DockStyle.Fill;
            diagnosisTab.Instance.BringToFront();
            diagnosisTab.Instance.Visible = true;
            docLabTab.Instance.Visible = false;
            sympAssTab.Instance.Visible = false;
            doctVitalTab.Instance.Visible = false;
            treatmentTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            docLabTab.Instance.Visible = false;
            sympAssTab.Instance.Visible = false;
            diagnosisTab.Instance.Visible = false;
            doctVitalTab.Instance.Visible = false;
            treatmentTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;
        }

        private void vitalBtn_Click(object sender, EventArgs e)
        {
            line.Width = vitalBtn.Width;
            line.Left = vitalBtn.Left;
            panel3.Controls.Add(doctVitalTab.Instance);
            doctVitalTab.Instance.Dock = DockStyle.Fill;
            doctVitalTab.Instance.BringToFront();
            doctVitalTab.Instance.Visible = true;
            diagnosisTab.Instance.Visible = false;
            docLabTab.Instance.Visible = false;
            sympAssTab.Instance.Visible = false;
            treatmentTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;
        }

        private void treatmentBtn_Click(object sender, EventArgs e)
        {
            line.Width = treatmentBtn.Width;
            line.Left = treatmentBtn.Left;
            panel3.Controls.Add(treatmentTab.Instance);
            treatmentTab.Instance.Dock = DockStyle.Fill;
            treatmentTab.Instance.BringToFront();
            treatmentTab.Instance.Visible = true;
            doctVitalTab.Instance.Visible = false;
            diagnosisTab.Instance.Visible = false;
            docLabTab.Instance.Visible = false;
            sympAssTab.Instance.Visible = false;
            docFinishTab.Instance.Visible = false;
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            line.Width = finishBtn.Width;
            line.Left = finishBtn.Left;
            panel3.Controls.Add(docFinishTab.Instance);
            docFinishTab.Instance.Dock = DockStyle.Fill;
            docFinishTab.Instance.BringToFront();
            docFinishTab.Instance.Visible = true;
            treatmentTab.Instance.Visible = false;
            doctVitalTab.Instance.Visible = false;
            diagnosisTab.Instance.Visible = false;
            docLabTab.Instance.Visible = false;
            sympAssTab.Instance.Visible = false;
        }
    }
}
