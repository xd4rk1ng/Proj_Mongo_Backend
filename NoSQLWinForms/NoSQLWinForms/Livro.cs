using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSQLWinForms
{
    public class Livro
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        // atributos
        public string Id { get; set; }
        private string _isbn;
        private string _titulo;
        private string _subTitulo;
        private string _autor;
        private DateTime _dataPublicacao;
        private string _editora;
        private int _numeroPaginas;
        private string _descricao;

        // propriedades
        public string Isbn { get => _isbn; set => _isbn = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string SubTitulo { get => _subTitulo; set => _subTitulo = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public DateTime DataPublicacao { get => _dataPublicacao; set => _dataPublicacao = value; }
        public string Editora { get => _editora; set => _editora = value; }
        public int NumeroPaginas { get => _numeroPaginas; set => _numeroPaginas = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }

        // construtor
        public Livro()
        {
            Isbn = string.Empty;
            Titulo = string.Empty;
            SubTitulo = string.Empty;
            Autor = string.Empty;
            DataPublicacao = DateTime.MinValue;
            Editora = string.Empty;
            NumeroPaginas = 0;
            Descricao = string.Empty;
        }
        public Livro(string isbn, string titulo, string subTitulo, string autor, DateTime dataPublicacao, string editora, int numeroPaginas, string descricao)
        {
            Isbn = isbn;
            Titulo = titulo;
            SubTitulo = subTitulo;
            Autor = autor;
            DataPublicacao = dataPublicacao;
            Editora = editora;
            NumeroPaginas = numeroPaginas;
            Descricao = descricao;
        }

    }
}
