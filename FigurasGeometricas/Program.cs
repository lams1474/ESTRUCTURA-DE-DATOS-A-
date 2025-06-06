using System;

namespace FigurasGeometricas
{
    // Interfaz que define el contrato para cualquier figura geométrica
    interface IFigura
    {
        // Método para calcular el área
        double CalcularArea();

        // Método para calcular el perímetro
        double CalcularPerimetro();
    }

    // Clase Circulo que implementa la interfaz IFigura
    class Circulo : IFigura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Calcula el área del círculo: π * radio^2
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Calcula el perímetro del círculo: 2 * π * radio
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase Rectangulo que implementa la interfaz IFigura
    class Rectangulo : IFigura
    {
        private double baseRectangulo;
        private double altura;

        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        // Calcula el área del rectángulo: base * altura
        public double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        // Calcula el perímetro del rectángulo: 2 * (base + altura)
        public double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una figura tipo círculo
            IFigura figura1 = new Circulo(5);

            // Crear una figura tipo rectángulo
            IFigura figura2 = new Rectangulo(4, 3);

            // Imprimir resultados
            Console.WriteLine("Círculo:");
            Console.WriteLine("Área: " + figura1.CalcularArea());
            Console.WriteLine("Perímetro: " + figura1.CalcularPerimetro());

            Console.WriteLine();

            Console.WriteLine("Rectángulo:");
            Console.WriteLine("Área: " + figura2.CalcularArea());
            Console.WriteLine("Perímetro: " + figura2.CalcularPerimetro());
        }
    }
}