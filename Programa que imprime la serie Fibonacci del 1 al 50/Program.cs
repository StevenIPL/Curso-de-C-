using System;

class Program
{
    static void Main()
    {
        int a = 0, b = 1, c = 0;

        Console.WriteLine("Serie Fibonacci hasta 50:");
        while (b <= 50)
        {
            Console.WriteLine(b);
            c = a + b;
            a = b;
            b = c;
        }
    }
}

