using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public static class Constants
    {
        private static string _connectionMiString { get; set; } =
            @"Data Source=SIARHEI-KHARLAP\SQLEXPRESS;Initial Catalog=DB2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static string ConnectionString { get => _connectionMiString;}
    }
}
