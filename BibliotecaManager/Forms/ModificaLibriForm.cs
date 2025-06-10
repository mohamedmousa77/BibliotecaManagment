using BibliotecaManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaManager.Forms
{
    public partial class ModificaLibriForm : Form
    {
        public Libro libroModificato { get; set; }
        public ModificaLibriForm(Libro libro)
        {
            InitializeComponent();

            if (libro == null)
                throw new ArgumentNullException(nameof(libro));

            libroModificato = libro;
        }


        private void ModificaLibriForm_Load(object sender, EventArgs e)
        {
            Titolotxt.Text = libroModificato.Titolo;
            CasaEditricetxt.Text = libroModificato.CasaEditrice;
            AnnoPubDate.Value = libroModificato.AnnoPubblicazione;
            QtyMagazzino.Value = libroModificato.QuantitaMagazzino;
            Generetxt.Text = libroModificato.Genere;
            ISBNtxt.Text = libroModificato.ISBN;

            this.Text = $"Modifica Libro - {libroModificato.Titolo} " +
                $"{libroModificato.CasaEditrice}" +
                $"{libroModificato.AnnoPubblicazione}" +
                $"{libroModificato.QuantitaMagazzino}" +
                $"{libroModificato.Genere}" +
                $"{libroModificato.ISBN}";

        }

        private void ConfermaBTN_Click(object sender, EventArgs e)
        {
            if (ValidaDati())
            {
                libroModificato.Titolo = Titolotxt.Text.Trim();
                libroModificato.CasaEditrice = CasaEditricetxt.Text.Trim();
                libroModificato.AnnoPubblicazione = AnnoPubDate.Value;
                libroModificato.QuantitaMagazzino = QtyMagazzino.Value;
                libroModificato.Genere = Generetxt.Text.Trim();
                libroModificato.ISBN = ISBNtxt.Text.Trim();


                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private bool ValidaDati()
        {
            if (string.IsNullOrWhiteSpace(Titolotxt.Text))
            {
                MessageBox.Show("Inserire il titolo dell'libro", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Titolotxt.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(CasaEditricetxt.Text))
            {
                MessageBox.Show("Inserire il cognome della Casa Editrice", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CasaEditricetxt.Focus();
                return false;
            }

            if (AnnoPubDate.Value == DateTime.MinValue)
            {
                MessageBox.Show("Inserire una data valida per la pubblicazione", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AnnoPubDate.Focus();
                return false;
            }

            if (QtyMagazzino.Value < 0)
            {
                MessageBox.Show("La quantità in magazzino non può essere negativa", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QtyMagazzino.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(Generetxt.Text))
            {
                MessageBox.Show("Inserire il genere del libro", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Generetxt.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(ISBNtxt.Text))
            {
                MessageBox.Show("Inserire l'ISBN del libro", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ISBNtxt.Focus();
                return false;
            }

            return true;
        }

        private void AnnullaBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void ModificaLibriForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
