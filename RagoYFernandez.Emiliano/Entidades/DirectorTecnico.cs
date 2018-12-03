using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia { get { return this.añosExperiencia; } set { this.añosExperiencia = value; } }

        public DirectorTecnico(string nombre, string apellido , int edad, int dni , int experiencia) : base (nombre,apellido,edad,dni)
        {
            this.añosExperiencia = experiencia;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Años De Experiencia : "+this.AñosExperiencia.ToString());

            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool tof = false;
            
            if(this.Edad < 65 && this.AñosExperiencia >= 2)
            {
                tof = true;
            }

            return tof;
        }
    }
}
