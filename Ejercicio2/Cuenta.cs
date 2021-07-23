using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cuenta
    {
        public Cuenta(string titular, int numeroCuenta, double balance)
        {
            this.Titular = titular;
            this.NumeroCuenta = numeroCuenta;
            this.Balance = balance;
        }

        public string Titular { get; set; }

        public int NumeroCuenta { get; set; }

        public double Balance = 0.00;

        public double BalanceInicial
        {
            get { return Balance; }
            set { Balance = value;  }
        }

        public void Depositar()
        {
            string titular;
            int cuentaNumero;
            double deposito, total;

            Console.WriteLine("Ingrese el nombre del titular de la cuenta: ");
            titular = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de cuenta del titular: ");
            cuentaNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monto a depositar: ");
            deposito = Convert.ToDouble(Console.ReadLine());

            total = BalanceInicial + deposito;

            Console.WriteLine("*************************");
            Console.WriteLine($"Depositado a {titular}.");
            Console.WriteLine($"Con el numero de cuenta: {cuentaNumero}");
            Console.WriteLine($"Se le deposito la cifra de {deposito}$");

            Console.WriteLine($"La cuenta despues del deposito tiene un total de: {total}");
        }
        public void Retirar()
        {
            //string titular;
            //int cuentaNumero;
            double retiro, total;

            //Console.WriteLine("Ingrese el nombre del titular de la cuenta: ");
            //titular = Console.ReadLine();
            //Console.WriteLine("Ingrese el numero de cuenta del titular: ");
            //cuentaNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monto a retirar: ");
            retiro = Convert.ToDouble(Console.ReadLine());

            if(retiro > BalanceInicial)
            {
                total = BalanceInicial - retiro;
                //Console.WriteLine("*************************");
                //Console.WriteLine($"Retirado de {titular}.");
                //Console.WriteLine($"Con el numero de cuenta: {cuentaNumero}");
                Console.WriteLine($"Se le retiro la cifra de {retiro}$");

                Console.WriteLine($"La cuenta despues del deposito tiene un total de: {total}");
            }
            else
            {
                Console.WriteLine("Error al hacer el retiro!");
            }

        }

    }
}
