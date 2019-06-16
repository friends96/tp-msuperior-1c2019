using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_MateSuperior_Final.Clases;

namespace TP_MateSuperior_Final.Servicios
{
    class ServicesOperator
    {
        public ServicesOperator()
        {

        }

        public NComplejo Complemento(NComplejo c1)
        {
            double img = -1 * c1.IMG;
            NComplejo resultado = new NComplejo(c1.REAL, img, "BIN");
            return resultado;
        }
        public NComplejo SUMAR(NComplejo c1, NComplejo c2)
        {
            double real = c1.REAL + c2.REAL;
            double img = c1.IMG + c2.IMG;
            NComplejo Resultado = new NComplejo(real, img, "BIN");
            return Resultado;
        }
        public NComplejo RESTAR(NComplejo c1, NComplejo c2)
        {
            double real = c1.REAL - c2.REAL;
            double img = c1.IMG - c2.IMG;
            NComplejo Resultado = new NComplejo(real, img, "BIN");
            return Resultado;
        }
        public NComplejo MULTIPLICAR(NComplejo c1, NComplejo c2)
        {
            double real = c1.REAL * c2.REAL - c1.IMG * c2.IMG;
            double img = c1.REAL * c2.IMG + c1.IMG * c2.REAL;
            NComplejo Resultado = new NComplejo(real, img, "BIN");
            return Resultado;
        }
        public NComplejo DIVIDIR(NComplejo c1, NComplejo c2)
        {
            
            NComplejo AUX = new NComplejo();
            AUX = MULTIPLICAR(c1, Complemento(c2));
            NComplejo resultado = new NComplejo(AUX.REAL / c2.MODULO, AUX.IMG / c2.MODULO, "BIN");
            
            //NComplejo resultado = new NComplejo(c1.MODULO / c2.MODULO, c1.ARGUMENTO - c2.ARGUMENTO, "POLAR");
            return resultado;
        }
        public NComplejo POTENCIA(NComplejo c1, int exponente)
        {
            double modulo = Math.Pow(c1.MODULO, exponente);
            double argumento = c1.ARGUMENTO * exponente; //<<<< ======  Math.PI
            NComplejo Resultado = new NComplejo(modulo, argumento, "POLAR");
            return Resultado;
        }
        public NComplejo RAIZ_Nesima(NComplejo c1, int indice)
        {
            NComplejo Resultado = new NComplejo(Math.Pow(c1.MODULO, 1/indice), c1.ARGUMENTO / indice, "POLAR"); // <<< === Math.PI
            return Resultado;
        }
    }
}
