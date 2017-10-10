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
    }
}
