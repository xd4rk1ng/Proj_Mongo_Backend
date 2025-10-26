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
    public partial class FormEstudantes : Form
    {
        private readonly IMongoCollection<Estudante> _col;
        public FormEstudantes(IMongoDatabase db)
        {
            InitializeComponent();
            _col = db.GetCollection<Estudante>("students");
        }

        private void FormEstudantes_Load(object sender, EventArgs e)
        {
            // Add students from DB to the list box
            var cursor = _col.Find(_ => true);
            var results = cursor.ToList();

            listBox1.DataSource = results;
            listBox1.DisplayMember = "Nome";

            // Placeholder list of students
            listBox1.Items.Add("Estudante 1: João Silva");
            listBox1.Items.Add("Estudante 2: Maria Oliveira");
            listBox1.Items.Add("Estudante 3: Pedro Santos");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FormInserirEstudante formInserirEstudante = new FormInserirEstudante();
            formInserirEstudante.ShowDialog();
        }
    }
}
