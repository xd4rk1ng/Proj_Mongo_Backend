using MongoDB.Driver;

namespace NoSQLWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            ApplicationConfiguration.Initialize();

            // CONFIG HERE
            const string serverUser = "root";
            const string serverPasswd = "atec123";
            const string serverIp = "192.168.47.131";
            string connectionString = $"mongodb://{serverUser}:{serverPasswd}@{serverIp}:27017/admin";

            // TEST DB AND COLL NAMES, SUBJECT TO CHANGE
            string databaseName = "library";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);

            // LOCAL LISTS FOR TESTING PURPOSES
            //List<Estudante> estudantes = new List<Estudante>();
            //List<Livro> livros = new List<Livro>();
            //List<Emprestimo> emprestimos = new List<Emprestimo>();

            //estudantes.Add(new Estudante("Jo�o Sharp", 21, "Engenharia de Software", "mail@mail.com"));
            //livros.Add(new Livro("123456789", "1489", "Big Brother Returns", "Orge Georwell", new DateTime(2000, 10, 01), "Porto Editora", 297, "A t�o aclamada sequela."));
            //emprestimos.Add(new Emprestimo(estudantes[0], livros[0], DateTime.Now, DateTime.Now.AddDays(14)));

            Application.Run(new Form1(db));
        }
    }
}