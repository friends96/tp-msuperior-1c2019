using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo
{
    public class NumeroPrimerYCuartoCuadrante : NumeroComplejoBinomico
    {
        public override NumeroComplejoPolar GetFormaPolar()
        {
            return new NumeroComplejoPolar(GetModulo(), GetPrimerGiroPositivo(GetArgumento()));
        }

        private double GetPrimerGiroPositivo(double unArgumento)
        {
            if (unArgumento < 0)
                return unArgumento + (Math.PI * 2);
            else
                return unArgumento;
        }
    }
}
