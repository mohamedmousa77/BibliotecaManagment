using BibliotecaManager.Controllers;
using BibliotecaManager.Models;
using BibliotecaManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BibliotecaManager.Forms
{
    public partial class InscerisciLibro : Form
    {
        public Libro Libro { get; private set; }

        private List<Autore> listaAutori;
        private Autore autoreSelezionato;
        private PersonaController personaController;
        private PathController pathController;
        public InscerisciLibro(string folderPath, PersonaController PersonaC)
        {
            InitializeComponent();
            pathController = new PathController();
            personaController = PersonaC;
            CaricaAutori(folderPath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidaDati())
            {
                Libro = new Libro
                {
                     AnnoPubblicazione = AnnoPubDate.Value,
                     CasaEditrice = CasaEditricetxt.Text,
                     Genere = Generetxt.Text,
                     ISBN = ISBNtxt.Text,
                     QuantitaMagazzino = QtyMagazzino.Value,
                     Titolo = Titolotxt.Text,

                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CaricaAutori(string folderPath)
        {
            //var storageService = new DataStorageService();
            //var (autori, _, _, _) = storageService.CaricaTutti(pathController.FolderPath);

            //if (autori == null || autori.Count == 0)
            //{
            //    MessageBox.Show(
            //        "Non sono presenti autori nel database.\n\n" +
            //        "Per favore, aggiungi almeno un autore prima di inserire un prestito.",
            //        "Attenzione",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);

            //    autoriComboBox.DataSource = null;
            //    autoreSelezionato = null;
            //    return;
            //}

            var autori = personaController.Autori;
            if (autori == null || autori.Count == 0)
            {
                MessageBox.Show(
                    "Non sono presenti autori nel database.\n\n" +
                    "Per favore, aggiungi almeno un autore prima di inserire un prestito.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                autoriComboBox.DataSource = null;
                autoreSelezionato = null;
                return;
            }
            listaAutori = autori;

            autoriComboBox.DataSource = listaAutori;
            autoriComboBox.DisplayMember = "NomeCompleto";
            autoriComboBox.ValueMember = "ID";
        }
        private bool ValidaDati()
        {
            if (string.IsNullOrWhiteSpace(autoreSelezionato.NomeCompleto))
            {
                MessageBox.Show("Seleziona autore");
                return false;
            }
            if (AnnoPubDate.Value == null)
            {
                MessageBox.Show($"Inserire l'anno di publicazione {AnnoPubDate.Value}");
                return false;
            }
            if (string.IsNullOrWhiteSpace(CasaEditricetxt.Text))
            {
                MessageBox.Show($"Inserire il nome della Casa Editrice{CasaEditricetxt.Text}");
                return false;
            }
            if (string.IsNullOrWhiteSpace(Generetxt.Text))
            {
                MessageBox.Show($"Inserire lo Genere Del Libro {Generetxt.Text}");
                return false;
            }
            if (string.IsNullOrWhiteSpace(ISBNtxt.Text))
            {
                MessageBox.Show($"Inserire l'ISBN {ISBNtxt.Text}");
                return false;
            }
            if (QtyMagazzino == null)
            {
                MessageBox.Show($"Inserire la Quantita in magazzino {QtyMagazzino.Value}");
                return false;
            }
            if (string.IsNullOrWhiteSpace(Titolotxt.Text))
            {
                MessageBox.Show($"Inserire il Titolo {Titolotxt.Text}");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AnnoPubDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void qtymagtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void QtyMagazzino_ValueChanged(object sender, EventArgs e)
        {

        }

        private void autoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (autoriComboBox.SelectedItem is Autore autore)
            {
                autoreSelezionato = autore;
                //MessageBox.Show($"Autore selezionato: {autore.NomeCompleto}", "Autore Selezionato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //else
            //{
            //    MessageBox.Show("Seleziona un autore non valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void InscerisciLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
