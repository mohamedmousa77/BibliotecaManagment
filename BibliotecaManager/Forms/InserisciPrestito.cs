using BibliotecaManager.Models;
using System;
using System.Windows.Forms;

namespace BibliotecaManager.Forms
{
    public partial class InserisciPrestitoForm : Form
    {
        public Prestito Prestito { get; private set; }

        public InserisciPrestitoForm()
        {
            InitializeComponent();
        }

        

     

        private void InserisciPrestitoForm_Load(object sender, EventArgs e)
        {

        }

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
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Inserire il nome del Cliente");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLibro.Text))
            {
                MessageBox.Show("Inserire il nome del libro");
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

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}