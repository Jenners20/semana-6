using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5. Crear una aplicación que muestre la cantidad de 0 que hay del 1 al 100.*/

            int conteo = 0;
            double divisor = 0;

            for (int i = 1; i < 101; i++)
            {
                divisor = i % 10;
                if (divisor==0)
                {
                    conteo++;
                    Console.WriteLine(i + " Este es el cero (0) número: " + conteo);
                }

            }
            conteo = conteo + 1;
            Console.WriteLine("Entre el 1 y el 100 hay {0} ceros ", conteo);
            Console.ReadKey();
        }
    }
}
