

using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace BibliotecaManager.Models
{
    public class Persona
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("cognome")]
        public string Cognome { get; set; }

    }
        
}
