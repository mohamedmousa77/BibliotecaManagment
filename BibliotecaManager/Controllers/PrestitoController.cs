using BibliotecaManager.Models;
using BibliotecaManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaManager.Controllers
{
    public class PrestitoController
    {
        private DataStorageService dataService;
        //private readonly string folderPath;
        public List<Prestito> Prestiti { get; set; } = new List<Prestito>();

        public PrestitoController()
        {
            dataService = new DataStorageService();
        }
        public bool AggiungiPrestito(Prestito prestito)
        {
            if (prestito.LibroPrestato.QuantitaMagazzino == 0)
            {
                MessageBox.Show("ci sono copie disponibili del libro selezionato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Prestito NuovoPrestito = new Prestito
            {
                Cliente = prestito.Cliente,
                Autore = prestito.Autore,
                LibroPrestato = prestito.LibroPrestato,
                DataPrestito = DateTime.Now,  
                DataScadenza = DateTime.Now.AddDays(30),
                DataDiConsegna = null,

            };

            prestito.LibroPrestato.QuantitaMagazzino -= 1;
            Prestiti.Add(NuovoPrestito);
            return true;
        }

        public void RegistraDiConsegna(Prestito Prestito, DateTime dataDiConsegna, string folderPath)
        {
            MessageBox.Show($"Registra la consegna del libro: {Prestito.LibroPrestato.Titolo} da parte di {Prestito.Cliente.NomeCompleto}", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Prestito.DataDiConsegna == null)
            {
                Prestito.DataDiConsegna = dataDiConsegna;
                Prestito.LibroPrestato.QuantitaMagazzino += 1;

                dataService.SalvaPrestiti(folderPath, Prestiti);

                MessageBox.Show("Libro Consegnato con successo e il DB aggiornato!");
            }
        }

        public int PrestitiInCorso() 
            => Prestiti.Count(Pre => Pre.DataDiConsegna == null);

        public List<Prestito> PrestitiScaduti ()
            => Prestiti.Where(pre => pre.DataDiConsegna == null && pre.DataScadenza < DateTime.Now).ToList();
        
        public double PercentualePrestitiSoci()
        {
            int totale = Prestiti.Count;
            if (totale == 0) return 0.0;

            int soci = Prestiti.Count(p => p.Cliente.Socio);
            return (double)soci/ totale * 100.0;
        }
    }
}