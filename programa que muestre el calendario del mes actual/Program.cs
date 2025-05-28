using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Obtener la fecha actual
        DateTime hoy = DateTime.Now;
        int año = hoy.Year;
        int mes = hoy.Month;

        // Crear un objeto con el primer día del mes actual
        DateTime primerDiaDelMes = new DateTime(año, mes, 1);

        // Obtener el nombre del mes y mostrarlo
        string nombreMes = primerDiaDelMes.ToString("MMMM", new CultureInfo("es-ES"));
        Console.WriteLine($"\n    {char.ToUpper(nombreMes[0]) + nombreMes.Substring(1)} {año}\n");

        // Mostrar encabezado de los días de la semana
        Console.WriteLine("lu ma mi ju vi sá do");

        // Calcular el día de la semana del primer día del mes (lunes = 1, domingo = 7)
        int diaSemana = ((int)primerDiaDelMes.DayOfWeek == 0) ? 7 : (int)primerDiaDelMes.DayOfWeek;

        // Imprimir espacios para los días antes del día 1
        for (int i = 1; i < diaSemana; i++)
        {
            Console.Write("   ");
        }

        int diasEnElMes = DateTime.DaysInMonth(año, mes);

        // Imprimir los días del mes
        for (int dia = 1; dia <= diasEnElMes; dia++)
        {
            Console.Write($"{dia,2} ");

            // Saltar de línea al llegar al domingo
            DateTime fecha = new DateTime(año, mes, dia);
            if (fecha.DayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine();
        }

        Console.WriteLine("\n\nPresiona una tecla para salir...");
        Console.ReadKey();
    }
}
