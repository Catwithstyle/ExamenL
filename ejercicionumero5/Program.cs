// See https://aka.ms/new-console-template for more information
using System;

class Programa
{
    private const int MAXIMO = 100; // Tamaño máximo del arreglo

    // Función privada para invertir un arreglo
    private static void InvertirArreglo(int[] arreglo, int tamaño)
    {
        int temp; // Variable temporal para el intercambio

        for (int i = 0; i < tamaño / 2; i++)
        {
            // Intercambiamos los elementos
            temp = arreglo[i];
            arreglo[i] = arreglo[tamaño - 1 - i];
            arreglo[tamaño - 1 - i] = temp;
        }
    }

    // Función privada para contar e imprimir los números impares en el arreglo
    private static void ContarImpares(int[] arreglo, int tamaño)
    {
        int contadorImpares = 0; // Contador de números impares

        for (int i = 0; i < tamaño; i++)
        {
            if (arreglo[i] % 2 != 0) // Verificamos si el número es impar
            {
                contadorImpares++;
                Console.WriteLine("Número impar encontrado: " + arreglo[i]);
            }
        }

        // Imprimimos el total de números impares encontrados
        Console.WriteLine("Total de números impares: " + contadorImpares);
    }

    // Función principal
    static void Main()
    {
        int[] arreglo = new int[MAXIMO];
        int tamaño;

        // Solicitamos al usuario el tamaño del arreglo
        Console.WriteLine("Ingrese el tamaño del arreglo (máximo " + MAXIMO + "): ");
        tamaño = int.Parse(Console.ReadLine());

        // Verificamos que el tamaño sea válido
        if (tamaño > MAXIMO || tamaño <= 0)
        {
            Console.WriteLine("Tamaño no válido. Debe ser un número entre 1 y " + MAXIMO);
            return;
        }

        // Solicitamos los elementos del arreglo
        Console.WriteLine("Ingrese los elementos del arreglo:");
        for (int i = 0; i < tamaño; i++)
        {
            Console.Write("Elemento " + (i + 1) + ": ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        // Mostramos el arreglo original
        Console.WriteLine("\nArreglo original:");
        for (int i = 0; i < tamaño; i++)
        {
            Console.Write(arreglo[i] + " ");
        }

        // Invertimos el arreglo
        InvertirArreglo(arreglo, tamaño);

        // Mostramos el arreglo invertido
        Console.WriteLine("\n\nArreglo invertido:");
        for (int i = 0; i < tamaño; i++)
        {
            Console.Write(arreglo[i] + " ");
        }

        // Contamos e imprimimos los números impares en el arreglo invertido
        Console.WriteLine("\n");
        ContarImpares(arreglo, tamaño);
    }
}
