using DbHelper;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace Lab2
{
    public static class Logic
    {
        public static string ConnectionString { get; set; } = "Data Source=WSA-220-71;Initial Catalog=db2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public static List<Employe> GetAllEmployes()
        {
            var provider = new DbProvider(ConnectionString);

            return provider.ExecuteCommand
                (
@"
select * from employes
",
(e) => new Employe
{
    Id = (int)e[0],
    Name = (string)e[1],
    Surname = (string)e[2],
    FatherName = (string)e[3],
}
);
        }

        public static int CreateNewEmploye(Employe employe)
        {
            using var con = new SqlConnection(ConnectionString);
            con.Open();
            using var cmd = new SqlCommand("InsEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LName", employe.Surname);
            cmd.Parameters.AddWithValue("@FName", employe.Name);
            cmd.Parameters.AddWithValue("@MName", employe.FatherName);

            // Последний параметр является выходным (output)
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
            cmd.Parameters["@EmployeeID"].Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            return (int)cmd.Parameters["@EmployeeID"].Value;
        }

        public static int GetCountOfAllEmployes()
        {
            var provider = new DbProvider(ConnectionString);
            return provider.ExecuteScalarCommand<int>("SELECT COUNT (*) FROM Employes");
        }
    }
}
