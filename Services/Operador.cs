using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Matematica_Superior_Demo.Clases;

namespace TP_Matematica_Superior_Demo.Services
{
    class Operador
    {
        public NComplejo complejo1 { get; set; }
        public NComplejo complejo2 { get; set; }

        public Operador()
        {
            //complejo1 = 0;
            //complejo2 = 0;
        }
        public NComplejo Sumar(NComplejo f1, NComplejo f2)
        {
            double real = f1.real + f2.real;
            double img = f1.img + f2.img;
            NComplejo Respuesta = new NComplejo(real,img);
            return Respuesta;
        }
    }
}
