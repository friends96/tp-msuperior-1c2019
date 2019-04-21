using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo
{
    public class NumeroReal : NumeroComplejoBinomico
    {
        public override NumeroComplejoPolar GetFormaPolar()
        {
            if(parteReal > 0)
                return new NumeroComplejoPolar(GetModulo(), 0);
            else
                return new NumeroComplejoPolar(GetModulo(), Math.PI);

        }
    }
}
