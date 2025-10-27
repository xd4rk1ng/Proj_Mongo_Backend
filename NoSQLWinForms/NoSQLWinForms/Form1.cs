using MongoDB.Driver;
using System.Threading.Tasks;

namespace NoSQLWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEstudantes formEstudantes = new FormEstudantes();
            formEstudantes.ShowDialog();
        }

        private void btnFormLivros_Click(object sender, EventArgs e)
        {
            FormLivros formLivros = new FormLivros();
            formLivros.ShowDialog();
        }

        private void btnFormEmprestimos_Click(object sender, EventArgs e)
        {
            FormEmprestimos formEmprestimos = new FormEmprestimos();
            formEmprestimos.ShowDialog();
        }
    }
}
