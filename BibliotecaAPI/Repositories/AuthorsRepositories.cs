﻿using BibliotecaManager.Models;
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
            _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BibliotecaManagerApi\\";
            
        }

        public Task AddAuthor(Autore author)
        {
            var autori = _dataStorageService.CaricaAutori(_folderPath);
            autori.Add(author);
            _dataStorageService.SalvaAutori(_folderPath,autori);
            return Task.CompletedTask;
        }

        public Task<int> GenerateUniqueID()
        {
            List<Autore> autori = _dataStorageService.CaricaAutori(_folderPath);
            int newId = new Random().Next(1000, 10000);
            bool isUnique = false;
            do
            {
                newId = new Random().Next(1000, 10000); // 4 cifre
                isUnique = autori.Any(l => l.Persona.ID == newId);
            }
            while (isUnique);


            return Task.FromResult(newId);
        }

        public Task DeleteAuthor(int id)
        {
            var autori = _dataStorageService.CaricaAutori(_folderPath);

            var autoreDaEliminare = autori.FirstOrDefault(a => a.Persona.ID == id);
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
            return Task.FromResult(autori.FirstOrDefault(a => a.Persona.ID == id)!);
        }

        public Task UpdateAuthor(Autore author)
        {
            var autori = _dataStorageService.CaricaAutori(_folderPath);
            var index = autori.FindIndex(a => a.Persona.ID == author.Persona.ID);
            if (index != -1)
            {
                autori[index] = author;
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
