using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Crear una aplicación que muestre la tabla de multiplicar del 7, tips usar ciclo while.*/

            int limite = 0;
            int factor = 0;
            int contador = 0;
            int producto = 0;

            Console.Write("Ingrese el límite para la tabla de multiplicar del 7: ");
            limite = int.Parse(Console.ReadLine());

            while (factor< limite)
            {
                factor++;
                producto = 7 * factor;
                Console.WriteLine(" 7 x {0} = {1}",factor, producto);
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
