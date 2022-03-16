using DbHelper;
using Models;

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
            return 0;
        } 

        public static int GetCountOfAllEmployes()
        {
            int count = 0;

            return count;
        }
    }
}
