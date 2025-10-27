using MongoDB.Driver;
using NoSQLWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NoSQLWinForms.Services
{
    public class BookService
    {
        private readonly IMongoCollection<Livro> _livros;

        public BookService(IMongoDatabase database)
        {
            _livros = database.GetCollection<Livro>("Livros");
        }

        public async Task<List<Livro>> GetAllAsync() =>
            await _livros.Find(_ => true).ToListAsync();

        public async Task<Livro?> GetByIdAsync(string id) =>
            await _livros.Find(b => b.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Livro book) =>
            await _livros.InsertOneAsync(book);
    }
}
