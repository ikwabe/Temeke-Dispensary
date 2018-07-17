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
    public partial class pharmacy : Form
    {
        public pharmacy()
        {
            InitializeComponent();
        }

        private void pharmacy_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            logoAnimator.ShowSync(logo);
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            line.Width = checkBtn.Width;
            line.Left = checkBtn.Left;
            panel2.Controls.Add(pharmCheckIn.Instance);
            pharmCheckIn.Instance.Dock = DockStyle.Fill;
            pharmCheckIn.Instance.BringToFront();
            pharmCheckIn.Instance.Visible = true;
            medicine.Instance.Visible = false;
            reportTab.Instance.Visible = false;

        }

        private void medicineBtn_Click(object sender, EventArgs e)
        {
            line.Width = medicineBtn.Width;
            line.Left = medicineBtn.Left;
            panel2.Controls.Add(medicine.Instance);
            medicine.Instance.Dock = DockStyle.Fill;
            medicine.Instance.BringToFront();
            pharmCheckIn.Instance.Visible = false;
            medicine.Instance.Visible = true ;
            reportTab.Instance.Visible = false;
        }

        private void repotBtn_Click(object sender, EventArgs e)
        {
            line.Width = repotBtn.Width;
            line.Left = repotBtn.Left;
           
                panel2.Controls.Add(reportTab.Instance);
                reportTab.Instance.Dock = DockStyle.Fill;
                reportTab.Instance.BringToFront();
                pharmCheckIn.Instance.Visible = false;
                medicine.Instance.Visible = false;
                reportTab.Instance.Visible = true;
           
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            login.logoutSt();
            login.logoutRecord();
            Application.Exit();
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login.logoutSt();
            login.logoutRecord();
            Application.Restart();
        }
    }
}
