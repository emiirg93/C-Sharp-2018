using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Clase 4";

            Cosa miCosita = new Cosa("Emiliano Papa");
            /*
            miCosita.cadena = "Emiliano Rago";
            miCosita.dato = DateTime.Now;
            miCosita.numero = 37904306;*/

            Console.WriteLine(Cosa.mostrar(miCosita));

            miCosita.establecerValor("Roberto");

            Console.WriteLine(Cosa.mostrar(miCosita));

            Console.ReadKey();
        }
    }
}
