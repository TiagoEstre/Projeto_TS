using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Projecto_TS.controller;
using System.Xml.Serialization;

namespace Projecto_TS.views
{
    public partial class Settings : Form
    {
        public event EventHandler<string> PhotoUpdated;

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Global.caminhoPhoto;
        string destinoCompleto = "";

        private string NameUser;
        private string Password;
        private string Phone;
        private string Address;

        // Flag para acompanhar se o modo noturno está ativado
        private bool isNightMode = true;

        // Definições de cores para os modos
        private Color dayBackgroundColor = SystemColors.Control;
        private Color nightBackgroundColor = Color.FromArgb(26, 32, 55); // Fundo escuro
        private Color dayTextColor = SystemColors.ControlText;
        private Color nightTextColor = Color.White;


        public Settings()
        {
            InitializeComponent();
            LoadCurrentUser();
            InitializeCustomComponents();
        }

        private void LoadSattus()
        {
            if (sessionManager.IsLoggedIn())
            {
                var currentUser = sessionManager.CurrentUser;

                if(currentUser.Status == "Occupied")
                {
                    CircleProgressBarStatus.ProgressColor = Color.FromArgb(255, 251, 165);
                    CircleProgressBarStatus.ProgressColor2 = Color.FromArgb(120, 171, 0);

                    CircleProgressBarStatus2.ProgressColor = Color.FromArgb(120, 171, 0);
                    CircleProgressBarStatus2.ProgressColor2 = Color.FromArgb(255, 251, 165);
                }
                else if(currentUser.Status == "Offline")
                {
                    CircleProgressBarStatus.ProgressColor = Color.FromArgb(239, 161, 161);
                    CircleProgressBarStatus.ProgressColor2 = Color.FromArgb(154, 26, 26);

                    CircleProgressBarStatus2.ProgressColor = Color.FromArgb(154, 26, 26);
                    CircleProgressBarStatus2.ProgressColor2 = Color.FromArgb(239, 161, 161);
                }
                else if (currentUser.Status == "Online")
                {
                    CircleProgressBarStatus.ProgressColor = Color.FromArgb(120, 180, 30);
                    CircleProgressBarStatus.ProgressColor2 = Color.FromArgb(150, 100, 50);

                    CircleProgressBarStatus2.ProgressColor = Color.FromArgb(150, 100, 50);
                    CircleProgressBarStatus2.ProgressColor2 = Color.FromArgb(120, 180, 30);
                }
            }
        }

        private void LoadCurrentUser()
        {
            if (sessionManager.IsLoggedIn())
            {
                var currentUser = sessionManager.CurrentUser;

                LoadSattus();
                textBoxName.Text = currentUser.Username;
                textBoxPassword.Text = currentUser.Password;
                textBoxPhone.Text = currentUser.Phone.ToString();
                if(currentUser.Photo != null )
                {
                    pictureBoxPhoto.ImageLocation = currentUser.Photo;
                }
                textBoxUsername.Text = currentUser.Username;
            }
        }

        // Insere uma imagem do Pc
        private void PictureBoxPhoto_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            destinoCompleto = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }

            if (File.Exists(destinoCompleto))
            {
                if(MessageBox.Show("Arquivo já existe, deseja substituir?","Substituir",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            System.IO.File.Copy(origemCompleto, destinoCompleto, true);
            if (File.Exists(destinoCompleto))
            {
                pictureBoxPhoto.ImageLocation = destinoCompleto;
                if (sessionManager.IsLoggedIn())
                {
                    using (var db = new ChatContext())
                    {
                        var currentUser = db.utilizadors.Find(sessionManager.CurrentUser.Id);
                        if (currentUser != null)
                        {
                            currentUser.Photo = destinoCompleto;
                            db.SaveChanges();

                            // Atualizar o usuário na sessão
                            sessionManager.CurrentUser.Photo = destinoCompleto;

                            PhotoUpdated?.Invoke(this, destinoCompleto);
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo não copiado");
            }
        }


        // Detecta o Rato e impede de interagir com a textBoxUsername
        private bool isMouseDown = false;
        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void textBoxUsername_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            textBoxUsername.SelectionLength = 0;
        }
        private void textBoxUsername_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                textBoxUsername.SelectionLength = 0; // Cancela a seleção durante o arrasto
            }
        }
        private void textBoxUsername_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            textBoxUsername.SelectionLength = 0;
        }
        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.SelectionLength = 0;
        }


