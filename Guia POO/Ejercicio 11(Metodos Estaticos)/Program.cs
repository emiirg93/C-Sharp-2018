using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11_Metodos_Estaticos_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int max = 0;
            int min = 0;
            int total = 0;
            float promedio;

            int incremento = 0;

            do
            {
                Console.Clear();
                Console.Write("Ingresa un numero : ");
                num = int.Parse(Console.ReadLine());

                while(Validacion.Validar(num,-100,100) == false)
                {
                    Console.Clear();
                    Console.Write("Ingreso un numero no VALIDO.\nReingrese el numero : ");
                    num = int.Parse(Console.ReadLine());
                }

                if (incremento == 0)
                {
                    max = min = total = num;
                    incremento++;
                    continue;
                }


                if(num < min)
                {
                    min = num;
                }
                else if (num > max)
                {
                    max = num;
                }

                total += num;
                incremento++;

            } while (incremento < 10);

            promedio = (float)total / 10;

            Console.WriteLine("Maximo : {0} - Minimo : {1} - Total : {2} - Promedio : {3}",max,min,total,promedio);
            Console.ReadKey();

        }
    }
}
