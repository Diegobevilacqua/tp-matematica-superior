using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM
{
    public enum TiposDeOnda
    {
        Coseno,
        Seno
    }
    public class Onda
    {
        public double Amplitud { get; set; }
        public double Frecuencia { get; set; }
        public double FaseInicial { get; set; }
        public TiposDeOnda Tipo { get; set; }

        public Onda(double amplitud, double frecuencia, double faseInicial, TiposDeOnda tipo)
        {
            Amplitud = amplitud;
            Frecuencia = frecuencia;
            FaseInicial = faseInicial;
            Tipo = tipo;
        }

        public ComplejoBinomica Fasor()
        {
            return new ComplejoPolar(Amplitud, FaseInicial).PasarABinomica();
        }



    }
}