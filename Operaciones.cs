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

            if (aSaldo <= 0)
            {
                Console.WriteLine("No posee saldo en su cuenta");
            }
            if(aRetiro >= 5000)
            {
                Console.WriteLine("No puedo retirar mas de $5000");
            }
            else
            {
                aSaldo -= aRetiro;
                Console.WriteLine("Retiro realizado con exito");
                Console.WriteLine("");
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
    }
}
