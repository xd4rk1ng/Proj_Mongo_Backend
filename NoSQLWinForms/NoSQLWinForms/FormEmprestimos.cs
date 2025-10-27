using MongoDB.Driver;
using NoSQLWinForms.Models;
using NoSQLWinForms.Services;
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
    public partial class FormEmprestimos : Form
    {
        List<Emprestimo> results;
        public FormEmprestimos()
        {
            InitializeComponent();
        }

        private async void FormEmprestimos_Load(object sender, EventArgs e)
        {
            results = await Service.Library!.Loans.GetAllAsync();


            // to get objects associated with id
            foreach (Emprestimo emp in results)
            {
                emp.EstudanteObj = await Service.Library.Students.GetByIdAsync(emp.EstudanteId);
                emp.LivroObj = await Service.Library.Books.GetByIdAsync(emp.LivroId);

                if(emp.LivroObj == null)
                {
                    emp.LivroObj = new Livro { Titulo = "Livro Removido" };
                }
            }
            listBox1.DataSource = results;
            // listBox1.DisplayMember = 
            // default display member calls object ToString() method, which is overriden to display 
            comboBox1.DataSource = new List<Emprestimo> { new Emprestimo { Id = "ALL" } }.Concat(results.DistinctBy(e => e.Id)).ToList(); // Para ignorar o filtro
            comboBox1.DisplayMember = "Id";

            comboBox2.DataSource = new List<Emprestimo> { new Emprestimo { EstudanteObj = new Estudante { Nome = "ALL" } } }.Concat(results.DistinctBy(e => e.EstudanteObj.Nome)).ToList();
            comboBox2.DisplayMember = "EstudanteObj";

            comboBox3.DataSource = new List<Emprestimo> { new Emprestimo { LivroObj = new Livro { Titulo = "ALL" } } }.Concat(results.DistinctBy(e => e.LivroObj.Titulo)).ToList();
            comboBox3.DisplayMember = "LivroObj";

            comboBox4.DataSource = new List<Emprestimo> { new Emprestimo { DataEmprestimo = DateTime.MinValue } }.Concat(results.DistinctBy(e => e.DataEmprestimo)).ToList();
            comboBox4.DisplayMember = "DataEmprestimo";

            comboBox5.DataSource = new List<Emprestimo> { new Emprestimo { DataDevolucao = DateTime.MinValue } }.Concat(results.DistinctBy(e => e.DataDevolucao)).ToList();
            comboBox5.DisplayMember = "DataDevolucao";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FormRealizarEmprestimo formRealizarEmprestimo = new FormRealizarEmprestimo();
            formRealizarEmprestimo.ShowDialog();
            Close();
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            // Apply all filters from the combo boxes and numeric up down
            listBox1.DataSource = results.Where(emp =>
                (comboBox1.SelectedIndex == 0 || emp.Id == ((Emprestimo)comboBox1.SelectedItem).Id) &&
                (comboBox2.SelectedIndex == 0 || emp.EstudanteObj.Nome == ((Emprestimo)comboBox2.SelectedItem).EstudanteObj.Nome) &&
                (comboBox3.SelectedIndex == 0 || emp.LivroObj.Titulo == ((Emprestimo)comboBox3.SelectedItem).LivroObj.Titulo) &&
                (comboBox4.SelectedIndex == 0 || emp.DataEmprestimo == ((Emprestimo)comboBox4.SelectedItem).DataEmprestimo) &&
                (comboBox5.SelectedIndex == 0 || emp.DataDevolucao == ((Emprestimo)comboBox5.SelectedItem).DataDevolucao)
            ).ToList();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Reset all filters and show all
            listBox1.DataSource = results;

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = listBox1.SelectedItem;
            comboBox2.SelectedItem = listBox1.SelectedItem;
            comboBox3.SelectedItem = listBox1.SelectedItem;
            comboBox4.SelectedItem = listBox1.SelectedItem;
            comboBox5.SelectedItem = listBox1.SelectedItem;
        }

        private async void btnTerminar_Click(object sender, EventArgs e)
        {
            var id = ((Emprestimo)listBox1.SelectedItem).Id;
            await Service.Library.Loans.UpdateReturnDateAsync(id, DateTime.Now);
            Close();
        }
    }
}
