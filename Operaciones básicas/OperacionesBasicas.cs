using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM.Operaciones_básicas
{
    class OperacionesBasicas
    {
        
        public static ComplejoBinomica Sumar(ComplejoBinomica unComplejo, ComplejoBinomica otroComlpejo)
        {

            double nuevoReal = unComplejo.ParteReal + otroComlpejo.ParteReal;
            double nuevoImaginario = unComplejo.ParteImaginaria + otroComlpejo.ParteImaginaria;

            ComplejoBinomica nuevoComplejo = new ComplejoBinomica(nuevoReal, nuevoImaginario);
            return nuevoComplejo;
        }
        public static ComplejoBinomica Restar(ComplejoBinomica unComplejo, ComplejoBinomica otroComlpejo)
        {

            double nuevoReal = unComplejo.ParteReal - otroComlpejo.ParteReal;
            double nuevoImaginario = unComplejo.ParteImaginaria - otroComlpejo.ParteImaginaria;

            ComplejoBinomica nuevoComplejo = new ComplejoBinomica(nuevoReal, nuevoImaginario);
            return nuevoComplejo;
        }

    }
}
