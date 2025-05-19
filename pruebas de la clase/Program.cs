using System;

public class NumerosPrimos
{
    public static void Main(string[] args)
    {
        Console.Write("Ingresa la cantidad de números primos que deseas ver: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Por favor, ingresa un número positivo.");
        }
        else
        {
            Console.WriteLine("Números primos:");
            int contador = 0;
            int numero = 2;

            while (contador < n)
            {
                if (EsPrimo(numero))
                {
                    Console.Write(numero + " ");
                    contador++;
                }
                numero++;
            }

            Console.WriteLine();
        }
    }

    // Función para verificar si un número es primo
    public static bool EsPrimo(int num)
    {
        if (num < 2) return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
