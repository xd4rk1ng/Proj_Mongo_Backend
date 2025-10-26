using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSQLWinForms
{
    public class Emprestimo
    {
        // Atributos
        private int _idEmprestimo;
        private Estudante _estudante;
        private Livro _livro;
        private DateTime _dataEmprestimo;
        private DateTime _dataDevolucao;

        // Propriedades
        public int IdEmprestimo { get => _idEmprestimo; set => _idEmprestimo = value; }
        public Estudante Estudante { get => _estudante; set => _estudante = value; }
        public Livro Livro { get => _livro; set => _livro = value; }
        public DateTime DataEmprestimo { get => _dataEmprestimo; set => _dataEmprestimo = value; }
        public DateTime DataDevolucao { get => _dataDevolucao; set => _dataDevolucao = value; }

        // Construtor
        public Emprestimo()
        {
            Estudante = new Estudante();
            Livro = new Livro();
            DataEmprestimo = DateTime.MinValue;
            DataDevolucao = DateTime.MinValue;
        }
        public Emprestimo(Estudante estudante, Livro livro, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            Estudante = estudante;
            Livro = livro;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
        }
    }
}
