using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSQLWinForms.Models
{
    public class Livro
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Autor { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Editora { get; set; }
        public int NumeroPaginas { get; set; }
        public string Descricao { get; set; }

        public override string ToString() => Titulo;
    }
}
