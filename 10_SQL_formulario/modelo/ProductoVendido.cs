namespace _10_SQL_formulario.modelo
{
    internal class ProductoVendido
    {
        int id;
        int idProducto;
        int stock;
        int idVenta;

        public ProductoVendido()
        {
            this.id = 0;
            this.idProducto = 0;
            this.stock = 0;
            this.idVenta = 0;

        }
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;
        }

        public int Id{get{return this.id;} set { this.id = value; } }
        public int IdProducto{get{return this.idProducto;} set { this.idProducto = value; } }
        public int Stock {get { return this.stock; }set{ this.stock = value; } }
        public int IdVenta { get { return this.idVenta; } set { this.idVenta = value; } }

    }
}
