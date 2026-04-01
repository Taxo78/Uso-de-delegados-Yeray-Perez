using System;
using System.Collections.Generic;

namespace Operaciones1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diccionario para asignar el método al delegado dinámicamente
            Dictionary<string, MiDelegado> calculadora = new Dictionary<string, MiDelegado>
            {
                { "+", Operaciones.Sumar },
                { "-", Operaciones.Restar },
                { "*", Operaciones.Multiplicar },
                { "/", Operaciones.Dividir }
            };

            Console.WriteLine("--- Calculadora con Delegados ---");

            Console.Write("Número 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Operación (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Número 2: ");
            double n2 = double.Parse(Console.ReadLine());

            if (calculadora.ContainsKey(op))
            {
                // Llamada a través del delegado
                MiDelegado ejecutar = calculadora[op];
                double resultado = ejecutar(n1, n2);

                Console.WriteLine($"\nResultado: {resultado}");
            }
            else
            {
                Console.WriteLine("Operación no válida.");
            }

            Console.ReadKey();
        }
    }
}