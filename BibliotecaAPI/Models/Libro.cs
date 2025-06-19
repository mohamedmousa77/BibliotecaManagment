using System;

namespace BibliotecaManager.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Titolo { get; set; }
        public string CasaEditrice { get; set; }
        public DateTime AnnoPubblicazione { get; set; }
        public string Genere { get; set; }
        public decimal QuantitaMagazzino { get; set; }
        public Autore Autore { get; set; }
    }

}
