using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Año_bisiesto
{
    internal class Solucion
    {
        private float añoB;
         

        public Solucion (float añoB)
        {
            this.añoB = añoB;
        }

        public string Respuesta()
        {
            if (añoB % 4 == 0 && añoB % 100 != 0 || añoB % 400 == 0)
            {
                return "Es bisiesto";
            }

            else
            {
                return "No es bisiesto";        
            }

        }
    }
}
