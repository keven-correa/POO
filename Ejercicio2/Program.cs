using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Carlos", 12345678, balance: 0.00 );

            cuenta.Depositar();
            cuenta.Retirar();

        }
    }
}
