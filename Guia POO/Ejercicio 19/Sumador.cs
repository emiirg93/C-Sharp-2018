using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_19
{
    public class Sumador
    {
        private int _cantidadSumas;

        public Sumador()
        {
            this._cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas)
        {
            this._cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            long sumar;

            sumar = a + b;
            this._cantidadSumas++;

            return sumar;
        }

        public string Sumar(string a, string b)
        {
            this._cantidadSumas++;
            return a +" "+b;
        }

        public static explicit operator int(Sumador s)
        {
            return s._cantidadSumas;
        }

        public static long operator +(Sumador s1 , Sumador s2)
        {
            return (long)(s1._cantidadSumas + s2._cantidadSumas);
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool tof = false;

            if(s1._cantidadSumas == s2._cantidadSumas)
            {
                tof = true;
            }

            return tof;
        }
    }

}
