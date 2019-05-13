using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM.Operaciones_avanzadas
{
    public static class RaicesPrimitivas
    {
        public static ComplejoPolar[] Calcular(int orden)
        {
            ComplejoPolar[] raices = new ComplejoPolar[orden];
            
            for (int k = 0; k < orden - 1; k++)
            {
                raices[k] = new ComplejoPolar(1, ((2 * Math.PI) * k) / orden);
            }

            return raices;
        }
    }
}
