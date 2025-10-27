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
        // a singleton is an instance of a class that is unique and the only of its kind
        // its useful so you can call class members statically (inside the namespace) without having
        // to duplicate or pass down information everytime theyre accessed
        private static Service? _instance; // singleton
        protected readonly IMongoDatabase _database;

        public readonly StudentService Students;
        public readonly BookService Books;
        public readonly LoanService Loans;

        // Protected constructor so only this class can instantiate it
        protected Service()
        {
            var client = new MongoClient("mongodb://root:atec123@192.168.109.129:27017/admin");
            _database = client.GetDatabase("library");

            // Pass the shared _database to each collection service
            Students = new StudentService(_database);
            Books = new BookService(_database);
            Loans = new LoanService(_database);
        }

        // Singleton accessor
        // if there is no instance of Service, will return a new one
        // if there is already, returns existing one
        // this way, thanks to the access modifiers, only one instance may exist
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