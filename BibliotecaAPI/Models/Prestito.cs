using System;

namespace BibliotecaManager.Models
{
    public class Prestito
    {
        public int Id { get; set; }
        public Cliente Cliente { get;    set; }    

        public Libro LibroPrestato { get;  set; }

        public Autore Autore { get; set; }

        public DateTime DataPrestito { get;  set; }
        public DateTime DataScadenza { get;  set; }

        public DateTime? DataDiConsegna { get;   set; }
    }
}
