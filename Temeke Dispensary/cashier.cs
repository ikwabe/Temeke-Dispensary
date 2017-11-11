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
    public partial class cashier : Form
    {
        public cashier()
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

        private void cashier_Load(object sender, EventArgs e)
        {
            timer1.Start();
           /* panel2.Controls.Add(paymentTab.Instance);
            paymentTab.Instance.Dock = DockStyle.Fill;*/

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
            panel2.Controls.Add(cashierReportTab.Instance);
            cashierReportTab.Instance.Visible = true;
            cashierReportTab.Instance.BringToFront();
            paymentTab.Instance.Visible = false;
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            line.Width = paymentBtn.Width;
            line.Left = paymentBtn.Left;
            panel2.Controls.Add(paymentTab.Instance);
            paymentTab.Instance.Visible = true;
            paymentTab.Instance.BringToFront();
            cashierReportTab.Instance.Visible = false;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            login lg = new login();
            lg.Show();

        }
    }
}
