using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respuesta = true;
            int opcion;
            string r;
            string binario;

            do
            {
                Console.Clear();
                Console.WriteLine("1- Convertir Decimal A Binario");
                Console.WriteLine("2- Convertir Binario A Decimal");
                Console.WriteLine("3- Salir");
                
                r = Console.ReadLine();

                while(int.TryParse(r,out opcion) == false)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESO UN CARACTER. \nINGRESE UN NUMERO ENTRE EL 1 Y 3");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("1- Convertir Decimal A Binario");
                    Console.WriteLine("2- Convertir Binario A Decimal");
                    Console.WriteLine("3- Salir");

                    r = Console.ReadLine();
                }

                switch(opcion)
                {
                    case 1:
                        Console.Clear();

                        double numero;

                        Console.WriteLine("Ingresa numero : ");
                        r = Console.ReadLine();

                        if(double.TryParse(r,out numero))
                        {
                            binario = Conversor.DecimalBinario(numero);
                            Console.Clear();
                            Console.WriteLine("Decimal : {0} \nEn Binario : {1}",numero,binario); 
                        }
                        else
                        {
                            Console.WriteLine("No se puede convertir lo ingresado a binario");
                        }
                        
                        Console.ReadKey();
                        break;
                    case 2:
                        string n = "110010";

                        double num = Conversor.BinarioDecimal(n);
                        Console.WriteLine(num);
                        Console.ReadKey();

                        break;
                    case 3:
                        respuesta = false;
                        break;
                    default:
                        Console.WriteLine("Ingrese Una Opcion Entre 1 y 3");
                        Console.ReadKey();
                        break;
                }

                
            } while (respuesta);
        }
    }
}
