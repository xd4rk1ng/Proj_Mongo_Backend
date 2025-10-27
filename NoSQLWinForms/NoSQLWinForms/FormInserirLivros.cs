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
using NoSQLWinForms.Services;
using NoSQLWinForms.Models;
namespace NoSQLWinForms
{
    public partial class FormInserirLivros : Form
    {
        public FormInserirLivros()
        {
            InitializeComponent();
        }

        private void FormInserirLivros_Load(object sender, EventArgs e)
        {

        }

        private async void btnInserir_Click(object sender, EventArgs e)
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
                await Service.Library!.Books.CreateAsync(new Livro {
                    Isbn = txtIsbn.Text, 
                    Titulo = txtTitulo.Text, 
                    SubTitulo = txtSubtitulo.Text, 
                    Autor = txtAutor.Text, 
                    DataPublicacao = dtpPub.Value, 
                    Editora = txtEditora.Text, 
                    NumeroPaginas = (int)nmPags.Value, 
                    Descricao = txtDesc.Text
                });
                Close();
            }
        }
    }
}
