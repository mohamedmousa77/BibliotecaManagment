using BibliotecaManager.Models;
using BibliotecaManager.Services;

namespace BibliotecaAPI.Repositories
{
    public class LibriRepositories : ILibriRepositories
    {
        public DataStorageService _dataStorageService;
        public string _folderPath;

        public LibriRepositories(DataStorageService dataStorageService)
        {
            _dataStorageService = dataStorageService;
            _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BibliotecaManagerApi\\";
        }

        public Task AddLibro(Libro Libro)
        {
            List<Libro> libri = _dataStorageService.CaricaLibri(_folderPath);
            libri.Add(Libro);
            _dataStorageService.SalvaLibri(_folderPath, libri);
            return Task.CompletedTask;
        }

        public Task DeleteLibro(int id)
        {
            List<Libro> libri = _dataStorageService.CaricaLibri(_folderPath);
            var libroDaEliminare = libri.FirstOrDefault(p => p.Id == id);

            if (libroDaEliminare != null)
            {
                libri.Remove(libroDaEliminare);
                _dataStorageService.SalvaLibri(_folderPath, libri);
            }
            else
            {
                throw new Exception("Libro non trovato per l'aggiornamento.");
            }
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Libro>> GetAllLibri()
        {
            List<Libro> libri = _dataStorageService.CaricaLibri(_folderPath);
            return Task.FromResult(libri.AsEnumerable());
        }

        public Task<Libro> GetLibroById(int libroID)
        {
            List<Libro> libri = _dataStorageService.CaricaLibri(_folderPath);
            return Task.FromResult(libri.FirstOrDefault(a => a.Id == libroID)!);
        }

        public Task UpdateLibro(Libro Libro)
        {
            List<Libro> libri = _dataStorageService.CaricaLibri(_folderPath);
            int index = libri.IndexOf(Libro);
            if(index > -1)
            {
                libri[index] = Libro;
                _dataStorageService.SalvaLibri(_folderPath,libri);
            }
            else
            {
                throw new Exception("Libro non trovato per l'aggiornamento.");
            }
            return Task.CompletedTask;
        }
    }
}
