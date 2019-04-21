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
    public partial class FormBasico : Form
    {
        public NumeroComplejoBinomico numeroAConvertir;
        

        public FormBasico()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            GenerarNumeroComplejo();
            MostrarNumeroEnFormaPolar(numeroAConvertir.GetFormaPolar());
            
        }

        private void GenerarNumeroComplejo()
        {
            if (numericUpDownParteReal.Value == 0 && numericUpDownParteImaginaria.Value != 0)
            {
                numeroAConvertir = new NumeroImaginarioPuro();
            }
            else if (numericUpDownParteReal.Value != 0 && numericUpDownParteImaginaria.Value == 0)
            {
                numeroAConvertir = new NumeroReal();
            }
            else if (numericUpDownParteReal.Value > 0 && numericUpDownParteImaginaria.Value != 0)
            {
                numeroAConvertir = new NumeroPrimerYCuartoCuadrante();
            }
            else if (numericUpDownParteReal.Value < 0 && numericUpDownParteImaginaria.Value != 0)
            {
                numeroAConvertir = new NumeroSegundoYTercerCuadrante();
            }
            else
            {
                numeroAConvertir = new NumeroOrigen();
            }

            numeroAConvertir.SetParteReal((double)numericUpDownParteReal.Value);
            numeroAConvertir.SetParteImaginaria((double)numericUpDownParteImaginaria.Value);
        }

        private void MostrarNumeroEnFormaPolar(NumeroComplejoPolar numeroFormaPolar)
        {
            String numeroAMostrar = "[ " + Math.Round(numeroFormaPolar.GetModulo(), 2).ToString() + " ; " + Math.Round(numeroFormaPolar.GetArgumento() / Math.PI, 2).ToString() + " π ]";
            labelNumeroEnFormaPolar.Text = numeroAMostrar;
        }
    }
}
