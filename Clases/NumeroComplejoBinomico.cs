using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo
{
    public abstract class NumeroComplejoBinomico : INumeroComplejo
    {
        protected double parteReal;
        protected double parteImaginaria;
        private static ConvertidorService convertidor = new ConvertidorService();

        public static NumeroComplejoBinomico NewNumeroComplejoBinomico(double unaParteReal, double unaParteImaginaria)
        {
            return convertidor.CrearNumeroBinomico(unaParteReal, unaParteImaginaria);
        }
        public String Show()
        {
            return $"({parteReal} , {parteImaginaria})"; //lo separo asi porque se confunden las comas de los numeros, de la que separa la parte real de la imaginaria
        }

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
        public NumeroComplejoBinomico GetFormaBinomica()
        {
            return this;
        }

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
