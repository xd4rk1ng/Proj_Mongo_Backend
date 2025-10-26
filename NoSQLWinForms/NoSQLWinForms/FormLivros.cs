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
        public FormLivros(IMongoDatabase db)
        {
            InitializeComponent();
        }

        private void FormLivros_Load(object sender, EventArgs e)
        {
            // Placeholder list of books
            listBox1.Items.Add("Livro 1: O Alquimista - Paulo Coelho");
            listBox1.Items.Add("Livro 2: Dom Casmurro - Machado de Assis");

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FormInserirLivros formInserirLivros = new FormInserirLivros();
            formInserirLivros.ShowDialog();
        }
    }
}
