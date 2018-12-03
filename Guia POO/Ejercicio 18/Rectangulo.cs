using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo
    {
        private float _area;
        private float _permimetro;
        private Punto _vertice1;
        private Punto _vertice2;
        private Punto _vertice3;
        private Punto _vertice4;

        public Rectangulo(Punto vertice1 , Punto vertice3)
        {
            this._vertice1 = vertice1;
            this._vertice3 = vertice3;
            this._vertice2 = Math.Abs(vertice1.GetX(),
        }

        public float GetArea ()
        {
            return this._area;
        }

        public float GetPerimetro()
        {
            return this._permimetro;
        }

        public float Area()
        {
            float resultado;

            resultado = this.GetArea
        }
    }
}
