using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MateSuperior_Final.Clases
{
    class NComplejo
    {
        public double REAL { get; set; }
        public double IMG { get; set; }
        public double MODULO { get; set; }
        public double ARGUMENTO { get; set; }

        //public int Razon { get; set; }

        public NComplejo()
        {
            REAL = 0;
            IMG = 0;
            MODULO = 0;
            ARGUMENTO = 0;
        }
        public NComplejo(double num1, double num2, string modo)
        {
            if(modo == "BIN")
            {
                REAL = num1;
                IMG = num2;
                complementarPOLAR();
            }else if(modo == "POLAR")
            {
                MODULO = num1;
                ARGUMENTO = num2 * Math.PI;
                complementarBINOMICA();
            }
            else
            {
                REAL = 0;
                IMG = 0;
                MODULO = 0;
                ARGUMENTO = 0;
            }
        }

        private void complementarPOLAR()
        {
            MODULO = Math.Sqrt(Math.Pow(REAL, 2) + Math.Pow(IMG, 2));
            ARGUMENTO = Math.Atan2(IMG, REAL);
        }
        private void complementarBINOMICA()
        {
            REAL = MODULO * Math.Cos(ARGUMENTO);
            IMG = MODULO * Math.Sin(ARGUMENTO);
        }
        public void RELOAD(string tipo, double valor)
        {
            if (tipo == "REAL")
            {
                REAL = valor;
                complementarPOLAR();
            }
            else if (tipo == "IMG")
            {
                IMG = valor;
                complementarPOLAR();
            }
            else if (tipo == "MODULO")
            {
                MODULO = valor;
                complementarBINOMICA();
            }
            else
            {
                ARGUMENTO = valor;
                complementarBINOMICA();
            }
        }
    }
}
