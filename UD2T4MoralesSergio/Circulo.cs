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
    /// Clase círculo
    /// </summary>
    internal class Circulo: Figura
    {

        // Declaración de las variables del círculo
        float radio;

        public Circulo (float radio)
        {
            this.radio = radio;
        }

        /// <summary>
        /// Perímetro del círculo
        /// </summary>
        /// <returns>
        /// Devuelve el resultado de la multiplicación del radio del círculo y el número pi y 2.
        /// </returns>
        public override float Perimetro()
        {
            return 2 * (float)Math.PI * radio;
        }

        /// <summary>
        /// Área del rectángulo
        /// </summary>
        /// <returns>
        /// Devuelve el resultado de la multiplicación del diámetro del círculo y el número pi
        /// </returns>
        public override float Area()
        {
            return (float)Math.PI * (radio * radio);
        }
    }
}
