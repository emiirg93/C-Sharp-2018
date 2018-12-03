using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int total = 0;
            
            bool respuesta = false;

            do
            {
                Console.Clear();
                Console.Write("Ingrese un numero : ");
                numero = int.Parse(Console.ReadLine());

                total += numero;

                Console.WriteLine("Desea continuar ingresando numeros ? [S/N]");
                respuesta = ValidarRespuesta.ValidarS_N(Console.ReadKey().KeyChar);

            } while (respuesta == true);

            Console.Clear();
            Console.WriteLine("Suma Total : {0}", total);
            Console.ReadKey();
            
        }
    }
}
