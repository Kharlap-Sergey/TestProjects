using System.Data.Common;
using DbHelper;

namespace Lab2
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

        static void Test()
        {
            DbProvider provider = new DbProvider("Data Source=WSA-220-71;Initial Catalog=db2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            var result = provider.ExecuteCommand(
                @"Select * from Products", (o) => o);
        }
    }
}