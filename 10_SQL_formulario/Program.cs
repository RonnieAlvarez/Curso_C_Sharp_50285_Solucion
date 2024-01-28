using _10_SQL_formulario.db;
using _10_SQL_formulario.modelo;
using System.Data.SqlClient;

namespace _10_SQL_formulario
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmInicio());
          //  UsuarioData dbUsuario = new UsuarioData();
          //  try
          //  {
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

            //    List<Usuario> usuarios = dbUsuario.ListarUsuarios();
            //    foreach (Usuario usuario in usuarios)
            //    {
            //        Console.WriteLine(usuario.ToString());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }
    }
}