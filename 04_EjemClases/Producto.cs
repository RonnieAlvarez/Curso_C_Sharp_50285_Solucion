namespace Producto
{
    internal class Producto
    {
        private int _codigo;
        private string _descripcion;
        private double _precioDeCompra;
        private double _precioDeVenta;
        private string _categoria;

        // * Constructor por defecto
        public Producto()
        {
            this._codigo = 0;
            this._descripcion = String.Empty;
            this._precioDeCompra = 0;
            this._precioDeVenta = 0;
            this._categoria = String.Empty;
        }

        //Constructor parametrizado

        public Producto(int codigo, string descripcion, double precioCompra, double precioVenta, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioDeCompra = precioCompra;
            this._precioDeVenta = precioVenta;
            this._categoria = categoria;
        }


        public int Codigo
        {
            get
            {
                return this._codigo;
            }
            set
            {
                this._codigo = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                this._descripcion = value;
            }
        }
        public double PrecioDeCompra
        {
            get
            {
                return this._precioDeCompra;
            }
            set
            {
                this._precioDeCompra = value;
            }
        }

        public double PrecioDeVenta
        {
            get
            {
                return this._precioDeVenta;
            }
            set
            {
                this._precioDeVenta = value;
            }
        }

        public string Categoria
        {
            get
            {
                if (!string.IsNullOrEmpty(this._categoria))
                    return this._categoria;
                else return "Sin Categoria";
            }
        }

        public bool HayPrecioDeVenta()
        {
            return this._precioDeVenta > 0;
        }
    }
}