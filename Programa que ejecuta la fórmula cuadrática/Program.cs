using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminante = Math.Pow(b, 2) - 4 * a * c;

        if (discriminante > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine("Las soluciones son: x1 = " + x1 + ", x2 = " + x2);
        }
        else if (discriminante == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("La solución doble es: x = " + x);
        }
        else
        {
            Console.WriteLine("No existen soluciones reales.");
        }
    }
}
