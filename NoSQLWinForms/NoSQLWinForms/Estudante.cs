using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;


namespace NoSQLWinForms
{
    public class Estudante // public pq se não o repository não consegue acessar
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        // Propriedades autoimplementadas
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; } = 0;
        public string Curso { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public Estudante() { }

        public Estudante(string nome, int idade, string curso, string email)
        {
            Nome = nome;
            Idade = idade;
            Curso = curso;
            Email = email;
        }
    }
}

