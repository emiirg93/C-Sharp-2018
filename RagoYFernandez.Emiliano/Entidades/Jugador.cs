using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura { get { return this.altura; } }
        public float Peso { get { return this.peso; } }
        public Posicion Posicion { get { return this.posicion; } }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            : base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());

            sb.AppendLine("Altura : " + this.Altura);
            sb.AppendLine("Peso : " + this.Peso);
            sb.AppendLine("Posicion : "+this.Posicion.ToString());

            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            bool tof = false;
            double IMC;

            IMC = this.Peso / Math.Pow(this.Altura,2);

            if(IMC > 18.5 && IMC <=25)
            {
                tof = true;
            }

            return tof;
        }

        public override bool ValidarAptitud()
        {
            bool tof = false;

            if(this.Edad < 40 && this.ValidarEstadoFisico() == true)
            {
                tof = true; 
            }

            return tof;
        }
    }
}
