using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM.Operaciones_básicas
{
    public class EspecialistaEnSumasDeFasores
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

            this.VerificarYConvertirTiposOnda();

            if (UnaOnda.Frecuencia != OtraOnda.Frecuencia)
                throw new FrecuenciasDistintasException();

            return OperacionesBasicas.Sumar(UnaOnda.Fasor(), OtraOnda.Fasor());
        }

        public Onda SumarOndas()
        {
            ComplejoPolar fasoresSumados = SumarFasores().PasarAPolar();

            return new Onda(fasoresSumados.Modulo, UnaOnda.Frecuencia, fasoresSumados.Argumento, UnaOnda.Tipo);
        }

        private void VerificarYConvertirTiposOnda()
        {
            if (UnaOnda.Tipo != OtraOnda.Tipo)
            {
                OtraOnda.Tipo = UnaOnda.Tipo;
                if (UnaOnda.Tipo == TipoDeOnda.COSENO)
                    OtraOnda.FaseInicial -= Math.PI / 2;
                else
                    OtraOnda.FaseInicial += Math.PI / 2;
            }
        }
    }



}