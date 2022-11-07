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
    internal class Ractangulo: Figura
    {
        float lado1;
        float lado2;
        public override float Perimetro()
        {
            return lado1 + lado1 + lado2 + lado2;
        }

        public override float Area()
        {
            return lado1 * lado2;
        }
    }
}
