using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static int Calcular (int n1,int n2, char operador)
        {
            int resultado = 0;

            if(operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                switch (operador)
                {
                    case '+':
                        resultado = n1 + n2;
                        break;
                    case '-':
                        resultado = n1 - n2;
                        break;
                    case '*':
                        resultado = n1 * n2;
                        break;
                    case '/':
                        if (Validar(n1))
                        {
                            resultado = n1 / n2;
                        }
                        else
                        {
                            Console.Write("No se puede dividir por 0");
                            Console.ReadKey();
                        }
                        break;

                }  
            }
            else
            {
                Console.WriteLine("\nNo se puede realizar la operacion porque ingreso un operador invalido");
                Console.ReadKey();
            }
            

            return resultado;
        }

        private static bool Validar(int num)
        {
            bool tof = false;
            
            if (num != 0)
            {
                tof = true;
            }

            return tof;
        }
    }
}
