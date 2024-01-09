using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto;

public class ImpProducto
{
    static void Main(string[] args)
    {
        Producto producto1 = new Producto(1, "pañales", 5, 6, null);
        Console.WriteLine("Codigo:" + producto1.Codigo + " " +
            "Descripcion: " + producto1.Descripcion + " " +
            "Precio de Compra: "+producto1.PrecioDeCompra + " " +
            "Precio de Venta: " +producto1.PrecioDeVenta+ " " +
            "Categoria: " + producto1.Categoria);

        producto1.Codigo = 2;
        producto1.Descripcion = "pañales chicos";
        producto1.PrecioDeCompra = 5;
        producto1.PrecioDeVenta = 6;
        

        if (producto1.HayPrecioDeVenta())
            Console.WriteLine("Codigo:" + producto1.Codigo + " " +
            "Descripcion: " + producto1.Descripcion + " " +
            "Precio de Compra: " + producto1.PrecioDeCompra + " " +
            "Precio de Venta: " + producto1.PrecioDeVenta + " " +
            "Categoria: " + producto1.Categoria);
        else
            Console.WriteLine("El Producto no fue publicado aún");

        Producto producto2 = new Producto();
        producto2.Codigo = 03;
        producto2.Descripcion = "Desodorante";
        producto2.PrecioDeCompra = 10;
        producto2.PrecioDeVenta = 4;

        if (producto2.HayPrecioDeVenta())
            Console.WriteLine("Codigo:" + producto2.Codigo + " " +
              "Descripcion: " + producto2.Descripcion + " " +
              "Precio de Compra: " + producto2.PrecioDeCompra + " " +
              "Precio de Venta: " + producto2.PrecioDeVenta + " " +
              "Categoria: " + producto2.Categoria);
        else
            Console.WriteLine("El Producto no fue publicado aún");
    }
}
