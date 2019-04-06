﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOM
{
    class NumeroComplejo
    {
        private double ParteReal { get; set; }
        private double ParteImaginaria { get; set; }

        public int Cuadrante()
        {
            if (ParteReal > 0)
            {
                if (ParteImaginaria > 0)
                    return 1;
                else
                    return 4;
            }
            else
            {
                if (ParteImaginaria > 0)
                    return 2;
                else
                    return 3;
            }
        }
        public double Modulo()
        {
            return Math.Sqrt(Math.Pow(ParteReal, 2) + Math.Pow(ParteImaginaria, 2));
        }

        public double Argumento()
        {
            double argumento = Math.Atan(ParteImaginaria / ParteReal);
            int cuadrante = Cuadrante();

            if (cuadrante == 4)
            {
                argumento += 2 * Math.PI;
                return argumento;
            }

            if (cuadrante == 3)
            {
                argumento += Math.PI;
                return argumento;
            }

            if (argumento == 2)
            {
                argumento += Math.PI;
                return argumento;
            }

            return argumento;
        }

        public double GetParteReal()
        {
            double modulo = Modulo();
            double argumento = Argumento();

            return modulo * Math.Cos(argumento);
        }

        public double GetParteImaginaria()
        {
            double modulo = Modulo();
            double argumento = Argumento();

            return modulo * Math.Sin(argumento);
        }
    }
}
