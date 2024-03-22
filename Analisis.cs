using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Año_bisiesto
{
    internal class Analisis
    {
        public void Start()
        {
            analisis();
        }

        bool continueflag = true;

        public void analisis()
        {
            while (continueflag)
            {
                float añoB;
                Console.WriteLine("Ingresa el año a analisas: \n");
                añoB = float.Parse(Console.ReadLine());

                Solucion solucion = new Solucion(añoB);
                Console.WriteLine($"Resultado: {solucion.Respuesta()}");

                Console.WriteLine("Deseas conntinuar, SI/NO \n");
                if (Console.ReadLine() == "NO")
                {
                    continueflag = false;
                }

                Console.WriteLine();

            }

        }
    }
}
