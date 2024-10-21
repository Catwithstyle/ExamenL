namespace EjercicioN1;

public struct Persona
{
    private string nombre;

    private string direccion;

    private string telefono;

    private int edad; 

    public Persona(string nombre, string direccion, string telefono, int edad)
    {
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        this.edad = edad;
    }

    public string ObtenerNombre()
    {
        return nombre;
    }

    // Devuelve la edad de la persona.
    public int ObtenerEdad()
    {
        return edad;
    }

    // Verifica si el nombre coincide con el nombre buscado.
    public bool CoincideNombre(string nombreBuscado)
    {
        return string.Equals(this.nombre, nombreBuscado, StringComparison.OrdinalIgnoreCase);
    }

    // Función estática para pedir los datos de una persona desde la consola.
    public static Persona PedirDatos()
    {
        Console.Write("Ingrese el nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la dirección: ");
        string direccion = Console.ReadLine();
        Console.Write("Ingrese el teléfono: ");
        string telefono = Console.ReadLine();
        Console.Write("Ingrese la edad: ");
        int edad = int.Parse(Console.ReadLine());

        return new Persona(nombre, direccion, telefono, edad);
    }
}

    
    
