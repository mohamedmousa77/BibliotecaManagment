using BibliotecaManager.Models;

namespace BibliotecaAPI.Repositories
{
    public class PrestitiRepositories : ILibriRepositories
    {
        public Task AddPrestito(Prestito prestito)
        {
            throw new NotImplementedException();
        }

        public Task DeletePrestito(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Prestito>> GetAllPresitit()
        {
            throw new NotImplementedException();
        }

        public Task<Prestito> GetPrestitoById(int prestitioId)
        {
            throw new NotImplementedException();
        }

        public Task MarkPrestitoAsConsegnato(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePrestito(Prestito prestito)
        {
            throw new NotImplementedException();
        }
    }
}
