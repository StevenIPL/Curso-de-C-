using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números impares del 1 al 30:");
        for (int i = 1; i <= 30; i++)
        {
            if (i % 2 != 0)
                Console.WriteLine(i);
        }
    }
}

