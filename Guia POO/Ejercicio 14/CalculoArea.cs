using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_14
{
    public class CalculoArea
    {
        public static double CalcularCuadrado(double n)
        {
            double area;

            area = Math.Pow(n,2);

            return area;
        }

        public static double CalcularTriangulo(double Base ,double Altura)
        {
            double area;

            area = (Base * Altura) / 2;

            return area;
        }

        public static double CalcularCirculo (double radio)
        {
            double area;

            area = 2 * Math.PI * radio;

            return area;
        }
    }
}
