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
        using var cmd = new SqlCommand(command);
        return ExecuteCommand(cmd, dataMapper);
    }

    public List<TReturn> ExecuteCommand<TReturn>(SqlCommand command, Func<object[], TReturn> dataMapper)
    {
        using var conn = new SqlConnection(ConnectionString);
        conn.Open();
        command.Connection = conn;
        using SqlDataReader reader = command.ExecuteReader();

        var result = new List<TReturn>();
        while (reader.Read())
        {
            var values = new object[100];
            int count = reader.GetValues(values);

            result.Add(dataMapper(values));
        }

        return result;
    }

    public TReturn ExecuteScalarCommand<TReturn>(string command)
    {
        using var cmd = new SqlCommand(command);
        return ExecuteScalarCommand<TReturn>(cmd);
    }

    public TReturn ExecuteScalarCommand<TReturn>(SqlCommand command)
    {
        using var con = new SqlConnection(ConnectionString);
        con.Open();
        command.Connection = con;
        return (TReturn)command.ExecuteScalar();
    }
}