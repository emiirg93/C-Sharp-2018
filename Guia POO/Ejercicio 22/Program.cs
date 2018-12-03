using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numBinario = "10110";
            NumeroDecimal numDecimal = 15;

            Console.WriteLine(Conversor.BinarioDecimal(numBinario.numero));
            Console.WriteLine("La suma de {0} y {1}", (string)numBinario,(double)numDecimal);
            Console.WriteLine(numDecimal+numBinario);
            Console.ReadKey();

        }
    }
}
