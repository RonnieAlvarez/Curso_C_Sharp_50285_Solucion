using System.Diagnostics.Metrics;
using System;
using System.ComponentModel.Design;

Console.WriteLine("---- Ejercicio 1 After -----");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Mostrar los nùmeros impares entre el 0 y el 100");

for (int i = 0; i < 100; i++)
{
    if (i % 2 != 0) Console.Write(i.ToString() + '-');
};

Console.WriteLine("");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Mostrar los nùmeros pares entre el 0 y el 100");

for (int i = 0; i < 100; i++)
{
    if (i % 2 == 0) Console.Write(i.ToString() + '-');
};
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Mostrar los multiplos de 3 del 0 al 100");

for (int i = 0; i < 100; i++)
{
    if (i % 3 == 0) Console.Write(i.ToString() + '-');
};
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Ingresar un número y mostrar la suma de los números que lo anteceden.");
Console.Write("Digite un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());
int suma = 0;
for (int i = numero-1 ; i >= 0; i--)
{
    suma += i;
};
Console.WriteLine($"El Resultado es: {suma}");
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Mostrar los números del 1 hasta el número ingresado.");
Console.Write("Digite un numero: ");
for (int i = 1; i < numero; i++)
{
    Console.Write("-"+i.ToString());
};
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Contar los multiplos de 3 desde la unidad hasta un num que ingresamos");
int contar = 0;
for (int i = 0; i < numero; i++)
{
    if (i % 3 == 0) contar++;
}
Console.WriteLine(contar);
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Ingresar 10 números sumar los + y multiplicar los - (0=Fin).");
int cuenta = 1;
int positivos = 0;
int negativos = 1;
while (cuenta <= 10)
{
    Console.Write($"Digite el {cuenta} número (+ o -): ");
    string input = Console.ReadLine();
    try
    {
        int entrada = Convert.ToInt32(input);
        if (entrada == 0) break;
        if (entrada < 0) negativos *= entrada;
        else positivos += entrada;
        cuenta++;
    }
    catch (FormatException ) {break;} catch (OverflowException ) {break;}
};
if (positivos + negativos > 1)
{
    Console.WriteLine($"El resultado de los números positivos fue: {positivos}");
    Console.WriteLine($"El resultado de los números negativos fue: {negativos}");
}
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Ingresar x cant de pesos y mostrar la cantidad de personas que pesan + de 80 y - de 80.");
int masde80 = 0;
int menosde80 = 0;
int control = 1;
while (control!=0)
{
    Console.Write("Ingrese el peso de la persona (0 para finalizar): ");
    string input = Console.ReadLine();
    try
    {
        control = Convert.ToInt32(input);
        if (control == 0) break;
        if (control < 80) menosde80++;
        else if (control >= 80) masde80++;
        //    menosde80--;
        continue;
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, ingresa un número válido.");
    }
}
Console.WriteLine($"La cantidad de personas con peso mayor a 80 es: {masde80}");
Console.WriteLine($"y las personas con peso inferior a 80 son : {menosde80}");
Console.WriteLine("==========================================================");
Console.WriteLine("==================== Fin Punto 1 =========================");
Console.ReadKey();

