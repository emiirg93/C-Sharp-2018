using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_22
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string num)
        {
            this.numero = num;
        }

        public static string operator +(NumeroBinario a, NumeroDecimal b)
        {
            double aConvertido = Conversor.BinarioDecimal(a.numero);

            double resultado = aConvertido + b.numero;

            string retorno = Conversor.DecimalBinario(resultado);

            return retorno;
        }

        public static string operator -(NumeroBinario a, NumeroDecimal b)
        {
            double aConvertido = Conversor.BinarioDecimal(a.numero);

            double resultado = aConvertido - b.numero;

            string retorno = Conversor.DecimalBinario(resultado);

            return retorno;
        }

        public static bool operator ==(NumeroBinario a, NumeroDecimal b)
        {
            bool tof = false;

            double aConvertido = Conversor.BinarioDecimal(a.numero);

            if (aConvertido == b.numero)
            {
                tof = true;
            }

            return tof;
        }

        public static bool operator !=(NumeroBinario a, NumeroDecimal b)
        {
            return !(a == b);
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator string(NumeroBinario a)
        {
            return a.numero;
        }
    }
}
