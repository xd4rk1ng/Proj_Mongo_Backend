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
        List<Estudante> results;
        public FormEstudantes()
        {
            InitializeComponent();
        }

        private async void FormEstudantes_Load(object sender, EventArgs e)
        {

            // Add students from DB to the list box
            results = await Service.Library!.Students.GetAllAsync();

            // Data sources for all elements
            // List box
            listBox1.DataSource = results;
            listBox1.DisplayMember = "Nome";
            listBox1.SelectedIndex = -1; // No selection at start

            // Combo boxes e idade
            cmbId.DataSource = new List<Estudante> { new Estudante { Id = "ALL", Nome = "ALL", Curso = "ALL", Email = "ALL", Idade = 0 } }.Concat(results.DistinctBy(e => e.Id)).ToList(); // Para ignorar o filtro
            cmbId.DisplayMember = "Id";

            cmbNome.DataSource = new List<Estudante> { new Estudante { Id = "ALL", Nome = "ALL", Curso = "ALL", Email = "ALL", Idade = 0 } }.Concat(results.DistinctBy(e => e.Nome)).ToList();
            cmbNome.DisplayMember = "Nome";

            cmbCurso.DataSource = new List<Estudante> { new Estudante { Id = "ALL", Nome = "ALL", Curso = "ALL", Email = "ALL", Idade = 0 } }.Concat(results.DistinctBy(e => e.Curso)).ToList();
            cmbCurso.DisplayMember = "Curso";

            cmbEmail.DataSource = new List<Estudante> { new Estudante { Id = "ALL", Nome = "ALL", Curso = "ALL", Email = "ALL", Idade = 0 } }.Concat(results.DistinctBy(e => e.Email)).ToList();
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
            if (listBox1.SelectedItem != null)
                nmIdade.Value = ((Estudante)listBox1.SelectedItem).Idade;
            else
                nmIdade.Value = 0;
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            // Apply all filters from the combo boxes and numeric up down
            listBox1.DataSource = results.Where(estudante =>
                ((cmbId.SelectedItem is Estudante selectedId && selectedId.Id == "ALL") ||
                 (estudante.Id == ((Estudante)cmbId.SelectedItem).Id)) &&
                ((cmbNome.SelectedItem is Estudante selectedNome && selectedNome.Nome == "ALL") ||
                 (estudante.Nome == ((Estudante)cmbNome.SelectedItem).Nome)) &&
                ((cmbCurso.SelectedItem is Estudante selectedCurso && selectedCurso.Curso == "ALL") ||
                 (estudante.Curso == ((Estudante)cmbCurso.SelectedItem).Curso)) &&
                ((cmbEmail.SelectedItem is Estudante selectedEmail && selectedEmail.Email == "ALL") ||
                 (estudante.Email == ((Estudante)cmbEmail.SelectedItem).Email)) &&
                (nmIdade.Value == 0 || estudante.Idade == (int)nmIdade.Value)
            ).ToList();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // clean filters and reset list box
            listBox1.DataSource = results;

            cmbId.SelectedIndex = 0;
            cmbNome.SelectedIndex = 0;
            cmbCurso.SelectedIndex = 0;
            cmbEmail.SelectedIndex = 0;
            nmIdade.Value = 0;
        }
    }
}
