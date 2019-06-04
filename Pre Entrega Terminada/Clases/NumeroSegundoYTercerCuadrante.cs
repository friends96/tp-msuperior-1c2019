using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo
{
    public class NumeroSegundoYTercerCuadrante : NumeroComplejoBinomico
    {
        public override NumeroComplejoPolar GetFormaPolar()
        {
            return new NumeroComplejoPolar(GetModulo(), GetArgumento() + Math.PI);
        }
        
    }
}
