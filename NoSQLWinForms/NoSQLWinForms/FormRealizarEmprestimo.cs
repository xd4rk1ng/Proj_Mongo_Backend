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
    public partial class FormRealizarEmprestimo : Form
    {
        public FormRealizarEmprestimo()
        {
            InitializeComponent();
        }

        private async void FormRealizarEmprestimo_Load(object sender, EventArgs e)
        {
            List<Estudante> results1 = await Service.Library!.Students.GetAllAsync();
            comboBox1.DataSource = results1;
            comboBox1.DisplayMember = "Nome";

            List<Livro> results2 = await Service.Library!.Books.GetAllAsync();
            comboBox2.DataSource = results2;
            comboBox2.DisplayMember = "Titulo";

        }

        private async void btnInserir_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue == null || comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            await Service.Library!.Loans.CreateAsync(new Emprestimo{ 
                EstudanteId = ((Estudante)comboBox1.SelectedValue).Id, 
                LivroId = ((Livro)comboBox2.SelectedValue).Id, 
                DataEmprestimo = dateTimePicker1.Value
            });
            Close();

        }
    }
}
