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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null && listBox1.SelectedItems.Count > 0)
            {
                textBoxMesagem.Clear();

                textBoxMesagem.Enabled = true;
            }
        }
    }
}
