using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_22
{
    public class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double num)
        {
            this.numero = num;
        }

        public static double operator +(NumeroDecimal a, NumeroBinario b)
        {
            double bConversor = Conversor.BinarioDecimal(b.numero);

            double resultado = a.numero + bConversor;

            return resultado;
        }

        public static double operator -(NumeroDecimal a, NumeroBinario b)
        {
            double bConversor = Conversor.BinarioDecimal(b.numero);

            double resultado = a.numero - bConversor;

            return resultado;
        }

        public static bool operator ==(NumeroDecimal a, NumeroBinario b)
        {
            bool tof = false;

            if (a.numero == Conversor.BinarioDecimal(b.numero))
            {
                tof = true;
            }

            return tof;
        }

        public static bool operator !=(NumeroDecimal a, NumeroBinario b)
        {
            return !(a == b);
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double(NumeroDecimal a)
        {
            return a.numero;
        }
    }
}

