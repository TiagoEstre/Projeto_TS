﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;

namespace Projecto_TS.views
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            string message = textBoxMesagem.Text;

            if (!string.IsNullOrEmpty(message))
            {
                listBoxMessager.Items.Add(message);
                textBoxMesagem.Clear();
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
    }
}
