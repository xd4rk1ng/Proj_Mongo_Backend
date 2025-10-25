namespace backendCSharp;

using MongoDB.Driver;
using MongoApi;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string connectionString = "mongodb://root:atec123@127.0.0.1:27017/admin";
        string databaseName = "library";
        string collectionName = "students";

        var client = new MongoClient(connectionString);
        var db = client.GetDatabase(databaseName);
        var collection = db.GetCollection<StudentModel>(collectionName);

        var student = new StudentModel { FirstName = "Joao", LastName = "Sharp" };

        await collection.InsertOneAsync(student);

        var cursor = await collection.FindAsync(_ => true);
        var results = cursor.ToList();

        foreach(var result in results)
        {
            Console.WriteLine(result);
        }



    }
}
