using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador a = new Sumador(3);
            Sumador b = new Sumador(5);

            long resultado = a.Sumar(2, 3);
            string resultadob = a.Sumar("hola", "como va");

            Console.WriteLine(resultado);
            Console.WriteLine(resultadob);
            Console.WriteLine("Cantidad De Sumas : "+(int)a);

            Console.WriteLine(a + b);
            Console.WriteLine(a | b);

            Console.ReadKey();


        }
    }
}
