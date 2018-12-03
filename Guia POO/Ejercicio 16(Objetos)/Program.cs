using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_16_Objetos_
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno a = new Alumno("Rago Y Fernandez", 105106, "Emiliano");
            Alumno b = new Alumno("Popolo", 104106, "Leo");
            Alumno c = new Alumno("Encina", 105102, "Javier");

            a.Estudiar(10, 5);
            b.Estudiar(8, 6);
            c.Estudiar(6, 7);

            a.CalcularFinal();
            b.CalcularFinal();
            c.CalcularFinal();

            string aDatos = a.Mostrar();
            string bDatos = b.Mostrar();
            string cDatos = c.Mostrar();

            Console.WriteLine(aDatos);
            Console.WriteLine("\n");
            Console.WriteLine(bDatos);
            Console.WriteLine("\n");
            Console.WriteLine(cDatos);
            Console.ReadKey();
        }
    }
}
