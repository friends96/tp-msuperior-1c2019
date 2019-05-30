using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Matematica_Superior_Demo.Clases;

namespace TP_Matematica_Superior_Demo.Services
{
    class Operador
    {
        public NComplejo complejo1 { get; set; }
        public NComplejo complejo2 { get; set; }
        public NComplejo resultado { get; set; }

        public Operador()
        {
            //complejo1 = 0;
            //complejo2 = 0;
        }
        public NComplejo Sumar(NComplejo f1, NComplejo f2)
        {
            double real = (double)f1.real + (double)f2.real;
            double img = f1.img + f2.img;
            NComplejo Respuesta = new NComplejo(real,img);
            /*
            MessageBox.Show($"" +
                $"F1 = ({Math.Round(f1.real, 4)};{Math.Round(f1.img, 4)}) -- [{Math.Round(f1.modulo, 4)};{Math.Round(f1.argumento, 4)}]\n" +
                $"F2 = ({Math.Round(f2.real, 4)};{Math.Round(f2.img, 4)}) -- [{Math.Round(f2.modulo, 4)};{Math.Round(f2.argumento, 4)}]\n" +
                $"FR = ({Math.Round(Respuesta.real, 4)};{Math.Round(Respuesta.img, 4)}) -- [{Math.Round(Respuesta.modulo, 4)};{Math.Round(Respuesta.argumento),4}]");
            */
            return Respuesta;
        }

        public void REPORTARfasores(NComplejo fasor1, NComplejo fasor2, NComplejo fasorFinal)
        {
            MessageBox.Show($"" +
                $"       BINOMICO           POLAR\n" + 
                $"F1 = ({Math.Round(fasor1.real, 4)};{Math.Round(fasor1.img, 4)})      ---      [{Math.Round(fasor1.modulo, 4)};{Math.Round(fasor1.argumento, 4)}]\n" +
                $"F2 = ({Math.Round(fasor2.real, 4)};{Math.Round(fasor2.img, 4)})      ---      [{Math.Round(fasor2.modulo, 4)};{Math.Round(fasor2.argumento, 4)}]\n" +
                $"FR = ({Math.Round(fasorFinal.real, 4)};{Math.Round(fasorFinal.img, 4)})      ---      [{Math.Round(fasorFinal.modulo, 4)};{Math.Round(fasorFinal.argumento, 4)}]\n");
        }
    }
}
