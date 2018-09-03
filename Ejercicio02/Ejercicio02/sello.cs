using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Sello
    {
        public static string mensaje;
        
        public static ConsoleColor color;

        public static string Imprimir()
        {
            bool ok = TryParse(mensaje, out mensaje);
            string respuesta = "Error";

            if (ok)
            {
              mensaje = ArmarMensajeConFormato();
              return mensaje;
            }
            else
            {
                return respuesta;
            }
            
        }

        public static void Borrar()
        {
            mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.Write(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static string ArmarMensajeConFormato()
        {
            string a = "";

            for (int i = 0; i < mensaje.Length + 2; i++)
            {
                a += "*";
            }
            
            a  += "\n*";

            a += Sello.mensaje;

            a += "*\n";

            for (int i = 0; i < mensaje.Length + 2; i++)
            {
                a += "*";
            }

            return a;
        }

        private static bool TryParse ( string a, out string b)
        {
            bool ToF = false;
            
            if (a.Length != 0)
            {
                b = a;
                ToF = true;
            } 
            else
            {
                b = "";
            }

            return ToF;
        }

    }
}
