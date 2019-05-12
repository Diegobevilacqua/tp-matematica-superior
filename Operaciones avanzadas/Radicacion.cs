using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM.Operaciones_avanzadas
{
    public static class Radicacion
    {
        public static ComplejoPolar[] Calcular(ComplejoPolar complejoPolar, double orden)
        {
            ComplejoPolar[] raices = new ComplejoPolar[(int)orden];

            for (int k = 0; k < orden - 1; k++)
            {
                double modulo = Math.Pow(complejoPolar.Modulo, 1 / orden);
                double argumento = (complejoPolar.Argumento + 2 * k * Math.PI) / orden;
                raices[k] = new ComplejoPolar(modulo, argumento);
            }

            return raices;
        }
    }
}
