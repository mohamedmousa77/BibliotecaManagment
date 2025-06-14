namespace BibliotecaManager.Models
{
    public class Autore
    {
        public Persona Persona { get; set; }

        public string CasaEditrice { get; set; }

        public int IndiceDiGradimento { get; set; }

        public string NomeCompleto => Persona?.Nome + " " + Persona?.Cognome;
    }

}
