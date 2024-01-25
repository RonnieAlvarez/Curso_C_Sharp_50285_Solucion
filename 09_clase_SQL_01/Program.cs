using System.Data;
using System.Data.SqlClient;

string connectionString = @"Server=localhost;Database=master;Trusted_Connection=True;";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    using (SqlDataAdapter comando = new SqlDataAdapter("SELECT * FROM USUARIO", connection))
    {
        DataTable resultado = new DataTable();
        comando.Fill(resultado);
        foreach (DataRow row in resultado.Rows)
        {
            string[] allColumns = row.ItemArray.Select(obj => obj.ToString()).ToArray();
            Console.WriteLine(string.Join(", ", allColumns));
        }
    }
    Console.ReadKey();
}

