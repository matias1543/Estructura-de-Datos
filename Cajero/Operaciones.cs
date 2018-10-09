using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Operaciones
    {
        //Define las operaciones basicas del cajero
        public double saldo = 0;
        public double abono = 0;
        public double retiro = 0;
        public int pin = 1234;

        public void mostrarSaldo(double dinero)
        {
            Console.Clear();
            Console.WriteLine("***************************************");
            Console.WriteLine("El saldo de su cuenta es de " + dinero);
            Console.WriteLine("***************************************");
        }

        public double agregarBono(double aSaldo, double aAbono)
        {
            // Permite agregar efectivo a la cuenta
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad a abonar: ");
            aAbono = Convert.ToDouble(Console.ReadLine());
            aSaldo += aAbono;

            Console.WriteLine("Abono realizado con exito");
            Console.WriteLine("");

            return aSaldo;
        }

        public double retirarEfectivo(double aSaldo, double aRetiro)
        {
            // Permite retirar dinero de la cuenta
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad a retirar: ");
            aRetiro = Convert.ToDouble(Console.ReadLine());
            aSaldo -= aRetiro;

            if (aSaldo < 0)
            {
                aSaldo += aRetiro;
                Console.WriteLine("No pudo realizarse la operacion");
                Console.WriteLine("");
            }
            else if(aRetiro > 5000)
            {
                aSaldo += aRetiro;
                Console.WriteLine("No puedo retirar mas de $5000");
            }
            else
            {
                Console.WriteLine("Operacion realizada con exito");
            }
            return aSaldo;
        }

        public int generarPIN(int aPIN)
        {
            //Permite generar un nuevo PIN
            Console.Clear();
            Console.WriteLine("Ingrese su nuevo PIN: ");
            aPIN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("PIN generado con exito");
            Console.WriteLine("");
            return aPIN;
        }

        public void generarRecibo(double aSaldo, double aAbono, double aRetiro)
        {
          int opcion;
            Console.WriteLine("Desea recibir un recibo de la operacion actual?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            opcion = Convert.ToInt32(Console.ReadLine());
         
        if(opcion == 1)
        {
            Console.Clear();
            Console.WriteLine("El saldo actual de su cuenta es de " +aSaldo);
            Console.WriteLine("Muchas gracias por utilizar nuestros servicios.");
        }
        else
        {
            Console.WriteLine("Muchas gracias por utilizar nuestros servicios.");
        }
    }
}
}
