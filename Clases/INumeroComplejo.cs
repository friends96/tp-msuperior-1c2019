using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo
{
    public interface INumeroComplejo
    {
        NumeroComplejoPolar GetFormaPolar();
        NumeroComplejoBinomico GetFormaBinomica();
    }
}
