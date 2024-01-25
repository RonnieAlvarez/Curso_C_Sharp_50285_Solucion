using System.Data.SqlClient;

namespace SqlPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=localhost;Database=master;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand commando = new SqlCommand("Select * from usuario", connection))
                {
                    connection.Open();
                    using (SqlDataReader dataReader = commando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var datoAUsar = dataReader.GetString(3);
                                Console.WriteLine(datoAUsar);
                            }
                        }
                    }
                    connection.Close();
                    Console.ReadKey();
                }
            }
        }
    }
}
