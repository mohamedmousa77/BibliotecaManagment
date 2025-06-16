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
    public partial class StatisticheForm : Form
    {
        private List<Prestito> prestiti;
        public StatisticheForm(List<Prestito> prestiti)
        {
            InitializeComponent();
            this.prestiti = prestiti;
            verificaDati(prestiti);
        }

        public void verificaDati(List<Prestito> prestiti)
        {
            int inCorso = prestiti.Count(p => p.DataDiConsegna == null);
            int scaduti = prestiti.Count(p => p.DataDiConsegna == null && p.DataScadenza < DateTime.Today);

            //var clientiDaSollecitare = prestiti
            //    .Where(p => p.DataDiConsegna == null && p.DataScadenza < DateTime.Today)
            //    .Select(p => new
            //    {
            //        Cliente = $"{p.Cliente.Persona} {p.Cliente.Persona}",
            //        Mail = p.Cliente.Mail,
            //        Telefono = p.Cliente.Telefono,
            //        Scadenza = p.DataScadenza.ToShortDateString()
            //    }).ToList();

            int prestitiSoci = prestiti.Count(p => p.Cliente.Socio);
            double percentualeSoci = prestiti.Count > 0 ? (prestitiSoci * 100.0) / prestiti.Count : 0;

            // Aggiorna etichette inCorso scaduti
            lblInCorso.Text = inCorso.ToString();
            lblScaduti.Text = scaduti.ToString();
            // Conta i clienti che hanno almeno un prestito
            label8.Text = prestiti.Select(p => p.Cliente).Distinct().Count().ToString();
            // Conta i libri prestati (Attualmente in prestito)
            label7.Text = $"{percentualeSoci} %".ToString();
            //(prestiti.Where(p => p.DataDiConsegna == null).Select(p => p.LibroPrestato.ISBN).Distinct().Count()).ToString();
        }
        private void StatisticheForm_Load(object sender, EventArgs e)
        {
            ScadutiLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AttiviLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            LibriPrestitiLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            UtentiRegistratiLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblScaduti_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
