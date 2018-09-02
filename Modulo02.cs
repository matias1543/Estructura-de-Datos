using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarea 2: Crea un programa que diga el resultado de sumar 200 y 56.
            Console.WriteLine("Tarea 2");
            Console.WriteLine(200 + 56);

            //Tarea 3: Haz un programa que calcule el producto de los números 13 y 12.
            Console.WriteLine("Tarea 3");
            Console.WriteLine(13 * 12);

            //Tarea 4: Un programa que calcule la diferencia (resta) entre 321 y 213
            Console.WriteLine("Tarea 4");
            Console.WriteLine(321 - 213);

            //Tarea 5: Calcular el resultado de (20+5) % 6
            Console.WriteLine("Tarea 5");
            Console.WriteLine((20 + 5) % 6);

            //Tarea 6: Crea un programa que calcule el producto de los números 12 y 102, usando variables.
            Console.WriteLine("Tarea 6");
            int num01 = 12;
            int num02 = 102;
            Console.Write(num01 * num02);

            //Tarea 7: Crea un programa que calcule la suma de 200 y 1111, usando variables.
            Console.WriteLine("Tarea 7");
            int num03 = 200;
            int num04 = 1111;
            Console.WriteLine(num03 + num04);

            /*Tarea 8: Crea un programa que calcule el producto de los números 10 y 25,  
            variables llamadas "numero1" y "numero2". 6 PROGRAMACION I ACTIVIDAD
            MODULO II*/
            Console.WriteLine("Tarea 8");
            int numero01 = 10;
            int numero02 = 25;
            Console.WriteLine(numero01 * numero02);

            //Tarea 9: Crea un programa que calcule el producto de dos números introducidos por el usuario.
            Console.WriteLine("Tarea 9");
            int num05 = Convert.ToInt32(Console.ReadLine());
            int num06 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num05 * num06);

            /*Tarea 10: Crea un programa que pida al usuario un número entero y diga si es par
            (pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero: if (x
            % 2 == 0) ...)*/
            int num07 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tarea 10");
            if (num07 % 2 == 0)
            {               
                Console.WriteLine("El número ingresado es par");
            }
            else
            {
                Console.WriteLine("El número ingresado es impart");
            }

            //Tarea 11: Crea un programa que pida al usuario dos números enteros y diga cuál es mayor de ellos.
            Console.WriteLine("Tarea 11");
            int num08 = Convert.ToInt32(Console.ReadLine());
            int num09 = Convert.ToInt32(Console.ReadLine());

            if(num08 > num09)
            {
                Console.WriteLine("El número mayo es {0}", num08);
            }
            else if(num09 < num08)
            {
                Console.WriteLine("El número menor es {0}", num09);
            }

            /*Tarea 12: Crea un programa que pida al usuario dos números enteros. Si el segundo
            no es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el
            contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre
            cero".*/
            Console.WriteLine("Tarea 12");
            int num10 = Convert.ToInt32(Console.ReadLine());
            int num11 = Convert.ToInt32(Console.ReadLine());

            if(num11 != 0)
            {
                Console.WriteLine(num10 / num11);
            }
            else if(num11 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }

            /*Tarea 13: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el
            nombre de ese número, usando "switch"(por ejemplo, si introduce "1", el programa
            escribirá "uno").*/
            Console.WriteLine("Tarea 13");
            Console.WriteLine("Elegir un número del 1 al 5");
            int num12 = Convert.ToInt32(Console.ReadLine());
            switch(num12)
            {
                case 1:
                    Console.WriteLine("uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
                default:
                    Console.WriteLine("El número ingresado no esta entre el 1 y 5");
                    break;
            }

            //Tarea 14: Crea un programa que escriba en pantalla los números del 1 al 10, usando "while".
            int cont = 1;
            while(cont <= 10)
            {
                Console.WriteLine(cont);
                cont++;
            }

            //Tarea 15: Crea un programa que escriba en pantalla  números del 1 al 10, usando "do..while".
            int cont01 = 1;
            do
            {
                Console.WriteLine(cont01);
                cont01++;
            } while (cont01 <= 10);

            //Tarea 16: Crea un programa que muestre los números del 10 al 20, ambos incluidos, usando “for”
            for(int i= 10; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
