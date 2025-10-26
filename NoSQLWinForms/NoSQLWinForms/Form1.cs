using MongoDB.Driver;
using System.Threading.Tasks;

namespace NoSQLWinForms
{
    public partial class Form1 : Form
    {
        private readonly IMongoDatabase _db;
        public Form1(IMongoDatabase db)
        {
            InitializeComponent();
            _db = db;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEstudantes formEstudantes = new FormEstudantes(_db);
            formEstudantes.ShowDialog();
        }

        private void btnFormLivros_Click(object sender, EventArgs e)
        {
            FormLivros formLivros = new FormLivros(_db);
            formLivros.ShowDialog();
        }

        private void btnFormEmprestimos_Click(object sender, EventArgs e)
        {
            FormEmprestimos formEmprestimos = new FormEmprestimos(_db);
            formEmprestimos.ShowDialog();
        }
    }
}
