// See https://aka.ms/new-console-template for more information

using EjercicioN1;

AdministrarPersona adminPersonas = new AdministrarPersona();
bool continuarIngresando = true;

// Bucle para pedir los datos de las personas hasta que el usuario decida detenerse.
while (continuarIngresando)
{
    adminPersonas.AgregarPersona();

    Console.WriteLine("¿Desea ingresar otra persona? (s/n): ");
    continuarIngresando = Console.ReadLine().Trim().ToLower() == "s";
}

// Mostrar el menú de opciones
adminPersonas.MostrarMenu();