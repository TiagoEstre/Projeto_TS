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

        private void buttonrRegister_Click(object sender, EventArgs e)
        {
            // Valores das TextBox
            string Username = textBoxUsername.Text;
            string Email = textBoxEmail.Text;
            string Phone = textBoxPhone.Text;
            string User = textBoxUser.Text;
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
                    Username = Username,
                    Email = Email,
                    Numero = Phone,
                    Name = User,
                    Password = Password,
                };

                // Adiciona um novo utilizador ao DbSet
                db.utilizadors.Add(novoUtilizador);

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
