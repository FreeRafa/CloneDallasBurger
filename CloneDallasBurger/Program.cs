using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

IConfiguration config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString = config.GetConnectionString("CloneDallasBurger")!;

using (SqlConnection conn = new SqlConnection(connectionString))
{
    try
    {
        conn.Open();
        Console.WriteLine("Ligação feita com sucesso!");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro ao ligar: " + ex.Message);
    }
}
