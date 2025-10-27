namespace backendCSharp;

using MongoDB.Driver;
using MongoApi;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // CONFIG HERE
        const string serverUser = "root";
        const string serverPasswd = "atec123";
        const string serverIp = "192.168.47.131"; // Insira o IP da sua VM aqui
        string connectionString = $"mongodb://{serverUser}:{serverPasswd}@{serverIp}:27017/admin";
        
        // TEST DB AND COLL NAMES, SUBJECT TO CHANGE
        string databaseName = "library";
        string collectionName = "students";


        var client = new MongoClient(connectionString);
        var db = client.GetDatabase(databaseName);
        var collection = db.GetCollection<StudentModel>(collectionName);

        var student = new StudentModel { FirstName = "Joao", LastName = "Sharp" };

        // ATTENTION: some methods require "await". This is normal, and C# compiler should warn you in most cases
        await collection.InsertOneAsync(student);

        // Example: Query
        var cursor = await collection.FindAsync(_ => true);
        var results = cursor.ToList();

        // Print query
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }



    }
}