        private void InitializeCustomComponents()
        {
            // Adiciona um botão ao formulário
            Button nightModeButton = new Button();
            nightModeButton.Text = "Toggle Night Mode";
            nightModeButton.Location = new Point(10, 10);
            nightModeButton.Click += new EventHandler(ButtonNightMode_Click);

            // Adiciona uma Label de exemplo
            Label exampleLabel = new Label();
            exampleLabel.Text = "Example Label";
            exampleLabel.Location = new Point(10, 50);
            exampleLabel.Name = "exampleLabel"; 

            // Adiciona uma TextBox de exemplo
            TextBox exampleTextBox = new TextBox();
            exampleTextBox.Text = "Example TextBox";
            exampleTextBox.Location = new Point(10, 90);
            exampleTextBox.Name = "exampleTextBox";

            // Adiciona os controles ao formulário
            this.Controls.Add(nightModeButton);
            this.Controls.Add(exampleLabel);
            this.Controls.Add(exampleTextBox);
        }

        private void ButtonNightMode_Click(object sender, EventArgs e)
        {
            if (isNightMode)
            {
                // Muda para o modo claro
                this.BackColor = dayBackgroundColor;
                ChangeControlsColors(dayTextColor, dayBackgroundColor);
                ButtonNightMode.Text = "NIGHT MODE : OFF";
            }
            else
            {
                // Muda para o modo noturno
                this.BackColor = nightBackgroundColor;
                ChangeControlsColors(nightTextColor, nightBackgroundColor);
                ButtonNightMode.Text = "NIGHT MODE : ON";
            }


            // Alterna o estado do modo noturno
            isNightMode = !isNightMode;
        }
        private void ChangeControlsColors(Color textColor, Color backgroundColor)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label || control is TextBox || control is Button)
                {
                    control.ForeColor = textColor;

                    // Para os TextBoxes e Buttons, também mudamos a cor de fundo
                    if (control is TextBox || control is Button)
                    {
                        control.BackColor = backgroundColor;
                    }
                }
            }
        }


        // Definiçoes dos buttons de Status
        private void ButtonOccupied_CheckedChanged(object sender, EventArgs e)
        {
            CircleProgressBarStatus.ProgressColor = Color.FromArgb(255, 251, 165);
            CircleProgressBarStatus.ProgressColor2 = Color.FromArgb(120, 171, 0);

            CircleProgressBarStatus2.ProgressColor = Color.FromArgb(120, 171, 0);
            CircleProgressBarStatus2.ProgressColor2 = Color.FromArgb(255, 251, 165);

            using (var db = new ChatContext())
            {
                var currentUser = db.utilizadors.Find(sessionManager.CurrentUser.Id);
                if (currentUser != null)
                {
                    currentUser.Status = "Occupied";
                    db.SaveChanges();

                    // Atualizar o usuário na sessão
                    sessionManager.CurrentUser.Status = "Occupied";
                }
            }

        }
        private void ButtonOff_CheckedChanged(object sender, EventArgs e)
        {
            CircleProgressBarStatus.ProgressColor = Color.FromArgb(239, 161, 161);
            CircleProgressBarStatus.ProgressColor2 = Color.FromArgb(154, 26, 26);

            CircleProgressBarStatus2.ProgressColor = Color.FromArgb(154,26,26);
            CircleProgressBarStatus2.ProgressColor2 = Color.FromArgb(239,161,161);

            using (var db = new ChatContext())
            {
                var currentUser = db.utilizadors.Find(sessionManager.CurrentUser.Id);
                if (currentUser != null)
                {
                    currentUser.Status = "Offline";
                    db.SaveChanges();

                    // Atualizar o usuário na sessão
                    sessionManager.CurrentUser.Status = "Offline";
                }
            }
        }
        private void ButtonOn_CheckedChanged(object sender, EventArgs e)
        {
            CircleProgressBarStatus.ProgressColor = Color.FromArgb(120, 180, 30);
            CircleProgressBarStatus.ProgressColor2 = Color.FromArgb(150, 100, 50);

            CircleProgressBarStatus2.ProgressColor = Color.FromArgb(150, 100, 50);
            CircleProgressBarStatus2.ProgressColor2 = Color.FromArgb(120, 180, 30);

            using (var db = new ChatContext())
            {
                var currentUser = db.utilizadors.Find(sessionManager.CurrentUser.Id);
                if (currentUser != null)
                {
                    currentUser.Status = "Online";
                    db.SaveChanges();

                    // Atualizar o usuário na sessão
                    sessionManager.CurrentUser.Status = "Online";
                }
            }
        }


        // Text para alterar o Nome do Usuario
        private void textBoxName_Enter(object sender, EventArgs e)
        {
            textBoxName.Text = NameUser;

            if (textBoxName.Text == NameUser)
            {
                textBoxName.Text = "";

                textBoxName.ForeColor = Color.White;
            }
        }
        private void TextBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = NameUser;

                textBoxName.ForeColor = Color.Silver;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.Text = Password;

            if (textBoxPassword.Text == Password)
            {
                textBoxPassword.Text = "";

                textBoxPassword.ForeColor = Color.White;
            }
        }
        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = Password;

                textBoxPassword.ForeColor = Color.Silver;
            }
        }

        private void TextBoxPhone_Enter(object sender, EventArgs e)
        {
            textBoxPhone.Text = Phone;

            if (textBoxPhone.Text == Phone)
            {
                textBoxPhone.Text = "";

                textBoxPhone.ForeColor = Color.White;
            }
        }
        private void TextBoxPhone_Leave(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "")
            {
                textBoxPhone.Text = Phone;

                textBoxPhone.ForeColor = Color.Silver;
            }
        }

        private void TextBoxAddress_Enter(object sender, EventArgs e)
        {
            TextBoxAddress.Text = Address;

            if (TextBoxAddress.Text == Address)
            {
                TextBoxAddress.Text = "";

                TextBoxAddress.ForeColor = Color.White;
            }
        }
        private void TextBoxAddress_Leave(object sender, EventArgs e)
        {
            if (TextBoxAddress.Text == "")
            {
                TextBoxAddress.Text = Address;

                TextBoxAddress.ForeColor = Color.Silver;
            }
        }


        // Button para alterar o Nome do Usuario
        private void labelChangeName_Click(object sender, EventArgs e)
        {
            NameUser = textBoxName.Text;

            textBoxUsername.Text = NameUser;
        }
        private void labelChangePassword_Click(object sender, EventArgs e)
        {
            Password = textBoxPassword.Text;
        }
        private void labelChangePhone_Click(object sender, EventArgs e)
        {
            Phone = textBoxPhone.Text;
        }
        private void labelChangeAddress_Click(object sender, EventArgs e)
        {
            Address = TextBoxAddress.Text;
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja sair?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Chamar o método de logout para encerrar a sessão do usuário
                sessionManager.Logout();

                // Fechar o formulário Settings
                this.Close();

                // Fechar o formulário HomePage
                var homePage = Application.OpenForms.OfType<HomePage>().FirstOrDefault();
                if (homePage != null)
                {
                    homePage.Close();
                }
            }
        }
    }
}
