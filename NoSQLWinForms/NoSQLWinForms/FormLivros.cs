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
using NoSQLWinForms.Services;

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
            results = await Service.Library!.Books.GetAllAsync();

            // Data sources for all elements
            lstLivros.DataSource = results;
            lstLivros.DisplayMember = "Titulo";
            lstLivros.SelectedIndex = -1; // No selection at start

            cmbIsbn.DataSource = new List<Livro> { new Livro { Isbn = "ALL", Titulo = "ALL", SubTitulo = "ALL", Autor = "ALL", Editora = "ALL", Descricao = "ALL" } }.Concat(results.DistinctBy(l => l.Isbn)).ToList(); // Para ignorar o filtro
            cmbIsbn.DisplayMember = "Isbn";

            cmbTitulo.DataSource = new List<Livro> { new Livro { Isbn = "ALL", Titulo = "ALL", SubTitulo = "ALL", Autor = "ALL", Editora = "ALL", Descricao = "ALL" } }.Concat(results.DistinctBy(l => l.Titulo)).ToList();
            cmbTitulo.DisplayMember = "Titulo";

            cmbSubtitulo.DataSource = new List<Livro> { new Livro { Isbn = "ALL", Titulo = "ALL", SubTitulo = "ALL", Autor = "ALL", Editora = "ALL", Descricao = "ALL" } }.Concat(results.DistinctBy(l => l.SubTitulo)).ToList();
            cmbSubtitulo.DisplayMember = "SubTitulo";

            cmbAutor.DataSource = new List<Livro> { new Livro { Isbn = "ALL", Titulo = "ALL", SubTitulo = "ALL", Autor = "ALL", Editora = "ALL", Descricao = "ALL" } }.Concat(results.DistinctBy(l => l.Autor)).ToList();
            cmbAutor.DisplayMember = "Autor";

            cmbEditora.DataSource = new List<Livro> { new Livro { Isbn = "ALL", Titulo = "ALL", SubTitulo = "ALL", Autor = "ALL", Editora = "ALL", Descricao = "ALL" } }.Concat(results.DistinctBy(l => l.Editora)).ToList();
            cmbEditora.DisplayMember = "Editora";

            cmbDesc.DataSource = new List<Livro> { new Livro { Isbn = "ALL", Titulo = "ALL", SubTitulo = "ALL", Autor = "ALL", Editora = "ALL", Descricao = "ALL" } }.Concat(results.DistinctBy(l => l.Descricao)).ToList();
            cmbDesc.DisplayMember = "Descricao";

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(dtpPubl, "A data atual mostra todos os livros!");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FormInserirLivros formInserirLivros = new FormInserirLivros();
            formInserirLivros.ShowDialog();
            Close();
        }

        private void lstLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Alteram-se os valores dos combo boxes conforme o estudante selecionado na list box
            cmbIsbn.SelectedItem = lstLivros.SelectedItem;
            cmbTitulo.SelectedItem = lstLivros.SelectedItem;
            cmbSubtitulo.SelectedItem = lstLivros.SelectedItem;
            cmbAutor.SelectedItem = lstLivros.SelectedItem;
            cmbEditora.SelectedItem = lstLivros.SelectedItem;
            cmbDesc.SelectedItem = lstLivros.SelectedItem;
            if (lstLivros.SelectedItem != null)
            {
                nmPags.Value = ((Livro)lstLivros.SelectedItem).NumeroPaginas;
                dtpPubl.Value = ((Livro)lstLivros.SelectedItem).DataPublicacao;
            }
            else
            {
                nmPags.Value = 0;
                dtpPubl.Value = DateTime.Now;
            }
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            // Apply all filters from the combo boxes and numeric up down
            lstLivros.DataSource = results.Where(livro =>
                ((cmbIsbn.SelectedItem is Livro selectedIsbn && selectedIsbn.Isbn == "ALL") ||
                 (livro.Isbn == ((Livro)cmbIsbn.SelectedItem).Isbn)) &&
                ((cmbTitulo.SelectedItem is Livro selectedTitulo && selectedTitulo.Titulo == "ALL") ||
                 (livro.Titulo == ((Livro)cmbTitulo.SelectedItem).Titulo)) &&
                ((cmbSubtitulo.SelectedItem is Livro selectedSubtitulo && selectedSubtitulo.SubTitulo == "ALL") ||
                 (livro.SubTitulo == ((Livro)cmbSubtitulo.SelectedItem).SubTitulo)) &&
                ((cmbAutor.SelectedItem is Livro selectedAutor && selectedAutor.Autor == "ALL") ||
                 (livro.Autor == ((Livro)cmbAutor.SelectedItem).Autor)) &&
                ((cmbEditora.SelectedItem is Livro selectedEditora && selectedEditora.Editora == "ALL") ||
                 (livro.Editora == ((Livro)cmbEditora.SelectedItem).Editora)) &&
                ((cmbDesc.SelectedItem is Livro selectedDesc && selectedDesc.Descricao == "ALL") ||
                 (livro.Descricao == ((Livro)cmbDesc.SelectedItem).Descricao)) &&
                 (nmPags.Value == 0 || livro.NumeroPaginas == (int)nmPags.Value) &&
                 (dtpPubl.Value == DateTime.Now || livro.DataPublicacao.Date == dtpPubl.Value.Date)
            ).ToList();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Reset all filters and show all books
            lstLivros.DataSource = results;

            cmbIsbn.SelectedIndex = 0;
            cmbTitulo.SelectedIndex = 0;
            cmbSubtitulo.SelectedIndex = 0;
            cmbAutor.SelectedIndex = 0;
            cmbEditora.SelectedIndex = 0;
            cmbDesc.SelectedIndex = 0;
            nmPags.Value = 0;
            dtpPubl.Value = DateTime.Now;
        }

        private async void btnApagar_Click(object sender, EventArgs e)
        {
            var id = ((Livro)lstLivros.SelectedValue).Id;
            await Service.Library.Books.DeleteAsync(id);
        }
    }
}
