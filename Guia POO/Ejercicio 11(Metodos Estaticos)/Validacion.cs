using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11_Metodos_Estaticos_
{
    public class Validacion
    {
        public static bool Validar(int valor, int min,int max)
        {
            bool tof = false;
 
            if(valor > min && valor < max)
            {
                tof = true;   
            }

            return tof;
        }
    }
}
