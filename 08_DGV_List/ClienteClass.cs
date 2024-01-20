using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DGV_List
{
    internal class ClienteClass
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public short Edad { get; set; }

        public ClienteClass(long id, string nombre,string direccion,short edad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;  
        }
        public override bool Equals(object obj)
        {
            ClienteClass cliente = (ClienteClass)obj;
            return this.Id.Equals(cliente.Id);
        }
    }
}
