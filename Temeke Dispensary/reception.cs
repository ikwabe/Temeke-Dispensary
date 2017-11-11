using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Temeke_Dispensary
{
    public partial class reception : Form
    {
        public reception()
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

        private void reception_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
           logoAnimator.ShowSync(logo);
            
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
           
            
            line.Width = regBtn.Width;
            line.Left = regBtn.Left;
            panel2.Controls.Add(registrationTab.Instance);
            registrationTab.Instance.Dock = DockStyle.Fill;
            registrationTab.Instance.BringToFront();
            registrationTab.Instance.Visible = true;
            chekIn.Instance.Visible = false;
            patientNameListGrid.Visible = false;
            dummyTicketTab.Instance.Visible = false;

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
           
           
            line.Width = checkBtn.Width;
            line.Left = checkBtn.Left;
            panel2.Controls.Add(chekIn.Instance);
            chekIn.Instance.Dock = DockStyle.Fill;
            chekIn.Instance.BringToFront();
            patientNameListGrid.Visible = true;
            chekIn.Instance.Visible = true;
            dummyTicketTab.Instance.Visible = false;
            registrationTab.Instance.Visible = false;
        }

        private void dummyBtn_Click(object sender, EventArgs e)
        {
            line.Left = dummyBtn.Left;
            line.Width = dummyBtn.Width;
            panel2.Controls.Add(dummyTicketTab.Instance);
            dummyTicketTab.Instance.Dock = DockStyle.Fill;
            dummyTicketTab.Instance.BringToFront();
            dummyTicketTab.Instance.Visible = true;
            chekIn.Instance.Visible = false;
            registrationTab.Instance.Visible = false;
            patientNameListGrid.Visible = false;

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            login lg = new login();
            lg.Show();
        }
    }
}
