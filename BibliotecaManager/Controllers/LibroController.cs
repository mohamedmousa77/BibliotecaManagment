using BibliotecaManager.Models;
using BibliotecaManager.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BibliotecaManager.Controllers
{
    public class LibroController
    {
        public List<Libro> Libri { get; set; } = new List<Libro>();
        private readonly PathController pathController;

        private  List<Prestito> Prestiti;
        private DataStorageService dataService;

        public LibroController(PathController PathController)
        {
            dataService = new DataStorageService();
            pathController = PathController;

            //var (_, _, libri, prestiti) = dataService.CaricaTutti(folderPath);
            //Libri = libri ?? new List<Libro>();
            //Prestiti = prestiti ?? new List<Prestito>();

        }

        public void AggiungiLibro(Libro libro) => Libri.Add(libro);

        public void ModificaLibro(Libro LibroOriginale, Libro LibroModificato)
        {
            int index = Libri.IndexOf(LibroOriginale);

            if (index >= 0) Libri[index] = LibroModificato;
        }

        public bool EliminaLibro(Libro libro)
        {
            MessageBox.Show($"Eliminazione libro in corso... {Prestiti.Count}, {libro.Titolo},  {Prestiti.Any(p => p.LibroPrestato == libro && p.DataDiConsegna == null)}", "Attendere", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (libro == null)
            {
                MessageBox.Show("Il libro da eliminare non può essere null.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Prestiti.Any(p => p.LibroPrestato.ISBN == libro.ISBN))
                 //&& p.DataDiConsegna == null
            {
                MessageBox.Show("Impossibile eliminare il libro, è attualmente in prestito.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Libri.Remove(libro);

            return true;

        }
    }
}
