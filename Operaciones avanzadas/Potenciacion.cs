using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM.Operaciones_avanzadas
{
    public static class Potenciacion
    {
        public static ComplejoPolar Calcular(ComplejoPolar complejoPolar, Int16 exponente)
        {
            return new ComplejoPolar(Math.Pow(complejoPolar.Modulo, exponente), complejoPolar.Argumento * exponente);
        }
    }
}
