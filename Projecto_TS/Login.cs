using Projecto_TS.controller;
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

        // buttons de fecha / minimizar / maxmizar janela
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


        // Funçoes que premitem entrar ao clicar no 'Enter'
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


        // função para fechar o form
        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }


        // button de login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Verifica se os campos todos estão preenchidos
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                labelErro.Visible = true;
                labelErro.Text = "Todos os campos são de preenchimento obrigatório";
                return;
            }

            // Premite usar a Base de Dados 'ChatContext'
            using(var db = new ChatContext())
            {
                // vai buscar o Username na base de dados e vê se igual ao username da textBox
                var utilizador = db.utilizadors.FirstOrDefault(u => u.Username == username || u.Email == username);

                // se for igual entra no if e envia-me para a homePage
                if(utilizador != null && utilizador.Password == password)
                {
                    labelErro.Visible = true;
                    labelErro.Text = "Login bem-sucedido ! Bem-Vindo, " + utilizador.Name;

                    // Armazena o usuário logado na sessão
                    sessionManager.Login(utilizador);

                    HomePage homePage = new HomePage();

                    Hide();
                    homePage.FormClosed += Closed_FormClosed;
                    homePage.ShowDialog();

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