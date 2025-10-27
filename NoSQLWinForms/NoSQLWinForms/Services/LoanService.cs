using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoSQLWinForms.Models;
namespace NoSQLWinForms.Services
{
    public class LoanService
    {
        private readonly IMongoCollection<Emprestimo> _emprestimos;

        public LoanService(IMongoDatabase database)
        {
            _emprestimos = database.GetCollection<Emprestimo>("Emprestimos");
        }

        public async Task<List<Emprestimo>> GetAllAsync() =>
            await _emprestimos.Find(_ => true).ToListAsync();

        public async Task<Emprestimo?> GetByIdAsync(string id) =>
            await _emprestimos.Find(l => l.Id == id).FirstOrDefaultAsync();

        public async Task<List<Emprestimo>> GetPendingByStudentAsync(string studentId) =>
            await _emprestimos.Find(l => l.EstudanteId == studentId && !l.Devolvido).ToListAsync();

        public async Task CreateAsync(Emprestimo loan) =>
            await _emprestimos.InsertOneAsync(loan);
    }
}
