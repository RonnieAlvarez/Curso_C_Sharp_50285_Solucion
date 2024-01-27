using _10_SQL_formulario.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SQL_formulario.db
{
    internal class GestorDB
    {
        private string stringConnection;

        public GestorDB()
        {
            this.stringConnection = @"Server=localhost;Database=coderhouse;Trusted_Connection=True;";
        }
        public modelo.Usuario ObtenerUsuarioPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "SELECT * FROM Usuario WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id); // binding para evitar el SQL Injection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string nombreUsuario = reader.GetString(3);
                    string password = reader.GetString(4);
                    string email = reader.GetString(5);

                    modelo.Usuario usuario = new modelo.Usuario(id, nombre, apellido, nombreUsuario, password, email);

                    return usuario;
                }
                throw new Exception("Id No encontrado");
            }
        }
        public bool AgregarUsuario(modelo.Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail)  values" +
                    " (@nombre,@apellido,@nombreUsuario,@password,@eMail)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("password", usuario.Password);
                command.Parameters.AddWithValue("email", usuario.Email);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool BorraUsuarioPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "DELETE FROM Usuario WHERE id= @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Usuario no encontrado");
        }

        public bool UpdateUsuarioPorId(int id, modelo.Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "UPDATE Usuario SET  Nombre=@nombre,Apellido=@apellido,NombreUsuario=@nombreUsuario,Contraseña=@password,Mail=@email WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("password", usuario.Password);
                command.Parameters.AddWithValue("email", usuario.Email);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            throw new Exception(message: "Usuario Actualizado");
        }
        public List<modelo.Usuario> ListarUsuarios()
        {
            List<modelo.Usuario> usuarios = new List<modelo.Usuario>();
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "SELECT * FROM Usuario";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string nombreUsuario = reader.GetString(3);
                    string password = reader.GetString(4);
                    string email = reader.GetString(5);

                    modelo.Usuario usuario = new modelo.Usuario(idObtenido, nombre, apellido, nombreUsuario, password, email);
                    usuarios.Add(usuario);
                }
                return usuarios;
            }

            throw new Exception("Id No encontrado");
        }
    }
}
