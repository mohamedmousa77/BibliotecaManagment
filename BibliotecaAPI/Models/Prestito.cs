using System;
using System.Text.Json.Serialization;

namespace BibliotecaManager.Models
{
    public class Prestito
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("cliente")]
        public Cliente Cliente { get;    set; }
        [JsonPropertyName("libroPrestato")]
        public Libro LibroPrestato { get;  set; }
        [JsonPropertyName("autore")]

        public Autore Autore { get; set; }
        [JsonPropertyName("dataPrestito")]
        public DateTime DataPrestito { get;  set; }
        [JsonPropertyName("dataScadenza")]
        public DateTime DataScadenza { get;  set; }
        [JsonPropertyName("dataDiConsegna")]
        public DateTime? DataDiConsegna { get;   set; }
    }
}
