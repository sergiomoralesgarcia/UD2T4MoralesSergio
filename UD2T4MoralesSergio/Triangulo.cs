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
    internal class Triangulo: Figura
    {
        float base1;
        float altura;

        public override float Perimetro()
        {
            return base1 + base1 + base1;
        }

        public override float Area()
        {
            return (base1 * altura) / 2;
        }
    }
}
