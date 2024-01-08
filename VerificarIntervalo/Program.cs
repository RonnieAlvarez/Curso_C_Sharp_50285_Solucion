Console.Write("Ingrese el límite inferior del intervalo: ");
double limiteInferior = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el límite superior del intervalo: ");
double limiteSuperior = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el número que quiere verificar si pertenece al intervalo: ");
double numero = Convert.ToDouble(Console.ReadLine());

if (limiteInferior <= numero && numero <= limiteSuperior)
{
    Console.WriteLine("El número pertenece al intervalo.");
}
else
{
    Console.WriteLine("El número no pertenece al intervalo.");
}