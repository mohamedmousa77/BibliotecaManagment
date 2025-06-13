using BibliotecaManager.Models;
using BibliotecaManager.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaManager.Forms
{
    public partial class InserisciPrestitoForm : Form
    {
        public Prestito Prestito { get; private set; }

        private List<Cliente> listaClienti;
        private Cliente clienteSelezionato;

        private List<Autore> listaAutori;
        private Autore autoreSelezionato;

        private List<Libro> listaLibri;
        private Libro libroSelezionato;

        public InserisciPrestitoForm(string folderPath)
        {
            InitializeComponent();
            CaricaClienti(folderPath);
            CaricaAutori(folderPath);
            CaricaLibri(folderPath);

        }




        private bool CaricaClienti(string folderPath)
        {
            var storageService = new DataStorageService();
            var (_, clienti, _, _) = storageService.CaricaTutti(folderPath);

            if (clienti == null || clienti.Count == 0)
            {
                MessageBox.Show(
                    "Non sono presenti clienti nel database.\n\n" +
                    "Per favore, aggiungi almeno un cliente prima di inserire un prestito.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                clienteComboBox.DataSource = null;
                clienteSelezionato = null;
                return false;
            }

            listaClienti = clienti;

            clienteComboBox.DataSource = listaClienti;
            clienteComboBox.DisplayMember = "NomeCOmpleto";
            clienteComboBox.ValueMember = "Mail";
            return true;
        }

        
        private bool CaricaLibri(string folderPath)
        {
            var storageService = new DataStorageService();
            var (_, _, libri, _) = storageService.CaricaTutti(folderPath);

            if (libri == null || libri.Count == 0)
            {
                MessageBox.Show(
                    "Non sono presenti libri nel database.\n\n" +
                    "Per favore, aggiungi almeno un libro prima di inserire un prestito.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                clienteComboBox.DataSource = null;
                libroSelezionato = null;
                return false;
            }


            listaLibri = libri;

            clienteComboBox.DataSource = listaLibri;
            clienteComboBox.DisplayMember = "Titolo";
            clienteComboBox.ValueMember = "ISBN";
            return true;
        }
        private bool CaricaAutori(string folderPath)
        {
            var storageService = new DataStorageService();
            var (autori, _, _, _) = storageService.CaricaTutti(folderPath);

            if (autori == null || autori.Count == 0)
            {
                MessageBox.Show(
                    "Non sono presenti autori nel database.\n\n" +
                    "Per favore, aggiungi almeno un autore prima di inserire un prestito.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                clienteComboBox.DataSource = null;
                autoreSelezionato = null;
                return false;
            }


            listaAutori = autori;

            clienteComboBox.DataSource = listaAutori;
            clienteComboBox.DisplayMember = "NomeCompleto";
            clienteComboBox.ValueMember = "ID";
            return true;
        }

        private void InserisciPrestitoForm_Load(object sender, EventArgs e){ }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidaDati())
            {
                Prestito = new Prestito
                {
                    Cliente = new Cliente(),
                    LibroPrestato = new Libro(),
                    
                    DataPrestito = dataPrestito.Value,
                    DataScadenza = dataScadenza.Value,
                    DataDiConsegna = dataConsegna.Value,

                };

                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private bool ValidaDati()
        {
            if (string.IsNullOrWhiteSpace(clienteSelezionato.Persona.Nome))
            {
                MessageBox.Show("Seleziona un cliente");
                return false;
            }
            if (string.IsNullOrWhiteSpace(autoreSelezionato.Nome))
            {
                MessageBox.Show("Seleziona un autore");
                return false;
            }
            if (string.IsNullOrWhiteSpace(libroSelezionato.ISBN))
            {
                MessageBox.Show("Seleziona un libro");
                return false;
            }
            if (dataPrestito.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Seleziona una data valida.");
                return false;
            }

            if (dataScadenza.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Seleziona una data valida.");
                return false;
            }
            if (dataConsegna.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Seleziona una data valida.");
                return false;
            }
            
            return true;
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
        private void clienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clienteComboBox.SelectedItem is Cliente cliente)
            {
                clienteSelezionato = cliente;
            }
        }

        private void autoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (autoriComboBox.SelectedItem is Autore autore)
            {
                autoreSelezionato = autore;
            }
        }

        private void libroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (libroComboBox.SelectedItem is Libro libro)
            {
                libroSelezionato = libro;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}