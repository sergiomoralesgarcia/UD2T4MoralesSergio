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
    /// Clase rectángulo
    /// </summary>
    internal class Rectangulo: Figura
    {
        // Declaración de las variables del rectángulo
        private float lado1;
        private float lado2;

        public Rectangulo(float lado1, float lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        /// <summary>
        /// Perímetro del rectángulo
        /// </summary>
        /// <returns>
        /// Devuelve la suma de los cuatro lados del rectángulo
        /// </returns>
        public override float Perimetro()
        {
            return lado1 + lado1 + lado2 + lado2;
        }

        /// <summary>
        /// Área del rectángulo
        /// </summary>
        /// <returns>
        /// Devuelve el resultado de la multiplicación de los dos lados distintos del rectángulo
        /// </returns>
        public override float Area()
        {
            return lado1 * lado2;
        }
    }
}
