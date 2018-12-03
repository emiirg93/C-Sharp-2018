using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billetes
{
    public class Dolar
    {
        private double _cantidad;
        private static float _cotizRespectoDolar = 1;

        public Dolar()
        {
            this._cantidad = 0;
        }

        public Dolar(double cantidad)
        {
            this._cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
            : this(cantidad)
        {
            _cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro();

            double cantidad = d._cantidad * e.GetCotizacion();

            Euro nuevo = new Euro(cantidad);

            return nuevo;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos p = new Pesos();

            double cantidad = d._cantidad * p.GetCotizacion();

            Pesos nuevo = new Pesos(cantidad);

            return nuevo;
        }

        public double GetCantidad()
        {
            return this._cantidad;
        }

        public float GetCotizacion()
        {
            return _cotizRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar nuevo = new Dolar(d);

            return nuevo;
        }

        public static bool operator ==(Dolar a, Dolar b)
        {
            bool tof = false;

            if (a._cantidad == b._cantidad)
            {
                tof = true;
            }

            return tof;
        }

        public static bool operator !=(Dolar a, Dolar b)
        {
            return !(a == b);
        }





    }
}
