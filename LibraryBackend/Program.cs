using MongoDB.Driver;
namespace LibraryBackend;

public class MongoService
{
    private readonly IMongoDatabase _database;

    public MongoService( string serverIp,  string serverUser,  string serverPasswd)
    {
        var client = new MongoClient($"mongodb://{serverUser}:{serverPasswd}@{serverIp}:27017/admin");
        _database = client.GetDatabase("LibraryDB");
    }

    public IMongoCollection<StudentModel> Students  => _database.GetCollection<StudentModel>("Students");
    public IMongoCollection<BookModel> Books => _database.GetCollection<BookModel>("Books");
    public IMongoCollection<LoanModel> Loans => _database.GetCollection<LoanModel>("Loans");
}

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        const string serverUser = "root";
        const string serverPasswd = "atec123";
        const string serverIp = "192.168.109.129";


        // Configure the HTTP request pipeline.
        var mongoService = new MongoService(serverIp, serverUser, serverPasswd);

        app.MapGet("/students", async () =>
            await mongoService.Students.Find(_ => true).ToListAsync()
        );

        app.MapPost("/students", async (StudentDTO student) =>
        {
            var newStudent = new StudentModel { Name = student.Name, Age = student.Age };
            await mongoService.Students.InsertOneAsync(newStudent);
            return newStudent;
        });


        app.Run();
    }
}
