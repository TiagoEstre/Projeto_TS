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
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        // Detecta o Rato e impede de interagir com a textBoxUsername
        private bool isMouseDown = false;
        private void textBoxNameClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void textBoxNameClient_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            textBoxNameClient.SelectionLength = 0;
        }
        private void textBoxNameClient_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                textBoxNameClient.SelectionLength = 0; // Cancela a seleção durante o arrasto
            }
        }
        private void textBoxNameClient_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            textBoxNameClient.SelectionLength = 0;
        }
        private void textBoxNameClient_Click(object sender, EventArgs e)
        {
            textBoxNameClient.SelectionLength = 0;
        }


        private void PictureBoxClient_Click(object sender, EventArgs e)
        {
            PanelInfChat.Visible = false;

            PanelStatusClient.Visible = true;
        }
        private void PictureBoxArrowBack_Click(object sender, EventArgs e)
        {
            PanelStatusClient.Visible = false;

            PanelInfChat.Visible = true;
        }


        
        private void SendMessage()
        {
            // Obter a mensagem do TextBox
            string message = textBoxMessageChat.Text.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                // Exemplo de ação: Adiciona a mensagem a um ListBox
                listBoxChat.Items.Add(message);

                // Limpa o TextBox após enviar a mensagem
                textBoxMessageChat.Clear();
            }
        }
        private void textBoxMessageChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Envia a mensagem quando a tecla Enter é pressionada
                SendMessage();

                // Indica que o evento foi tratado
                e.Handled = true;

                // Previne que a tecla 'Enter' seja processada pelo controle
                e.SuppressKeyPress = true;
            }
        }
        private void PictureBoxSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void textBoxMessageChat_Enter(object sender, EventArgs e)
        {
            if (textBoxMessageChat.Text == "Escreva sua mensagem")
            {
                textBoxMessageChat.Text = "";

                textBoxMessageChat.ForeColor = Color.White;
            }
        }
        private void textBoxMessageChat_Leave(object sender, EventArgs e)
        {
            if (textBoxMessageChat.Text == "")
            {
                textBoxMessageChat.Text = "Escreva sua mensagem";

                textBoxMessageChat.ForeColor = Color.Silver;
            }
        }




    }
}
