using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Captura un numero");
            var numero = Convert.ToInt32(Console.ReadLine());

            FibonacciModelo fibo = new FibonacciModelo();
            Console.Write("El resultado es: ");
            fibo.Datos(numero);         

            }
            catch (Exception)
            {
                Console.WriteLine("El dato no puede convertirse a un número");
            }

            Console.WriteLine("\n" + "Presiona cualquier tecla para salir");
            Console.ReadKey();

        }
    }
}
