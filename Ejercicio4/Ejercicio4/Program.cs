using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4. Crear una aplicación que genere un numero aleatorio entre 50
             * y 100. Y pida al usuario si desea generar otro número antes de terminar la 
             * aplicación. El programa debe terminar cuando el usuario presione la letra S. */

           
            string paro = "N";

            while (paro!="S")
            {
                int numero = new Random().Next(50, 101);
                Console.WriteLine("El numero aleatorio entre 50 y 100 es: " + numero);
                Console.WriteLine();
                Console.Write("Pulse (S) para cerrar la aplicación o pulse cualquier tecla para continuar: ");
                paro = Console.ReadLine();
                if(paro=="s"|| paro=="S")
                {
                    paro = "S";
                    break;
                }
               
            }
            Console.ReadKey();
        }
    }
}
