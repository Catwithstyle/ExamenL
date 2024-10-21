// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    // Listas para almacenar temperaturas en Celsius y sus conversiones
    private static List<double> temperaturasCelsius = new List<double>();
    private static List<double> temperaturasFahrenheit = new List<double>();
    private static List<double> temperaturasKelvin = new List<double>();

    // Función para agregar temperatura en Celsius
    private static void AgregarTemperatura(double temperatura)
    {
        temperaturasCelsius.Add(temperatura);
        temperaturasFahrenheit.Add(ConvertirAFahrenheit(temperatura));
        temperaturasKelvin.Add(ConvertirAKelvin(temperatura));
    }

    // Función para convertir Celsius a Fahrenheit
    private static double ConvertirAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Función para convertir Celsius a Kelvin
    private static double ConvertirAKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    // Función para mostrar temperaturas convertidas
    private static void MostrarTemperaturasConvertidas()
    {
        Console.WriteLine("Temperaturas en Fahrenheit:");
        for (int i = 0; i < temperaturasFahrenheit.Count; i++)
        {
            Console.WriteLine($"{i}: {temperaturasFahrenheit[i]} °F");
        }

        Console.WriteLine("\nTemperaturas en Kelvin:");
        for (int i = 0; i < temperaturasKelvin.Count; i++)
        {
            Console.WriteLine($"{i}: {temperaturasKelvin[i]} K");
        }
    }

    // Función para eliminar temperatura de la lista convertida
    private static void EliminarTemperaturaConvertida(string tipo)
    {
        Console.WriteLine($"Elija el índice de la temperatura en {tipo} a eliminar:");
        int indice = int.Parse(Console.ReadLine());

        if (tipo.ToLower() == "fahrenheit" && indice >= 0 && indice < temperaturasFahrenheit.Count)
        {
            temperaturasFahrenheit.RemoveAt(indice);
            Console.WriteLine("Temperatura eliminada de Fahrenheit.");
        }
        else if (tipo.ToLower() == "kelvin" && indice >= 0 && indice < temperaturasKelvin.Count)
        {
            temperaturasKelvin.RemoveAt(indice);
            Console.WriteLine("Temperatura eliminada de Kelvin.");
        }
        else
        {
            Console.WriteLine("Índice inválido.");
        }
    }

    // Función principal
    static void Main(string[] args)
    {
        string continuar;
        do
        {
            Console.Write("Ingrese la temperatura en Celsius: ");
            double temperaturaCelsius = double.Parse(Console.ReadLine());
            AgregarTemperatura(temperaturaCelsius);

            // Mostrar las temperaturas convertidas
            MostrarTemperaturasConvertidas();

            // Opción para eliminar temperatura convertida
            Console.WriteLine("¿Desea eliminar una temperatura convertida? (f: Fahrenheit, k: Kelvin, n: No):");
            string opcion = Console.ReadLine();
            if (opcion.ToLower() == "f" || opcion.ToLower() == "k")
            {
                EliminarTemperaturaConvertida(opcion == "f" ? "fahrenheit" : "kelvin");
            }

            // Preguntar si desea continuar
            Console.Write("¿Desea ingresar otra temperatura? (s/n): ");
            continuar = Console.ReadLine();

        } while (continuar.ToLower() == "s");

        Console.WriteLine("Programa finalizado.");
    }
}
