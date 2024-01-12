using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Projecto_Final
{
    internal class Producto
    {
        int id;
        string descripcion;
        double costo;
        double precioVenta;
        int stock;
        int idUsuario;


        public Producto() 
        {
            this.id = 0;
            this.descripcion=string.Empty;
            this.costo = 0;
            this.precioVenta = 0;
            this.stock = 0;
            this.idUsuario = 0;
        }
        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }
        public int Id { get { return this.id; } set { this.id = value; } }
        public string Descripcion { get { return this.descripcion; } set { this.descripcion = value; } }
        public double Costo { get { return this.costo; } set { this.costo = value; } }
        public double PrecioVenta { get { return this.precioVenta; } set { this.precioVenta = value; } }
        public int Stock { get { return this.stock; } set { this.stock = value; } }
        public int IdUsuario { get { return this.idUsuario; }set { this.idUsuario = value; } }
    }
}
