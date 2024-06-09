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


        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Simula o clique do button
                ButtonLogin.PerformClick();

                // Indica que o evento foi tratado
                e.Handled = true;

                // Previne que a tecla 'Enter' seja processada pelo controle
                e.SuppressKeyPress = true;
            }
        }
        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Simula o clique do button
                ButtonLogin.PerformClick();

                // Indica que o evento foi tratado
                e.Handled = true;

                // Previne que a tecla 'Enter' seja processada pelo controle
                e.SuppressKeyPress = true;
            }

        }


        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                labelErro.Visible = true;
                labelErro.Text = "Todos os campos são de preenchimento obrigatório";
                return;
            }

            using(var db = new ChatContext())
            {
                var utilizador = db.utilizadors.FirstOrDefault(u => u.Username == username);
                var email = db.utilizadors.FirstOrDefault(e => e.Email == username);

                if(utilizador != null || email != null && utilizador.Password == password)
                {
                    labelErro.Visible = true;
                    labelErro.Text = "Login bem-sucedido ! Bem-Vindo, " + utilizador.Name;

                    HomePage homepage = new HomePage();

                    Hide();
                    homepage.FormClosed += Closed_FormClosed;
                    homepage.ShowDialog();

                }
                else
                {
                    labelErro.Visible = true;
                    labelErro.Text = "Username ou Password incorretos.";
                }
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