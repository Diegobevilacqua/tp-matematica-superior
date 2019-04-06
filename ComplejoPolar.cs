using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM
{
    class ComplejoPolar
    {
        private double Modulo { get; set; }
        private double Argumento { get; set; }

        public ComplejoPolar(double _Modulo, double _Argumento)
        {
            Modulo = _Modulo;
            Argumento = _Argumento;
        }

        public double ParteReal()
        {
            return Modulo * Math.Cos(Argumento);
        }

        public double ParteImaginaria()
        {
            return Modulo * Math.Sin(Argumento);
        }

        public ComplejoBinomica PasarABinomica()
        {
            ComplejoBinomica complejoBinomica = new ComplejoBinomica(ParteReal(), ParteImaginaria());
            return complejoBinomica;
        }
    }
}
