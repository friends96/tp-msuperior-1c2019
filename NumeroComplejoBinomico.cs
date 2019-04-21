﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo
{
    public abstract class NumeroComplejoBinomico
    {
        protected double parteReal;
        protected double parteImaginaria;

        public void SetParteReal(double parteReal)
        {
            this.parteReal = parteReal;
        }

        public double GetParteReal()
        {
            return parteReal;
        }
        public void SetParteImaginaria(double parteImaginaria)
        {
            this.parteImaginaria = parteImaginaria;
        }
        public double GetParteImaginaria()
        {
            return parteImaginaria;
        }
        public abstract NumeroComplejoPolar GetFormaPolar();

        protected double GetModulo()
        {
            return Math.Sqrt(Math.Pow(parteReal, 2) + Math.Pow(parteImaginaria, 2));
        }

        protected double GetArgumento()
        {
            return Math.Atan(parteImaginaria / parteReal);
        }

               
        
    }
}
