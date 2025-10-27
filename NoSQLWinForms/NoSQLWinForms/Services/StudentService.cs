using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoSQLWinForms.Models;
namespace NoSQLWinForms.Services
{
    public class StudentService
    {
        private readonly IMongoCollection<Estudante> _estudantes;

        public StudentService(IMongoDatabase database)
        {
            _estudantes = database.GetCollection<Estudante>("Estudantes");
        }

        public async Task<List<Estudante>> GetAllAsync() =>
            await _estudantes.Find(_ => true).ToListAsync();

        public async Task<Estudante?> GetByIdAsync(string id) =>
            await _estudantes.Find(s => s.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Estudante student) =>
            await _estudantes.InsertOneAsync(student);
    }
}
