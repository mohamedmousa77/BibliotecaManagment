using BibliotecaManager.Models;
using BibliotecaManager.Services;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace BibliotecaAPI.Repositories
{
    public class AuthorsRepositories : IAuthorsRepositories
    {
        public DataStorageService _dataStorageService;
        public string _folderPath;
        public AuthorsRepositories(DataStorageService dataStorageService)
        {
            _dataStorageService = dataStorageService;
            _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BibliotecaManager\\";
            
        }

        public Task AddAuthor(Autore author)
        {
            var autori = _dataStorageService.CaricaAutori(_folderPath);
            autori.Add(author);
            _dataStorageService.SalvaAutori(_folderPath,autori);
            return Task.CompletedTask;
        }

        public Task DeleteAuthor(int id)
        {
            var autori = _dataStorageService.CaricaAutori(_folderPath);

            var autoreDaEliminare = autori.FirstOrDefault(a => a.Persona.ID == id.ToString());
            if (autoreDaEliminare != null)
            {
                autori.Remove(autoreDaEliminare);
                _dataStorageService.SalvaAutori(_folderPath, autori);
            }
            else
            {
                throw new Exception("Autore non trovato per l'eliminazione.");
            }
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Autore>> GetAllAuthors()
        {
            var autori = _dataStorageService.CaricaAutori(_folderPath);
            return Task.FromResult(autori.AsEnumerable());
        }

        public Task<Autore> GetAuthorById(int id)
        {
            var autori = _dataStorageService.CaricaAutori(_folderPath);
            return Task.FromResult(autori.FirstOrDefault(a => a.Persona.ID == id.ToString())!);
        }

        public Task UpdateAuthor(Autore author)
        {
            var autori = _dataStorageService.CaricaAutori(_folderPath);
            var index = autori.FindIndex(a => a.Persona.ID == author.Persona.ID);
            if (index != -1)
            {
                autori[index] = author; // Sostituisci con la nuova versione
                _dataStorageService.SalvaAutori(_folderPath, autori);
            }
            else 
            {
                throw new Exception("Autore non trovato per l'aggiornamento.");
            }
            return Task.CompletedTask;
        }
    }
}
