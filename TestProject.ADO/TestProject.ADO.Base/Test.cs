using System;
using System.Configuration;
using System.Data.SqlClient;

namespace TestProject.ADO.Base
{
    public class Test
    {
        public void Run()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Console.WriteLine(connectionString);
            TestConnection();
        }

        public void TestConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                Console.WriteLine("Connection opened");
            }
        }
    }
}