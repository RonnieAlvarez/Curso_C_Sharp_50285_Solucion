
using System.Collections.Immutable;
using System.Numerics;

object[,] articulos = new object[3, 3];
string? codigoProducto = string.Empty;
int totalCompra = 0;

initDatos();

Console.WriteLine("-------  Bienvenido a la Tienda de articulos de Limpieza  --------");
Console.WriteLine("------------------------------------------------------------------");
while (codigoProducto != null && codigoProducto.ToLower() != "fin")
{
    Console.Write(" Digite el código del producto:  (o 'Fin' para terminar): ");
    codigoProducto = Console.ReadLine();
    if (codigoProducto == null) continue;
    if (codigoProducto == "fin") break;
    int posicionProducto = existeProducto(codigoProducto.ToString().ToLower());
    if (posicionProducto == -1)
    {
        Console.WriteLine("El código digitado no existe!!");
        continue;
    };
    Console.Write("Digite la Cantidad: ");
    int cantidad = Convert.ToInt32(Console.ReadLine());
    int subTotal = Convert.ToInt32(cantidad * Convert.ToInt32(articulos[2, posicionProducto]));
    totalCompra += subTotal;
    Console.WriteLine($"Cant. {cantidad} | Cod.{codigoProducto} | Descripción: {articulos[1, posicionProducto]}. | Monto: {subTotal}");
    Console.WriteLine("------------------------------------------------------------------");
};
if (totalCompra >= 0)
{
    Console.WriteLine("==================================================================");
    Console.WriteLine($"El Monto total de la compra es: {totalCompra}");
    Console.WriteLine("Gracias por comprar en nuestra tienda");
    Console.WriteLine("==================================================================");
};

int existeProducto(string codigoProducto)
{
    for (int i = 0; i < articulos.GetLength(0); i++)
    {
        if (articulos[0, i].ToString() == codigoProducto.ToUpper()) return i;
    };
    return -1;
};
void initDatos()
{
    articulos[0, 0] = "DES";
    articulos[0, 1] = "JP";
    articulos[0, 2] = "DET";

    articulos[1, 0] = "Desodorante";
    articulos[1, 1] = "Jabón en Polvo";
    articulos[1, 2] = "Detergente";

    articulos[2, 0] = 200;
    articulos[2, 1] = 300;
    articulos[2, 2] = 250;
}

