using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSQLWinForms.Models
{
    public class Emprestimo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;
        public string EstudanteId { get; set; } = null!;
        public string LivroId { get; set; } = null!;
        public DateTime LoanDate { get; set; }
    }
}
