using MongoDB.Driver;
using NoSQLWinForms.Services;
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
            //const string serverUser = "root";
            //const string serverPasswd = "atec123";
            //const string serverIp = "192.168.109.129";
            //string connectionString = $"mongodb://{serverUser}:{serverPasswd}@{serverIp}:27017/admin";
            Application.Run(new Form1());
        }
    }
}