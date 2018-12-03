using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respuesta = true;

            do
            {
                int opcion;
                Console.Clear();
                Console.WriteLine("1- Calcular Area De Un Cuadrado");
                Console.WriteLine("2- Calcular Area De Un Triangulo");
                Console.WriteLine("3- Calcular Area De Un Circulo");
                Console.WriteLine("4- Salir");

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        double areaCuadrado;
                        double lado;
                        Console.Clear();
                        Console.WriteLine("Ingresa Lado Del Cuadrado : ");
                        if (double.TryParse(Console.ReadLine(), out lado))
                        {
                            areaCuadrado = CalculoArea.CalcularCuadrado(lado);
                            Console.WriteLine("Area Cuadrado : {0}", areaCuadrado);

                        }
                        else
                        {
                            Console.WriteLine("No ingrese Caracteres.");
                        }

                        Console.ReadKey();

                        break;
                    case 2:
                        double areaTriangulo;
                        double Base, altura;

                        Console.Clear();
                        Console.WriteLine("Ingresa Base : ");

                        if (double.TryParse(Console.ReadLine(), out Base))
                        {
                            Console.WriteLine("Ingresa Altura : ");
                            if (double.TryParse(Console.ReadLine(), out altura))
                            {
                                areaTriangulo = CalculoArea.CalcularTriangulo(Base, altura);
                                Console.WriteLine("Area : {0}", areaTriangulo);
                            }
                            else
                            {
                                Console.WriteLine("No Ingrese Caracteres.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("No Ingrese Caracteres.");
                        }

                        Console.ReadKey();
                        break;

                    case 3:
                        double areaCirculo;
                        double radio;
                        Console.Clear();
                        Console.WriteLine("Ingresa Radio Del Circulo : ");
                        if (double.TryParse(Console.ReadLine(), out radio))
                        {
                            areaCirculo = CalculoArea.CalcularCuadrado(radio);
                            Console.WriteLine("Area Cuadrado : {0}", areaCirculo);

                        }
                        else
                        {
                            Console.WriteLine("No ingrese Caracteres.");
                        }

                        Console.ReadKey();
                        break;
                    case 4:
                        respuesta = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }


            } while (respuesta);
        }
    }
}
