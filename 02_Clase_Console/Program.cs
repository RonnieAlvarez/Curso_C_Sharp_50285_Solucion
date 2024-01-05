using _02_Clase_Console.Utils;

string comision;
string inputComision;
while (true)
{
    Console.WriteLine("Universidad");
    Console.WriteLine("");
    Console.WriteLine("Estado de Notas");
    Console.WriteLine("");
    Console.WriteLine("Ingresar los datos del alumno");
    Console.WriteLine("-------------------------------");
    string? input;
    do
    {
        Console.Write("Digite la comisión (A,B,C): ");
        input = Console.ReadLine();
        inputComision = input ?? string.Empty;
    } while (string.IsNullOrEmpty(inputComision));

    comision = inputComision switch
    {
        "A" => "Turno de la Mañana",
        "B" => "Turno de la Tarde",
        "C" => "Turno de la Noche",
        _ => "No tiene Turno Asignado",
    };
    Console.WriteLine(comision);
    Console.WriteLine("-------------------------------");
    byte nota;
    while (true)
    {
        Console.Write("Digite la Nota (0-10): ");
        input = Console.ReadLine();
        if (byte.TryParse(input, out nota) && (byte.Parse(input) >= 0 && byte.Parse(input) <= 10))
        {
            Console.WriteLine("Valor ingresado correctamente.");
            Console.WriteLine("");
            if (nota >= 0 && nota <= 10)
            {
                if (nota < 4)
                {
                    Console.WriteLine("El Alumno Recursa la Materia");
                }
                else if (nota >= 4 && nota <= 7)
                {
                    Console.WriteLine("El Alumno Aprobó");
                }
                else
                {
                    Console.WriteLine("El alumno Promociona la Materia");
                }
            }
            break;
        }
        else
        {
            Console.WriteLine("El valor ingresado no es válido. Por favor, inténtelo de nuevo.");
            continue;
        }
    }

    if (!Utils.SolicitarConfirmacion("Desea agregar otro alumno"))
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("--------------fin--------------");
        Console.ReadKey();
        break;
    }
    else
    {
        Console.Clear();
        continue;
    }
}



