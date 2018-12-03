using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_22
{
    public class Conversor
    {
        public static string DecimalBinario(string n)
        {
            int numero;
            string retorno = string.Empty;

            if (int.TryParse(n, out numero))
            {
                while (numero > 0)
                {
                    retorno = (numero % 2).ToString() + retorno;
                    numero = numero / 2;
                }
            }


            return retorno;
        }

        public static string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        public static double BinarioDecimal(string n)
        {
            double entero = 0;
            bool esBinario = true;
            
            foreach (char item in n)
            {
                if (!(item == '0' || item == '1'))
                {
                    esBinario = false;
                    Console.WriteLine("entre aca");
                    Console.ReadKey();
                    break;
                }

            }

            if (esBinario)
            {
                for (int i = 1; i <= n.Length; i++)
                {
                    entero += int.Parse(n[i - 1].ToString()) * (int)Math.Pow(2, n.Length - i);
                }
            }


            return entero;
        }
    }
}
