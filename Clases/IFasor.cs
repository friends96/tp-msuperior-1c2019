using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo.Clases
{
    public interface IFasor
    {
        IFasor EnCos();
        IFasor EnSen();
        string Show();
        IFasor SumarEnCos(IFasor sumando);
        IFasor SumarEnSen(IFasor sumando);
        NumeroComplejoBinomico EnBinomico();

    }
}
