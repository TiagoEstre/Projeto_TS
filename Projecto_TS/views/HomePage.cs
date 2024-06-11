using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Projecto_TS.models;
using Projecto_TS.controller;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;
using System.Net.Http;
using System.Net;

namespace Projecto_TS.views
{
    public partial class HomePage : Form
    {
        private const int PORT = 500;
        NetworkStream networkStream;
        TcpClient tcpClient;
        ProtocolSI protocolSI;

        public HomePage()
        {
            InitializeComponent();
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, PORT);
            tcpClient = new TcpClient();
            tcpClient.Connect(endPoint);
            networkStream = tcpClient.GetStream();
            protocolSI = new ProtocolSI();
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            string msg = textBoxMesagem.Text;
            textBoxMesagem.Clear();

            byte[] packet = protocolSI.Make(ProtocolSICmdType.DATA, msg);
            networkStream.Write(packet, 0, packet.Length);
            while (protocolSI.GetCmdType() != ProtocolSICmdType.ACK ) 
            { 
                networkStream.Read(protocolSI.Buffer,0,protocolSI.Buffer.Length);
            }
        }


        private void pictureBoxDefinition_Click(object sender, EventArgs e)
        {
            Definition definition = new Definition();

            definition.ShowDialog();
        }

<<<<<<< HEAD

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxMesagem.Text.Trim()))
            {
                listBoxMessager.Items.Add(textBoxMesagem.Text.Trim());

                textBoxMesagem.Clear();

                textBoxMesagem.Focus();
            }
        }


=======
>>>>>>> 42af38f5b1fe79dc715bdf721cedc8022430ef8e
        private void button3_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                textBoxSearch.Text = "Por favor, insira um nome para pesquisar.";
                return;
            }

            using (var db = new ChatContext())
            {
                var results = db.Utilizadors
                    .Where(u => u.Name.Contains(searchQuery) && u.Username != sessionManager.CurrentUser.Username)
                    .ToList();

                listBoxSearch.Items.Clear();

                foreach (var result in results)
                {
                    listBoxSearch.Items.Add(result);
                }

                if (results.Count == 0)
                {
                    listBoxSearch.Items.Add("Nenhum resultado encontrado.");
                }
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                using (var db = new ChatContext())
                {
                    var results = db.utilizadors
                        .Where(u => u.Name.Contains(searchQuery))
                        .Select(u => new { u.Name, u.Username })
                        .ToList();

                    listBoxSearch.Items.Clear();

                    if (results.Count > 0)
                    {
                        foreach (var result in results)
                        {
                            listBoxSearch.Items.Add($"{result.Name} ({result.Username})");
                        }
                        listBoxSearch.Visible = true; // Mostrar a ListBox
                    }
                    else
                    {
                        listBoxSearch.Items.Add("Nenhum resultado encontrado.");
                        listBoxSearch.Visible = true; // Mostrar a ListBox mesmo se não houver resultados
                    }
                }
            }
            else
            {
                listBoxSearch.Visible = false; // Esconder a ListBox se a busca estiver vazia
            }
        }
        private void listBoxSearch_Leave(object sender, EventArgs e)
        {
            listBoxSearch.Visible = false;
        }
        private void HomePage_Leave(object sender, EventArgs e)
        {
            listBoxSearch.Visible = false;
        }
        private void panel3_Leave(object sender, EventArgs e)
        {
            listBoxSearch.Visible = false;
        }
        private void listBoxMessager_Leave(object sender, EventArgs e)
        {
            listBoxSearch.Visible = false;
        }


        private void listBoxSearch_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxSearch.SelectedItems != null && listBoxSearch.SelectedItems.Count > 0)
            {
                var selectedUser = (Utilizador)listBoxSearch.SelectedItem;
                string selectedName = selectedUser.Name;
                string selectedUsername = selectedUser.Username;
                string formattedAccount = $"{selectedName} ({selectedUsername})";

                string loggedInUsername = sessionManager.CurrentUser.Username;

                if (selectedUsername == loggedInUsername)
                {
                    MessageBox.Show("Você não pode adicionar a conta que está logada.");
                }
                else if (!listBox1.Items.Contains(formattedAccount))
                {
                    listBox1.Items.Add(formattedAccount);
                }
                else
                {
                    MessageBox.Show("Esta conta já foi adicionada.");
                }
            } 
            
        }

<<<<<<< HEAD
        

        
=======
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null && listBox1.SelectedItems.Count > 0)
            {
                textBoxMesagem.Clear();

                textBoxMesagem.Enabled = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
>>>>>>> 42af38f5b1fe79dc715bdf721cedc8022430ef8e
    }
}
