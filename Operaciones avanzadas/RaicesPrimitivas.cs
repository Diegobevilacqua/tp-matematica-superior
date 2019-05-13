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
            
            for (int k = 0; k < orden; k++)
            {
                ComplejoPolar nuevoComplejo = new ComplejoPolar(1, ((2 * Math.PI) * k) / orden);

                if (MCD(k + 1, orden) == 1)
                    raices[k] = nuevoComplejo;
            }

            return raices;
        }

        public static int MCD(int a, int b)
        {
            int res;

            do
            {
                res = b;
                b = a % b;
                a = res;
            } while (b != 0);

            return res;
        }
    }
}
