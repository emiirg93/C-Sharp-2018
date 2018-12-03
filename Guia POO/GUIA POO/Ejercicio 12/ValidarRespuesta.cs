using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    public class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            bool tof = false;

            c = char.ToUpper(c);
            
            if(c == 'S')
            {
                tof = true;   
            }

            return tof;
        }
    }
}
