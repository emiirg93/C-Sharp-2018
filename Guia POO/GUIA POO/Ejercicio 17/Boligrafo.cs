using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_17
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this._color = color;
            this._tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this._color;
        }

        public short GetTinta()
        {
            return this._tinta;
        }

        private void SetTinta(short tinta)
        {
            if ((this._tinta - tinta) <= cantidadTintaMaxima && tinta >= 0)
            {
                this._tinta -= tinta;
            }
        }

        public void Recargar()
        {
            this._tinta = cantidadTintaMaxima;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool tof = false;
            dibujo = "";

            if (gasto <= cantidadTintaMaxima && (this.GetTinta()-gasto) >= 0)
            {
                this.SetTinta((short)gasto);

                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*"; 
                }

                tof = true;
            }
            else
            {
                Console.WriteLine("Tinta Insuficiente\n\nRECARGUE TINTA.");
                Console.ReadKey();
            }

            return tof;
        }




    }
}
