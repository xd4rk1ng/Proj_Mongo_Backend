using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoSQLWinForms
{
    public partial class FormInserirLivros : Form
    {
        private readonly IMongoDatabase _db;
        public FormInserirLivros(IMongoDatabase db)
        {
            InitializeComponent();
            _db = db;
        }

        private void FormInserirLivros_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (txtIsbn.Text == "" || txtTitulo.Text == "" || txtSubtitulo.Text == "" || txtDesc.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            else
            {
                // Inserir livro na base de dados
                var collection = _db.GetCollection<Livro>("livros");
                collection.InsertOne(new Livro(txtIsbn.Text, txtTitulo.Text, txtSubtitulo.Text, txtAutor.Text, dtpPub.Value, txtEditora.Text, (int)nmPags.Value, txtDesc.Text));
                Close();
            }
        }
    }
}
