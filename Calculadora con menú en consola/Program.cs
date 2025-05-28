using System;

class Calculadora
{
    static void Main()
    {
        int opcion;
        double num1, num2, resultado;

        do
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA ===\n");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");
            Console.WriteLine("5 - Elevar un número a la potencia");
            Console.WriteLine("6 - Salir");
            Console.Write("\nSeleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            if (opcion >= 1 && opcion <= 5)
            {
                Console.Write("Ingrese el primer número: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                num2 = double.Parse(Console.ReadLine());
            } 
            else
            {
                num1 = num2 = resultado = 0;
            }

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"\nResultado: {num1} + {num2} = {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"\nResultado: {num1} - {num2} = {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"\nResultado: {num1} * {num2} = {resultado}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"\nResultado: {num1} / {num2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("\nError: División por cero.");
                    }
                    break;
                case 5:
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine($"\nResultado: {num1} ^ {num2} = {resultado}");
                    break;
                case 6:
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                    break;
            }

            if (opcion != 6)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 6);
    }
}
