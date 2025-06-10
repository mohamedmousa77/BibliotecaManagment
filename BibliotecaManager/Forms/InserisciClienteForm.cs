using BibliotecaManager.Models;
using System;
using System.Windows.Forms;

namespace BibliotecaManager.Forms
{
    public partial class InserisciClienteForm : Form
    {
        public Cliente Cliente { get; private set; }
        public InserisciClienteForm()
        {
            InitializeComponent();
        }

   

        private bool ValidaDati()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Inserire il nome dell'autore");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCognome.Text))
            {
                MessageBox.Show("Inserire il cognome dell'autore");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Inserire la casa editrice");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Inserire la casa editrice");
                return false;
            }
            return true;
        }

        
        private void InserisciClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void txtCognome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCasaEditrice_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnulla_Click_1(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnConferma_Click_1(object sender, EventArgs e)
        {
            if (ValidaDati())
            {
                Cliente = new Cliente
                {
                    Persona = new Persona
                    {
                        ID = Guid.NewGuid().ToString(),
                        Nome = txtNome.Text,
                        Cognome = txtCognome.Text
                    },
                    Telefono = txtPhone.Text,
                    Mail = txtMail.Text,
                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
