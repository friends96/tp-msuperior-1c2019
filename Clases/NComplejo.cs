using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Matematica_Superior_Demo.Clases
{
    class NComplejo
    {
        public double real { get; set; }
        public double img { get; set; }
        public double modulo { get; set; }
        public double argumento { get; set; }
        public int razon { get; set; }
        public RazonesTrigonometricas Tipo { get; set; }

        public NComplejo()
        {
            real = 0;
            img = 0;
            modulo = 0;
            argumento = 0;
        }
        public NComplejo(double real, double img, int razon)
        {
            this.real = real;
            this.img = img;
            this.razon = razon;
            complementarPolar();
        }
        public NComplejo(double modulo, double argumento, int razon, string tipo)
        {
            this.modulo = modulo;
            this.argumento = argumento*Math.PI;
            this.razon = razon;
            complementarBinomica();
        }

        private void complementarBinomica()
        {
            //throw new NotImplementedException();
            real = modulo * Math.Cos(argumento);
            img = modulo * Math.Sin(argumento);
        }

        private void complementarPolar()
        {
            modulo = (double)Math.Sqrt(Math.Pow(real, 2) + Math.Pow(img, 2));
            argumento = Math.Atan2(img, real);
            //argumento = Math.Atan(img / real);
        }

        public void ImplementarBinario(double real, double img)
        {
            this.real = real;
            this.img = img;
            complementarPolar();
        }

        public void RELOAD(string tipo, double valor)
        {
            if(tipo == "real")
            {
                real = valor;
                complementarPolar();
            }else if(tipo == "img")
            {
                img = valor;
                complementarPolar();
            }else if(tipo == "modulo")
            {
                modulo = valor;
                complementarBinomica();
            }
            else
            {
                argumento = valor;
                complementarBinomica();
            }
        }
    }
}
