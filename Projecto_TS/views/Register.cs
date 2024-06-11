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
    public partial class Register : Form
    {
        public Register()
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


        private void buttonrRegister_Click(object sender, EventArgs e)
        {
            // Valores das TextBox
            string User = textBoxUser.Text;
            string Email = textBoxEmail.Text;
            string Phone = textBoxPhone.Text;
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;
            string ConfirmePassword = textBoxConfirPassword.Text;


            // Verifica se todos os campos estão preenchidos e se a Password e diferente da ConfirmePassword
            if(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Phone) ||  
               string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmePassword))
            {
                labelErro.Visible = true;
                labelErro.Text = "Todos os campos são de preenchimento obrigatório";
                return;
            }
            else if(Password != ConfirmePassword)
            {
                labelErro.Visible = true;
                labelErro.Text = "Password incorreta";
                return;
            }


            // Usando o contexto de banco de dados com as instruções preenchidos
            using (var db = new ChatContext())
            {
                // Cria uma nova instância de Utilizador
                var novoUtilizador = new Utilizador
                {
                    Username = User,
                    Email = Email,
                    Phone = Phone,
                    Name = Username,
                    Password = Password,
                };

                // Adiciona um novo utilizador ao DbSet
                db.Utilizadors.Add(novoUtilizador);

                // Salva as alterações na base de dados
                db.SaveChanges();


                // Fecha o form de Register
                this.Close();


                // Abre o form de Login
                Login login = new Login();
                login.Show();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Fecha o from de Register
            this.Close();

            // Abre o form de Login
            Login login = new Login();
            login.Show();
        }
    }
}
