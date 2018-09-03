using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cosa
    {
        #region Atributos

        public string cadena;
        public double numero;
        public DateTime dato;

        #endregion

        #region Metodos

        public Cosa()  //constructor.
        {
            this.cadena = "sin valor";
            this.numero = 1.9;
            this.dato = DateTime.Now;
        }

        public Cosa(string a) : this() //constructor 2, utilizo el this() para no repetir las lineas de codigo que ya estan repetidas en el primer constructor.
        {
            this.cadena = a; 
            //this.numero = 1.9;
            //this.dato = DateTime.Now;
        }

        public Cosa(string a , DateTime b) : this(a)
        {
            //this.cadena = a;
            //this.numero = 1.9;
            this.dato = b;
        }

        public Cosa(string a , DateTime b, double c) :this(a,b)
        {
            //this.cadena = a;
            this.numero = c;
            //this.dato = b; 
        }

        public static string mostrar(Cosa algo)
        {
            return algo.mostrar();
        }

        private string mostrar()
        {

            return this.cadena + " " + this.numero.ToString() + " " + this.dato.ToLongDateString();
        }

        public void establecerValor (string a)
        {
            this.cadena = a;
        }

        public void establecerValor(string a, double b)
        {
            this.cadena = a;
            this.numero = b;
        }

        public void establecerValor(string a , double b, DateTime c)
        {
            this.cadena = a;
            this.numero = b;
            this.dato = c;
        }

        #endregion

    }  

}
