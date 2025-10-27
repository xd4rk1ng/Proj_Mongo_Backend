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
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private async void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtCurso.Text == "" || txtEmail.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            else {
                // Inserir estudante na base de dados
                await Service.Library!.Students.CreateAsync(new Estudante { Nome = txtNome.Text, Idade = (int)nmIdade.Value, Curso = txtCurso.Text, Email = txtEmail.Text });
                Close();
            }
        }
    }
}
