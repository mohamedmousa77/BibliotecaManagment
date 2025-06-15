using System.Text.Json.Serialization;

namespace BibliotecaManager.Models
{
    public class Autore
    {
        [JsonPropertyName("persona")]
        public Persona Persona { get; set; }

        [JsonPropertyName("casaEditrice")]
        public string CasaEditrice { get; set; }

        [JsonPropertyName("indiceDiGradimento")]
        public int IndiceDiGradimento { get; set; }

    }

}
