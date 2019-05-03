using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo
{
    public class NumeroOrigen : NumeroComplejoBinomico
    {
        public override NumeroComplejoPolar GetFormaPolar()
        {
            return new NumeroComplejoPolar(0, 0);
        }
    }
}
