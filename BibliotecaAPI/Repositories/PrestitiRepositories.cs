using BibliotecaManager.Models;
using BibliotecaManager.Services;

namespace BibliotecaAPI.Repositories
{
    public class PrestitiRepositories : IPrestitiRepositories
    {
        public DataStorageService _dataStorageService;
        public string _folderPath;

        public PrestitiRepositories(DataStorageService dataStorageService)
        {
            _dataStorageService = dataStorageService;
            _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BibliotecaManagerApi\\";
        }

        public Task AddPrestito(Prestito prestito)
        {
            List<Prestito> prestiti = _dataStorageService.CaricaPrestiti(_folderPath);
            prestiti.Add(prestito);
            return Task.CompletedTask;
        }

        public Task DeletePrestito(int id)
        {
            List<Prestito> prestiti = _dataStorageService.CaricaPrestiti(_folderPath);
            var prestitoDaEliminare = prestiti.FirstOrDefault(p => p.Id == id);

            if (prestitoDaEliminare != null)
            {
                prestiti.Remove(prestitoDaEliminare);
                _dataStorageService.SalvaPrestiti(_folderPath ,prestiti);
            }
            else
            {
                throw new Exception("Prestito non trovato per l'eliminazione.");
            }
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Prestito>> GetAllPresitit()
        {
            List<Prestito> prestiti = _dataStorageService.CaricaPrestiti(_folderPath);
            return Task.FromResult(prestiti.AsEnumerable());
        }

        public Task<Prestito> GetPrestitoById(int prestitioId)
        {
            List<Prestito> prestiti = _dataStorageService.CaricaPrestiti(_folderPath);
            return Task.FromResult(prestiti.FirstOrDefault(p => p.Id == prestitioId)!);
        }

        public Task UpdatePrestito(Prestito prestito)
        {
            List<Prestito> prestiti = _dataStorageService.CaricaPrestiti(_folderPath);
            int index = prestiti.FindIndex(p => p.Id == prestito.Id);
            if (index > -1)
            {
                prestiti[index] = prestito;
                _dataStorageService.SalvaPrestiti(_folderPath, prestiti);
            }
            else
            {
                throw new Exception("Autore non trovato per l'aggiornamento.");
            }
            return Task.CompletedTask;
        }

        public Task MarkPrestitoAsConsegnato(int id)
        {
            List<Prestito> prestiti = _dataStorageService.CaricaPrestiti(_folderPath);
            int index = prestiti.FindIndex(p => p.Id == id);
            if (index > -1)
            {
                prestiti[index].DataDiConsegna = DateTime.Now;
                _dataStorageService.SalvaPrestiti(_folderPath, prestiti);
            }
            else
            {
                throw new Exception("Autore non trovato per l'aggiornamento.");
            }
            return Task.CompletedTask;
        }
    }
}
