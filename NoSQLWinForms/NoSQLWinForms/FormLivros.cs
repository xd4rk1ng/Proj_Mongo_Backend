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
    public partial class FormLivros : Form
    {
        private readonly IMongoDatabase _db;
        private readonly IMongoCollection<Livro> _col;
        public FormLivros(IMongoDatabase db)
        {
            InitializeComponent();
            _db = db;
            _col = db.GetCollection<Livro>("livros");
        }

        private void FormLivros_Load(object sender, EventArgs e)
        {
            // Add books from DB to the list box
            var cursor = _col.Find(_ => true);
            var results = cursor.ToList();

            // Data sources for all elements
            lstLivros.DataSource = results;
            lstLivros.DisplayMember = "Titulo";

            cmbIsbn.DataSource = results;
            cmbIsbn.DisplayMember = "Isbn";

            cmbTitulo.DataSource = results;
            cmbTitulo.DisplayMember = "Titulo";

            cmbSubtitulo.DataSource = results;
            cmbSubtitulo.DisplayMember = "SubTitulo";

            cmbAutor.DataSource = results;
            cmbAutor.DisplayMember = "Autor";

            cmbEditora.DataSource = results;
            cmbEditora.DisplayMember = "Editora";

            cmbDesc.DataSource = results;
            cmbDesc.DisplayMember = "Descricao";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FormInserirLivros formInserirLivros = new FormInserirLivros(_db);
            formInserirLivros.ShowDialog();
            Close();
        }
    }
}
