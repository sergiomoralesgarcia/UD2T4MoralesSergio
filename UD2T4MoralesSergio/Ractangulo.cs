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
        public override float Perimetro()
        {
            return altura * base;
        }

        public override float Area(float a, float b)
        {
            return a * b;
        }
    }
}
