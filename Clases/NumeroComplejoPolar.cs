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
            this._argumento = PrimerGiroPositivo(argumento);
        }

        public String Show()
        {
            return $"[{Math.Round(_modulo, 2)};{Math.Round(_argumento / Math.PI, 2)}π]";
        }

        private double PrimerGiroPositivo(double unArgumento)
        {
            if (unArgumento >= 2 * Math.PI)
            {
                return unArgumento % (2 * Math.PI);
            }
            else if(unArgumento >= 0 && unArgumento < 2 * Math.PI)
            {
                return unArgumento;
            }
            else if(unArgumento < 0 && ((unArgumento % (2*Math.PI)) != 0))
            {
                return (unArgumento % (2 * Math.PI)) + 2 * Math.PI;
            }
            else
            {
                return 0;
            }
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

        public double GetParteReal()
        {
            return convertidor.ConvertirABinomico(this).GetParteReal();
        }

        public double GetParteImaginaria()
        {
            return convertidor.ConvertirABinomico(this).GetParteImaginaria();
        }
    }
}
