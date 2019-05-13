using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NCOM
{
    public class Parser
    {
        public static bool EstaEnBinomica(string complejo)
        {
            Regex regexBinomica = new Regex(@"\s*\(\s*([\+-]?\d+(?:,\d+)?)\s*,\s*([\+-]?\d+(?:,\d+)?)\s*\)\s*");
            return regexBinomica.IsMatch(complejo);
        }
        public static bool EstaEnPolar(string complejo)
        {
            Regex regexPolar = new Regex(@"\s*\[\s*([\+-]?\d+(?:,\d+)?)\s*;\s*([\+-]?\d+(?:,\d+)?)\s*\]\s*");

            return regexPolar.IsMatch(complejo);
        }
        public static ComplejoBinomica Parsear(string textoComplejo)
        {
            Regex regexBinomica = new Regex(@"\s*\(\s*([\+-]?\d+(?:,\d+)?)\s*,\s*([\+-]?\d+(?:,\d+)?)\s*\)\s*");
            Regex regexPolar = new Regex(@"\s*\[\s*([\+-]?\d+(?:,\d+)?)\s*;\s*([\+-]?\d+(?:,\d+)?)\s*\]\s*");

            if (EstaEnBinomica(textoComplejo))
            {
                Match matchBin = regexBinomica.Match(textoComplejo);

                double parteReal = Convert.ToDouble(matchBin.Groups[1].Value);
                double parteImaginaria = Convert.ToDouble(matchBin.Groups[2].Value);

                ComplejoBinomica complejoBin = new ComplejoBinomica(parteReal, parteImaginaria);
                return complejoBin;
            }
            else 
            if (EstaEnPolar(textoComplejo))
            {
                Match matchPol = regexPolar.Match(textoComplejo);

                double modulo = Convert.ToDouble(matchPol.Groups[1].Value);
                double argumento = Convert.ToDouble(matchPol.Groups[2].Value);

                ComplejoPolar complejoPolar = new ComplejoPolar(modulo, argumento);
                return complejoPolar.PasarABinomica();
            }

            if (textoComplejo == "")
                return null;

            throw new FormatException("Los números no se ingresaron en el formato correcto.");
        }

        public static string BinAStringBin(ComplejoBinomica unComplejo)
        {
            double suParteReal = unComplejo.ParteReal;
            double suParteImaginaria = unComplejo.ParteImaginaria;
            return "(" + String.Format("{0:0.000}", suParteReal) + " , " + String.Format("{0:0.000}", suParteImaginaria) + ")";
        }
        public static string BinAStringPol(ComplejoBinomica unComplejo)
        {
            ComplejoPolar enPolar = unComplejo.PasarAPolar();
            double suModulo = enPolar.Modulo;
            double suArgumento = enPolar.Argumento;
            return "[" + String.Format("{0:0.000}", suModulo) + " ; " + String.Format("{0:0.000}", suArgumento) + "]";
        }
    }
}
