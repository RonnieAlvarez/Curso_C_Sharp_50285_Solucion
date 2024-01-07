while (true)
{
    Console.Write("Ingrese el primer lado del triángulo: ");
    string input1 = Console.ReadLine();
    Console.Write("Ingrese el segundo lado del triángulo: ");
    string input2 = Console.ReadLine();
    Console.Write("Ingrese el tercer lado del triángulo: ");
    string input3 = Console.ReadLine();
    try
    {

        double lado1 = Convert.ToDouble(input1);
        double lado2 = Convert.ToDouble(input2);
        double lado3 = Convert.ToDouble(input3);

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
                Console.WriteLine("");
                Console.WriteLine("Un triángulo equilátero es un triángulo que tiene\nsus tres lados de la misma longitud y \ncuyos ángulos internos presentan la misma medida");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
                Console.WriteLine("");
                Console.WriteLine("El triángulo isósceles es un triángulo que \ntiene dos lados iguales y uno diferente. ");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
                Console.WriteLine("");
                Console.WriteLine("Un triángulo escaleno es una figura \ngeométrica con tres lados de diferentes\nlongitudes y tres ángulos de diferentes medidas.\nLos ángulos de un triángulo escaleno siempre suman 180°.");
            }
            break;
        }
        else
        {
            Console.WriteLine("Los números ingresados no pueden formar un triángulo.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, ingresa un número válido.");
    }
}
Console.WriteLine("");
Console.WriteLine("========================================================");
Console.ReadKey();