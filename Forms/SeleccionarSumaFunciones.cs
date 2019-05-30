using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Matematica_Superior_Demo.Clases;
using TP_Matematica_Superior_Demo.Services;

namespace TP_Matematica_Superior_Demo.Forms
{
    public partial class SeleccionarSumaFunciones : Form
    {
        public double modulo1 { get; set; }
        public double pulso1 { get; set; }
        public double argumento1 { get; set; }

        

        public SeleccionarSumaFunciones()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSumarFasores(object sender, EventArgs e)
        {
            Fasoriando();
        }

        private void Fasoriando()
        {
            //throw new NotImplementedException();
            NComplejo fasor1 = new NComplejo(Convert.ToDouble(txtBoxModulo1.Text), Convert.ToDouble(txtBoxArgumento1.Text), "POLAR");
            NComplejo fasor2 = new NComplejo(Convert.ToDouble(txtBoxModulo2.Text), Convert.ToDouble(txtBoxArgumento2.Text), "POLAR");
            NComplejo fasorFinal = new NComplejo();

            Operador Servicio = new Operador();
            fasorFinal = Servicio.Sumar(fasor1,fasor2);

            lblReporteFinal.Text = $"f1 + f2 = {Math.Round(fasorFinal.modulo, 3)} sen( {txtBoxPulso1.Text} X  + {Math.Round(fasorFinal.argumento,4)} )";

            MessageBox.Show($"" +
                $"F1 = ({Math.Round(fasor1.real,4)};{Math.Round(fasor1.img,4)}) -- [{Math.Round(fasor1.modulo,4)};{Math.Round(fasor1.argumento,4)}]\n" +
                $"F2 = ({Math.Round(fasor2.real,4)};{Math.Round(fasor2.img,4)}) -- [{Math.Round(fasor2.modulo,4)};{Math.Round(fasor2.argumento,4)}]\n" +
                $"FR = ({Math.Round(fasorFinal.real,4)};{Math.Round(fasorFinal.img,4)}) -- [{Math.Round(fasorFinal.modulo,4)};{Math.Round(fasorFinal.argumento),4}]\n");

            //lblReporteFinal.Text = $"[{fasor1.modulo} , {fasor1.argumento}] ---- >>  ({fasor1.real} , {fasor1.img})";
            //lblReporteFinal.Text = $"[{Math.Round(fasor2.modulo,3)} , {Math.Round(fasor2.argumento, 3)}] ---- >>  ({Math.Round(fasor2.real, 3)} , {Math.Round(fasor2.img, 3)})";
        }
    }
}
