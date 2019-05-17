using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM
{
    public class Onda
    {
        public double Amplitud { get; set; }
        public double Frecuencia { get; set; }
        public double FaseInicial { get; set; }
        public TipoDeOnda Tipo { get; set; }

        public Onda(double amplitud, double frecuencia, double faseInicial, TipoDeOnda tipo)
        {
            Amplitud = amplitud;
            Frecuencia = frecuencia;
/*
            while (faseInicial < 0)
            {
                faseInicial += 2 * Math.PI;
            }
*/
            FaseInicial = faseInicial;

            Tipo = tipo;
        }

        public ComplejoBinomica Fasor()
        {
            return new ComplejoPolar(Amplitud, FaseInicial).PasarABinomica();
        }
    }
}