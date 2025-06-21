using BibliotecaManager.Models;

namespace BibliotecaAPI.Repositories
{
    public interface IAuthorsRepositories
    {
        Task<IEnumerable<Autore>> GetAllAuthors();
        Task<Autore> GetAuthorById (int id);
        Task AddAuthor(Autore author);
        Task UpdateAuthor(Autore author);
        Task DeleteAuthor(int id);

        Task<int> GenerateUniqueID();
    }

}
