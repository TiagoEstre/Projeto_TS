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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projecto_TS.views
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            labelUsername.Text = sessionManager.CurrentUser.Name;
        }

        
        private void pictureBoxDefinition_Click(object sender, EventArgs e)
        {
            Definition definition = new Definition();

            definition.ShowDialog();
        }


        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxMesagem.Text.Trim()))
            {
                listBoxMessager.Items.Add(textBoxMesagem.Text.Trim());

                textBoxMesagem.Clear();

                textBoxMesagem.Focus();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();

            if(string.IsNullOrEmpty(searchQuery) )
            {
                textBoxSearch.Text = "Por favor, insira um nome para pesquisar.";
                return;
            }

            using (var db = new ChatContext())
            {
                var results = db.utilizadors
                    .Where(u => u.Name.Contains(searchQuery))
                    .Select(u => new {u.Name, u.Username})
                    .ToList();

                listBoxSearch.Items.Clear();

                foreach (var result in results)
                {
                    listBoxSearch.Items.Add($"{result.Name} ({result.Username})");
                    listBoxSearch.Visible = true;
                }

                if(results.Count == 0)
                {
                    listBoxSearch.Visible = true;
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
            
        }

        

        
    }
}
