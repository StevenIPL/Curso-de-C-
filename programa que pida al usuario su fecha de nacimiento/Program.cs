using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Introduce el día de nacimiento: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Introduce el mes de nacimiento: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Introduce el año de nacimiento: ");
            int año = int.Parse(Console.ReadLine());

            // Crear el objeto DateTime con los valores proporcionados
            DateTime fechaNacimiento = new DateTime(año, mes, dia);

            // Obtener el día de la semana en español
            string diaSemana = fechaNacimiento.ToString("dddd", new System.Globalization.CultureInfo("es-ES"));

            Console.WriteLine($"Naciste un {diaSemana}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fecha no válida. Asegúrate de ingresar valores numéricos correctos.");
        }

        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();
    }
}
