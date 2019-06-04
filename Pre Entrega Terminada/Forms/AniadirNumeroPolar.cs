using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Matematica_Superior_Demo
{
    public partial class AniadirNumeroPolar : Form
    {
        ConvertidorService convertidor = new ConvertidorService();
        public AniadirNumeroPolar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NumeroComplejoPolar numeroPolar = new NumeroComplejoPolar((double)numericUpDownModulo.Value, (double) numericUpDownArgumento.Value * Math.PI);
            NumeroComplejoBinomico binomico = convertidor.ConvertirABinomico(numeroPolar); 
            labelBinomicoAMostrar.Text = $"({Math.Round(binomico.GetParteReal(),2)}; {Math.Round(binomico.GetParteImaginaria(),2)})";
        }

        
    }
}
