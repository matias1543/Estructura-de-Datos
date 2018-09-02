using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");

            int numero = 9;

            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese un número: ");
            int numero01 = Convert.ToInt32(Console.ReadLine());

            int suma = numero + numero01;


            Console.WriteLine("Saludos {0}", nombre);
            if(suma < 0) 
            {
                Console.WriteLine("La suma es menor a 0");
            }
            else if(suma > 0)
            {
                Console.WriteLine("La suma es mayor a 0");
            }
            else
            {
                Console.WriteLine("La suma es igual a 0");
            }

            Console.ReadKey();
        }
    }
}
