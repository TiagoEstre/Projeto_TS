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
    public partial class Message : Form
    {
        private Form formAtivo;

        public Message()
        {
            InitializeComponent();
        }

        private void trocarFormMessage(Form novoForm)
        {
            if (formAtivo != null)
            {
                formAtivo.Close();
                panelChat.Controls.Remove(formAtivo);
            }

            formAtivo = novoForm;
            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;

            panelChat.Controls.Add(novoForm);
            novoForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trocarFormMessage(new Chat());
        }
    }
}
