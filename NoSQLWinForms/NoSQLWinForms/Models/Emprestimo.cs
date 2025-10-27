using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoSQLWinForms.Services;
namespace NoSQLWinForms.Models
{
    public class Emprestimo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string EstudanteId { get; set; } = "";
        [BsonRepresentation(BsonType.ObjectId)]
        public string LivroId { get; set; } = "";

        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public bool Devolvido { get; set; }


        [BsonIgnore] // So MongoDB doesn’t try to serialize this
        public Estudante EstudanteObj { get; set; }

        [BsonIgnore]
        public Livro LivroObj { get; set; }


        public override string ToString() => $"{LivroObj.Titulo} -- {EstudanteObj.Nome}";
    }
}
