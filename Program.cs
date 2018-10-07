using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones cajero = new Operaciones();
            int opcion;

            double cAbono = cajero.abono;
            double cRetiro = cajero.retiro;
            double cSaldo = cajero.saldo;
            int cPIN = cajero.pin;

            // Vista de la consola
            Console.Title = "Cajero Automatico";
            // Menu de presentacion
            Console.WriteLine("Bienvenido al cajero");
            Console.WriteLine("--------------------");
            do
            {
                Console.WriteLine("Seleccione una opcion por favor:");
                Console.WriteLine("");
                Console.WriteLine("1. Realizar un deposito");
                Console.WriteLine("2. Realizar un retiro");
                Console.WriteLine("3. Consultar saldo");
                Console.WriteLine("4. Generar nuevo PIN");
                Console.WriteLine("5 - Salir");
                Console.WriteLine("");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        cSaldo =  cajero.agregarBono(cSaldo, cAbono);
                        Console.WriteLine("\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        cSaldo = cajero.retirarEfectivo(cSaldo, cRetiro);
                        Console.WriteLine("\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        // Opcion consultar saldo
                        cajero.mostrarSaldo(cSaldo);
                        Console.WriteLine("\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        // Generar nuevo PIN
                        cPIN = cajero.generarPIN(cPIN);
                        Console.WriteLine("\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        // Salida del sistema
                        Console.Clear();
                        Console.WriteLine("Gracias por su preferencia");
                        Console.WriteLine("Presione cualquier tecla para terminar");
                        Console.ReadKey();
                        break;
                    default:
                        // Ninguna opcion valida seleccionada
                        Console.WriteLine("Elija una opcion valida");
                        Console.Clear();
                        break;
                }
            } while (opcion != 4);

        }
    }
}