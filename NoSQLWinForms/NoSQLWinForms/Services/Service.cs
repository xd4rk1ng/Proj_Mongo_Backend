using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using NoSQLWinForms.Models;
namespace NoSQLWinForms.Services
{
    public class Service
    {
        private static Service? _instance; // singleton
        protected readonly IMongoDatabase _database;

        public readonly StudentService Students;
        public readonly BookService Books;
        public readonly LoanService Loans;

        // Protected constructor so only this class can instantiate it
        protected Service()
        {
            var client = new MongoClient("mongodb://root:atec123@192.168.47.131:27017/admin");
            _database = client.GetDatabase("library");

            // Pass the shared _database to each collection service
            Students = new StudentService(_database);
            Books = new BookService(_database);
            Loans = new LoanService(_database);
        }

        // Singleton accessor
        public static Service Library
        {
            get
            {
                if (_instance == null)
                    _instance = new Service();
                return _instance;
            }
        }
    }
}