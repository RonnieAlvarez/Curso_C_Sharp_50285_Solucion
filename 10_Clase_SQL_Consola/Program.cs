using _10_Clase_SQL_Consola.modelo;
using System.Data.SqlClient;


namespace _10_Clase_SQL_Consola.database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorDeBaseDeDatos db = new GestorDeBaseDeDatos();
            try
            {
                //Usuario usuarioObtenido = db.ObtenerUsuarioPorId(1);
                //Console.WriteLine(usuarioObtenido.ToString());

                // Usuario usuarioNuevo = new Usuario("Federico", "Garza", "Gape", "12345", "Gapp@gmail.com");
                //if (db.AgregarUsuario(usuarioNuevo))
                //{
                //    Console.WriteLine("Agregue un usuario nuevo a la DB");
                //}
                //int sid = 6;
                //if (db.BorraUsuarioPorId(@sid))
                //{
                //    Console.WriteLine($"Se elimino el usuario No: {sid} a la db");
                //}
                //int sid = 3;
                //Usuario usuarioActualizar = new ("Ramon", "Lopez", "pera", "12345", "peGapp@gmail.com");
                //if (db.UpdateUsuarioPorId(@sid,usuarioActualizar))
                //{
                //    Console.WriteLine($"Se Actualizo el usuario No: {sid} en la db");
                //}

                List<Usuario> usuarios = db.ListarUsuarios();
                foreach (Usuario usuario in usuarios)
                {
                    Console.WriteLine(usuario.ToString());
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}