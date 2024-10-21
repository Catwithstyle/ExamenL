using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_sem_9
{
    struct Persona
    {
        public string Nombre;
        public string Direccion;
        public string Telefono;
        public int Edad;
    }

    internal class GestionPersona
    {
        private Persona[] personas = new Persona[10];
        private int contador = 0;
        public void AgregarPersona(string nombre, string direccion, string telefono, int edad)
        {
            if (contador < 10)
            {
                personas[contador].Nombre = nombre;
                personas[contador].Direccion = direccion;
                personas[contador].Telefono = telefono;
                personas[contador].Edad = edad;
                contador++;
            }
            else
            {
                Console.WriteLine("No se pueden agregar más personas. Capacidad máxima alcanzada.");
            }

        }
        public void MostrarNombres()
        {
            Console.WriteLine("Lista de nombres:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(personas[i].Nombre);
            }
        }
        public void MostrarPersonasPorEdad(int edad)
        {
            Console.WriteLine($"Personas con {edad} años:");
            for (int i = 0; i < contador; i++)
            {
                if (personas[i].Edad == edad)
                {
                    Console.WriteLine($"Nombre: {personas[i].Nombre}, Dirección: {personas[i].Direccion}, Teléfono: {personas[i].Telefono}");
                }
            }
        }
        public void BuscarPersonaPorNombre(string nombre)
        {
            Console.WriteLine($"Personas con el nombre {nombre}:");
            for (int i = 0; i < contador; i++)
            {
                if (personas[i].Nombre.ToLower() == nombre.ToLower())
                {
                    Console.WriteLine($"Nombre: {personas[i].Nombre}, Dirección: {personas[i].Direccion}, Teléfono: {personas[i].Telefono}, Edad: {personas[i].Edad}");
                }
            }




        }
    }
}
