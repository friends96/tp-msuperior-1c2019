using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo
{
    class ConvertidorService
    {
       // public ConvertidorService() { }

        public NumeroComplejoBinomico ConvertirABinomico(NumeroComplejoPolar numeroPolar)
        {
            double angulo = numeroPolar.GetArgumento();
            double modulo = numeroPolar.GetModulo();
            double parteReal = Math.Cos(angulo) * modulo;
            double parteImaginaria = Math.Sin(angulo) * modulo;

            return CrearNumeroBinomico(parteReal, parteImaginaria);

        }

        public NumeroComplejoBinomico CrearNumeroBinomico(double parteReal, double parteImaginaria)
        {
            NumeroComplejoBinomico resultado;

            if (parteReal == 0 && parteImaginaria != 0)
            {
                resultado = new NumeroImaginarioPuro();
            }
            else if (parteReal != 0 && parteImaginaria == 0)
            {
                resultado = new NumeroReal();
            }
            else if (parteReal > 0 && parteImaginaria != 0)
            {
                resultado = new NumeroPrimerYCuartoCuadrante();
            }
            else if (parteReal < 0 && parteImaginaria != 0)
            {
                resultado = new NumeroSegundoYTercerCuadrante();
            }
            else
            {
                resultado = new NumeroOrigen();
            }

            resultado.SetParteReal((double)parteReal);
            resultado.SetParteImaginaria((double)parteImaginaria);

            return resultado;



        }

    }
}
