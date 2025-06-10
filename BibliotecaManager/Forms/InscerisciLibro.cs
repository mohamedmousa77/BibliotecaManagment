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
    public partial class InscerisciLibro : Form
    {
        public Libro Libro { get; private set; }
        public InscerisciLibro()
        {
            InitializeComponent();
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
        private bool ValidaDati()
        {
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
    }
}
