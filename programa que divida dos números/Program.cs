using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el dividendo: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el divisor: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 != 0)
        {
            double resultado = num1 / num2;
            Console.WriteLine("Resultado: " + resultado);
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
    }
}
