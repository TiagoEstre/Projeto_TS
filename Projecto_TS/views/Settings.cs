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
    public partial class Settings : Form
    {
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

            InitializeCustomComponents();
        }

        // Insere uma imagem do Pc
        private void PictureBoxPhoto_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Define os filtros de arquivo - você pode adicionar mais formatos de imagem se necessário
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select an Image File";

            // Abre a caixa de diálogo para selecionar um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Carrega a imagem selecionada na PictureBox
                    PictureBoxPhoto.Image = new System.Drawing.Bitmap(openFileDialog.FileName);

                    // Ajusta o SizeMode para ajustar a imagem no PictureBox
                    PictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
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

        }
        private void ButtonOff_CheckedChanged(object sender, EventArgs e)
        {
            CircleProgressBarStatus.ProgressColor = Color.FromArgb(239, 161, 161);
            CircleProgressBarStatus.ProgressColor2 = Color.FromArgb(154, 26, 26);

            CircleProgressBarStatus2.ProgressColor = Color.FromArgb(154,26,26);
            CircleProgressBarStatus2.ProgressColor2 = Color.FromArgb(239,161,161);
        }
        private void ButtonOn_CheckedChanged(object sender, EventArgs e)
        {
            CircleProgressBarStatus.ProgressColor = Color.FromArgb(120, 180, 30);
            CircleProgressBarStatus.ProgressColor2 = Color.FromArgb(150, 100, 50);

            CircleProgressBarStatus2.ProgressColor = Color.FromArgb(150, 100, 50);
            CircleProgressBarStatus2.ProgressColor2 = Color.FromArgb(120, 180, 30);
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
            TextBoxPassword.Text = Password;

            if (TextBoxPassword.Text == Password)
            {
                TextBoxPassword.Text = "";

                TextBoxPassword.ForeColor = Color.White;
            }
        }
        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "")
            {
                TextBoxPassword.Text = Password;

                TextBoxPassword.ForeColor = Color.Silver;
            }
        }

        private void TextBoxPhone_Enter(object sender, EventArgs e)
        {
            TextBoxPhone.Text = Phone;

            if (TextBoxPhone.Text == Phone)
            {
                TextBoxPhone.Text = "";

                TextBoxPhone.ForeColor = Color.White;
            }
        }
        private void TextBoxPhone_Leave(object sender, EventArgs e)
        {
            if (TextBoxPhone.Text == "")
            {
                TextBoxPhone.Text = Phone;

                TextBoxPhone.ForeColor = Color.Silver;
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
            Password = TextBoxPassword.Text;
        }
        private void labelChangePhone_Click(object sender, EventArgs e)
        {
            Phone = TextBoxPhone.Text;
        }
        private void labelChangeAddress_Click(object sender, EventArgs e)
        {
            Address = TextBoxAddress.Text;
        }

        
    }
}
