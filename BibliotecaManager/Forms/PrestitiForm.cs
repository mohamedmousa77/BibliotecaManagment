using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaManager.Controllers;
using BibliotecaManager.Models;
using BibliotecaManager.Services;

namespace BibliotecaManager.Forms
{
    public partial class PrestitiForm : Form
    {
        private PrestitoController PrestitiController;
        private DataStorageService storageService;
        private string folderPath;

        public PrestitiForm(PrestitoController controller, DataStorageService storage, string path)
        {

            InitializeComponent();

            storageService = storage;
            folderPath = path;
            PrestitiController = controller;

            ConfiguraGrid();
            AggiornaGrid(); // Ora mostrerà i dati caricati dal file JSON

        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            using (var form = new InserisciPrestitoForm())
            {
                var PrestitoController = new PrestitoController();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PrestitoController.AggiungiPrestito(form.Prestito);
                        AggiornaGrid();
                        storageService.SalvaTutti(folderPath,new List<Autore>(), new List<Cliente>(), new List<Libro>(), PrestitoController.Prestiti);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AggiornaGrid()
        {
            try
            {
                dgvPrestito.SuspendLayout();


                var dati = PrestitiController.Prestiti.Select(a => new
                {
                    Cliente = a.Cliente,
                    Libro = a.LibroPrestato,
                    DataPrestito = a.DataPrestito,
                    DataScadenza = a.DataScadenza,
                    DataConsegna = a.DataDiConsegna,
                }).ToList();

                dgvPrestito.DataSource = null;
                dgvPrestito.DataSource = dati;
            }
            finally
            {
                dgvPrestito.ResumeLayout();
            }
        }


        private void ConfiguraGrid()
        {
            dgvPrestito.AutoGenerateColumns = false;
            dgvPrestito.Columns.Clear();

            dgvPrestito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nome",
                DataPropertyName = "Nome",
                HeaderText = "Nome",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPrestito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cognome",
                DataPropertyName = "Cognome",
                HeaderText = "Cognome",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPrestito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CasaEditrice",
                DataPropertyName = "CasaEditrice",
                HeaderText = "Casa Editrice",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPrestito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IndiceDiGradimento",
                DataPropertyName = "IndiceDiGradimento",
                HeaderText = "Gradimento",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }

        private void PrestitiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
