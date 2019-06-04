using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo
{
    public class NumeroImaginarioPuro : NumeroComplejoBinomico
    {
        public override NumeroComplejoPolar GetFormaPolar()
        {
            if (parteImaginaria > 0)
                return new NumeroComplejoPolar(GetModulo(), Math.PI / 2);
            else
                return new NumeroComplejoPolar(GetModulo(), 3 * Math.PI / 2);
        }
    }
}
