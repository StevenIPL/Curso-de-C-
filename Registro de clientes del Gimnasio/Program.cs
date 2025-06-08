using System;
using System.Collections.Generic;
using System.Linq;

namespace GimnasioApp
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
    }

    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        static int nextId = 1;

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("*** Registro de clientes del Gimnasio ***\n");
                Console.WriteLine("1. Dar de alta un cliente");
                Console.WriteLine("2. Mostrar detalles de un cliente");
                Console.WriteLine("3. Listar clientes");
                Console.WriteLine("4. Buscar cliente (Nombre)");
                Console.WriteLine("5. Dar de baja un cliente");
                Console.WriteLine("6. Modificar un cliente");
                Console.WriteLine("7. Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": DarDeAlta(); break;
                    case "2": MostrarDetalles(); break;
                    case "3": ListarClientes(); break;
                    case "4": BuscarCliente(); break;
                    case "5": DarDeBaja(); break;
                    case "6": ModificarCliente(); break;
                    case "7": salir = true; break;
                    default: Console.WriteLine("Opción inválida."); Esperar(); break;
                }
            }
        }

        static void DarDeAlta()
        {
            Console.Clear();
            Console.WriteLine("=== Alta de Cliente ===");
            Console.WriteLine("Escriba '0' o 'volver' en cualquier momento para cancelar.");

            Cliente nuevo = new Cliente();
            nuevo.Id = nextId++;

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            if (EsVolver(nombre)) return;
            nuevo.Nombre = nombre;

            Console.Write("Edad: ");
            string edadStr = Console.ReadLine();
            if (EsVolver(edadStr)) return;
            if (!int.TryParse(edadStr, out int edad))
            {
                Console.WriteLine("Edad inválida.");
                Esperar(); return;
            }
            nuevo.Edad = edad;

            Console.Write("Teléfono: ");
            string tel = Console.ReadLine();
            if (EsVolver(tel)) return;
            nuevo.Telefono = tel;

            clientes.Add(nuevo);
            Console.WriteLine("\nCliente agregado correctamente.");
            Esperar();
        }

        static void MostrarDetalles()
        {
            Console.Clear();
            Console.WriteLine("=== Detalles de Cliente ===");
            Console.Write("Ingrese ID del cliente ('0' para volver): ");
            string entrada = Console.ReadLine();
            if (EsVolver(entrada)) return;

            if (int.TryParse(entrada, out int id))
            {
                var cliente = clientes.FirstOrDefault(c => c.Id == id);
                if (cliente != null)
                {
                    Console.WriteLine($"\nID: {cliente.Id}");
                    Console.WriteLine($"Nombre: {cliente.Nombre}");
                    Console.WriteLine($"Edad: {cliente.Edad}");
                    Console.WriteLine($"Teléfono: {cliente.Telefono}");
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }

            Esperar();
        }

        static void ListarClientes()
        {
            Console.Clear();
            Console.WriteLine("=== Lista de Clientes ===");
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
            }
            else
            {
                foreach (var c in clientes)
                {
                    Console.WriteLine($"ID: {c.Id}, Nombre: {c.Nombre}, Edad: {c.Edad}, Teléfono: {c.Telefono}");
                }
            }

            Esperar();
        }

        static void BuscarCliente()
        {
            Console.Clear();
            Console.WriteLine("=== Buscar Cliente por Nombre ===");
            Console.Write("Nombre o parte del nombre ('0' para volver): ");
            string nombre = Console.ReadLine();
            if (EsVolver(nombre)) return;

            var encontrados = clientes.Where(c => c.Nombre.ToLower().Contains(nombre.ToLower())).ToList();

            if (encontrados.Count == 0)
            {
                Console.WriteLine("No se encontraron coincidencias.");
            }
            else
            {
                foreach (var c in encontrados)
                {
                    Console.WriteLine($"ID: {c.Id}, Nombre: {c.Nombre}, Edad: {c.Edad}, Teléfono: {c.Telefono}");
                }
            }

            Esperar();
        }

        static void DarDeBaja()
        {
            Console.Clear();
            Console.WriteLine("=== Baja de Cliente ===");
            Console.Write("Ingrese ID del cliente a eliminar ('0' para volver): ");
            string entrada = Console.ReadLine();
            if (EsVolver(entrada)) return;

            if (int.TryParse(entrada, out int id))
            {
                var cliente = clientes.FirstOrDefault(c => c.Id == id);
                if (cliente != null)
                {
                    clientes.Remove(cliente);
                    Console.WriteLine("Cliente eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }

            Esperar();
        }

        static void ModificarCliente()
        {
            Console.Clear();
            Console.WriteLine("=== Modificar Cliente ===");
            Console.Write("Ingrese ID del cliente a modificar ('0' para volver): ");
            string entrada = Console.ReadLine();
            if (EsVolver(entrada)) return;

            if (int.TryParse(entrada, out int id))
            {
                var cliente = clientes.FirstOrDefault(c => c.Id == id);
                if (cliente != null)
                {
                    Console.WriteLine($"Nombre actual: {cliente.Nombre}");
                    Console.Write("Nuevo nombre (enter para mantener): ");
                    string nuevoNombre = Console.ReadLine();
                    if (EsVolver(nuevoNombre)) return;
                    if (!string.IsNullOrWhiteSpace(nuevoNombre)) cliente.Nombre = nuevoNombre;

                    Console.WriteLine($"Edad actual: {cliente.Edad}");
                    Console.Write("Nueva edad (enter para mantener): ");
                    string nuevaEdad = Console.ReadLine();
                    if (EsVolver(nuevaEdad)) return;
                    if (int.TryParse(nuevaEdad, out int edad)) cliente.Edad = edad;

                    Console.WriteLine($"Teléfono actual: {cliente.Telefono}");
                    Console.Write("Nuevo teléfono (enter para mantener): ");
                    string nuevoTel = Console.ReadLine();
                    if (EsVolver(nuevoTel)) return;
                    if (!string.IsNullOrWhiteSpace(nuevoTel)) cliente.Telefono = nuevoTel;

                    Console.WriteLine("Cliente modificado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }

            Esperar();
        }

        static bool EsVolver(string entrada)
        {
            return entrada.Trim() == "0" || entrada.Trim().ToLower() == "volver";
        }

        static void Esperar()
        {
            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
