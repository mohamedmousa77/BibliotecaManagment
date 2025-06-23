using System;
using System.Text.Json.Serialization;

namespace BibliotecaManager.Models
{
    public class Libro
    {
        public int Id { get; set; }
        [JsonPropertyName("isbn")]
        public string ISBN { get; set; }
        [JsonPropertyName("titolo")]
        public string Titolo { get; set; }
        [JsonPropertyName("casaEditrice")]
        public string CasaEditrice { get; set; }

        [JsonPropertyName("annoPubblicazione")]
        public DateTime AnnoPubblicazione { get; set; }
        [JsonPropertyName("genere")]
        public string Genere { get; set; }
        [JsonPropertyName("quantitaMagazzino")]
        public decimal QuantitaMagazzino { get; set; }
        [JsonPropertyName("autore")]
        public Autore Autore { get; set; }
    }

}
