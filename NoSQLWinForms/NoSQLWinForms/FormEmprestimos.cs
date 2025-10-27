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
        public FormEmprestimos()
        {
            InitializeComponent();
        }

        private async void FormEmprestimos_Load(object sender, EventArgs e)
        {
            List<Emprestimo> results = await Service.Library!.Loans.GetAllAsync();


            // to get objects associated with id
            foreach(Emprestimo emp in results)
            {
                emp.EstudanteObj = await Service.Library.Students.GetByIdAsync(emp.EstudanteId);
                emp.LivroObj = await Service.Library.Books.GetByIdAsync(emp.LivroId);
            }
            listBox1.DataSource = results;
            // listBox1.DisplayMember = 
            // default display member calls object ToString() method, which is overriden to display 
            comboBox1.DataSource = results;
            comboBox1.DisplayMember = "Id";

            comboBox2.DataSource = results;
            comboBox2.DisplayMember = "EstudanteObj";
            
            comboBox3.DataSource = results;
            comboBox3.DisplayMember = "LivroObj";

            comboBox4.DataSource = results;
            comboBox4.DisplayMember = "DataEmprestimo";

            comboBox5.DataSource = results;
            comboBox5.DisplayMember = "DataDevolucao";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FormRealizarEmprestimo formRealizarEmprestimo = new FormRealizarEmprestimo();
            formRealizarEmprestimo.ShowDialog();
        }
    }
}
