namespace _02_Clase_Console.Utils
{
    internal class Utils
    {
        public static bool SolicitarConfirmacion(string mensaje)
        {
            string entrada;
            while (true)
            {
                Console.Write(mensaje + " (S/N): ");
                entrada = Console.ReadLine().ToUpper();
                if (entrada.Equals("N")) return false;
                else
                {
                    if (entrada.Equals("S")) return true;
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese S o N.");
                        continue;
                    }
                }

            }
        }
    }
}

