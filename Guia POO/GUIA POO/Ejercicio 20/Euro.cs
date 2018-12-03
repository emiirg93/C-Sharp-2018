using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billetes
{
    public class Euro
    {
        private double _cantidad;
        private static float _cotizRespectoDolar = 1.15f;

        public Euro()
        {
            this._cantidad = 0; 
        }

        public Euro(double cantidad) : this ()
        {
            this._cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this (cantidad)
        {
            _cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Euro p)
        {
            double cantidad = p._cantidad * p.GetCotizacion();

            Dolar nuevo = new Dolar(cantidad);

            return nuevo;
        }
        /*
        public static explicit operator Pesos(Euro e)
        {
            Pesos p = new Pesos();

            double cantidad = e._cantidad * p.GetCotizacion();
        }
          */
        public double GetCantidad()
        {
            return this._cantidad;
        }

        public float GetCotizacion()
        {
            return _cotizRespectoDolar;
        }
    }
}
