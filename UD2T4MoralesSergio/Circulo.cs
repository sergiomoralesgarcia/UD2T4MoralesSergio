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
    internal class Circulo: Figura
    {
        float
        public override float Perimetro(float radio)
        {
            return Math.PI() * (radio * radio);
        }

        public override float Area(float radio)
        {
            return Math.PI() * (r * r)   ;
        }
    }
}
