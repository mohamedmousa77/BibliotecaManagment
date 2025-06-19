using BibliotecaManager.Models;

namespace BibliotecaAPI.Repositories
{
    public interface ILibriRepositories
    {
        Task<IEnumerable<Libro>> GetAllLibri();

        Task<Libro> GetLibroById(int libroID);

        Task UpdateLibro(Libro Libro);

        Task DeleteLibro(int id);

        Task AddLibro(Libro Libro);
    }
}