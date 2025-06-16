using BibliotecaManager.Controllers;
using BibliotecaManager.Models;
using BibliotecaManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaManager.Forms
{
    public partial class Gestione : Form
    {
        private LibroController libriController;
        private DataStorageService storageService;
        private PersonaController PersonaController;
        private string folderPath;
        public Gestione(LibroController controller, DataStorageService storage, string path, PersonaController PersonaCon)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller), "LibroController non puo essere nullo");
            if (storage == null)
                throw new ArgumentNullException(nameof(storage), "DataStorageService non puo essere nullo");
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path), "Folder path non puo essere nullo o vuoto");
         
            InitializeComponent();
            libriController = controller;
            storageService = storage;
            folderPath = path;
            PersonaController = PersonaCon;

            ConfiguraGrid();
            AggiornaGrid();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            using (var form = new InscerisciLibro(folderPath, PersonaController)) 
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        libriController.AggiungiLibro(form.Libro);
                        AggiornaGrid();
                        //storageService.SalvaTutti(folderPath, new List<Autore>(), new List<Cliente>(), libriController.Libri, new List<Prestito>());
                        //storageService.SalvaLibri(folderPath, libriController.Libri);
                        //if (storageService.VerificaSalvataggio(folderPath))
                        //{
                        //    //MessageBox.Show($"Dati salvati correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ConfiguraGrid()
        {
            dgvLibri.AutoGenerateColumns = false;
            dgvLibri.Columns.Clear();

            dgvLibri.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Titolo",
                DataPropertyName = "Titolo",
                HeaderText = "Titolo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvLibri.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CasaEditrice",
                DataPropertyName = "CasaEditrice",
                HeaderText = "Casa Editrice",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvLibri.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AnnoPubblicazione",
                DataPropertyName = "AnnoPubblicazione",
                HeaderText = "Anno Pubblicazione",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvLibri.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "QuantitaMagazzino",
                DataPropertyName = "QuantitaMagazzino",
                HeaderText = "Quantita Magazzino",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            //dgvLibri.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "Autore",
            //    DataPropertyName = "Autore",
            //    HeaderText = "Autore",
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            //});
            dgvLibri.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Genere",
                DataPropertyName = "Genere",
                HeaderText = "Genere",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvLibri.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ISBN",
                DataPropertyName = "ISBN",
                HeaderText = "ISBN",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }

        private void AggiornaGrid()
        {
            try
            {
                dgvLibri.SuspendLayout();
                var dati = libriController.Libri.Select(a => new
                {
                    titolo = a.Titolo,
                    isbn = a.ISBN,
                    QuantitaMagazzino = a.QuantitaMagazzino,
                    casaEditrice = a.CasaEditrice,
                    annoPubblicazione = a.AnnoPubblicazione,
                    genere = a.Genere,
                    //Autore = a.Autore != null ? $"{a.Autore.Nome} {a.Autore.Cognome}" : "Sconosciuto"


                }).ToList();

                dgvLibri.DataSource = null;
                dgvLibri.DataSource = dati;
            }
            finally
            {
                dgvLibri.ResumeLayout();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvLibri.CurrentRow?.DataBoundItem != null)
            {
                var libroSelezionato = libriController.Libri
                    .FirstOrDefault(a => a.Titolo == dgvLibri.CurrentRow.Cells["Titolo"].Value.ToString());

                if (libroSelezionato != null)
                {
                    using (var form = new ModificaLibriForm(libroSelezionato, folderPath))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                storageService.SalvaTutti(folderPath, new List<Autore>() , new List<Cliente>(), libriController.Libri, new List<Prestito>());
                                AggiornaGrid();

                                if (storageService.VerificaSalvataggio(folderPath))
                                {
                                    MessageBox.Show("Modifiche salvate correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Errore durante il salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void LibriForm_Load(object sender, EventArgs e)
        {

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvLibri.CurrentRow?.DataBoundItem != null)
            {
                var libroSelezionato = libriController.Libri
                    .FirstOrDefault(a => a.Titolo == dgvLibri.CurrentRow.Cells["Titolo"].Value.ToString());
                MessageBox.Show($"book selected to delete. {libroSelezionato.Titolo}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (libroSelezionato != null)
                {
                    libriController.EliminaLibro(libroSelezionato);
                    AggiornaGrid();
                }
            }      
        }
    }
}
