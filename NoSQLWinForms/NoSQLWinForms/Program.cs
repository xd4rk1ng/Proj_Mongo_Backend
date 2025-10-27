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
            Application.Run(new Form1());
        }
    }
}