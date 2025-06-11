using System;

namespace FigurasGeometricas
{
    // Clase que representa un círculo
    class Circulo
    {
        // Atributo privado que almacena el radio del círculo
        private double radio;

        // Constructor de la clase Circulo que recibe el radio como parámetro
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // CalcularArea devuelve un valor double y calcula el área de un círculo usando la fórmula: π * radio^2
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro devuelve un valor double y calcula el perímetro (circunferencia) del círculo: 2 * π * radio
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase que representa un rectángulo
    class Rectangulo
    {
        // Atributos privados que almacenan la base y altura del rectángulo
        private double baseRectangulo;
        private double altura;

        // Constructor de la clase Rectangulo que recibe la base y la altura como parámetros
        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        // CalcularArea devuelve un valor double y calcula el área del rectángulo: base * altura
        public double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        // CalcularPerimetro devuelve un valor double y calcula el perímetro del rectángulo: 2 * (base + altura)
        public double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }
    }

    // Clase principal que contiene el método Main
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo Circulo con radio 5
            Circulo miCirculo = new Circulo(5);

            // Mostrar el área y el perímetro del círculo
            Console.WriteLine("Círculo:");
            Console.WriteLine("Área: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro: " + miCirculo.CalcularPerimetro());

            Console.WriteLine();

            // Crear un objeto de tipo Rectangulo con base 4 y altura 3
            Rectangulo miRectangulo = new Rectangulo(4, 3);

            // Mostrar el área y el perímetro del rectángulo
            Console.WriteLine("Rectángulo:");
            Console.WriteLine("Área: " + miRectangulo.CalcularArea());
            Console.WriteLine("Perímetro: " + miRectangulo.CalcularPerimetro());
        }
    }
}
