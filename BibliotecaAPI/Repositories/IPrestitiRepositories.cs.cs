using BibliotecaManager.Models;

namespace BibliotecaAPI.Repositories
{
    public interface IPrestitiRepositories
    {
        Task<IEnumerable<Prestito>> GetAllPresitit();

        Task<Prestito> GetPrestitoById(int prestitioId);

        Task UpdatePrestito(Prestito prestito);

        Task DeletePrestito(int id);

        Task AddPrestito(Prestito prestito);

        Task MarkPrestitoAsConsegnato(int id);

        Task<int> GenerateUniqueID();
    }
}
