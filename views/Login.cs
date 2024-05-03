using Projecto_TS.models;
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
    public List<Utilizadores> utilizadores;
    public partial class Login : Form
    {
        public Login()
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

        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (username == "Tiago" && password == "1234")
            {
                HomePage homepage = new HomePage();

                Hide();
                homepage.FormClosed += Closed_FormClosed;
                homepage.ShowDialog();
            }
            else if (username == "" && password == "")
            {
                labelErro.Text = "Insira credênciais";
                labelErro.Visible = true;
                labelErro.ForeColor = Color.Yellow;
            }
            else if (username != "Tiago")
            {
                labelErro.Text = "Utilizador não tem conta";
                labelErro.Visible = true;
                labelErro.ForeColor = Color.Yellow;
            }
            else if (username == "Tiago" && password != "1234")
            {
                labelErro.Text = "Utilizador ou Palavra-Passe incorreto!";
                labelErro.Visible = true;
                labelErro.ForeColor = Color.Yellow;
            }
        }
        private void buttonrRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            Hide();
            register.FormClosed += Closed_FormClosed;
            register.ShowDialog();
        }        
    }
}