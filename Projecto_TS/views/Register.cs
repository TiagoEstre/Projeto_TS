using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_TS.views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void buttonMaxime_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
            }
        }
        private void buttonMinimed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void buttonClosed_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonrRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
