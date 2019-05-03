using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo
{
    public class NumeroComplejoPolar : INumeroComplejo
    {
        private double _modulo;
        private double _argumento;
        private ConvertidorService convertidor = new ConvertidorService();

        public NumeroComplejoPolar(double modulo, double argumento)
        {
            this._modulo = modulo;
            this._argumento = argumento;
        }

        public double GetModulo()
        {
            return _modulo;
        }

        public double GetArgumento()
        {
            return _argumento;
        }

        public NumeroComplejoBinomico GetFormaBinomica()
        {
            return convertidor.ConvertirABinomico(this);
        }

        public NumeroComplejoPolar GetFormaPolar()
        {
            return this;
        }
    }
}
