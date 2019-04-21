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
        private ConvertidorService convertidor = new ConvertidorService();
        

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
            numeroAConvertir = convertidor.CrearNumeroBinomico((double)numericUpDownParteReal.Value, (double)numericUpDownParteImaginaria.Value);
        }

        private void MostrarNumeroEnFormaPolar(NumeroComplejoPolar numeroFormaPolar)
        {
            String numeroAMostrar = "[ " + Math.Round(numeroFormaPolar.GetModulo(), 2).ToString() + " ; " + Math.Round(numeroFormaPolar.GetArgumento() / Math.PI, 2).ToString() + " π ]";
            labelNumeroEnFormaPolar.Text = numeroAMostrar;
        }

        private void SwitchForm_Click(object sender, EventArgs e)
        {
            Form formulario = new AniadirNumeroPolar();
            formulario.Show();
        }
    }
}
