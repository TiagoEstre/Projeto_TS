using Projecto_TS.controller;
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
    public partial class Definition : Form
    {
        public Definition()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void radioButtonOn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOn.Checked)
            {
                sessionManager.CurrentUser.Status = "Online";
            }

        }

        private void radioButtonOcupado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOcupado.Checked)
            {
                sessionManager.CurrentUser.Status = "Ocupado";
            }

        }

        private void radioButtonOffline_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOffline.Checked)
            {
                sessionManager.CurrentUser.Status = "Offline";
            }

        }
    }
}
