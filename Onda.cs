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
    class Onda
    {
        public double Amplitud { get; set; }
        public double Frecuencia { get; set; }
        public double Periodo { get; set; }
        public double FaseInicial { get; set; }
        public double DesplazamientoVertical { get; set; }
        public TiposDeOnda Tipo { get; set; }

        public Onda(double amplitud, double frecuencia, double periodo, double faseInicial, double desplazamientoVertical, TiposDeOnda tipo)
        {
            Amplitud = amplitud;
            Frecuencia = frecuencia;
            Periodo = periodo;
            FaseInicial = faseInicial;
            DesplazamientoVertical = desplazamientoVertical;
            Tipo = tipo;
        }

        public ComplejoBinomica Fasor()
        {
            return new ComplejoPolar(Amplitud, FaseInicial).PasarABinomica();
        }



    }
}
