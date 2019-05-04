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
    }
}
