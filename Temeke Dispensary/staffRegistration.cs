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
    public partial class staffRegistration : Form
    {
        public staffRegistration()
        {
            InitializeComponent();
        }

        private void staffRegistration_Load(object sender, EventArgs e)
        {
            timer1.Start();
            line.Width = regBtn.Width;
            line.Left = regBtn.Left;
            panel2.Controls.Add(staffRegTab.Instance);
            staffRegTab.Instance.Dock = DockStyle.Fill;
            staffRegTab.Instance.BringToFront();
            staffRegTab.Instance.Visible = true;
            staffUpdtTab.Instance.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            logoAnimator.ShowSync(logo);
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            line.Width = regBtn.Width;
            line.Left = regBtn.Left;
            panel2.Controls.Add(staffRegTab.Instance);
            staffRegTab.Instance.Dock = DockStyle.Fill;
            staffRegTab.Instance.BringToFront();
            staffRegTab.Instance.Visible = true;
            staffUpdtTab.Instance.Visible = false;


        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            line.Width = updBtn.Width;
            line.Left = updBtn.Left;
            panel2.Controls.Add(staffUpdtTab.Instance);
            staffUpdtTab.Instance.Dock = DockStyle.Fill;
            staffUpdtTab.Instance.BringToFront();
            staffRegTab.Instance.Visible = false;
            staffUpdtTab.Instance.Visible = true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            login lg = new login();
            lg.Show();
        }
    }
}
