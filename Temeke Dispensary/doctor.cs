using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temeke_Dispensary
{
    public partial class doctor : Form
    {
        public doctor()
        {
            InitializeComponent();
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            line.Width = checkBtn.Width;
            line.Left = checkBtn.Left;
            panel2.Controls.Add(doctCheckInTab.Instance);
            doctCheckInTab.Instance.Dock = DockStyle.Fill;
            doctCheckInTab.Instance.BringToFront();
            doctCheckInTab.Instance.Visible = true;
            patientTreatmentTab.Instance.Visible = false;
            docreportTab.Instance.Visible = false;
        }

        private void patientTrtmntBtn_Click(object sender, EventArgs e)
        {
            line.Width = patientTrtmntBtn.Width;
            line.Left = patientTrtmntBtn.Left;
            panel2.Controls.Add(patientTreatmentTab.Instance);
            patientTreatmentTab.Instance.Dock = DockStyle.Fill;
            patientTreatmentTab.Instance.BringToFront();
            patientTreatmentTab.Instance.Visible = true;
           doctCheckInTab.Instance.Visible = false;
            docreportTab.Instance.Visible = false;
        }

        private void doctor_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            logoAnimator.ShowSync(logo);
        }

        private void repotBtn_Click(object sender, EventArgs e)
        {
            line.Width = repotBtn.Width;
            line.Left = repotBtn.Left;
            panel2.Controls.Add(docreportTab.Instance);
            docreportTab.Instance.Dock = DockStyle.Fill;
            docreportTab.Instance.BringToFront();
            docreportTab.Instance.Visible = true;
            patientTreatmentTab.Instance.Visible = false;
            doctCheckInTab.Instance.Visible = false;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            login lg = new login();
            lg.Show();
        }
    }
}
