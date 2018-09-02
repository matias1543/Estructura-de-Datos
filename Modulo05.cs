using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tarea 1: Crea una función llamada "Signo", que reciba un número real, y devuelva un número
            entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero*/
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Signo(numero));

            /*Tarea 2: Crea una función "Menor" que calcule el menor de dos números enteros que recibirá
            como parámetros. El resultado será otro número entero.*/
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int numero3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Menor(numero2, numero3));

            /*Tarea 3: Crea una función "EsPrimo", que reciba un número y devuelva el valor booleano
            "true" si es un número primo o "false" en caso contrario.*/
            int numero4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EsPrimo(numero4));

            Console.ReadKey();

            /*Tarea 4: Analice el código ¿Qué hace este código? Realizar captura de pantalla del código con
            su resultado y análisis del mismo.*/
            Dibuja();

            /*Tarea 5: Crea una calculadora básica, llamada "calcula", que deberá sumar, restar, multiplicar
            o dividir los dos números que se le indiquen como parámetros. Ejemplos de su uso sería
            "calcula 2 + 3" o "calcula 5 * 60". (Utilice Funciones)*/
            int numero5 = Convert.ToInt32(Console.ReadLine());
            int numero6 = Convert.ToInt32(Console.ReadLine());
            calcula(numero5, numero6);

            /*Tarea 6: Crea una función "SumaCifras" que reciba un numero cualquiera y que devuelva como
            resultado la suma de sus dígitos.Por ejemplo, si el número fuera 123 la suma sería 6.*/
        }

        //Función de la Tarea 1
        static int Signo(int num)
        {
            if (num > 0)
            {
                return 1;
            }
            else if(num == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        //Función de la Tarea 2
        static int Menor(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }

        //Funcion de la Tarea 3
        static bool EsPrimo(int num)
        {
            int a = 0;

            for (int i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }

            if (a != 2)
            {
                Console.WriteLine("No es Primo");
                return false;
            }
            else
            {
                Console.WriteLine("Si es Primo");
                return true;
            }
        }

        //Función de la Tarea 4 - Dibuja una piramide
        static void Dibuja() 
        {
            Console.Clear();
            for (int fila = 1; fila <= 7; fila++)
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                {
                    Console.Write(" ");
                }
                for (int conta = 1; conta < (2 * fila); conta++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }

        //Función de la Tarea 5
        static void calcula(int num1, int num2)
        { 
            int operacion;

            do
            {
                Console.Write("Calculadora: \n1- Suma\n2-Resta\n3- Multiplicar\n4- Dividir\n5- Salir");
                Console.Write("Presione el número de la operación que desa realizar: ");
                operacion = Convert.ToInt32(Console.ReadLine());
                switch (operacion)
                {
                    case 1:
                        Console.WriteLine("El resultado es {0}", num1 + num2);
                        break;
                    case 2:
                        Console.WriteLine("El resultado es {0}", num1 - num2);
                        break;
                    case 3:
                        Console.WriteLine("El resultado es {0}", num1 * num2);
                        break;
                    case 4:
                        Console.WriteLine("El resultado es {0}", num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Porfavor ingrese una de las operaciones mostradas anteriormente.");
                        break;
                }
            } while (operacion != 5);
        }
   
    }


}
