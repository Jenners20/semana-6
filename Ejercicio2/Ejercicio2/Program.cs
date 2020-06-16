using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Crear una aplicación que le pida al usuario un numero
             * positivos y el sistema identifique si es primo o no */

            int numero = 0;
            int c = 0;

            Console.Write("Ingrese un numero entero positivo: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < (numero+1); i++)
            {
                if (numero%i==0)
                {
                    c++;
                }
            }
            if (c !=2)
            {
                Console.WriteLine("El numero {0} no es primo ",numero);
            }
            else
            {
                Console.WriteLine("El numero {0} es primo ", numero);
            }
            Console.ReadKey();
        }
    }
}
