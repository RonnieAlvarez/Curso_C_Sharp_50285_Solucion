using System;

string comision,inputComision;
byte nota;

Console.WriteLine("Universidad");
Console.WriteLine("");
Console.WriteLine("Estado de Notas");
Console.WriteLine("");
Console.WriteLine("Ingresar los datos del alumno");
Console.WriteLine("-------------------------------");
Console.Write("Digite la comisión (A,B,C): ");
string? input = Console.ReadLine();
inputComision = input ?? string.Empty;
while (string.IsNullOrEmpty(inputComision))
{
    Console.WriteLine("Por favor, ingrese un valor válido.");
    input = Console.ReadLine();
    inputComision = input ?? string.Empty;
}
switch (inputComision)
    {
     case "A":
        comision = "Turno de la Mañana";
        break;
    case "B":
        comision = "Turno de la Tarde";
        break;
    case "C":
        comision = "Turno de la Noche";
        break;
    default:
        comision = "No tiene Turno Asignado";
        break;
}
Console.WriteLine(comision);
Console.WriteLine("-------------------------------");
while (true)
{
    Console.Write("Digite la Nota (0-10): ");
    nota = Convert.ToByte(Console.ReadLine());
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
        break;
    }
    else continue;
}
Console.WriteLine("-------------------------------");
Console.WriteLine("--------------fin--------------");