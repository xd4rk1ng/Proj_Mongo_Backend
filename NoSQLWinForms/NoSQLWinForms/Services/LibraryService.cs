using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Driver;
using NoSQLWinForms.Models;
namespace NoSQLWinForms.Services
{
    public class LibraryService
    {
        private readonly IMongoDatabase _database;

        public LibraryService()
        {
            // MongoDB connection string (local or Docker)
            var client = new MongoClient("mongodb://root:atec123@192.168.109.129:27017/admin");
            _database = client.GetDatabase("library");
        }

        public IMongoCollection<Estudante> Estudantes => _database.GetCollection<Estudante>("Estudantes");
        public IMongoCollection<Livro> Livros => _database.GetCollection<Livro>("Livros");
        public IMongoCollection<Emprestimo> Emprestimos => _database.GetCollection<Emprestimo>("Emprestimos");

        // --- Estudantes ---
        public async Task<List<Estudante>> GetAllEstudantesAsync()
        {
            return await Estudantes.Find(_ => true).ToListAsync();
        }

        public async Task AddEstudanteAsync(Estudante Estudante)
        {
            await Estudantes.InsertOneAsync(Estudante);
        }

        // --- Livros ---
        public async Task<List<Livro>> GetAllLivrosAsync()
        {
            return await Livros.Find(_ => true).ToListAsync();
        }

        public async Task AddLivroAsync(Livro Livro)
        {
            await Livros.InsertOneAsync(Livro);
        }

        // --- Emprestimos ---
        public async Task<List<Emprestimo>> GetAllEmprestimosAsync()
        {
            return await Emprestimos.Find(_ => true).ToListAsync();
        }

        public async Task AddEmprestimoAsync(Emprestimo Emprestimo)
        {
            await Emprestimos.InsertOneAsync(Emprestimo);
        }
    }
}