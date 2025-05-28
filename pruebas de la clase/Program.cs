using System;

public class EcuacionCuadratica
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Ecuaciones Cuadráticas (ax^2 + bx + c = 0)");

        try
        {
            // Solicitar los coeficientes al usuario
            Console.Write("Introduce el valor de 'a': ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Introduce el valor de 'b': ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Introduce el valor de 'c': ");
            double c = double.Parse(Console.ReadLine());

            // Validar si 'a' es cero
            if (a == 0)
            {
                // No es una ecuación cuadrática, lanza una excepción personalizada o ArgumentException.
                // Aquí usamos ArgumentException para simplicidad, pero podrías definir tu propia excepción.
                throw new ArgumentException("El coeficiente 'a' no puede ser cero para una ecuación cuadrática.");
            }

            // Calcular el discriminante
            double discriminante = (b * b) - (4 * a * c);

            // Manejar los diferentes casos del discriminante
            if (discriminante >= 0)
            {
                // Raíces reales
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                Console.WriteLine($"\nLas raíces reales son:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else
            {
                // Raíces complejas (discriminante negativo)
                // Lanza una excepción personalizada para indicar raíces complejas
                throw new InvalidOperationException("La ecuación tiene raíces complejas (discriminante negativo).");
            }
        }
        catch (FormatException ex)
        {
            // Se ejecuta si el usuario introduce algo que no es un número.
            Console.WriteLine("\nError de entrada: Por favor, introduce solo números válidos para los coeficientes.");
            Console.WriteLine($"Detalles: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            // Se ejecuta si 'a' es cero.
            Console.WriteLine($"\nError de cálculo: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            // Se ejecuta si el discriminante es negativo.
            Console.WriteLine($"\nError matemático: {ex.Message}");
        }
        catch (OverflowException ex)
        {
            // Se ejecuta si los números son demasiado grandes o pequeños para el tipo double.
            Console.WriteLine("\nError numérico: Los números introducidos son demasiado grandes o pequeños.");
            Console.WriteLine($"Detalles: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Captura cualquier otra excepción inesperada.
            Console.WriteLine("\nHa ocurrido un error inesperado durante el cálculo de la ecuación cuadrática.");
            Console.WriteLine($"Detalles del error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\n--- Fin del programa de cálculo de ecuaciones cuadráticas ---");
        }

        Console.WriteLine("Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}