using System.Data.SqlClient;

namespace DbHelper;

public class DbProvider
{
    public string ConnectionString { get; }


    public DbProvider(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public List<TReturn> ExecuteCommand<TReturn>(string command, Func<object[], TReturn> dataMapper)
    {
        using var conn = new SqlConnection(ConnectionString);
        using var cmd = new SqlCommand(command, conn);
        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();

        var result = new List<TReturn>();
        while (reader.Read())
        {
            var values = new object[100];
            int count = reader.GetValues(values);

            result.Add(dataMapper(values));
        }

        return result;
    }
}