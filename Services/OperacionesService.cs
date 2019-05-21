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

        
    }
}
