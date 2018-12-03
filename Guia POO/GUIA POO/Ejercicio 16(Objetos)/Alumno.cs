using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_16_Objetos_
{
    public class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string apellido, int legajo, string nombre)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random r = new Random();

                this._notaFinal = r.Next(4,11);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            if (notaUno >= 0 && notaUno <= 10)
            {
                this._nota1 = notaUno;

                if (notaDos >= 0 && notaDos <= 10)
                {
                    this._nota2 = notaDos;
                }
            }
        }

        public string Mostrar()
        {


            if (this._notaFinal != -1)
            {
                return "Nombre : " + this.nombre + "\nApellido : " + this.apellido + "\nPrimer Parcial : " + this._nota1.ToString() + "\nSegundo Parcial : " + this._nota2.ToString() + "\nFinal : " + this._notaFinal.ToString();
            }
            else
            {
                return "Nombre : " + this.nombre + "Apellido : " + this.apellido + "\nPrimer Parcial : " + this._nota1.ToString() + "\nSegundo Parcial : " + this._nota2.ToString() + "\nRecursa";
            }
        }
    }
}
