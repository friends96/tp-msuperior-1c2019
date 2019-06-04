using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo.Services
{
    public static class OperacionesService
    {
        public static INumeroComplejo Sumar(INumeroComplejo operando1, INumeroComplejo operando2)
        {
            double parteRealResultado = operando1.GetParteReal() + operando2.GetParteReal();
            double parteImaginariaResultado = operando1.GetParteImaginaria() + operando2.GetParteImaginaria();
            return NumeroComplejoBinomico.NewNumeroComplejoBinomico(parteRealResultado, parteImaginariaResultado);
        }

        public static INumeroComplejo Resta(INumeroComplejo operando1, INumeroComplejo operando2)
        {
            double parteRealResultado = operando1.GetParteReal() - operando2.GetParteReal();
            double parteImaginariaResultado = operando1.GetParteImaginaria() - operando2.GetParteImaginaria();
            return NumeroComplejoBinomico.NewNumeroComplejoBinomico(parteRealResultado, parteImaginariaResultado);
        }

        public static INumeroComplejo Multiplicar(INumeroComplejo operando1, INumeroComplejo operando2)
        {
            double parteRealResultado = operando1.GetParteReal() * operando2.GetParteReal() - operando1.GetParteImaginaria() * operando2.GetParteImaginaria();
            double parteImaginariaResultado = operando1.GetParteReal() * operando2.GetParteImaginaria() + operando1.GetParteImaginaria() * operando2.GetParteReal();
            return NumeroComplejoBinomico.NewNumeroComplejoBinomico(parteRealResultado, parteImaginariaResultado);
        }

        public static INumeroComplejo Dividir(INumeroComplejo operando1, INumeroComplejo operando2)
        {
            INumeroComplejo conjugadoDelSegundoOperando = NumeroComplejoBinomico
                .NewNumeroComplejoBinomico(operando2.GetParteReal(), operando2.GetParteImaginaria() * (-1));

            INumeroComplejo numerador = Multiplicar(operando1, conjugadoDelSegundoOperando);

            double resultadoProductoDeConjugados = Math.Pow(operando2.GetParteReal(), 2) + Math.Pow(operando2.GetParteImaginaria(), 2);

            return NumeroComplejoBinomico.NewNumeroComplejoBinomico(numerador.GetParteReal() / resultadoProductoDeConjugados, numerador.GetParteImaginaria() / resultadoProductoDeConjugados);
        }

        public static INumeroComplejo Potenciacion(INumeroComplejo radicando, int indice)
        {
            double moduloResultado = Math.Pow(radicando.GetFormaPolar().GetModulo(), indice);
            double argumentoResultado = radicando.GetFormaPolar().GetArgumento() * indice;

            return new NumeroComplejoPolar(moduloResultado, argumentoResultado);
        }

        public static List<INumeroComplejo> Radicacion(INumeroComplejo radicando, int indice)
        {
            List<INumeroComplejo> resultado = new List<INumeroComplejo>();
            NumeroComplejoPolar operando = radicando.GetFormaPolar();
            double moduloResultante = Math.Pow(operando.GetModulo(), 1 / (double)indice);   //no hay funcion para hacer la raiz N de un numero, asi que hago la potencia a la 1/N
            double argumentoResultante = operando.GetArgumento() / indice;
            NumeroComplejoPolar nuevaRaiz = new NumeroComplejoPolar(moduloResultante, argumentoResultante);
            double variacionAngulo = 2 * Math.PI / indice;

            resultado.Add(nuevaRaiz);
            int i = 1;
            while(i<indice)
            {
                argumentoResultante += variacionAngulo;
                nuevaRaiz = new NumeroComplejoPolar(moduloResultante, argumentoResultante);

                resultado.Add(nuevaRaiz);
                i++;
            }

            return resultado;
        }

        public static List<String> RaicesPrimitivasDeLaUnidadReal(int indice)
        {
            List<String> resultado = new List<String>();
            int i = 1;
            string unaRaiz;
            double anguloPorRaiz = (double)2 * Math.PI / (double)indice;
            while (i<indice)
            {
                if(OperacionesService.SonCoprimos(i,indice))
                {
                    unaRaiz = $"w{i}-- {(new NumeroComplejoPolar(1,i*anguloPorRaiz)).Show()}";
                    resultado.Add(unaRaiz);
                }
                i++;
            }
            return resultado;

        }
        public static bool SonCoprimos(int a, int b)
        {
            if (a == 1 || b == 1) return true;

            int i = 2;
            int min, max;
            if (a < b)
            {
                min = a;
                max = b;
            }
            else
            {
                min = b;
                max = a;
            }
            for(i=2; i<=min; i++)
            {
                if(min%i==0 && max%i==0)
                { return false;}
            }
            return true;
        }
    }
}
