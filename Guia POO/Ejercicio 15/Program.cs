using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,resultado;
            char operacion;

            Console.Write("Ingrese Primer Numero: ");
            int.TryParse(Console.ReadLine(),out n1);

            Console.Write("Ingrese Segundo Numero: ");
            int.TryParse(Console.ReadLine(), out n2);

            Console.Write("Ingrese operacion [+(suma),-(resta),*(mutiplicacion),/(divicion)] : ");
            operacion = Console.ReadKey().KeyChar;

            resultado = Calculadora.Calcular(n1, n2, operacion);

            Console.Clear();
            Console.WriteLine("Resultado : {0}", resultado);
            Console.ReadKey();

        }
    }
}
