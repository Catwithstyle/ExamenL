using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_sem_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                GestionPersona gestion = new GestionPersona();
                bool continuar = true;

                while (continuar)
                {
                    Console.WriteLine("Ingrese los datos de la persona:");
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Dirección: ");
                    string direccion = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    string telefono = Console.ReadLine();
                    Console.Write("Edad: ");
                    int edad = int.Parse(Console.ReadLine());

                    gestion.AgregarPersona(nombre, direccion, telefono, edad);

                    Console.WriteLine("¿Desea agregar otra persona? (s/n)");
                    continuar = Console.ReadLine().ToLower() == "s";
                }

                int opcion;
                do
                {
                    Console.WriteLine("\nMenú:");
                    Console.WriteLine("1. Mostrar la lista de todos los nombres.");
                    Console.WriteLine("2. Mostrar las personas de una cierta edad.");
                    Console.WriteLine("3. Mostrar las personas que coincidan con un nombre.");
                    Console.WriteLine("4. Salir.");
                    Console.Write("Seleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            gestion.MostrarNombres();
                            break;
                        case 2:
                            Console.Write("Ingrese la edad a buscar: ");
                            int edadBuscar = int.Parse(Console.ReadLine());
                            gestion.MostrarPersonasPorEdad(edadBuscar);
                            break;
                        case 3:
                            Console.Write("Ingrese el nombre a buscar: ");
                            string nombreBuscar = Console.ReadLine();
                            gestion.BuscarPersonaPorNombre(nombreBuscar);
                            break;
                        case 4:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                } while (opcion != 4);
            }
            Console.ReadKey();
        }
    }
    
}
