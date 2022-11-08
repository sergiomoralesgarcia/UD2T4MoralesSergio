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

    /// <summary>
    /// Clase triángulo
    /// </summary>
    internal class Triangulo: Figura
    {

        // Declaración de las variables del triángulo
        private float base1;
        private float altura;

        public Triangulo (float base1, float altura)
        {
            this.base1 = base1;
            this.altura = altura;
        }


        /// <summary>
        /// Perímetro del triángulo
        /// </summary>
        /// <returns>
        /// Devuelve la suma de los tres lados del triángulo que hemos introducido.
        /// </returns>
        public override float Perimetro()
        {
            return base1 + base1 + base1;
        }

        /// <summary>
        /// Área del triángulo
        /// </summary>
        /// <returns>
        /// Devuelve el resultado de la multiplicación de la base y la altura dividido entre dos
        /// </returns>
        public override float Area()
        {
            return (base1 * altura) / 2;
        }
    }
}
