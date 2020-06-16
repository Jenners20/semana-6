using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. Crear un programa que me diga la cantidad de digitos que tiene un numero positivo.
             * Mostrar en mensaje ej: El numero ingresado tiene (N) digitos */

            int numero =0;
            int dividir = 0;
            int digitos = 0;
           

            Console.Write("Ingrese un numero positivo: ");
            numero = int.Parse(Console.ReadLine());

            dividir = numero;
            Console.WriteLine();
            while (dividir>0)
            {
                dividir = dividir / 10;
                digitos++;

            }
            Console.WriteLine("El numero ingresado {0} tiene {1} digitos...",numero,digitos);
            Console.ReadKey();
        }
    }
}
