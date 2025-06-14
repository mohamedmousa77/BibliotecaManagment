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
            using (var form = new InserisciPrestitoForm(folderPath))
            {
                //var PrestitoController = new PrestitoController();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PrestitiController.AggiungiPrestito(form.Prestito);
                        AggiornaGrid();
                        //storageService.SalvaTutti(folderPath,new List<Autore>(), new List<Cliente>(), new List<Libro>(), PrestitoController.Prestiti);
                        //storageService.SalvaPrestiti(folderPath, PrestitiController.Prestiti);
                        //if (storageService.VerificaSalvataggio(folderPath))
                        //{
                        //    MessageBox.Show($"Dati salvati correttamente ", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    //{ form.Prestito.Autore.NomeCompleto}, { form.Prestito.Cliente.NomeCompleto}
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Errore nella verifica del salvataggio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //}
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Errore durante il salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvPrestito.CurrentRow?.DataBoundItem != null)
            {
                var libroSelezionato = PrestitiController.Prestiti
                    .FirstOrDefault(pres => pres.LibroPrestato.Titolo == dgvPrestito.CurrentRow.Cells["TitoloDelLibro"].Value.ToString());

                MessageBox.Show($"book selected to delete. {libroSelezionato.LibroPrestato.Titolo}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (libroSelezionato != null)
                {
                    PrestitiController.RegistraDiConsegna(libroSelezionato, DateTime.Now, folderPath);
                    AggiornaGrid();
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

                    TitoloDelLibro = a.LibroPrestato?.Titolo,
                    NomeCliente = a.Cliente?.NomeCompleto,
                    NomeAutore = a.Autore?.NomeCompleto,

                    DataPrestito = a.DataPrestito.ToShortDateString(),
                    DataScadenza = a.DataScadenza.ToShortDateString(),
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
                Name = "TitoloDelLibro",
                DataPropertyName = "TitoloDelLibro",
                HeaderText = "Titolo del libro",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPrestito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NomeCliente",
                DataPropertyName = "NomeCliente",
                HeaderText = "Nome Cliente",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPrestito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NomeAutore",
                DataPropertyName = "NomeAutore",
                HeaderText = "Nome Autore",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void PrestitiForm_Load(object sender, EventArgs e)
        {

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

        }

       
    }
}
