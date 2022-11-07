///////////////////////////////////////////
// Tarea: UD2T4
// Alumno/a: Sergio Morales García
// Curso: 2022/2023
///////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4MoralesSergio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Boolean acabar = false;

            while (!acabar)
            {
                try
                {
                    Console.WriteLine("Elija una de las siguientes opciones");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("0 - Salir");
                    Console.WriteLine("1 - Rectángulo");
                    Console.WriteLine("2 - Círculo");
                    Console.WriteLine("3 - Triángulo");
                    int numero = int.Parse(Console.ReadLine());

                    switch (numero)
                    {
                        case 0:
                            Console.WriteLine("Has salido");
                            acabar = true;
                            break;
                        case 1:
                            
                            break;
                        case 2:
                            
                            break;
                        case 3:
                            
                            break;
                        default:

                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dato mal introducido");
                }
            }

        }
    }
}
