namespace EjercicioN1;

public class AdministrarPersona 
{
    private List<Persona> personas;

    public AdministrarPersona()
    {
        this.personas = new List<Persona>(); 
    } 

    public void AgregarPersona()
    {
        if (personas.Count < 10)
        {
            Persona nuevaPersona = Persona.PedirDatos();
            personas.Add(nuevaPersona);
        }
        else
        {
            Console.WriteLine("Se ha alcanzado el limite de 10 personas");
        }
    }

    public void MostrarNombres()
    {
        Console.WriteLine("Lista de Nombres:");
        foreach (var persona in personas)
        {
            Console.WriteLine(persona.ObtenerNombre());
        }
    }

    public void MostrarPersonaPorEdad(int edad)
    {
        Console.WriteLine($"Personas con {edad} años: ");
        bool encontrado = false;

        foreach (var persona in personas)
        {
            if (persona.ObtenerEdad() == edad)
            {
                Console.WriteLine(persona.ObtenerNombre());
                encontrado = true;
            }
        }

        // Verifica si no se encontró ninguna persona con esa edad.
        if (!encontrado)
        {
            Console.WriteLine($"No se encontraron personas con {edad} años.");
        }
    }

    public void MostrarPersonaPorNombre(string nombre)
    {
        Console.WriteLine($"\nPersonas con el nombre {nombre}: ");
        bool encontrado = false;
        foreach (var persona in personas)
        {
            if (persona.CoincideNombre(nombre))
            {
                Console.WriteLine(persona.ObtenerNombre());
                encontrado = true;
            }
            else
            {
                Console.WriteLine("No se encontraron personas con ese nombre.");
            }
        }
    }

    public void MostrarMenu()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Mostrar lista de todos los nombres.");
            Console.WriteLine("2. Mostrar personas de cierta edad.");
            Console.WriteLine("3. Mostrar personas que coincidan con un nombre.");
            Console.WriteLine("4. Salir.");
            Console.Write("Seleccione una opción: ");
            
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MostrarNombres();
                    break;
                case "2":
                    Console.Write("Ingrese la edad que desea buscar: ");
                    int edadBuscada = int.Parse(Console.ReadLine());
                    MostrarPersonaPorEdad(edadBuscada);
                    if (edadBuscada == null)
                    {
                        Console.WriteLine("No se encontraron personas con esa edad");
                    }
                    break;
                case "3":
                    Console.Write("Ingrese el nombre que desea buscar: ");
                    string nombreBuscado = Console.ReadLine();
                    MostrarPersonaPorNombre(nombreBuscado);
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente nuevamente.");
                    break;
            }
        }
    }
}