using System;

namespace Operaciones1
{
    // Nuestro delegado
    public delegate double MiDelegado(double a, double b);

    public class Operaciones
    {
        // Mlos metodos de la operaciones
        public static double Sumar(double a, double b) => a + b;
        public static double Restar(double a, double b) => a - b;
        public static double Multiplicar(double a, double b) => a * b;

        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
                return 0;
            }
            return a / b;
        }
    }
}