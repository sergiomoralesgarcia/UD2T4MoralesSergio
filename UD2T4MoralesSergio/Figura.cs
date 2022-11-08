///////////////////////////////////////////
// Tarea: UD2T4
// Alumno/a: Sergio Morales García
// Curso: 2022/2023
///////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4MoralesSergio
{

    /// <summary>
    /// Clase figura que actua como padre 
    /// </summary>
    internal class Figura
    {
        // Método del perímetro 
        public virtual float Perimetro()
        {
            return 0; 
        }

        // Método del área
        public virtual float Area()
        {
            return 0; 
        }
    }
}
