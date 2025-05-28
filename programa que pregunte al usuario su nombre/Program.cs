using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce tu nombre completo (nombre y apellidos): ");
        string entrada = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(entrada))
        {
            // Separar por espacios (compatible con C# < 8.0)
            string[] palabras = entrada.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string iniciales = "";

            foreach (string palabra in palabras)
            {
                iniciales += char.ToUpper(palabra[0]);
            }

            Console.WriteLine($"Tus iniciales son: {iniciales}");
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }

        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();
    }
}
