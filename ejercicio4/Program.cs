// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    const int MAXIMO = 100;  // Definimos el tamaño máximo del arreglo

    // Función recursiva para calcular el factorial de un número
    private static ulong CalcularFactorial(int numero)
    {
        if (numero < 0) return 0; // No calcular factorial para números negativos
        if (numero == 0) return 1; // El factorial de 0 es 1
        return (ulong)numero * CalcularFactorial(numero - 1); // Llamada recursiva
    }

    static void Main(string[] args)
    {
        int[] numeros = new int[MAXIMO];             // Arreglo para almacenar los números
        ulong[] factoriales = new ulong[MAXIMO];     // Arreglo para almacenar los factoriales
        int contador = 0;                             // Contador de números ingresados
        char continuar;                               // Variable para controlar si se repite el programa

        do
        {
            // Solicitar al usuario que ingrese un número
            Console.Write("Ingrese un número positivo (o cero): ");
            int numero = int.Parse(Console.ReadLine());

            // Verificar si el número es positivo o cero
            if (numero >= 0)
            {
                // Almacenar el número en el arreglo
                numeros[contador] = numero;

                // Calcular el factorial y almacenar en el segundo arreglo
                factoriales[contador] = CalcularFactorial(numero);
                contador++; // Incrementar el contador

                // Verificar si se ha alcanzado el máximo de números
                if (contador >= MAXIMO)
                {
                    Console.WriteLine("Se ha alcanzado el número máximo de entradas.");
                    break; // Salir si se alcanza el límite
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número no negativo.");
            }

            // Preguntar al usuario si desea continuar
            Console.Write("¿Desea ingresar otro número? (s/n): ");
            continuar = char.ToLower(Console.ReadKey().KeyChar); // Leer entrada del usuario
            Console.WriteLine(); // Nueva línea después de la entrada
        } while (continuar == 's');

        // Mostrar resultados
        Console.WriteLine("\nNúmeros ingresados y sus factoriales:");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"Número: {numeros[i]}, Factorial: {factoriales[i]}");
        }
    }
}
