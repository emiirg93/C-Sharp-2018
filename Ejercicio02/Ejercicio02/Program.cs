using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

//incluir using Entidades para llamar directamente con Sello.

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Emiliano es el mejor";
            Sello.color = ConsoleColor.Blue;

            Console.Write(Sello.Imprimir());

            Console.ReadKey();

            Console.Clear();

            Sello.Borrar();

            //Console.Write(Sello.Imprimir());

            //Sello.mensaje = "Emiliano es el mejor";

            Sello.ImprimirEnColor();

            Console.ReadKey();
        }
    }
}
