using BibliotecaManager.Models;

namespace BibliotecaAPI.Repositories
{
    public interface IClientsRepositories
    {
        Task<IEnumerable<Cliente>> GetAllClients();

        Task<Cliente> GetClientById(int clienteId);

        Task UpdateClient(Cliente client);

        Task DeleteClient(int id);

        Task AddClient(Cliente client);

        Task<int> GenerateUniqueID();
    }
}
