using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                try
                {
                    if (this.directorTecnico.ValidarAptitud())
                    {
                        this.directorTecnico = value;
                    }  
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }
        public string Nombre { set { this.nombre = value; } }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
            : this()
        {
            this.Nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre Del Equipo : " + e.nombre);

            if (e.directorTecnico == null)
            {
                sb.AppendLine("Sin DT Asignado.");
            }
            else
            {
                sb.AppendLine("Director Tecnico : " + e.directorTecnico);
            }

            foreach (Jugador item in e.jugadores)
            {
                sb.AppendLine(item.Mostrar());
            }

            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool tof = true;

            foreach (Jugador item in e.jugadores)
            {
                if (item == j)
                {
                    tof = true;
                    break;
                }
            }

            return tof;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            int flag = 0;

            if (e.jugadores.Count < cantidadMaximaJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag != 1)
                {
                    if (j.ValidarAptitud())
                    {
                        e.jugadores.Add(j);
                    }
                }
            }

            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool tof = false;
            int cantArquero = 0;
            bool cantDefensor = false;
            bool cantCentral = false;
            bool cantDelantero = false;

            if (e.directorTecnico != null && e.jugadores.Count == cantidadMaximaJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    switch (item.Posicion)
                    {
                        case Posicion.Arquero:
                            cantArquero++;
                            break;
                        case Posicion.Defensor:
                            cantDefensor = true;
                            break;
                        case Posicion.Central:
                            cantCentral = true;
                            break;
                        case Posicion.Delantero:
                            cantDelantero = true;
                            break;
                        default:
                            break;
                    }
                }

                if (cantArquero == 1 && cantDelantero == true && cantCentral == true && cantDelantero == true)
                {
                    tof = true; 
                }
            }

            return tof;
        }





    }
}
