using BibliotecaManager.Models;

namespace BibliotecaAPI.Repositories
{
    public interface IBibliotecaRepositories
    {
        Task<IEnumerable<Cliente>> GetAllClients();

        Task<IEnumerable<Autore>> GetAllAuthors();

        Task<IEnumerable<Libro>> GetAllBooks();

        Task<IEnumerable<Prestito>> GetAllLoans();
    }
}
