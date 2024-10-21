// See https://aka.ms/new-console-template for more information
using System;

class ProgramaVentas
{
    // Definimos el número de días a 7
    const int DIAS = 7;

    // Función para ingresar las ventas diarias
    static void IngresarVentas(float[] ventas)
    {
        for (int i = 0; i < DIAS; i++)
        {
            Console.Write($"Ingrese las ventas del día {i + 1}: ");
            ventas[i] = float.Parse(Console.ReadLine());  // Almacenamos la venta en el arreglo
        }
    }

    // Función para calcular el total vendido
    static float CalcularTotal(float[] ventas)
    {
        float total = 0;  // Inicializamos el total en 0
        for (int i = 0; i < DIAS; i++)
        {
            total += ventas[i];  // Sumamos las ventas diarias al total
        }
        return total;  // Retornamos el total vendido
    }

    // Función para encontrar el día con la venta más alta
    static int EncontrarDiaMaximo(float[] ventas)
    {
        int diaMaximo = 0;  // Inicializamos el día máximo como el primer día
        for (int i = 1; i < DIAS; i++)
        {
            if (ventas[i] > ventas[diaMaximo])  // Comparamos con la venta más alta
            {
                diaMaximo = i;  // Actualizamos el día máximo
            }
        }
        return diaMaximo;  // Retornamos el índice del día con la venta más alta
    }

    static void Main(string[] args)
    {
        float[] ventas = new float[DIAS];  // Arreglo para almacenar las ventas diarias

        // Llamamos a la función para ingresar las ventas
        IngresarVentas(ventas);

        // Calculamos el total vendido
        float totalVendido = CalcularTotal(ventas);
        Console.WriteLine($"El total vendido en la semana es: {totalVendido}");

        // Encontramos el día con la venta más alta
        int diaMaximo = EncontrarDiaMaximo(ventas);
        Console.WriteLine($"El día con la venta más alta fue el día {diaMaximo + 1} con ventas de: {ventas[diaMaximo]}");
    }
}
