﻿namespace _10_SQL_formulario.modelo
{
    internal class Producto
    {
        int id;
        string descripciones;
        decimal costo;
        decimal precioVenta;
        int stock;
        int idUsuario;


        public Producto() 
        {
            this.id = 0;
            this.descripciones=string.Empty;
            this.costo = 0;
            this.precioVenta = 0;
            this.stock = 0;
            this.idUsuario = 0;
        }
        public Producto(int id, string descripciones, decimal costo, decimal precioVenta, int stock, int idUsuario)
        {
            this.id = id;
            this.descripciones = descripciones;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }
        public int Id { get { return this.id; } set { this.id = value; } }
        public string Descripciones { get { return this.descripciones; } set { this.descripciones = value; } }
        public decimal Costo { get { return this.costo; } set { this.costo = value; } }
        public decimal PrecioVenta { get { return this.precioVenta; } set { this.precioVenta = value; } }
        public int Stock { get { return this.stock; } set { this.stock = value; } }
        public int IdUsuario { get { return this.idUsuario; }set { this.idUsuario = value; } }
    }
}
