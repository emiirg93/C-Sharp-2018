using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro e = new Euro(10);

            Dolar d = new Dolar();

            d = (Dolar)e;

            Console.Write(d.GetCantidad());
            Console.ReadKey();

            
        }
    }
}
