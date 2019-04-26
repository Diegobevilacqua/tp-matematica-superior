using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM
{
    class ComplejoBinomica
    {
        public double ParteReal { get; set; }
        public double ParteImaginaria { get; set; }

        public ComplejoBinomica(double _ParteReal, double _ParteImaginaria)
        {
            ParteReal = _ParteReal;
            ParteImaginaria = _ParteImaginaria;
        }

        public int Cuadrante()
        {
            if (ParteReal > 0)
            {
                if (ParteImaginaria > 0)
                    return 1;
                else
                    return 4;
            }
            else
            {
                if (ParteImaginaria > 0)
                    return 2;
                else
                    return 3;
            }
        }
        public double Modulo()
        {
            return Math.Sqrt(Math.Pow(ParteReal, 2) + Math.Pow(ParteImaginaria, 2));
        }

        public double Argumento()
        {
            double argumento = Math.Atan(ParteImaginaria / ParteReal);
            int cuadrante = Cuadrante();

            if (cuadrante == 4)
            {
                argumento += 2 * Math.PI;
                return argumento;
            }

            if (cuadrante == 3)
            {
                argumento += Math.PI;
                return argumento;
            }

            if (cuadrante == 2)
            {
                argumento += Math.PI;
                return argumento;
            }

            return argumento;
        }
        
        public ComplejoPolar PasarAPolar()
        {
            ComplejoPolar complejoPolar = new ComplejoPolar(Modulo(), Argumento());
            return complejoPolar;
        }

        public ComplejoBinomica PasarABinomica()
        {
            return this;
        }


    }
}
