using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM.Operaciones_básicas
{
    public class OperacionesBasicas
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

        public static ComplejoBinomica Multiplicar(ComplejoBinomica unComplejo, ComplejoBinomica otroComplejo)
        {
            double nuevoReal = (unComplejo.ParteReal * otroComplejo.ParteReal) - (unComplejo.ParteImaginaria * otroComplejo.ParteImaginaria);
            double nuevoImaginaria = (unComplejo.ParteReal * otroComplejo.ParteImaginaria) + (unComplejo.ParteImaginaria * otroComplejo.ParteReal);

            return new ComplejoBinomica(nuevoReal, nuevoImaginaria);
        }

        public static ComplejoBinomica Dividir(ComplejoBinomica unComplejo, ComplejoBinomica otroComplejo)
        {
            double nuevoReal = ((unComplejo.ParteReal * otroComplejo.ParteReal) + (unComplejo.ParteImaginaria + otroComplejo.ParteImaginaria)) / (Math.Pow(otroComplejo.ParteReal, 2) + Math.Pow(otroComplejo.ParteImaginaria, 2));
            double nuevoImaginaria = ((unComplejo.ParteImaginaria * otroComplejo.ParteReal) - (unComplejo.ParteReal * otroComplejo.ParteImaginaria)) / (Math.Pow(otroComplejo.ParteReal, 2) + Math.Pow(otroComplejo.ParteImaginaria, 2));
            return new ComplejoBinomica(nuevoReal, nuevoImaginaria);
        }

    }
}
