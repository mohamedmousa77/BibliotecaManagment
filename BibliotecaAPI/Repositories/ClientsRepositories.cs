using BibliotecaManager.Models;
using BibliotecaManager.Services;

namespace BibliotecaAPI.Repositories
{
    public class ClientsRepositories : IClientsRepositories
    {
        private DataStorageService _dataStorageService;
        private string _folderPath;
        public ClientsRepositories(DataStorageService dataStorageService)
        {
            _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BibliotecaManagerApi\\";
            _dataStorageService = dataStorageService;
        }
        public Task AddClient(Cliente client)
        {
            var clienti = _dataStorageService.CaricaClienti(_folderPath);
            clienti.Add(client);
            _dataStorageService.SalvaClienti(_folderPath, clienti);
            return Task.CompletedTask;
        }

        public Task<int> GenerateUniqueID()
        {
            List<Cliente> clienti = _dataStorageService.CaricaClienti(_folderPath);
            int newId = new Random().Next(1000, 10000);
            bool isUnique = false;
            do
            {
                newId = new Random().Next(1000, 10000); // 4 cifre
                isUnique = clienti.Any(l => l.Persona.ID == newId);
            }
            while (isUnique);


            return Task.FromResult(newId);
        }

        public Task DeleteClient(int id)
        {
            var clienti = _dataStorageService.CaricaClienti(_folderPath);
            return Task.FromResult(clienti.FirstOrDefault(c => c.Persona.ID == id));
        }

        public Task<IEnumerable<Cliente>> GetAllClients()
        {
            var clienti = _dataStorageService.CaricaClienti(_folderPath);
            return Task.FromResult(clienti.AsEnumerable());
        }

        public Task<Cliente> GetClientById(int clienteId)
        {
            var clienti = _dataStorageService.CaricaClienti(_folderPath);
            return Task.FromResult(clienti.FirstOrDefault(c => c.Persona.ID == clienteId));
        }

        public Task UpdateClient(Cliente client)
        {
            var clienti = _dataStorageService.CaricaClienti(_folderPath);
            var index = clienti.FindIndex(c => c.Persona.ID == client.Persona.ID);
            if (index != -1)
            {
                clienti[index] = client; 
                _dataStorageService.SalvaClienti(_folderPath, clienti);
            }
            else
            {
                    throw new Exception("Autore non trovato per l'aggiornamento.");
            }
            return Task.CompletedTask;
        }
    }
}
