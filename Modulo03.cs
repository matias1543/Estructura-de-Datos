using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tarea 1: Crea un programa que pida al usuario su identificador y su contraseña (ambos
            numéricos), y no le permita seguir hasta que introduzca como identificador "1234" y como
            contraseña "1111".*/
            string identificador, contrasenia;
            do
            {
                Console.WriteLine("Ingrese Identificador: ");
                identificador = Console.ReadLine();
                Console.WriteLine("Ingrese Contraseña: ");
                contrasenia = Console.ReadLine();
            } while (identificador != "1234" && contrasenia != "1111");

            Console.WriteLine("Datos Correctos");
            

            /*Tarea 2: Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: se
            puede hacer dividiendo varias veces entre 10).*/
            int cont = 0;
            Console.WriteLine("Ingresar número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            while(num > 0)
            {
                num /= 10;
                cont++;
            }

            Console.WriteLine("El número ingresado tiene {0} cifras", cont);

            //Tarea 3: Crea un programa que muestre la tabla de multiplicar del 9.
            for(int i= 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", i , 9, i * 9);
            }

            /*Tarea 4: Crea un programa que contenga un bucle sin fin que muestre los números enteros
            positivos a partir del uno.*/
            for(int i= 1; i != 0; i++)
            {
                Console.WriteLine(i);
            }

            /*Tarea 5: Crea un programa que contenga un bucle sin fin que escriba "Hola " en pantalla, sin
            avanzar de línea.*/
            for (int i = 1; i != 0; i++)
            {
                Console.Write("Hola");
            }

            /*Tarea 6: ¿Cuál sería el resultado de las siguientes operaciones? a = 5; b = ++a; c = a++; b = b * 5;
            a = a * 2; Crea un programa que lo resuelva.*/
            int a = 5;
            int b = ++a;
            int c = a++;
            b *= 5;
            a *= 2;

            Console.WriteLine("a = {0} /n b = {1} /n c = {2}", a, b, c);

            //Tarea 8 -Crea un programa que pida una letra al usuario y diga si se trata de una 
            Console.Write("Bienvenido! Ingrese una letra: ");
            string letra = Console.ReadLine();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("La letra ingresada es una vocal");

            }
            else
            {
                Console.WriteLine("La letra ingresada no es una vocal");
            }
            
            /*Tarea 9: Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se
            debe introducir dos veces. Si las dos contraseñas no son iguales, se avisará al usuario y se le
            volverán a pedir las dos contraseñas. */
            string passw, nombre, pass2;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            do
            {
                Console.Write("Ingrese su contraseña: ");
                passw = Console.ReadLine();

                Console.Write("Ingrese su contraseña nuevamente: ");
                pass2 = Console.ReadLine();

                if (passw != pass2)
                {
                    Console.WriteLine("Las contraseñas no coinciden, intentelo nuevamente.");
                }
                else
                {

                    Console.WriteLine("Contraseña correcta. BIENVENIDO..");
                }
            } while (passw != pass2);

            //Tarea 10: Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Martín", o bien le diga "No te conozco" si teclea otro nombre.
            Console.Write("Ingrese su nombre: ");
            string nom = Console.ReadLine();

            if (nom != "Martin")
            {
                Console.WriteLine("No te conozco");
            }
            else
            {
                Console.WriteLine("Hola");
            }

            Console.ReadKey();
        }
    }
}
