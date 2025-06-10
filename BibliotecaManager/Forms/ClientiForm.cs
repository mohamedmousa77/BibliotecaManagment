using BibliotecaManager.Controllers;
using BibliotecaManager.Models;
using BibliotecaManager.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BibliotecaManager.Forms
{
    public partial class ClientiForm : Form
    {
        private PersonaController personaController;
        private DataStorageService storageService;
        private string folderPath;

        public ClientiForm(PersonaController controller, DataStorageService storage, string path)
        {
            InitializeComponent();

            personaController = controller;
            storageService = storage;
            folderPath = path;

            ConfiguraGrid();
            AggiornaGrid(); 
        }

        private void ConfiguraGrid()
        {
            dgvClienti.AutoGenerateColumns = false;
            dgvClienti.Columns.Clear();

            dgvClienti.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nome",
                DataPropertyName = "Nome",
                HeaderText = "Nome",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClienti.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cognome",
                DataPropertyName = "Cognome",
                HeaderText = "Cognome",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClienti.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Mail",
                DataPropertyName = "Mail",
                HeaderText = "E-main",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClienti.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                DataPropertyName = "Phone",
                HeaderText = "Phone",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }

        private void AggiornaGrid()
        {
            try
            {
                dgvClienti.SuspendLayout();
                var dati = personaController.Clienti.Select(a => new
                {
                    Nome = a.Persona.Nome,
                    Cognome = a.Persona.Cognome,
                    Phone = a.Telefono,
                    Mail = a.Mail   
                }).ToList();

                dgvClienti.DataSource = null;
                dgvClienti.DataSource = dati;
            }
            finally
            {
                dgvClienti.ResumeLayout();
            }
        }
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            using (var form = new InserisciClienteForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        personaController.AggiungiCliente(form.Cliente);
                        AggiornaGrid();
                        storageService.SalvaTutti(folderPath, new List<Autore>() ,personaController.Clienti, new List<Libro>(), new List<Prestito>());

                        if (storageService.VerificaSalvataggio(folderPath))
                        {
                            MessageBox.Show($"Dati salvati correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Errore nella verifica del salvataggio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Errore durante il salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClientiForm_Load(object sender, EventArgs e)
        {

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

        }
    }
}
