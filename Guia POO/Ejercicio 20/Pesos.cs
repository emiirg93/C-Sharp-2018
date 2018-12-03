using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billetes
{
    public class Pesos
    {
        private double _cantidad;
        private static float _cotizRespectoDolar = 0.028f;

        public Pesos()
        {
            this._cantidad = 0;
        }

        public Pesos(double cantidad)
            : this()
        {
            this._cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
            : this(cantidad)
        {
            _cotizRespectoDolar = cotizacion;
        }

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
