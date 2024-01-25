using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ClaseSQL_2
{
    internal class Producto
    {
        private int _id;
        private string _descripciones;
        private double _costo;
        private double _precioVenta;
        private int _stock;

        // * Constructor por defecto
        public Producto()
        {
            this._id = 0;
            this._descripciones = String.Empty;
            this._costo = 0;
            this._precioVenta = 0;
            this._stock = 0;
        }

        //Constructor parametrizado

        public Producto(int id, string descripciones, double costo, double precioVenta, int stock)
        {
            this._id = id;
            this._descripciones = descripciones;
            this._costo = costo;
            this._precioVenta = precioVenta;
            this._stock = stock;
        }


        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public string Descripciones
        {
            get
            {
                return this._descripciones;
            }
            set
            {
                this._descripciones = value;
            }
        }
        public double Costo
        {
            get
            {
                return this._costo;
            }
            set
            {
                this._costo = value;
            }
        }

        public double PrecioVenta
        {
            get
            {
                return this._precioVenta;
            }
            set
            {
                this._precioVenta = value;
            }
        }
        public int Stock
        {
            get
            {
                return this._stock;
            }
            set
            {
                this._stock = value;
            }
        }


        public bool HayprecioVenta()
        {
            return this._precioVenta > 0;
        }
    }
}
