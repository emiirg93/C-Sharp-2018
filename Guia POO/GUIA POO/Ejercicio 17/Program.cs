using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo lapicera = new Boligrafo(100, ConsoleColor.Blue);

            string resultado;
            int gasto = 50;

            lapicera.Pintar(gasto,out resultado);

            Console.ForegroundColor = lapicera.GetColor();

            Console.WriteLine(resultado);
            
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Cantidad de tinta : {0}", lapicera.GetTinta());
            
            Console.ReadKey();
            
        }
    }
}
