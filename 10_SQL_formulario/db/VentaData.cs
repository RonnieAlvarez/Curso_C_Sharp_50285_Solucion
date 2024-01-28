using _10_SQL_formulario.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SQL_formulario.db
{
    internal class VentaData
    {
        private string stringConnection;

        public VentaData()
        {
            this.stringConnection = @"Server=localhost;Database=coderhouse;Trusted_Connection=True;";
        }
        public modelo.clsVenta ObtenerVentaPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "SELECT * FROM Venta WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id); // binding para evitar el SQL Injection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    string comentarios = reader.GetString(1);
                    int idUsuario = Convert.ToInt32(reader[2]);
                    

                    modelo.clsVenta venta = new modelo.clsVenta(id, comentarios,idUsuario);

                    return venta;
                }
                throw new Exception("Id No encontrado");
            }
        }
        public bool AgregarVenta(modelo.clsVenta venta)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "INSERT INTO Venta (comentarios,idUsuario)  values" +
                    " (@comentarios,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("comentarios", venta.Comentarios);
                command.Parameters.AddWithValue("idUsuarios", venta.IdUsuario);
                
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool BorraVentaPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "DELETE FROM Venta WHERE id= @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Venta no encontrada");
        }

        public bool UpdateVentaPorId(int id, modelo.clsVenta venta)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "UPDATE Venta SET  Comentarios=@comentarios,IdUsuario=@idUsuario WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("comentarios", venta.Comentarios);
                command.Parameters.AddWithValue("idUsuario", venta.IdUsuario);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Venta Actualizada");
        }
        public List<modelo.clsVenta> ListarVentas()
        {
            List<modelo.clsVenta> lstVentas = new List<modelo.clsVenta>();
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "SELECT * FROM Venta";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    string comentarios = reader.GetString(1);
                    int idUsuario = Convert.ToInt32(reader[2]);

                    modelo.clsVenta venta = new modelo.clsVenta(idObtenido, comentarios, idUsuario);
                    lstVentas.Add(venta);
                }
                return lstVentas;
            }

            throw new Exception("Id No encontrado");
        }
    }
}
