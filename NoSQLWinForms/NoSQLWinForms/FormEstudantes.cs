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
    public partial class FormEstudantes : Form
    {

        public FormEstudantes()
        {
            InitializeComponent();
        }

        private async void FormEstudantes_Load(object sender, EventArgs e)
        {
            // Add students from DB to the list box
            List<Estudante> results = await Service.Library!.Students.GetAllAsync();

            // Data sources for all elements
            // List box
            listBox1.DataSource = results;
            listBox1.DisplayMember = "Nome";

            // Combo boxes e idade
            cmbId.DataSource = results;
            cmbId.DisplayMember = "Id";

            cmbNome.DataSource = results;
            cmbNome.DisplayMember = "Nome";

            cmbCurso.DataSource = results;
            cmbCurso.DisplayMember = "Curso";

            cmbEmail.DataSource = results;
            cmbEmail.DisplayMember = "Email";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FormInserirEstudante forminserirestudante = new FormInserirEstudante();
            forminserirestudante.ShowDialog();
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Alteram-se os valores dos combo boxes conforme o estudante selecionado na list box
            cmbId.SelectedItem = listBox1.SelectedItem;
            cmbNome.SelectedItem = listBox1.SelectedItem;
            cmbCurso.SelectedItem = listBox1.SelectedItem;
            cmbEmail.SelectedItem = listBox1.SelectedItem;
            nmIdade.Value = ((Estudante)listBox1.SelectedItem).Idade;
        }

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nmIdade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
