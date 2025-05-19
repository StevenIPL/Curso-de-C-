using System;

class ProgramaOrdenarNumeros
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            int[] numeros = new int[10];

            Console.WriteLine("Ingrese 10 números desordenados:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);

            Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n");

            // Preguntar si desea continuar
            Console.Write("¿Desea ordenar otros 10 números? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta != "s" && respuesta != "si")
            {
                continuar = false;
                Console.WriteLine("Programa finalizado.");
            }

            Console.WriteLine(); // Salto de línea para separar ejecuciones
        }
    }
}

