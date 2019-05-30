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
            
            if(f1.razon == 0) // 0 = seno  //  1 = coseno
            {
                f1.RELOAD("argumento", f1.argumento - Math.PI/2);
            }
            if(f2.razon == 0)
            {
                f2.RELOAD("argumento", f2.argumento - Math.PI/2);
            }
            double real = (double)f1.real + (double)f2.real;
            double img = f1.img + f2.img;
            NComplejo Respuesta = new NComplejo(real, img, 1); // El Fasor simpre suma en COSENOS

            return Respuesta;

        }

        public void REPORTARfasores(NComplejo fasor1, NComplejo fasor2, NComplejo fasorFinal)
        {
            
            if(fasorFinal.argumento == Math.PI)
            {
                //π
                MessageBox.Show($"" +
                $"     BINOMICO           POLAR\n" +
                $"F1 = ({Math.Round(fasor1.real, 4)};{Math.Round(fasor1.img, 4)})      ---      [{Math.Round(fasor1.modulo, 4)};{Math.Round(fasor1.argumento, 4)}]\n" +
                $"F2 = ({Math.Round(fasor2.real, 4)};{Math.Round(fasor2.img, 4)})      ---      [{Math.Round(fasor2.modulo, 4)};{Math.Round(fasor2.argumento, 4)}]\n" +
                $"FR = ({Math.Round(fasorFinal.real, 4)};{Math.Round(fasorFinal.img, 4)})      ---      [{Math.Round(fasorFinal.modulo, 4)};π]\n","COS");
            }
            else
            {
                MessageBox.Show($"" +
                $"     BINOMICO           POLAR\n" +
                $"F1 = ({Math.Round(fasor1.real, 4)};{Math.Round(fasor1.img, 4)})      ---      [{Math.Round(fasor1.modulo, 4)};{Math.Round(fasor1.argumento, 4)}]\n" +
                $"F2 = ({Math.Round(fasor2.real, 4)};{Math.Round(fasor2.img, 4)})      ---      [{Math.Round(fasor2.modulo, 4)};{Math.Round(fasor2.argumento, 4)}]\n" +
                $"FR = ({Math.Round(fasorFinal.real, 4)};{Math.Round(fasorFinal.img, 4)})      ---      [{Math.Round(fasorFinal.modulo, 4)};{Math.Round(fasorFinal.argumento, 4)}]\n","COS");
            }
            
        }

        public void REPORTEfasorSUMA(Label miReporte, NComplejo f)
        {
            miReporte.Text = "Si Afecta la Label";
        }
    }
}
