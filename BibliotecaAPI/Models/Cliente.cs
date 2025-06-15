

using System.Text.Json.Serialization;

namespace BibliotecaManager.Models
{
    public class  Cliente 
    {
        [JsonPropertyName("persona")]
        public Persona Persona { get; set; }
        [JsonPropertyName("mail")]
        public string Mail { get; set; }
        [JsonPropertyName("telefono")]
        public string Telefono { get; set; }
        [JsonPropertyName("socio")]
        public bool Socio { get; set; }

        public string NomeCompleto => Persona?.Nome + " " + Persona?.Cognome;

    }
}
