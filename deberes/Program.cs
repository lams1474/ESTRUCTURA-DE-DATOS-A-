using System;

namespace RegistroEstudiante
{
    // Clase Estudiante que contiene todos los atributos requeridos
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; }

        // Constructor que recibe los datos iniciales
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos;
        }

        // Método para mostrar los datos del estudiante
        public void MostrarDatos()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Teléfonos:");
            foreach (var tel in Telefonos)
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
}
