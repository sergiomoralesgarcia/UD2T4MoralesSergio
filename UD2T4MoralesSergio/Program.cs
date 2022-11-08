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
        /// <summary>
        /// Menú principal del programa
        /// </summary>
        /// <remarks>
        /// Esta es la interfaz pricipal del programa en el que elegimos qué opcion queremos realizar.
        /// Podemos elejir entre salir del programa, o calcular el área y el perímetro de un rectángulo, un círculo o un triángulo.
        /// </remarks>
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
                            Rectangulo();
                            break;
                        case 2:
                            Circulo();
                            break;
                        case 3:
                            Triangulo();
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

        /// <summary>
        /// Método del rectángulo
        /// </summary>
        /// <remarks>
        /// Calculamos perímetro y el área de un triángulo equilátero a partir 
        /// de una base y una altura introducidas por el usuario
        /// </remarks>
        private static void Rectangulo()
        {
            try
            {
                Console.WriteLine("Vamos a calcular el perímetro y el área del rectángulo.");
                Console.WriteLine("Introduzca la base:");
                float lado1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca la altura:");
                float lado2 = float.Parse(Console.ReadLine());
                Figura rectangulo = new Rectangulo(lado1, lado2);

                Console.WriteLine($"El perímetro del rectángulo es: {rectangulo.Perimetro()} \n");
                Console.WriteLine($"El área del rectángulo es: {rectangulo.Area()} \n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Dato mal introducido");
            }
        }

        /// <summary>
        /// Método del Círculo
        /// </summary>
        /// <remarks>
        /// Calculamos perímetro y el área de un círculoo equilátero a partir 
        /// de un radio introducido por el usuario
        /// </remarks>
        private static void Circulo()
        {
            try
            {
                Console.WriteLine("Vamos a calcular el perímetro y el área del círculo.");
                Console.WriteLine("Introduzca el radio:");
                float radio = float.Parse(Console.ReadLine());
                Figura circulo = new Circulo(radio);

                Console.WriteLine($"El perímetro del círculo es: {circulo.Perimetro()} \n");
                Console.WriteLine($"El área del círculo es: {circulo.Area()} \n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Dato mal introducido");
            }
        }

        /// <summary>
        /// Método del triángulo
        /// </summary>
        /// <remarks>
        /// Calculamos perímetro y el área de un triángulo equilátero a partir 
        /// de una base y una altura introducidas por el usuario
        /// </remarks>
        private static void Triangulo()
        {
            try
            {
                Console.WriteLine("Vamos a calcular el perímetro y el área del triángulo.");
                Console.WriteLine("Introduzca la base:");
                float base1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca la altura:");
                float altura = float.Parse(Console.ReadLine());
                Figura triangulo = new Triangulo(base1, altura);

                Console.WriteLine($"El perímetro del triángulo es: {triangulo.Perimetro()} \n");
                Console.WriteLine($"El área del triángulo es: {triangulo.Area()} \n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Dato mal introducido");
            }
        }
    }
}
