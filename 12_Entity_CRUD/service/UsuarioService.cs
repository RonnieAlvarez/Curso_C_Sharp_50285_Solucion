using _12_Entity_CRUD.database;
using _12_Entity_CRUD.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Entity_CRUD.service
{
    public static class UsuarioService
    {
        public static List<Usuario> GetUsuarios()
        {
            using (CoderContext context = new CoderContext())
            {
                List<Usuario> usuarios = context.Usuarios.ToList();
                return usuarios;
            }
        }
        public static Usuario GetUsuario(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Usuario? UsuarioBuscado = context.Usuarios.Where(u => u.Id == id).FirstOrDefault();
                return UsuarioBuscado;
            }
        }

        public static bool AgregarUsuario(Usuario usuario)
        {
            using (CoderContext context = new CoderContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return true;
            }
        }
        public static bool ActualizarUsuarioXId(Usuario usuario, int Id)
        {
            using (CoderContext context = new CoderContext())
            {
                Usuario? usuarioBuscado = GetUsuario(Id);
                usuarioBuscado.Nombre = usuario.Nombre;
                usuarioBuscado.Apellido = usuario.Apellido;
                usuarioBuscado.NombreUsuario = usuario.NombreUsuario;
                usuarioBuscado.Contraseña = usuario.Contraseña;
                usuarioBuscado.Mail = usuario.Mail;

                context.Usuarios.Update(usuarioBuscado);
                context.SaveChanges();
                return true;
            }
        }
    }
}
