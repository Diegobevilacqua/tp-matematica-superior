using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM.Operaciones_básicas
{
    class EspecialistaEnSumasDeFasores
    {
        public Onda UnaOnda { get; set; }
        public Onda OtraOnda { get; set; }

        public EspecialistaEnSumasDeFasores(Onda unaOnda, Onda otraOnda)
        {
            UnaOnda = unaOnda;
            OtraOnda = otraOnda;
        }

        public ComplejoBinomica SumarFasores()
        {
            if (UnaOnda.Frecuencia != OtraOnda.Frecuencia)
                throw new FrecuenciasDistintasException();
            return OperacionesBasicas.Sumar(UnaOnda.Fasor(), OtraOnda.Fasor());
        }

        public Onda SumarOndas()
        {
            ComplejoBinomica fasoresSumados = SumarFasores();
        }


    }
}
