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
    public partial class FormInserirEstudante : Form
    {
        private readonly IMongoDatabase _db;
        public FormInserirEstudante(IMongoDatabase db)
        {
            _db = db;
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtCurso.Text == "" || txtEmail.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            else {
                // Inserir estudante na base de dados
                var collection = _db.GetCollection<Estudante>("estudantes");
                collection.InsertOne(new Estudante(txtNome.Text, (int)nmIdade.Value, txtCurso.Text, txtEmail.Text));
                Close();
                    }
        }
    }
}
