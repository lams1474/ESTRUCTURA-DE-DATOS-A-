public class Estudiante
{
    // Campos privados como en el ejemplo
    private int id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos;

    // Constructor similar al del ejemplo
    public Estudiante(int _id, string _nombres, string _apellidos, string _direccion, string[] _telefonos)
    {
        id = _id;
        nombres = _nombres;
        apellidos = _apellidos;
        direccion = _direccion;
        
        // Inicialización del array como en el ejemplo
        telefonos = new string[3];
        telefonos = _telefonos;
    }

    // Métodos get como en el ejemplo
    public int GetId()
    {
        return id;
    }

    public string GetNombres()
    {
        return nombres;
    }

    public string GetApellidos()
    {
        return apellidos;
    }

    public string GetDireccion()
    {
        return direccion;
    }

    public string[] GetTelefonos()
    {
        return telefonos;
    }

    // Método para mostrar datos adaptado
    public void MostrarDatos()
    {
        Console.WriteLine("ID: " + GetId());
        Console.WriteLine("Nombres: " + GetNombres());
        Console.WriteLine("Apellidos: " + GetApellidos());
        Console.WriteLine("Dirección: " + GetDireccion());
        Console.WriteLine("Teléfonos:");
        foreach (var tel in GetTelefonos())
        {
            Console.WriteLine("- " + tel);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Datos de ejemplo
        string[] telefonos = { "0996813865", "0960698503", "0971720777" };

        Estudiante estudiante1 = new Estudiante(1, "Luis Alfonso", "Maigua Sisalema", "Calle Rafael morales", telefonos);

        estudiante1.MostrarDatos();

        // Evita que la consola se cierre inmediatamente
        Console.WriteLine("\nPresiona Enter para salir...");
        Console.ReadLine();
    }
}