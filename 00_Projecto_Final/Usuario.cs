using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Projecto_Final
{
    internal class Usuario
    {
        int id;
        string nombre;
        string apellido;
        string nombreUsuario;
        string contrasena;
        string eMail;

        public Usuario() 
        { 
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.nombreUsuario = string.Empty;
            this.contrasena = string.Empty;
            this.eMail = string.Empty;
        }

        public Usuario(string nombre,string apellido,string nombreUsuario,string contrasena,string eMail)
        { 
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contrasena=contrasena;
            this.eMail = eMail;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get {  return apellido; } set {    apellido = value; } }
        public string NombreUsuario { get { return nombreUsuario; }set {nombreUsuario=value; } }
        public string Contrasena { get { return contrasena; } set { contrasena = value; } }
        public string EMail { get { return eMail; } set { eMail = value; } }

    }
}
