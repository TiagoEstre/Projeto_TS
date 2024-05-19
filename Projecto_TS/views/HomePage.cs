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
    public partial class HomePage : Form
    {
        public HomePage()
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


        private void pictureBoxDefinition_Click(object sender, EventArgs e)
        {
            Definition definition = new Definition();

            definition.ShowDialog();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string mesage = textBoxMesagem.Text;

            listBoxMessager.Text = mesage;
        }

       
    }
}
