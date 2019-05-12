using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM.Operaciones_avanzadas
{
    public static class Potenciacion
    {
        public static ComplejoPolar Calcular(ComplejoPolar complejoPolar, double exponente)
        {
            return new ComplejoPolar(Math.Pow(complejoPolar.Argumento, exponente), complejoPolar.Argumento * exponente);
        }
    }
}
