using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Temeke_Dispensary
{
    public partial class laboratory : Form
    {
        public laboratory()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            line.Width = viewBtn.Width;
            line.Left = viewBtn.Left;
            panel2.Controls.Add(labViewTb.Instance);
            labViewTb.Instance.Dock = DockStyle.Fill;
            labViewTb.Instance.BringToFront();
            labViewTb.Instance.Visible = true;
            labreportTab.Instance.Visible = false;
            measurementTab.Instance.Visible = false;
           
        }

        private void measureBtn_Click(object sender, EventArgs e)
        {
            line.Width = measureBtn.Width;
            line.Left = measureBtn.Left;
            panel2.Controls.Add(measurementTab.Instance);
            measurementTab.Instance.Dock = DockStyle.Fill;
            measurementTab.Instance.BringToFront();
            measurementTab.Instance.Visible = true;
            labViewTb.Instance.Visible = false;
            labreportTab.Instance.Visible = false;
           
        }

        private void repotBtn_Click(object sender, EventArgs e)
        {
            line.Width = repotBtn.Width;
            line.Left = repotBtn.Left;
            panel2.Controls.Add(labreportTab.Instance);
            labreportTab.Instance.Dock = DockStyle.Fill;
            labreportTab.Instance.BringToFront();
            labreportTab.Instance.Visible = true;
            measurementTab.Instance.Visible = false;
            labViewTb.Instance.Visible = false;
           
        }

        private void laboratory_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
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

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            login lg = new login();
            lg.Show();
        }
    }
}
