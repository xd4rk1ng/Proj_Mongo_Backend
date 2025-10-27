using MongoDB.Driver;
using NoSQLWinForms.Models;
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
        List<Livro> results;

        public FormLivros()
        {
            InitializeComponent();
        }

        private async void FormLivros_Load(object sender, EventArgs e)
        {
            // Add books from DB to the list box
            results = await Services.Service.Library!.Books.GetAllAsync();

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
            FormInserirLivros formInserirLivros = new FormInserirLivros();
            formInserirLivros.ShowDialog();
            Close();
        }
    }
}
