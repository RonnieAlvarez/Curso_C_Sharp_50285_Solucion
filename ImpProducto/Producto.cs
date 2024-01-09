using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Producto
{
    private int _codigo;
    private string _descripcion;
    private double _precioDeCompra;
    private double _precioDeVenta;
    private string _categoria;

    // * Constructor por defecto
    public Producto()
    {
        _codigo = 0;
        _descripcion = string.Empty;
        _precioDeCompra = 0;
        _precioDeVenta = 0;
        _categoria = string.Empty;
    }

    //Constructor parametrizado

    public Producto(int codigo, string descripcion, double precioCompra, double precioVenta, String categoria)
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
    public double PrecioDeCompra { get; set; }

    public double PrecioDeVenta { get; set; }

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

